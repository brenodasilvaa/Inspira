using Inspira.Domain.Interfaces.Repository;
using Inspira.Music.Infrastructure.Repository;
using Inspira_Music.Domain.Entities;
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
        public async Task<IActionResult> Get(string trackName, string artistName, int skip)
        {
            return Ok(await _trackRepository.Get(trackName, artistName, skip));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _trackRepository.GetById(id, CancellationToken.None));
        }
    }
}
