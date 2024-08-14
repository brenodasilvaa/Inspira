using Inspira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Domain.Entities
{
    public class Track
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Artist> Artists { get; set; } = [];
        public Album Album { get; set; }
    }
}
