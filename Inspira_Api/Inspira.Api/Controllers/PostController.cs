using Inspira.Domain.Entities;
using Inspira.Domain.Interfaces;
using Inspira.Domain.Interfaces.Repository;
using Inspira_Music.Api.Dtos;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Inspira.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IUnityOfWork _unityOfWork;

        public PostController(IPostRepository postRepository, IUnityOfWork unityOfWork)
        {
            _postRepository = postRepository;
            _unityOfWork = unityOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreatePostDto postDto)
        {
            try
            {
                var post = postDto.Adapt<Post>();

                await _postRepository.Create(post);
                await _unityOfWork.SaveAsync();

                return Ok(post.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(new ProblemDetails() { Detail = ex.Message });
            }
        }
    }
}
