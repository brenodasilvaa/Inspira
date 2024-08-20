using Inspira.Domain.Entities;

namespace Inspira_Music.Api.Dtos
{
    public class CreatePostDto
    {
        public Guid OwnerId { get; set; }
        public Guid TrackSourceId { get; set; }
        public Guid TrackDestId { get; set; }
    }
}
