using CompHi.Core.Domain;
using CompHi.Core.Domain.Models;
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
            //throw new Exception();
            return _companiesRepository.GetAll();
        }

        public Company Get(Guid id)
        {
            throw new Exception();

            //return _companiesRepository.Get(id);
        }

    }
}
