using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderMasterAPI.Data.Interfaces;
using OrderMasterAPI.Models;

namespace OrderMasterAPI.Data.Repository
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly DataContext _context;

        public WorkerRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<int> AddUser(Worker worker)
        {
            await _context.Workers.AddAsync(worker);
            await _context.SaveChangesAsync();

            int id = worker.Id;

            return id;
        }

        public void DeleteUser(Worker worker)
        {
            _context.Workers.Remove(worker);
        }

        public async Task<IEnumerable<Worker>> GetAllUsers()
        {
            var workersInfo = await _context.Workers.ToListAsync();
            
            return workersInfo;
        }

        public async Task<Worker> GetUserById(int id)
        {
            var workerInfo = await _context.Workers.FirstOrDefaultAsync(w => w.Id == id);

            return workerInfo;
        }

        public async Task<int> UpdateUser(Worker worker)
        {
            _context.Workers.Attach(worker);
            _context.Workers.Update(worker);
            await _context.SaveChangesAsync();

            int id = worker.Id;

            return id;
        }
    }
}