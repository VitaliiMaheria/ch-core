using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompHi.Core.Domain.Models
{
    public class Company
    {
        #region Properties
        public Guid Id { get; set; }
        public Guid? ParentCompanyId { get; set; }
        public string Name { get; set; }
        public decimal Earnings { get; set; }

        public virtual Company ParentCompany { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        #endregion

        #region Constructors
        public Company()
        {
            Companies = new List<Company>();
        }
        #endregion
    }
}
