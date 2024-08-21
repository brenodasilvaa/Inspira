namespace Inspira.Domain.Entities
{
    public class Track : MusicEntity
    {
 
        public string Title { get; set; }
        public Album Album { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
