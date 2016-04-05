using CompHi.Core.Domain.Models;
using SharpRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompHi.Core.Domain
{
    public interface ICompaniesRepository: IRepository<Company, Guid>
    {
    }
}
