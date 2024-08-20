using Inspira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Domain.Interfaces.Repository
{
    public interface IPostRepository : ICommand<Post>
    {
    }
}
