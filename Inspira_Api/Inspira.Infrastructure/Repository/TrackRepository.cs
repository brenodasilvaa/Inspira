using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Inspira_Music.Infrastructure.Repository
{
    internal class TrackRepository : ITrackRepository
    {
        private readonly InspiraDbContext _context;

        public TrackRepository(InspiraDbContext context)
        {
            _context = context;
        }

        public async Task Create(Track track)
        {
            await _context.Tracks.AddAsync(track);
        }

        public async Task<IEnumerable<Track>> Get(string trackName, string artistName, int skip)
        {
            return await _context.Tracks.Where(x => x.Artists.Any(y => y.Name == artistName) && x.Title == trackName).Skip(skip).ToListAsync();
        }

        public async Task<Track?> GetById(Guid id)
        {
            return await _context.Tracks.FindAsync(id);
        }
    }
}
