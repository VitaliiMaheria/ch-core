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
        static CompaniesContext()
        {
            Database.SetInitializer(new CompaniesContextInitializer());
        }

        public CompaniesContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Configuration.ProxyCreationEnabled = true;
            //Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Company> Companies { get; set; }
    }
}
