using Inspira.Api.Dtos;
using Inspira.Domain.Interfaces;
using Inspira.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Inspira.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IUnityOfWork _unityOfWork;

        public CommentController(ICommentRepository commentRepository, IUnityOfWork unityOfWork)
        {
            _commentRepository = commentRepository;
            _unityOfWork = unityOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCommentDto comment)
        {
            await _commentRepository.Create(comment.Adapt<Comment>());
            await _unityOfWork.SaveAsync();

            return Ok();
        }

        [HttpGet]
        public IActionResult Get([FromQuery] FilterBase filter)
        {
            return Ok(_commentRepository.Get(filter).Adapt<IEnumerable<CommentDto>>());
        }

        [HttpGet("by-user-id/{id}")]
        public IActionResult GetByUserId(Guid id, [FromQuery] FilterBase filter)
        {
            return Ok(_commentRepository.GetByUserId(id, filter).Adapt<IEnumerable<CommentDto>>());
        }

        [HttpGet("by-post-id/{id}")]
        public IActionResult GetByPostId(Guid id, [FromQuery] FilterBase filter)
        {
            return Ok(_commentRepository.GetByPostId(id, filter).Adapt<IEnumerable<CommentDto>>());
        }
    }
}
