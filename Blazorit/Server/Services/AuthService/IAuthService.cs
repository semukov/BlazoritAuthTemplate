using Blazorit.Shared;

namespace Blazorit.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<bool> UserExists(string userName);
        Task<ServiceResponse<string>> Login(string userName, string password);
        Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);
        int GetUserId();
        string GetUserName();
        Task<User> GetUserByUserName(string userName);
    }
}
