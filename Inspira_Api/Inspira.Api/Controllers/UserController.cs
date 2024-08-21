using Inspira.Api.Dtos;
using Inspira.Domain.Interfaces;
using Inspira.Domain.Interfaces.Repository;
using Inspira.Infrastructure;
using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inspira.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnityOfWork _unityOfWork;

        public UserController(IUserRepository userRepository, IUnityOfWork unityOfWork)
        {
            _userRepository = userRepository;
            _unityOfWork = unityOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateUserDto createUserDto)
        {
            var user = new User() { Name = createUserDto.Name };

            await _userRepository.Create(user);

            await _unityOfWork.SaveAsync();

            return Ok(user);
        }

        [HttpGet]
        public IActionResult Get([FromQuery] FilterBase filter)
        {
            var user = _userRepository.Get(filter);

            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await _userRepository.GetById(id);

            return Ok(user);
        }
    }
}
