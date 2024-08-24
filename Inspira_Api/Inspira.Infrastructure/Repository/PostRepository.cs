using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Models;
using Microsoft.EntityFrameworkCore;

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
            var postExists = await _context.Posts.AnyAsync(x => x.TrackSourceId == post.TrackSourceId &&
            x.TrackDestId == post.TrackDestId);

            if (postExists)
                throw new InvalidOperationException("A relação entre as músicas selecionadas já existe");
            
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
