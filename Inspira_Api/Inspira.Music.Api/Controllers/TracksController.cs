using Inspira.Domain.Interfaces.Repository;
using Inspira.Music.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Inspira.Music.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TracksController : ControllerBase
    {
        private readonly ILogger<TracksController> _logger;
        private readonly ITrackRepository _trackRepository;

        public TracksController(ILogger<TracksController> logger, ITrackRepository trackRepository)
        {
            _logger = logger;
            _trackRepository = trackRepository;
        }

        [HttpGet()]
        public async Task<IEnumerable<string>> Get(string trackName, string artistName, int? skip)
        {
            var teste = await _trackRepository.Get(trackName, artistName, skip);

            return [];
        }
    }
}
