using Inspira.Domain.Entities;
using Inspira_Music.Domain.Entities;

namespace Inspira.Api.Dtos
{
    public class CreateCommentDto
    {
        public string Text { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
    }
}
