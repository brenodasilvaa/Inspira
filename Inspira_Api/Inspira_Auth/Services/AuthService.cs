
using Inspira_Auth.Adapters;

namespace Inspira_Auth.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthServiceAdapter _authServiceAdapter;

        public AuthService(IAuthServiceAdapter authServiceAdapter)
        {
            _authServiceAdapter = authServiceAdapter;
        }

        public async Task ConfirmSignUp(string userName, string code)
        {
            await _authServiceAdapter.ConfirmEmail(userName, code);
        }

        public async Task<string> Login(string userName, string password)
        {
            return await _authServiceAdapter.GetToken(userName, password);
        }

        public async Task SignUp(string userName, string email, string password)
        {
            await _authServiceAdapter.SignUp(userName, email, password);
        }
    }
}
