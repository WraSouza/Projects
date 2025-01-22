using Projects.Model;

namespace Projects.Repositories.Login
{
    public interface ILoginRepository
    {
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
        void RequestCode(PasswordRecoveryCode email);
        Task<bool> SendCodeValidation(ValidateCode code);
    }
}
