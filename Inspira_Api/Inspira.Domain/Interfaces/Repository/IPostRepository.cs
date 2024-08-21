using Inspira.Domain.Entities;
using Inspira_Music.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Domain.Interfaces.Repository
{
    public interface IPostRepository : ICommand<Post>, IQuery<Post>
    {
        public IEnumerable<Post> GetByUserId(Guid id, FilterBase filter);
    }
}
