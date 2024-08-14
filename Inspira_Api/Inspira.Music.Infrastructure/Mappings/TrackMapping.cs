using Inspira.Domain.Entities;
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
            TypeAdapterConfig<SimpleArtist, Artist>.NewConfig()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Id, src => src.Id);

            TypeAdapterConfig<SimpleAlbum, Album>.NewConfig()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.CoverUrl, src => src.Images.First().Url)
                .Map(dest => dest.ReleaseDate, src => src.ReleaseDate);

            TypeAdapterConfig<FullTrack, Track>.NewConfig()
                .Map(dest => dest.Title, src => src.Name)
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Artists, src => src.Artists)
                .Map(dest => dest.Album, src => src.Album);
        }
    }
}
