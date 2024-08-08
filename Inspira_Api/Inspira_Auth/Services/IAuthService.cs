namespace Inspira_Auth.Services
{
    public interface IAuthService
    {
        public Task<string> Login(string userName, string password);
        public Task SignUp(string userName, string email, string password);
        public Task ConfirmSignUp(string userName, string code);
    }
}
