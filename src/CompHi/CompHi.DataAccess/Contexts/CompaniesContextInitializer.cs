using CompHi.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompHi.DataAccess.Contexts
{
    //public class CompaniesContextInitializer : DropCreateDatabaseIfModelChanges<CompaniesContext>
    //public class CompaniesContextInitializer : CreateDatabaseIfNotExists<CompaniesContext>
    public class CompaniesContextInitializer : DropCreateDatabaseAlways<CompaniesContext>
    {
        protected override void Seed(CompaniesContext context)
        {
            base.Seed(context);


            var company1 = new Company { Id = Guid.NewGuid(), Name = "Company1", Earnings = 25000 };
            var company2 = new Company { Id = Guid.NewGuid(), ParentCompanyId = company1.Id, Name = "Company2", Earnings = 13000 };
            var company3 = new Company { Id = Guid.NewGuid(), ParentCompanyId = company2.Id, Name = "Company3", Earnings = 5000 };
            var company4 = new Company { Id = Guid.NewGuid(), ParentCompanyId = company1.Id, Name = "Company4", Earnings = 10000 };
            var company5 = new Company { Id = Guid.NewGuid(), Name = "Company5", Earnings = 12000 };
            var company6 = new Company { Id = Guid.NewGuid(), ParentCompanyId = company3.Id, Name = "Company6", Earnings = 19000 };

            context.Companies.Add(company1);
            context.Companies.Add(company2);
            context.Companies.Add(company3);
            context.Companies.Add(company4);
            context.Companies.Add(company5);
            context.Companies.Add(company6);
            context.SaveChanges();
        }
    }
}
