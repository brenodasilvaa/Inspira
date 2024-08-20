using Inspira.Domain.Entities;
using Inspira_Music.Api.Dtos;
using Mapster;

namespace Inspira.Api.Mappings
{
    public class PostMappings
    {
        public static void Add()
        {
            TypeAdapterConfig<CreatePostDto, Post>.NewConfig()
                .Map(dest => dest.TrackSource, src => new Track() { Id = src.TrackSourceId })
                .Map(dest => dest.TrackDest, src => new Track() { Id = src.TrackDestId })
                .Map(dest => dest.UserId, src => src.OwnerId);
        }
    }
}
