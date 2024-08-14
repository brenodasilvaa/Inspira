using Inspira_Music.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Domain.Interfaces.Repository
{
    public interface ITrackRepository
    {
        Task<IEnumerable<Track>> Get(string trackName, string artistName, int? skip);
    }
}
