using Projects.Model;

namespace Projects.Repositories.Users
{
    public interface IUserRepository
    {
        Task<bool> AddUserAsync(User user);
        Task<List<UserResponse>> GetAllUsersAsync();       
    }
}
