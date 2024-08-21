using Inspira_Music.Domain.Entities;

namespace Inspira.Domain.Entities
{
    public class Post : Entity
    {
        public string TrackSourceId { get; set; }
        public string TrackDestId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Descricao { get; set; }
        public List<Comment> Comments { get; set; } = [];
    }
}
