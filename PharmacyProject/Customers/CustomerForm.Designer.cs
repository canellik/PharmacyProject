namespace PharmacyProject
{
    partial class CustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerEmailTxt = new System.Windows.Forms.TextBox();
            this.customerGenderCbox = new System.Windows.Forms.ComboBox();
            this.customerPhoneTxt = new System.Windows.Forms.TextBox();
            this.customerSurnameTxt = new System.Windows.Forms.TextBox();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.Barcode = new System.Windows.Forms.Label();
            this.customerEditBtn = new System.Windows.Forms.PictureBox();
            this.customerAddBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerEditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(392, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 110);
            this.label1.TabIndex = 28;
            this.label1.Text = "+ Pharmacy";
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToDeleteRows = false;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(155, 281);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.Size = new System.Drawing.Size(583, 248);
            this.customerDataGrid.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Surname";
            // 
            // customerEmailTxt
            // 
            this.customerEmailTxt.Location = new System.Drawing.Point(641, 162);
            this.customerEmailTxt.Name = "customerEmailTxt";
            this.customerEmailTxt.Size = new System.Drawing.Size(100, 20);
            this.customerEmailTxt.TabIndex = 19;
            // 
            // customerGenderCbox
            // 
            this.customerGenderCbox.FormattingEnabled = true;
            this.customerGenderCbox.Items.AddRange(new object[] {
            "M",
            "F",
            "Not Specify"});
            this.customerGenderCbox.Location = new System.Drawing.Point(391, 161);
            this.customerGenderCbox.Name = "customerGenderCbox";
            this.customerGenderCbox.Size = new System.Drawing.Size(104, 21);
            this.customerGenderCbox.TabIndex = 18;
            // 
            // customerPhoneTxt
            // 
            this.customerPhoneTxt.Location = new System.Drawing.Point(517, 161);
            this.customerPhoneTxt.Name = "customerPhoneTxt";
            this.customerPhoneTxt.Size = new System.Drawing.Size(100, 20);
            this.customerPhoneTxt.TabIndex = 17;
            // 
            // customerSurnameTxt
            // 
            this.customerSurnameTxt.Location = new System.Drawing.Point(268, 161);
            this.customerSurnameTxt.Name = "customerSurnameTxt";
            this.customerSurnameTxt.Size = new System.Drawing.Size(100, 20);
            this.customerSurnameTxt.TabIndex = 16;
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Location = new System.Drawing.Point(155, 161);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(100, 20);
            this.customerNameTxt.TabIndex = 20;
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(155, 142);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(35, 13);
            this.Barcode.TabIndex = 21;
            this.Barcode.Text = "Name";
            // 
            // customerEditBtn
            // 
            this.customerEditBtn.Image = global::PharmacyProject.Properties.Resources.icons8_edit_100__1_;
            this.customerEditBtn.Location = new System.Drawing.Point(488, 208);
            this.customerEditBtn.Name = "customerEditBtn";
            this.customerEditBtn.Size = new System.Drawing.Size(100, 50);
            this.customerEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerEditBtn.TabIndex = 30;
            this.customerEditBtn.TabStop = false;
            this.customerEditBtn.Click += new System.EventHandler(this.customerEditBtn_Click);
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.Image = global::PharmacyProject.Properties.Resources.icons8_add_100;
            this.customerAddBtn.Location = new System.Drawing.Point(330, 208);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(100, 50);
            this.customerAddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerAddBtn.TabIndex = 29;
            this.customerAddBtn.TabStop = false;
            this.customerAddBtn.Click += new System.EventHandler(this.customerAddBtn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PharmacyProject.Properties.Resources.icons8_doctors_bag_100;
            this.pictureBox6.Location = new System.Drawing.Point(235, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(151, 94);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Save Changes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Add Medicine";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 537);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerEditBtn);
            this.Controls.Add(this.customerAddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.customerNameTxt);
            this.Controls.Add(this.customerEmailTxt);
            this.Controls.Add(this.customerGenderCbox);
            this.Controls.Add(this.customerPhoneTxt);
            this.Controls.Add(this.customerSurnameTxt);
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerEditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox customerEditBtn;
        private System.Windows.Forms.PictureBox customerAddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerEmailTxt;
        private System.Windows.Forms.ComboBox customerGenderCbox;
        private System.Windows.Forms.TextBox customerPhoneTxt;
        private System.Windows.Forms.TextBox customerSurnameTxt;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}