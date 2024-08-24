using Inspira.Domain.Entities;
using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Domain.Interfaces.Repository
{
    public interface ICommentRepository : IQuery<Comment>, ICommand<Comment>
    {
        public IEnumerable<Comment> GetByUserId(Guid id, FilterBase filter);
        public IEnumerable<Comment> GetByPostId(Guid id, FilterBase filter);
    }
}
