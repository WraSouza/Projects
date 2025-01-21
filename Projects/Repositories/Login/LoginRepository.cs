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
    }
}
