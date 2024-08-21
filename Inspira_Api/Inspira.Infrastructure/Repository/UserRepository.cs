using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Models;

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

        public IEnumerable<User> Get(FilterBase filter)
        {
            return [.. _context.Users.Skip(filter.Skip).Take(filter.Take)];
        }

        public async Task<User?> GetById(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
