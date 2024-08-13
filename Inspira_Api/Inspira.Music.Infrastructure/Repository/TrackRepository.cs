using Inspira.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Entities;
using MetaBrainz.MusicBrainz;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Music.Infrastructure.Repository
{
    public class TrackRepository : ITrackRepository
    {
        private readonly ISpotifyClient _spotifyClient;

        public TrackRepository(ISpotifyClient spotifyClient)
        {
            _spotifyClient = spotifyClient;
        }

        public async Task<IEnumerable<Song>> Get(string trackName, string artistName, int? skip)
        {
            var searchRequest = new SearchRequest(SearchRequest.Types.Track, $"track:{trackName} artist:{artistName}");

            searchRequest.Market = "BR";
            searchRequest.Offset = skip;

            var tracks = await _spotifyClient.Search.Item(searchRequest);
            tracks.Tracks.Items

            return Enumerable.Empty<Song>();
        }
    }
}
