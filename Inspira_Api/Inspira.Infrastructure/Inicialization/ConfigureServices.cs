using Inspira_Music.Domain.Interfaces.Repository;
using Inspira_Music.Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Neo4j.Driver;
using System.Text.Json;

namespace Inspira_Music.Infrastructure.Inicialization
{
    public static class ConfigureServices
    {
        public static void Configure(this IServiceCollection services, IConfiguration cfg)
        {
            var neo4JConfig = cfg.GetSection("Neo4J").Get<Neo4JConfig>()!;

            services.AddSingleton(sp =>
            {
                var uri = neo4JConfig.Endpoint;
                var username = neo4JConfig.Login;
                var password = neo4JConfig.Password;

                return GraphDatabase.Driver(uri, AuthTokens.Basic(username, password));
            });

            services.AddScoped<ITrackRepository, TrackRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
