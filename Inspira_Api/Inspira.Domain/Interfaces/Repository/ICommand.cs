using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Domain.Interfaces.Repository
{
    public interface ICommand<T>
    {
        Task<Guid> Create(T entity);
    }
}
