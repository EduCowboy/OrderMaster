using System.Collections.Generic;
using System.Threading.Tasks;
using OrderMasterAPI.Models;

namespace OrderMasterAPI.Data.Interfaces
{
    public interface IWorkerRepository
    {
        Task<int> AddUser(Worker worker);
        void DeleteUser(Worker worker);
        Task<int> UpdateUser(Worker worker);
        Task<IEnumerable<Worker>> GetAllUsers();
        Task<Worker> GetUserById(int id);
    }
}