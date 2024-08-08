namespace Inspira_Auth.Adapters
{
    public interface IAuthServiceAdapter

    {
        public Task<string> GetToken(string userName, string password);
        public Task SignUp(string userName, string email, string password);
        public Task ConfirmEmail(string userName, string code);
    }
}
