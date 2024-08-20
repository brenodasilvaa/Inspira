using Inspira.Domain.Entities;

namespace Inspira_Music.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
