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

namespace PharmacyProject
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            DataConnection.db().Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = DataConnection.db();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "AddCustomer";

            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = customerNameTxt.Text;
            sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar, 100).Value = customerSurnameTxt.Text;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.NVarChar, 100).Value = customerGenderCbox.SelectedItem;
            sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = customerPhoneTxt.Text;
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = customerEmailTxt.Text;
            sqlCommand.ExecuteNonQuery();

            DataConnection.db().Close();
            MessageBox.Show("Added Successful");
            Customer.GetCustomerData();
            customerDataGrid.DataSource = Customer.dt;
            


            

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Customer.GetCustomerData();
            customerDataGrid.DataSource = Customer.dt;
            customerDataGrid.Columns[0].Visible = false;
        }

        private void customerEditBtn_Click(object sender, EventArgs e)
        {
            Customer.dataAdapter.Update(Customer.dt);
            MessageBox.Show("Changes are Successful!");
            Customer.GetCustomerData();
                
        }
    }
}
