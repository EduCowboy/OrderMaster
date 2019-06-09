using System.Collections.Generic;
using Newtonsoft.Json;
using OrderMasterAPI.Models;

namespace OrderMasterAPI.Data.Seed
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        /* public void SeedUsers() 
        {
            var userData = System.IO.File.ReadAllText("Data/SeedFiles/UserSeedData.json");
            var users = JsonConvert.DeserializeObject<List<User>>(userData);

            foreach (var user in users)
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash("password", out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.UserName = user.UserName.ToLower();

                _context.Users.Add(user);
            }

            _context.SaveChanges();
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
    
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }*/

        public void SeedUserTypes()
        {
            var userData = System.IO.File.ReadAllText("Data/SeedFiles/UserTypeSeedData.json");
            var users = JsonConvert.DeserializeObject<List<UserType>>(userData);

            foreach (var user in users)
            {
                _context.UserTypes.Add(user);
            }
            
            _context.SaveChanges();
        }
    }
}