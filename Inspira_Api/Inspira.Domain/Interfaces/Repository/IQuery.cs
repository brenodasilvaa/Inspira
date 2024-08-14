using Inspira_Music.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Domain.Interfaces.Repository
{
    public interface IQuery<T>
    {
        public Task<T> GetById(string id);
    }
}
