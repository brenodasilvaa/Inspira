namespace Inspira.Domain.Entities
{
    public class Track : Entity
    {
 
        public string Title { get; set; }
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
        public List<Post> Posts { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
