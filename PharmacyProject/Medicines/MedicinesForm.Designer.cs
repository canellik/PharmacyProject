namespace PharmacyProject
{
    partial class MedicinesForm
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
            this.medicineNameTxt = new System.Windows.Forms.TextBox();
            this.medicineQuantityTxt = new System.Windows.Forms.TextBox();
            this.medicineTypeCbox = new System.Windows.Forms.ComboBox();
            this.medicinePriceTxt = new System.Windows.Forms.TextBox();
            this.medicineBarcodeTxt = new System.Windows.Forms.TextBox();
            this.Barcode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.medicineDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineEditBtn = new System.Windows.Forms.PictureBox();
            this.medicinesAddBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineEditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesAddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // medicineNameTxt
            // 
            this.medicineNameTxt.Location = new System.Drawing.Point(268, 161);
            this.medicineNameTxt.Name = "medicineNameTxt";
            this.medicineNameTxt.Size = new System.Drawing.Size(100, 20);
            this.medicineNameTxt.TabIndex = 0;
            // 
            // medicineQuantityTxt
            // 
            this.medicineQuantityTxt.Location = new System.Drawing.Point(517, 161);
            this.medicineQuantityTxt.Name = "medicineQuantityTxt";
            this.medicineQuantityTxt.Size = new System.Drawing.Size(100, 20);
            this.medicineQuantityTxt.TabIndex = 1;
            // 
            // medicineTypeCbox
            // 
            this.medicineTypeCbox.FormattingEnabled = true;
            this.medicineTypeCbox.Items.AddRange(new object[] {
            "Capsule",
            "Tablet",
            "Flakon",
            "Ampule",
            "Cream"});
            this.medicineTypeCbox.Location = new System.Drawing.Point(391, 161);
            this.medicineTypeCbox.Name = "medicineTypeCbox";
            this.medicineTypeCbox.Size = new System.Drawing.Size(104, 21);
            this.medicineTypeCbox.TabIndex = 2;
            // 
            // medicinePriceTxt
            // 
            this.medicinePriceTxt.Location = new System.Drawing.Point(641, 162);
            this.medicinePriceTxt.Name = "medicinePriceTxt";
            this.medicinePriceTxt.Size = new System.Drawing.Size(100, 20);
            this.medicinePriceTxt.TabIndex = 3;
            // 
            // medicineBarcodeTxt
            // 
            this.medicineBarcodeTxt.Location = new System.Drawing.Point(155, 161);
            this.medicineBarcodeTxt.Name = "medicineBarcodeTxt";
            this.medicineBarcodeTxt.Size = new System.Drawing.Size(100, 20);
            this.medicineBarcodeTxt.TabIndex = 4;
            this.medicineBarcodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.medicineBarcodeTxt_KeyPress);
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(155, 142);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(47, 13);
            this.Barcode.TabIndex = 5;
            this.Barcode.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medicine Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medicine Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // medicineDataGrid
            // 
            this.medicineDataGrid.AllowUserToDeleteRows = false;
            this.medicineDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineDataGrid.Location = new System.Drawing.Point(155, 283);
            this.medicineDataGrid.Name = "medicineDataGrid";
            this.medicineDataGrid.Size = new System.Drawing.Size(583, 248);
            this.medicineDataGrid.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 110);
            this.label1.TabIndex = 12;
            this.label1.Text = "+ Pharmacy";
            // 
            // medicineEditBtn
            // 
            this.medicineEditBtn.Image = global::PharmacyProject.Properties.Resources.icons8_edit_100__1_;
            this.medicineEditBtn.Location = new System.Drawing.Point(466, 209);
            this.medicineEditBtn.Name = "medicineEditBtn";
            this.medicineEditBtn.Size = new System.Drawing.Size(100, 50);
            this.medicineEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medicineEditBtn.TabIndex = 14;
            this.medicineEditBtn.TabStop = false;
            this.medicineEditBtn.Click += new System.EventHandler(this.medicineEditBtn_Click);
            // 
            // medicinesAddBtn
            // 
            this.medicinesAddBtn.Image = global::PharmacyProject.Properties.Resources.icons8_add_100;
            this.medicinesAddBtn.Location = new System.Drawing.Point(308, 209);
            this.medicinesAddBtn.Name = "medicinesAddBtn";
            this.medicinesAddBtn.Size = new System.Drawing.Size(100, 50);
            this.medicinesAddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medicinesAddBtn.TabIndex = 13;
            this.medicinesAddBtn.TabStop = false;
            this.medicinesAddBtn.Click += new System.EventHandler(this.medicinesAddBtn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PharmacyProject.Properties.Resources.icons8_doctors_bag_100;
            this.pictureBox6.Location = new System.Drawing.Point(238, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(151, 94);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Add Medicine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Save Changes";
            // 
            // MedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 537);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.medicineEditBtn);
            this.Controls.Add(this.medicinesAddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.medicineDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.medicineBarcodeTxt);
            this.Controls.Add(this.medicinePriceTxt);
            this.Controls.Add(this.medicineTypeCbox);
            this.Controls.Add(this.medicineQuantityTxt);
            this.Controls.Add(this.medicineNameTxt);
            this.Name = "MedicinesForm";
            this.Text = "Medicines";
            this.Load += new System.EventHandler(this.MedicinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicineDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineEditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesAddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox medicineNameTxt;
        private System.Windows.Forms.TextBox medicineQuantityTxt;
        private System.Windows.Forms.ComboBox medicineTypeCbox;
        private System.Windows.Forms.TextBox medicinePriceTxt;
        private System.Windows.Forms.TextBox medicineBarcodeTxt;
        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView medicineDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox medicinesAddBtn;
        private System.Windows.Forms.PictureBox medicineEditBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}