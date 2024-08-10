using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Domain.Entities
{
    public class SongRelation
    {
        public Guid Id { get; set; }
        public Guid OriginalSongId { get; set; }
        public Guid InspiredSongId { get; set; }
    }
}
