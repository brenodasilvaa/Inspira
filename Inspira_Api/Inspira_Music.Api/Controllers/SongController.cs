using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inspira_Music.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : ControllerBase
    {
        private ISongRelationRepository _songRelationRepository;
        private ISongRepository _songRepository;

        public SongController(ISongRelationRepository songRelationRepository, ISongRepository songRepository)
        {
            _songRelationRepository = songRelationRepository;
            _songRepository = songRepository;
        }

        private readonly ILogger<SongController> _logger;

        [HttpGet("Related/{id}")]
        public async Task<IActionResult> GetRelated(Guid id, [FromQuery] FilterBase? filter)
        {
            return Ok(await _songRepository.GetInspired(id));
        }

        [HttpGet()]
        public async Task<IActionResult> Get(Guid id, [FromQuery] FilterBase? filter)
        {
            return Ok(await _songRepository.GetById(id));
        }

        [HttpPost()]
        public async Task<IActionResult> Post(Song song)
        {
            return Ok(await _songRepository.Create(song));
        }
    }
}
