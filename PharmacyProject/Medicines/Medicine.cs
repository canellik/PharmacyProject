using PharmacyProject.DataAccessLayer;
using PharmacyProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject.Medicines
{
    
    internal class Medicine:AbstractBaseProp
    {
        public static SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Medicines where IsDelete=0", DataConnection.db());
        public static DataTable dt = new DataTable();
        public static List<Medicine> MedicineList = new List<Medicine>();
        public string Barcode { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        

        public static void GetMedicineData()
        {
            dt.Rows.Clear();
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(dt);
            
            
        }

        public static void GetMedicineList()
        {
            DataConnection.db().Open();
            string query = "select * from Medicines where IsStatus=1 and IsDelete=0";
            SqlCommand sqlCommand = new SqlCommand(query, DataConnection.db());
            SqlDataReader data = sqlCommand.ExecuteReader();
            while (data.Read())
            {
                Medicine medicine = new Medicine
                {
                    Barcode = data["Barcode"].ToString(),
                    Name = data["Name"].ToString(),
                    Price = Convert.ToDouble(data["Price"])
                };
                Medicine.MedicineList.Add(medicine);
            }
            DataConnection.db().Close();
        }
        
}

}
