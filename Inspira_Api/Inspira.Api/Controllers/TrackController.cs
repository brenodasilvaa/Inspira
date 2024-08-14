using Inspira_Music.Api.Dtos;
using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inspira_Music.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrackController : ControllerBase
    {
        private ISongRelationRepository _songRelationRepository;
        private ITrackRepository _songRepository;

        public TrackController(ISongRelationRepository songRelationRepository, ITrackRepository songRepository)
        {
            _songRelationRepository = songRelationRepository;
            _songRepository = songRepository;
        }

        private readonly ILogger<TrackController> _logger;

        [HttpGet("Inspired/{id}")]
        public async Task<IActionResult> GetRelated(string id, [FromQuery] FilterBase? filter)
        {
            return Ok(await _songRepository.GetInspired(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id, [FromQuery] FilterBase? filter)
        {
            return Ok(await _songRepository.GetById(id));
        }

        [HttpPost()]
        public async Task<IActionResult> Post(Track song)
        {
            return Ok(await _songRepository.Create(song));
        }

        [HttpPost("Inspired")]
        public async Task<IActionResult> PostInspired(CreateTrackInspiration tracks)
        {
            await _songRepository.CreateInspiration(tracks.Track, tracks.TrackInspired);
            return Ok();
        }
    }
}
