using Inspira_Music.Api.Dtos;
using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Inspira_Music.Api.Controllers
{
    public class SongRelationController : Controller
    {
        private readonly ISongRelationRepository _relationRepository;

        public SongRelationController(ISongRelationRepository relationRepository)
        {
            _relationRepository = relationRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateSongRelation createSongRelation)
        {
            var songRelation = new SongRelation()
            {
                OriginalSongId = createSongRelation.OriginalSongId,
                InspiredSongId = createSongRelation.InspiredSongId
            };

            return Ok(await _relationRepository.CreateRelation(songRelation));
        }
    }
}
