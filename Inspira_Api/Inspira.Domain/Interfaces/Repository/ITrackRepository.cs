using Inspira.Domain.Entities;

namespace Inspira.Domain.Interfaces.Repository
{
    public interface ITrackRepository : IQuery<Track>, ICommand<Track>
    {
        Task<IEnumerable<Track>> Get(string trackName, string artistName, int skip);
    }
}
