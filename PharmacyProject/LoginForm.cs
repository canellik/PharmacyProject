using PharmacyProject.DataAccessLayer;
using PharmacyProject.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (User.UserLogin(usernameTxt.Text,passwordTxt.Text))
            {
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect Entry");
            }

           


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DataConnection.db().Open();
            string query = "select Username, Password from Users";
            SqlCommand sqlCommand = new SqlCommand(query, DataConnection.db());
            SqlDataReader data = sqlCommand.ExecuteReader();

            while (data.Read())
            {
                User user = new User()
                {
                    Username = data["Username"].ToString(),
                    Password = data["Password"].ToString()
                };

                User.UserList.Add(user);

            }

            DataConnection.db().Close();
        }
    }
}
