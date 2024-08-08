using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Extensions.CognitoAuthentication;
using Inspira_Auth.Inicialization.Options;
using Microsoft.Extensions.Options;

namespace Inspira_Auth.Adapters
{
    public class AuthCognitoAdapter : IAuthServiceAdapter
    {
        private readonly AmazonCognitoIdentityProviderClient _cognitoClient;
        private readonly CognitoUserPool _cognitoUserPool;
        private readonly CognitoOptions _cognitoOptions;

        public AuthCognitoAdapter(IOptionsMonitor<CognitoOptions> cognitoOption)
        {
            _cognitoOptions = cognitoOption.CurrentValue;

            _cognitoClient = new AmazonCognitoIdentityProviderClient(_cognitoOptions.AccessKey, _cognitoOptions.SecretKey, Amazon.RegionEndpoint.USEast1);
            _cognitoUserPool = new CognitoUserPool(_cognitoOptions.PoolId, _cognitoOptions.ClientId, _cognitoClient);
        }

        public async Task<string> GetToken(string userName, string password)
        {
            var user = new CognitoUser(userName, _cognitoOptions.ClientId, _cognitoUserPool, _cognitoClient);

            var authRequest = new InitiateSrpAuthRequest()
            {
                Password = password
            };

            var authResponse = await user.StartWithSrpAuthAsync(authRequest).ConfigureAwait(false);
            var accessToken = authResponse.AuthenticationResult.AccessToken;

            return authResponse.AuthenticationResult.AccessToken;
        }

        public async Task SignUp(string userName, string email, string password)
        {
            var authRequest = new SignUpRequest()
            {
                Username = userName,
                Password = password,
                ClientId = _cognitoOptions.ClientId,
                UserAttributes = new List<AttributeType>() { 
                    new(){ Name = "given_name", Value = userName },
                    new(){ Name = "email", Value = email }
                }
            };

            var signupResponse = await _cognitoClient.SignUpAsync(authRequest).ConfigureAwait(false);
        }

        public async Task ConfirmEmail(string userName, string code)
        {
            var authRequest = new ConfirmSignUpRequest()
            {
                ClientId = _cognitoOptions.ClientId,
                Username = userName,
                ConfirmationCode = code
            };

            var authResponse = await _cognitoClient.ConfirmSignUpAsync(authRequest).ConfigureAwait(false);
        }
    }
}
