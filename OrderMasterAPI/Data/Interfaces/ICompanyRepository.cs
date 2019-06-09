using System.Collections.Generic;
using System.Threading.Tasks;
using OrderMasterAPI.Models;

namespace OrderMasterAPI.Data.Interfaces
{
    public interface ICompanyRepository
    {
        Task<int> AddCompany(Company company);
        void DeleteCompany(Company company);
        Task<int> UpdateCompany(Company company);
        Task<IEnumerable<Company>> GetAllCompanies();
        Task<Company> GetCompanyById(int id);
    }
}