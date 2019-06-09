using Microsoft.EntityFrameworkCore;
using OrderMasterAPI.Models;

namespace OrderMasterAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Value> Values { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkerType> WorkerTypes { get; set; }
    }
}