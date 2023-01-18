using PharmacyProject.DataAccessLayer;
using PharmacyProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject.Customers
{
    internal class Customer:AbstractBaseProp
    {
        public static SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Customer where IsDelete=0", DataConnection.db());

        public static DataTable dt = new DataTable();
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }



        public static void GetCustomerData()
        {
            dt.Rows.Clear();
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(dt);
        }

    }


    
}
