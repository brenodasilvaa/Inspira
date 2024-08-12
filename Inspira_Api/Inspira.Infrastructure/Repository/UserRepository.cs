using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Interfaces.Repository;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Infrastructure.Repository
{
    public  class UserRepository : IUserRepository
    {
        private IDriver _driver;

        public UserRepository(IDriver driver)
        {
            _driver = driver;
        }

        public async Task<Guid> Create(User user)
        {
            var uuid = Guid.NewGuid();

            await using (var session = _driver.AsyncSession())
            {
                var query = new Query($"CREATE(n:User {{uuid: '{uuid}'}}, name: {user.Name} RETURN n");

                var result = await session.RunAsync(query);
            }

            return uuid;
        }
    }
}
