using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Domain.Entities
{
    public class Album : Entity
    {
        public string Name { get; set; }
        public string CoverUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Guid ArtistId { get; set; }
        public Artist Artist{ get; set; }
        public List<Track> Tracks { get; set; }
    }
}
