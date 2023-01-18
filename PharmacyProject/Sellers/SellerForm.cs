using PharmacyProject.DataAccessLayer;
using PharmacyProject.Medicines;
using PharmacyProject.Sells;
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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            Seller.GetSellerData();
            sellerDataGrid.DataSource = Seller.dt;
        }

        private void sellerEditBtn_Click(object sender, EventArgs e)
        {
            
            
                Seller.dataAdapter.Update(Seller.dt);
                MessageBox.Show("Changes Successful");
                Seller.GetSellerData();
           
            
        }

        private void sellerAddBtn_Click(object sender, EventArgs e)
        {
            DataConnection.db().Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = DataConnection.db();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "AddSeller";
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = sellerNameTxt.Text;
            sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar, 100).Value = sellerSurnameTxt.Text;
            sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = sellerUsernameTxt.Text;
            sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = sellerPhoneTxt.Text;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.NVarChar,50).Value = sellerGenderCbox.SelectedItem;
            sqlCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 1000).Value = sellerAdressRichBox.Text;
            sqlCommand.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = sellerBirthdayTpick.Value;
            sqlCommand.ExecuteNonQuery();

            DataConnection.db().Close();

            MessageBox.Show("Added Seller Successfull");
            Seller.GetSellerData();
            sellerDataGrid.DataSource = Seller.dt;
        }
    }
}
