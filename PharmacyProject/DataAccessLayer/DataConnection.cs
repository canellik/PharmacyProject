using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject.DataAccessLayer
{
    internal class DataConnection
    {
        private static SqlConnection database = new SqlConnection(@"Data Source=DESKTOP-67MKEAK\MSSQLSERVER01; initial Catalog=PharmacyDb; integrated security=true");

        public static SqlConnection db()
        {
            return database;
        }
    }
}
