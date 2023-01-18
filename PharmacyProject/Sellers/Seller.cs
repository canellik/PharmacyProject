using PharmacyProject.DataAccessLayer;
using PharmacyProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace PharmacyProject.Sells
{
    internal class Seller:AbstractBaseProp
    {

        public static SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Seller where IsDelete=0", DataConnection.db());

        public static DataTable dt = new DataTable();
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public double Balance { get; set; }



        public static void GetSellerData()
        {
            dt.Rows.Clear();
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(dt);

        }
    }

    
}
