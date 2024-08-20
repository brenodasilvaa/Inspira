using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces.Repository;
using Mapster;
using SpotifyAPI.Web;

namespace Inspira.Music.Infrastructure.Repository
{
    public class TrackRepository : ITrackRepository
    {
        private readonly ISpotifyClient _spotifyClient;

        public TrackRepository(ISpotifyClient spotifyClient)
        {
            _spotifyClient = spotifyClient;
        }

        public async Task<IEnumerable<Track>> Get(string trackName, string artistName, int? skip)
        {
            var searchRequest = new SearchRequest(SearchRequest.Types.Track, $"track:{trackName} artist:{artistName}");

            searchRequest.Market = "BR";
            searchRequest.Offset = skip;

            var tracks = await _spotifyClient.Search.Item(searchRequest);
            var tracksMapped = tracks.Tracks.Items.Adapt<List<Track>>();

            return tracksMapped;
        }

        public Task<IEnumerable<Track>> Get(string trackName, string artistName, int skip)
        {
            throw new NotImplementedException();
        }


        public Task<Track?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        Task ICommand<Track>.Create(Track entity)
        {
            throw new NotImplementedException();
        }
    }
}
