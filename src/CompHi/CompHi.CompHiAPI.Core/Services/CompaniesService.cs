using CompHi.Core.Domain;
using CompHi.Core.Domain.Models;
using SharpRepository.Repository.FetchStrategies;
using SharpRepository.Repository.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompHi.CompHiAPI.Core.Services
{
    public class CompaniesService
    {
        private readonly ICompaniesRepository _companiesRepository;
        
        public CompaniesService(ICompaniesRepository companiesRepository)
        {
            _companiesRepository = companiesRepository;
        }

        public IEnumerable<Company> Get()
        {
            return _companiesRepository.FindAll(c => c.ParentCompanyId == null);
        }

        public Company Get(Guid id)
        {
            return _companiesRepository.Get(id);
        }

        public void Create(Company company)
        {
            _companiesRepository.Add(company);
        }

        public void Update(Company company)
        {
            var companyEntity = _companiesRepository.Get(company.Id);
            companyEntity.Name = company.Name;
            companyEntity.Earnings = company.Earnings;
            _companiesRepository.Update(companyEntity);
        }

        public void Delete(Guid id)
        {
            var companyEntity = _companiesRepository.Get(id);
            foreach (var childCompany in companyEntity.Companies)
            {
                childCompany.ParentCompanyId = companyEntity.ParentCompanyId;
            }
            _companiesRepository.Update(companyEntity.Companies);
            _companiesRepository.Delete(id);
        }
    }
}
