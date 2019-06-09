using System.Threading.Tasks;
using OrderMasterAPI.Models;

namespace OrderMasterAPI.Data.Interfaces
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExsists(string username); 
    }
}