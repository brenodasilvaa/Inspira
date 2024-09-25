using Inspira_Auth.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inspira_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string userName, string password)
        {
            return Ok(await _authService.Login(userName, password));
        }

        [HttpPost("register")]
        public async Task<IActionResult> SignUp(string userName, string email, string password)
        {
            await _authService.SignUp(userName, email, password);

            return Ok();
        }

        [HttpPost("confirmSignup")]
        public async Task<IActionResult> ConfirmSignUp(string userMail, string code)
        {
            await _authService.ConfirmSignUp(userMail, code);

            return Ok();
        }
    }
}
