using MetaBrainz.MusicBrainz;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Music.Infrastructure.Repository
{
    public class TrackRepository
    {
        public async Task<IEnumerable<string>> GetByName()
        {
            var songTitle = "two of us";
            var artistName = "the beatles";
            var config = SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator("f4f200ba3f074d98940338685ad2133f", "22884c66e4d1450abd63346c13f492c4"));

            var spotify = new SpotifyClient(config);

            var searchRequest = new SearchRequest(SearchRequest.Types.Track, "track:yesterday artist:The beatles");

            var track = await spotify.Search.Item(searchRequest);

            return Enumerable.Empty<string>();
        }
    }
}
