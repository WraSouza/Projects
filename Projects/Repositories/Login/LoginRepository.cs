using Flurl.Http;
using Newtonsoft.Json;
using Projects.Helpers;
using Projects.Model;

namespace Projects.Repositories.Login
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            try
            {
                var result = await SitesURL.userLoginAPI.PutJsonAsync(loginRequest);

                if (result.ResponseMessage.IsSuccessStatusCode)
                {
                    var content = await result.ResponseMessage.Content.ReadAsStringAsync();

                    var token = JsonConvert.DeserializeObject<LoginResponse>(content);

                    return token;
                }

            }
            catch(FlurlHttpException ex)
            {
                if(ex.StatusCode >= 400)
                {
                    return new LoginResponse();
                }
            }

          

            return new LoginResponse();
        }

        public async void RequestCode(PasswordRecoveryCode code)
        {
           await SitesURL.recoverPasswordAPI.PostJsonAsync(code);
        }
        
    }
}
