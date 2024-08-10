using Inspira_Music.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Domain.Interfaces.Repository
{
    public interface ISongRepository : IQuery<Song>
    {
        public Task<IEnumerable<Song>> GetInspired(Guid id);
        public Task<Guid> Create(Song song);
    }
}
