using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderMasterAPI.Data.Interfaces;
using OrderMasterAPI.Models;

namespace OrderMasterAPI.Data.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataContext _context;

        public CompanyRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<int> AddCompany(Company company)
        {
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();

            int id = company.Id;

            return id;
        }

        public void DeleteCompany(Company company)
        {
            _context.Companies.Remove(company);
        }

        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            var companiesInfo = await _context.Companies.ToListAsync();
            
            return companiesInfo;
        }

        public async Task<Company> GetCompanyById(int id)
        {
            var companyInfo = await _context.Companies.FirstOrDefaultAsync(c => c.Id == id);

            return companyInfo;
        }

        public async Task<int> UpdateCompany(Company company)
        {
            _context.Companies.Attach(company);
            _context.Companies.Update(company);
            await _context.SaveChangesAsync();

            int id = company.Id;

            return id;
        }
    }
}