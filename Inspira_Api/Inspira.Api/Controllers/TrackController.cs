using Inspira.Api.Dtos;
using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces.Repository;
using Inspira_Music.Api.Dtos;
using Inspira_Music.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inspira_Music.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrackController : ControllerBase
    {
        private ITrackRepository _songRepository;

        public TrackController(ITrackRepository songRepository)
        {
            _songRepository = songRepository;
        }

        private readonly ILogger<TrackController> _logger;

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id, [FromQuery] FilterBase? filter)
        {
            return Ok(await _songRepository.GetById(id));
        }

        [HttpPost()]
        public async Task<IActionResult> Post(Track track)
        {
            await _songRepository.Create(track);

            return Ok(track);
        }
    }
}
