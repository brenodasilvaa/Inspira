using Inspira.Domain.Entities;

namespace Inspira.Api.Dtos
{
    public class CommentDto : Entity
    {
        public string Text { get; set; } = string.Empty;
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
