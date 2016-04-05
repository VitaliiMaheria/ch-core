using CompHi.Core.Domain;
using CompHi.Core.Domain.Models;
using CompHi.DataAccess.Contexts;
using SharpRepository.EfRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompHi.DataAccess.Repositories
{
    public class CompaniesRepository : EfRepository<Company, Guid>, ICompaniesRepository
    {
        public CompaniesRepository(CompaniesContext dbContext) : base(dbContext)
        { }
    }
}
