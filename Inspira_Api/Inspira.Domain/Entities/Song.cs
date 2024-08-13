using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Domain.Entities
{
    public class Song
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTime Released { get; set; }
        public string Album { get; set; }
        public string AlbumCoverUrl { get; set; }
    }
}
