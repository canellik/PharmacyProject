namespace PharmacyProject
{
    partial class SellerForm
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
            this.sellerDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Barcode = new System.Windows.Forms.Label();
            this.sellerNameTxt = new System.Windows.Forms.TextBox();
            this.sellerGenderCbox = new System.Windows.Forms.ComboBox();
            this.sellerPhoneTxt = new System.Windows.Forms.TextBox();
            this.sellerSurnameTxt = new System.Windows.Forms.TextBox();
            this.sellerAdressRichBox = new System.Windows.Forms.RichTextBox();
            this.sellerBirthdayTpick = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.sellerEditBtn = new System.Windows.Forms.PictureBox();
            this.sellerAddBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sellerUsernameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerEditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerAddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(389, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 110);
            this.label1.TabIndex = 44;
            this.label1.Text = "+ Pharmacy";
            // 
            // sellerDataGrid
            // 
            this.sellerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerDataGrid.Location = new System.Drawing.Point(152, 292);
            this.sellerDataGrid.Name = "sellerDataGrid";
            this.sellerDataGrid.Size = new System.Drawing.Size(583, 248);
            this.sellerDataGrid.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Surname";
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(149, 149);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(35, 13);
            this.Barcode.TabIndex = 37;
            this.Barcode.Text = "Name";
            // 
            // sellerNameTxt
            // 
            this.sellerNameTxt.Location = new System.Drawing.Point(149, 168);
            this.sellerNameTxt.Name = "sellerNameTxt";
            this.sellerNameTxt.Size = new System.Drawing.Size(100, 20);
            this.sellerNameTxt.TabIndex = 36;
            // 
            // sellerGenderCbox
            // 
            this.sellerGenderCbox.FormattingEnabled = true;
            this.sellerGenderCbox.Items.AddRange(new object[] {
            "M",
            "F",
            "Not Specify"});
            this.sellerGenderCbox.Location = new System.Drawing.Point(385, 168);
            this.sellerGenderCbox.Name = "sellerGenderCbox";
            this.sellerGenderCbox.Size = new System.Drawing.Size(104, 21);
            this.sellerGenderCbox.TabIndex = 34;
            // 
            // sellerPhoneTxt
            // 
            this.sellerPhoneTxt.Location = new System.Drawing.Point(511, 168);
            this.sellerPhoneTxt.Name = "sellerPhoneTxt";
            this.sellerPhoneTxt.Size = new System.Drawing.Size(100, 20);
            this.sellerPhoneTxt.TabIndex = 33;
            // 
            // sellerSurnameTxt
            // 
            this.sellerSurnameTxt.Location = new System.Drawing.Point(262, 168);
            this.sellerSurnameTxt.Name = "sellerSurnameTxt";
            this.sellerSurnameTxt.Size = new System.Drawing.Size(100, 20);
            this.sellerSurnameTxt.TabIndex = 32;
            // 
            // sellerAdressRichBox
            // 
            this.sellerAdressRichBox.Location = new System.Drawing.Point(635, 170);
            this.sellerAdressRichBox.Name = "sellerAdressRichBox";
            this.sellerAdressRichBox.Size = new System.Drawing.Size(100, 40);
            this.sellerAdressRichBox.TabIndex = 48;
            this.sellerAdressRichBox.Text = "";
            // 
            // sellerBirthdayTpick
            // 
            this.sellerBirthdayTpick.Location = new System.Drawing.Point(754, 170);
            this.sellerBirthdayTpick.Name = "sellerBirthdayTpick";
            this.sellerBirthdayTpick.Size = new System.Drawing.Size(108, 20);
            this.sellerBirthdayTpick.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(751, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Date of Birth";
            // 
            // sellerEditBtn
            // 
            this.sellerEditBtn.Image = global::PharmacyProject.Properties.Resources.icons8_edit_100__1_;
            this.sellerEditBtn.Location = new System.Drawing.Point(459, 216);
            this.sellerEditBtn.Name = "sellerEditBtn";
            this.sellerEditBtn.Size = new System.Drawing.Size(100, 50);
            this.sellerEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sellerEditBtn.TabIndex = 46;
            this.sellerEditBtn.TabStop = false;
            this.sellerEditBtn.Click += new System.EventHandler(this.sellerEditBtn_Click);
            // 
            // sellerAddBtn
            // 
            this.sellerAddBtn.Image = global::PharmacyProject.Properties.Resources.icons8_add_100;
            this.sellerAddBtn.Location = new System.Drawing.Point(301, 216);
            this.sellerAddBtn.Name = "sellerAddBtn";
            this.sellerAddBtn.Size = new System.Drawing.Size(100, 50);
            this.sellerAddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sellerAddBtn.TabIndex = 45;
            this.sellerAddBtn.TabStop = false;
            this.sellerAddBtn.Click += new System.EventHandler(this.sellerAddBtn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PharmacyProject.Properties.Resources.icons8_doctors_bag_100;
            this.pictureBox6.Location = new System.Drawing.Point(232, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(151, 94);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Save Changes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Add Medicine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Username";
            // 
            // sellerUsernameTxt
            // 
            this.sellerUsernameTxt.Location = new System.Drawing.Point(152, 216);
            this.sellerUsernameTxt.Name = "sellerUsernameTxt";
            this.sellerUsernameTxt.Size = new System.Drawing.Size(100, 20);
            this.sellerUsernameTxt.TabIndex = 53;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 537);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sellerUsernameTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sellerBirthdayTpick);
            this.Controls.Add(this.sellerAdressRichBox);
            this.Controls.Add(this.sellerEditBtn);
            this.Controls.Add(this.sellerAddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.sellerDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.sellerNameTxt);
            this.Controls.Add(this.sellerGenderCbox);
            this.Controls.Add(this.sellerPhoneTxt);
            this.Controls.Add(this.sellerSurnameTxt);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerEditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerAddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox sellerEditBtn;
        private System.Windows.Forms.PictureBox sellerAddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridView sellerDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.TextBox sellerNameTxt;
        private System.Windows.Forms.ComboBox sellerGenderCbox;
        private System.Windows.Forms.TextBox sellerPhoneTxt;
        private System.Windows.Forms.TextBox sellerSurnameTxt;
        private System.Windows.Forms.RichTextBox sellerAdressRichBox;
        private System.Windows.Forms.DateTimePicker sellerBirthdayTpick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sellerUsernameTxt;
    }
}