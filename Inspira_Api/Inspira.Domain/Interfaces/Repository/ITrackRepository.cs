using Inspira.Domain.Entities;

namespace Inspira.Domain.Interfaces.Repository
{
    public interface ITrackRepository
    {
        Task<IEnumerable<Track>> Get(string trackName, string artistName, int skip);
        Task<Track> GetById(string id, CancellationToken cancellation);
    }
}
