using Inspira_Music.Domain.Entities;
using Mapster;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Music.Infrastructure.Mappings
{
    public static class TrackMapping
    {
        public static void Add()
        {
            TypeAdapterConfig<FullTrack, Song>.NewConfig()
                .Map(dest => dest.Title, src => src.Name)
                .Map(dest => dest.Artist, src => src.Artists.First().Name)
                .Map(dest => des)
        }
    }
}
