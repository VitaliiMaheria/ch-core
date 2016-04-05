using CompHi.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompHi.DataAccess.Contexts
{
    public class CompaniesContext : DbContext
    {
        public CompaniesContext(string nameOrConnectionString, bool proxyCreationEnabled = true)
            : base(nameOrConnectionString)
        {
            Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }
        public DbSet<Company> Companies { get; set; }
    }
}
