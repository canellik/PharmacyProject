using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProject
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MedicinesForm medicinesForm = new MedicinesForm();
            medicinesForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SellForm sellForm=new SellForm();
            sellForm.Show();
        }
    }
}
