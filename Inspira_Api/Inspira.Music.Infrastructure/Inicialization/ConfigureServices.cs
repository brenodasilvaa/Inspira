using Inspira.Domain.Interfaces.Repository;
using Inspira.Music.Infrastructure.Repository;
using Mapster;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpotifyAPI.Web;

namespace Inspira.Music.Infrastructure.Inicialization
{
    public static class ConfigureServices
    {
        public static void Configure(this IServiceCollection services, IConfiguration cfg)
        {
            var musicInfoConfig = cfg.GetSection("Spotify").Get<MusicInfoConfig>()!;

            services.AddMapster();

            services.AddSingleton<ISpotifyClient>(x =>
            {
                var config = SpotifyClientConfig
                .CreateDefault()
                .WithAuthenticator(new ClientCredentialsAuthenticator(musicInfoConfig.ClientId, musicInfoConfig.ClientSecret));

                return new SpotifyClient(config);
            });

            services.AddScoped<ITrackRepository, TrackRepository>();
        }
    }
}
