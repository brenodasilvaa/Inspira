using Inspira.Domain.Entities;
using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Interfaces.Repository;
using Neo4j.Driver;

namespace Inspira_Music.Infrastructure.Repository
{
    internal class TrackRepository : ITrackRepository
    {
        private IDriver _driver;

        public TrackRepository(IDriver driver)
        {
            _driver = driver;
        }

        public async Task<string> Create(Track track)
        {
 
            await using (var session = _driver.AsyncSession())
            {
                await CreateTrack(track, session);
            }

            return track.Id;
        }
        public async Task CreateInspiration(Track track, Track trackInspired)
        {
            await using (var session = _driver.AsyncSession())
            {
                await CreateTrack(track, session);
                await CreateTrack(trackInspired, session);

                var inspiration = $"MERGE (t:Track {{uuid : '{track.Id}', name: '{track.Title}'}}) " +
                        $"MERGE (ti:Track {{uuid : '{trackInspired.Id}', name: '{trackInspired.Title}'}}) " +
                        $"MERGE (t)-[:INSPIRED]->(ti) ";

                await session.RunAsync(inspiration);
            }
        }

        public async Task<Track> GetById(string id)
        {
            await using (var session = _driver.AsyncSession())
            {
                var query = new Query($"MATCH (track:Track {{uuid: '{id}'}})<-[:PERFORMED]-(a:Artist), " +
                    $"(track)<-[:CONTAINS]-(b:Album) RETURN track, collect(a) AS artists, b as album");

                var result = await session.RunAsync(query);

                foreach (var item in await result.ToListAsync())
                {
                    return MapRecord(item);
                };

                throw new KeyNotFoundException();
            }
        }

        public async Task<IEnumerable<Track>> GetInspired(string id)
        {
            var songRelation = new List<Track>();

            await using (var session = _driver.AsyncSession())
            {
                var query = new Query($"MATCH (p:Track {{uuid: '{id}'}})-[:INSPIRED]->(track:Track) , " +
                    $"(track)<-[:PERFORMED]-(a:Artist), (track)<-[:CONTAINS]-(b:Album) RETURN track, collect(a) AS artists, b as album");

                var result = await session.RunAsync(query);

                foreach (var item in await result.ToListAsync())
                {
                    songRelation.Add(MapRecord(item));
                };
            }

            return songRelation;
        }

        private async Task CreateTrack(Track track, IAsyncSession session)
        {
            foreach (var artist in track.Artists)
            {
                var qr = $"MERGE (p:Artist {{uuid : '{artist.Id}', name: '{artist.Name}'}}) " +
                    $"MERGE (a:Album {{uuid : '{track.Album.Id}', name: '{track.Album.Name}', releaseDate: '{track.Album.ReleaseDate}', coverUrl: '{track.Album.CoverUrl}'}}) " +
                    $"MERGE (t:Track {{uuid : '{track.Id}', name: '{track.Title}'}}) " +
                    $"MERGE (p)-[:PERFORMED]->(t) " +
                    $"MERGE (a)-[:CONTAINS]->(t)";

                await session.RunAsync(qr);
            }
        }

        private Track MapRecord(IRecord record)
        {
            var trackNode = record["track"].As<INode>();
            var artists = record["artists"].As<List<INode>>();
            var album = record["album"].As<INode>();


            var track = new Track()
            {
                Id = trackNode.Properties["uuid"].As<string>(),
                Title = trackNode.Properties["name"].As<string>(),
                Album = new Album() { ReleaseDate = DateTime.Parse(album.Properties["releaseDate"].As<string>()),
                                      CoverUrl = album.Properties["coverUrl"].As<string>(),
                                      Id = album.Properties["uuid"].As<string>(),
                                      Name = album.Properties["name"].As<string>()
                }
            };


            foreach (var artist in artists)
            {
                var newArtist = new Artist() { Id = artist.Properties["uuid"].As<string>(), Name = artist.Properties["name"].As<string>() };
                track.Artists.Add(newArtist);
            }

            return track;
        }
    }
}
