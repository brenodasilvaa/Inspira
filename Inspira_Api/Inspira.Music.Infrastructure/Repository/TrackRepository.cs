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

        public async Task<IEnumerable<Track>> Get(string trackName, string artistName, int skip)
        {
            var searchRequest = new SearchRequest(SearchRequest.Types.Track, $"track:{trackName} artist:{artistName}");

            searchRequest.Market = "BR";
            searchRequest.Offset = skip;

            var tracks = await _spotifyClient.Search.Item(searchRequest);
            var tracksMapped = tracks.Tracks.Items.Adapt<List<Track>>();

            return tracksMapped;
        }

        public async Task<Track> GetById(string id, CancellationToken cancellation)
        {
            var track = await _spotifyClient.Tracks.Get(id, cancellation);
            var tracksMapped = track.Adapt<Track>();

            return tracksMapped;
        }
    }
}
