using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Entities;

namespace Inspira_Music.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly InspiraDbContext _context;

        public UserRepository(InspiraDbContext ctx)
        {
            _context = ctx;
        }

        public async Task Create(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<User?> GetById(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
