using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces;
using Inspira.Domain.Interfaces.Repository;
using Inspira.Infrastructure;
using Inspira.Infrastructure.Repository;
using Inspira_Music.Infrastructure.Repository;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Inspira_Music.Infrastructure.Inicialization
{
    public static class ConfigureServices
    {
        public static void Configure(this IServiceCollection services, IConfiguration cfg)
        {
            var connectionString = cfg.GetConnectionString("DefaultConnection");

            services.AddDbContext<InspiraDbContext>(options => options.UseNpgsql(connectionString));

            services.AddScoped<IUnityOfWork, UnityOfWork>();

            services.AddMapster();

            services.AddScoped<ITrackRepository, TrackRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
        }
    }
}
