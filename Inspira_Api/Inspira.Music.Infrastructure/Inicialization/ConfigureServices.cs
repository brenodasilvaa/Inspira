using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Music.Infrastructure.Inicialization
{
    public static class ConfigureServices
    {
        public static void Configure(this IServiceCollection services, IConfiguration cfg)
        {
            var musicBrainzConfig = cfg.GetSection("MusicBrainz").Get<MusicBrainzConfig>()!;
        }
    }
}
