﻿using Inspira_Music.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Inspira.Domain.Interfaces.Repository
{
    public interface IUserRepository : ICommand<User>, IQuery<User>
    {
    }
}
