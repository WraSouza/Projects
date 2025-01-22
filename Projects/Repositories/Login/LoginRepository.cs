using Flurl.Http;
using Projects.Helpers;
using Projects.Model;

namespace Projects.Repositories.Login
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            return await SitesURL.userLoginAPI.GetJsonAsync<LoginResponse>();
        }

        public async void RequestCode(PasswordRecoveryCode code)
        {
           await SitesURL.recoverPasswordAPI.PostJsonAsync(code);
        }

        public async Task<bool> SendCodeValidation(ValidateCode code)
        {
            var resultMessage = await SitesURL.validateCodeAPI.PostJsonAsync(code);

            if (resultMessage.StatusCode == 204)
            {
                return true;
            }

            return false;
        }
    }
}
