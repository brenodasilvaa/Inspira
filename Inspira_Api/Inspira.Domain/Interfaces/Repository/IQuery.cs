using Inspira_Music.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Domain.Interfaces.Repository
{
    public interface IQuery<T>
    {
        public Task<T?> GetById(Guid id);
        public IEnumerable<T> Get(FilterBase filter);
    }
}
