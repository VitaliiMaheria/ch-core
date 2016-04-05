using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompHi.Core.Common
{
    public sealed class ConnectionStringsProvider
    {
        public static string GetCompaniesConnectionString()
        {
            return ConfigurationManager.ConnectionStrings[Constants.ConnectionName.CompaniesConnection].ConnectionString;
        }

        #region Constants
        private static class Constants
        {
            public static class ConnectionName
            {
                public const string CompaniesConnection = "CompaniesConnection";
            }
        }
        #endregion
    }

}
