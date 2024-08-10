using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Interfaces.Repository;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Infrastructure.Repository
{
    internal class SongRepository : ISongRepository
    {
        private IDriver _driver;

        public SongRepository(IDriver driver)
        {
            _driver = driver;
        }

        public async Task<Guid> Create(Song song)
        {
            var uuid = Guid.NewGuid();

            await using (var session = _driver.AsyncSession())
            {
                var query = new Query($"CREATE (n:Song {{uuid: '{uuid}', name: " +
                    $"'{song.Name}', performer: '{song.Performer}', released: '{song.Released}', " +
                    $"album: '{song.Album}'}}) RETURN n");

                var result = await session.RunAsync(query);
            }

            return uuid;
        }

        public async Task<Song> GetById(Guid id)
        {
            await using (var session = _driver.AsyncSession())
            {
                var query = new Query($"MATCH (song:Song {{uuid: '{id}'}}) RETURN song");

                var result = await session.RunAsync(query);

                foreach (var item in await result.ToListAsync())
                {
                    return MapRecord(item, "song");
                };

                throw new KeyNotFoundException();
            }
        }

        public async Task<IEnumerable<Song>> GetInspired(Guid id)
        {
            var songRelation = new List<Song>();

            await using (var session = _driver.AsyncSession())
            {
                var query = new Query($"MATCH (p:Song {{uuid: '{id}'}})-[:INSPIRED]->(song:Song) RETURN song");

                var result = await session.RunAsync(query);

                foreach (var item in await result.ToListAsync())
                {
                    songRelation.Add(MapRecord(item, "song"));
                };
            }

            return songRelation;
        }

        private Song MapRecord(IRecord record, string key)
        {
            var node = record[key].As<INode>();

            return new Song()
            {
                Id = Guid.Parse(node.Properties["uuid"].As<string>()),
                Name = node.Properties["name"].As<string>(),
                Album = node.Properties["album"].As<string>(),
                Performer = node.Properties["performer"].As<string>(),
                Released = DateTime.Parse(node.Properties["released"].As<string>())
            };
        }
    }
}
