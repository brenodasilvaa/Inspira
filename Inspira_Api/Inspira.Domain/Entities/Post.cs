using Inspira_Music.Domain.Entities;

namespace Inspira.Domain.Entities
{
    public class Post : Entity
    {
        public Guid TrackSourceId { get; set; }
        public Guid TrackDestId { get; set; }
        public Guid UserId { get; set; }
        public Track TrackSource { get; set; }
        public Track TrackDest { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; } = [];
    }
}
