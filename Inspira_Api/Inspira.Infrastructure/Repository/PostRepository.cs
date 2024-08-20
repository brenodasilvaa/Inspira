using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces.Repository;

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
    }
}
