using PharmacyProject.DataAccessLayer;
using PharmacyProject.Medicines;
using PharmacyProject.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace PharmacyProject
{
    public partial class MedicinesForm : Form
    {
        public MedicinesForm()
        {
            InitializeComponent();
        }

        private void MedicinesForm_Load(object sender, EventArgs e)
        {
           
            Medicine.GetMedicineData();
            medicineDataGrid.DataSource = Medicine.dt;
            medicineDataGrid.Columns[0].Visible = false;
        }

        private void medicinesAddBtn_Click(object sender, EventArgs e)
        {
            

            DataConnection.db().Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = DataConnection.db();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "AddMedicine";
            sqlCommand.Parameters.Add("@Barcode", SqlDbType.NVarChar, 100).Value = medicineBarcodeTxt.Text;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = medicineNameTxt.Text;
            sqlCommand.Parameters.Add("@Type", SqlDbType.NVarChar, 100).Value = medicineTypeCbox.SelectedItem;
            sqlCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = medicineQuantityTxt.Text;
            sqlCommand.Parameters.Add("@Price", SqlDbType.Float).Value = medicinePriceTxt.Text;
            sqlCommand.ExecuteNonQuery();

            DataConnection.db().Close();

            MessageBox.Show("Added Medicine Successfull");
            Medicine.GetMedicineData();
            medicineDataGrid.DataSource = Medicine.dt;
        }

        private void medicineEditBtn_Click(object sender, EventArgs e)
        {
            
           
                Medicine.dataAdapter.Update(Medicine.dt);
                MessageBox.Show("Changes are Successful!");
                Medicine.GetMedicineData();
            

            
            
        }

        private void medicineBarcodeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
