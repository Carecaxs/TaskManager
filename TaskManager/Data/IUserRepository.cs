using TaskManager.Models;

namespace TaskManager.Data
{
    public interface IUserRepository
    {
        Task<USERS> GetUserByIdAsync(int id);
        Task<IEnumerable<USERS>> GetAllUsersAsync();
        Task AddUserAsync(USERS user);
    }
}
