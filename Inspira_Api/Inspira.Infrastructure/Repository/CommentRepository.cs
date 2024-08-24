using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Models;

namespace Inspira.Infrastructure.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly InspiraDbContext _context;

        public CommentRepository(InspiraDbContext inspiraDbContext)
        {
            _context = inspiraDbContext;
        }

        public async Task Create(Comment entity)
        {
            await _context.Comments.AddAsync(entity);
        }

        public IEnumerable<Comment> Get(FilterBase filter)
        {
            return _context.Comments.Skip(filter.Skip).Take(filter.Take);
        }

        public async Task<Comment?> GetById(Guid id)
        {
            return await _context.Comments.FindAsync(id);
        }

        public IEnumerable<Comment> GetByPostId(Guid id, FilterBase filter)
        {
            return _context.Comments.Where(x => x.PostId == id).Skip(filter.Skip).Take(filter.Take);
        }

        public IEnumerable<Comment> GetByUserId(Guid id, FilterBase filter)
        {
            return _context.Comments.Where(x => x.UserId == id).Skip(filter.Skip).Take(filter.Take);
        }
    }
}
