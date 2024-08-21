using Inspira.Domain.Entities;

namespace Inspira_Music.Api.Dtos
{
    public class CreatePostDto
    {
        public Guid OwnerId { get; set; }
        public string TrackSourceId { get; set; }
        public string TrackDestId { get; set; }
        public string Descricao { get; set; } = string.Empty;
    }
}
