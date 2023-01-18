namespace PharmacyProject
{
    partial class SellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sellCustomerNameCbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellMedicineQuantityTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sellMedicinePriceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sellMedicineBarcodeTxt = new System.Windows.Forms.TextBox();
            this.sellMedicineDataGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.sellMedicineNameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sellCartDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sellBillDataGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sellSellBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.sellAddCartBtn = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.sellMedicineDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellCartDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBillDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellSellBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellAddCartBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // sellCustomerNameCbox
            // 
            this.sellCustomerNameCbox.FormattingEnabled = true;
            this.sellCustomerNameCbox.Location = new System.Drawing.Point(83, 138);
            this.sellCustomerNameCbox.Name = "sellCustomerNameCbox";
            this.sellCustomerNameCbox.Size = new System.Drawing.Size(100, 21);
            this.sellCustomerNameCbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // sellMedicineQuantityTxt
            // 
            this.sellMedicineQuantityTxt.Location = new System.Drawing.Point(211, 139);
            this.sellMedicineQuantityTxt.Name = "sellMedicineQuantityTxt";
            this.sellMedicineQuantityTxt.Size = new System.Drawing.Size(100, 20);
            this.sellMedicineQuantityTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // sellMedicinePriceTxt
            // 
            this.sellMedicinePriceTxt.Enabled = false;
            this.sellMedicinePriceTxt.Location = new System.Drawing.Point(211, 183);
            this.sellMedicinePriceTxt.Name = "sellMedicinePriceTxt";
            this.sellMedicinePriceTxt.Size = new System.Drawing.Size(100, 20);
            this.sellMedicinePriceTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Medicine Barcode";
            // 
            // sellMedicineBarcodeTxt
            // 
            this.sellMedicineBarcodeTxt.Location = new System.Drawing.Point(83, 183);
            this.sellMedicineBarcodeTxt.Name = "sellMedicineBarcodeTxt";
            this.sellMedicineBarcodeTxt.Size = new System.Drawing.Size(100, 20);
            this.sellMedicineBarcodeTxt.TabIndex = 8;
            this.sellMedicineBarcodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sellMedicineBarcodeTxt_KeyPress);
            // 
            // sellMedicineDataGrid
            // 
            this.sellMedicineDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellMedicineDataGrid.Location = new System.Drawing.Point(86, 384);
            this.sellMedicineDataGrid.Name = "sellMedicineDataGrid";
            this.sellMedicineDataGrid.Size = new System.Drawing.Size(277, 181);
            this.sellMedicineDataGrid.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Medicine";
            // 
            // sellMedicineNameTxt
            // 
            this.sellMedicineNameTxt.Enabled = false;
            this.sellMedicineNameTxt.Location = new System.Drawing.Point(83, 225);
            this.sellMedicineNameTxt.Name = "sellMedicineNameTxt";
            this.sellMedicineNameTxt.Size = new System.Drawing.Size(100, 20);
            this.sellMedicineNameTxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(87, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Add to Cart";
            // 
            // sellCartDataGrid
            // 
            this.sellCartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellCartDataGrid.Location = new System.Drawing.Point(506, 124);
            this.sellCartDataGrid.Name = "sellCartDataGrid";
            this.sellCartDataGrid.Size = new System.Drawing.Size(277, 133);
            this.sellCartDataGrid.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gabriola", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(383, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 110);
            this.label8.TabIndex = 34;
            this.label8.Text = "+ Pharmacy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(742, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Sell";
            // 
            // sellBillDataGrid
            // 
            this.sellBillDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellBillDataGrid.Location = new System.Drawing.Point(506, 384);
            this.sellBillDataGrid.Name = "sellBillDataGrid";
            this.sellBillDataGrid.Size = new System.Drawing.Size(277, 181);
            this.sellBillDataGrid.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(83, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Medicines";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(503, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Cart List";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(503, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "Bill";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(721, 618);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 18);
            this.label13.TabIndex = 43;
            this.label13.Text = "Export Bill";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PharmacyProject.Properties.Resources.icons8_print_100;
            this.pictureBox1.Location = new System.Drawing.Point(708, 571);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sellSellBtn
            // 
            this.sellSellBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellSellBtn.Image = global::PharmacyProject.Properties.Resources.icons8_money_bag_1001;
            this.sellSellBtn.Location = new System.Drawing.Point(708, 274);
            this.sellSellBtn.Name = "sellSellBtn";
            this.sellSellBtn.Size = new System.Drawing.Size(100, 50);
            this.sellSellBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sellSellBtn.TabIndex = 37;
            this.sellSellBtn.TabStop = false;
            this.sellSellBtn.Click += new System.EventHandler(this.sellSellBtn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PharmacyProject.Properties.Resources.icons8_doctors_bag_100;
            this.pictureBox6.Location = new System.Drawing.Point(227, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(151, 94);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // sellAddCartBtn
            // 
            this.sellAddCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellAddCartBtn.Image = global::PharmacyProject.Properties.Resources.icons8_add_100;
            this.sellAddCartBtn.Location = new System.Drawing.Point(76, 265);
            this.sellAddCartBtn.Name = "sellAddCartBtn";
            this.sellAddCartBtn.Size = new System.Drawing.Size(100, 50);
            this.sellAddCartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sellAddCartBtn.TabIndex = 30;
            this.sellAddCartBtn.TabStop = false;
            this.sellAddCartBtn.Click += new System.EventHandler(this.sellAddCartBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 645);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sellSellBtn);
            this.Controls.Add(this.sellBillDataGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.sellCartDataGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sellAddCartBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sellMedicineNameTxt);
            this.Controls.Add(this.sellMedicineDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sellMedicineBarcodeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sellMedicinePriceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellMedicineQuantityTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellCustomerNameCbox);
            this.Name = "SellForm";
            this.Text = "SellForm";
            this.Load += new System.EventHandler(this.SellForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellMedicineDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellCartDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBillDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellSellBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellAddCartBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sellCustomerNameCbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sellMedicineQuantityTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sellMedicinePriceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sellMedicineBarcodeTxt;
        private System.Windows.Forms.DataGridView sellMedicineDataGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sellMedicineNameTxt;
        private System.Windows.Forms.PictureBox sellAddCartBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView sellCartDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox sellSellBtn;
        private System.Windows.Forms.DataGridView sellBillDataGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}