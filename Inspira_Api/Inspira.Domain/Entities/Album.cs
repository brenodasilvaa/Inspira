using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Domain.Entities
{
    public class Album
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CoverUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
