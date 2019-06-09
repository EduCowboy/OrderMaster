using System.Collections.Generic;
using System.Threading.Tasks;
using OrderMasterAPI.Models;

namespace OrderMasterAPI.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<int> AddUser(User user);
        void DeleteUser(User user);
        Task<int> UpdateUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
    }
}