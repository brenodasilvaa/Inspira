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
                .Map(dest => dest.TrackSourceId, src => src.TrackSourceId )
                .Map(dest => dest.TrackDestId, src => src.TrackDestId )
                .Map(dest => dest.UserId, src => src.OwnerId);
        }
    }
}
