using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Models;

namespace Inspira.Infrastructure.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly InspiraDbContext _context;

        public PostRepository(InspiraDbContext ctx)
        {
            _context = ctx;
        }

        public async Task Create(Post post)
        {
            await _context.Posts.AddAsync(post);
        }

        public IEnumerable<Post> Get(FilterBase filter)
        {
            return _context.Posts.Skip(filter.Skip).Take(filter.Take);
        }

        public async Task<Post?> GetById(Guid id)
        {
            return await _context.Posts.FindAsync(id);
        }

        public IEnumerable<Post> GetByUserId(Guid id, FilterBase filter)
        {
            return _context.Posts.Where(x => x.UserId == id).Skip(filter.Skip).Take(filter.Take);
        }
    }
}
