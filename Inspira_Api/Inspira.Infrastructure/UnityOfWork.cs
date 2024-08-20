using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Infrastructure
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly InspiraDbContext context;

        public UnityOfWork(InspiraDbContext context)
        {
            this.context = context;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
