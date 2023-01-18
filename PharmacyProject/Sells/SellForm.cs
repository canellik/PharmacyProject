using PharmacyProject.Customers;
using PharmacyProject.DataAccessLayer;
using PharmacyProject.Medicines;
using PharmacyProject.Sells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Rectangle = System.Drawing.Rectangle;

namespace PharmacyProject
{
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            Customer.GetCustomerData();
            Medicine.GetMedicineData();
            sellCustomerNameCbox.DataSource = Customer.dt;
            sellCustomerNameCbox.ValueMember = "Id";
            sellCustomerNameCbox.DisplayMember = "Name";

            sellMedicineDataGrid.DataSource=Medicine.dt;

        }

        private void sellMedicineBarcodeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Enter)
            {
                Medicine.GetMedicineList();
                var medicine = Medicine.MedicineList.Find(x => x.Barcode == sellMedicineBarcodeTxt.Text.ToString());
                sellMedicineNameTxt.Text = medicine.Name;
                sellMedicinePriceTxt.Text = medicine.Price.ToString();
            }
            


        }

        private void sellAddCartBtn_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart()
            {
                Customer = sellCustomerNameCbox.SelectedValue.ToString(),
                Medicine = sellMedicineNameTxt.Text,
                Price = Convert.ToInt32(sellMedicinePriceTxt.Text),
                Quantity = Convert.ToInt32(sellMedicineQuantityTxt.Text),
                SoldDate = DateTime.Now,
                TotalPrice = Convert.ToDouble(sellMedicinePriceTxt.Text) * Convert.ToDouble(sellMedicineQuantityTxt.Text)
                
            };



            Cart.CartList.Add(cart);

            var medicine = Medicine.MedicineList.Find(x => x.Barcode == sellMedicineBarcodeTxt.Text);
            medicine.Quantity = medicine.Quantity - Convert.ToInt32(sellMedicineQuantityTxt.Text);

            sellCartDataGrid.DataSource = null;
            sellCartDataGrid.DataSource=Cart.CartList;
            sellCartDataGrid.Columns["SoldDate"].Visible = false;
            sellMedicineNameTxt.Clear();
            sellMedicineBarcodeTxt.Clear();
            sellMedicinePriceTxt.Clear();
            sellMedicineQuantityTxt.Clear();


        }

        private void sellSellBtn_Click(object sender, EventArgs e)
        {
            sellBillDataGrid.DataSource = Cart.CartList;
            Cart.CartList = null;
            sellCartDataGrid.DataSource = null;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap bm = new Bitmap(this.sellBillDataGrid.Width, this.sellBillDataGrid.Height);
            //sellBillDataGrid.DrawToBitmap(bm, new Rectangle(0, 0, this.sellBillDataGrid.Width, this.sellBillDataGrid.Height));
            //e.Graphics.DrawImage(bm, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //printDocument1.Print();


            if (sellBillDataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(sellBillDataGrid.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in sellBillDataGrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in sellBillDataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Bill Exported Successfully!", "Info");
                            sellBillDataGrid.DataSource = null;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!", "Info");
            }
        }
    }
}
