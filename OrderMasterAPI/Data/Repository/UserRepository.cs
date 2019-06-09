using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderMasterAPI.Data.Interfaces;
using OrderMasterAPI.Models;

namespace OrderMasterAPI.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<int> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            int id = user.Id;

            return id;
        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var usersInfo = await _context.Users.ToListAsync();
            
            return usersInfo;
        }

        public async Task<User> GetUserById(int id)
        {
            var userInfo = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

            return userInfo;
        }

        public async Task<int> UpdateUser(User user)
        {
            _context.Users.Attach(user);
            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            int id = user.Id;

            return id;
        }
    }
}