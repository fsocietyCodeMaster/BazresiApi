using BazresiApi.DTO;

namespace BazresiApi.Repository
{
    public interface IUser
    {
        Task<UserManageResponse> RegisterAsync(RegisterDto register);
        Task<UserManageResponse> LoginAsync(LoginDto login);
    }
}
