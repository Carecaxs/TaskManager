using TaskManager.Models;

namespace TaskManager.Services
{
    public interface IUserService
    {
        Task<USERS> GetUserByIdAsync(int id);
        Task<IEnumerable<USERS>> GetAllUsersAsync();
        Task AddUserAsync(USERS user);
    }
}
