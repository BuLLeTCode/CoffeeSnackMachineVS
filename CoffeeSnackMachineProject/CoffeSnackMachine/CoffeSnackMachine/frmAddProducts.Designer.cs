namespace CoffeSnackMachine
{
    partial class frmAddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProducts));
            this.lblAddProductManufacture = new System.Windows.Forms.Label();
            this.lblAddProductPrice = new System.Windows.Forms.Label();
            this.txtAddProductSpreader = new System.Windows.Forms.TextBox();
            this.txtAddProductPrice = new System.Windows.Forms.TextBox();
            this.lblAddProductCategory = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnAddProductCreate = new System.Windows.Forms.Button();
            this.txtAddProductDescription = new System.Windows.Forms.TextBox();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddProductDescription = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddProductBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddProductManufacture
            // 
            this.lblAddProductManufacture.AutoSize = true;
            this.lblAddProductManufacture.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAddProductManufacture.Location = new System.Drawing.Point(12, 83);
            this.lblAddProductManufacture.Name = "lblAddProductManufacture";
            this.lblAddProductManufacture.Size = new System.Drawing.Size(72, 18);
            this.lblAddProductManufacture.TabIndex = 0;
            this.lblAddProductManufacture.Text = "Izplatītājs:";
            this.lblAddProductManufacture.Click += new System.EventHandler(this.lblAddProductManufacture_Click);
            // 
            // lblAddProductPrice
            // 
            this.lblAddProductPrice.AutoSize = true;
            this.lblAddProductPrice.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAddProductPrice.Location = new System.Drawing.Point(12, 120);
            this.lblAddProductPrice.Name = "lblAddProductPrice";
            this.lblAddProductPrice.Size = new System.Drawing.Size(42, 18);
            this.lblAddProductPrice.TabIndex = 1;
            this.lblAddProductPrice.Text = "Cena:";
            // 
            // txtAddProductSpreader
            // 
            this.txtAddProductSpreader.Location = new System.Drawing.Point(93, 83);
            this.txtAddProductSpreader.Name = "txtAddProductSpreader";
            this.txtAddProductSpreader.Size = new System.Drawing.Size(112, 20);
            this.txtAddProductSpreader.TabIndex = 2;
            // 
            // txtAddProductPrice
            // 
            this.txtAddProductPrice.Location = new System.Drawing.Point(93, 120);
            this.txtAddProductPrice.Name = "txtAddProductPrice";
            this.txtAddProductPrice.Size = new System.Drawing.Size(112, 20);
            this.txtAddProductPrice.TabIndex = 3;
            // 
            // lblAddProductCategory
            // 
            this.lblAddProductCategory.AutoSize = true;
            this.lblAddProductCategory.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAddProductCategory.Location = new System.Drawing.Point(12, 156);
            this.lblAddProductCategory.Name = "lblAddProductCategory";
            this.lblAddProductCategory.Size = new System.Drawing.Size(74, 18);
            this.lblAddProductCategory.TabIndex = 4;
            this.lblAddProductCategory.Text = "Kategorija:";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(92, 156);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(113, 21);
            this.cmbCategories.TabIndex = 5;
            // 
            // btnAddProductCreate
            // 
            this.btnAddProductCreate.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnAddProductCreate.Location = new System.Drawing.Point(330, 218);
            this.btnAddProductCreate.Name = "btnAddProductCreate";
            this.btnAddProductCreate.Size = new System.Drawing.Size(75, 31);
            this.btnAddProductCreate.TabIndex = 9;
            this.btnAddProductCreate.Text = "Izveidot";
            this.btnAddProductCreate.UseVisualStyleBackColor = true;
            this.btnAddProductCreate.Click += new System.EventHandler(this.btnAddProductCreate_Click);
            // 
            // txtAddProductDescription
            // 
            this.txtAddProductDescription.Location = new System.Drawing.Point(249, 33);
            this.txtAddProductDescription.Multiline = true;
            this.txtAddProductDescription.Name = "txtAddProductDescription";
            this.txtAddProductDescription.Size = new System.Drawing.Size(153, 144);
            this.txtAddProductDescription.TabIndex = 13;
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.Location = new System.Drawing.Point(15, 34);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(153, 20);
            this.txtAddProductName.TabIndex = 12;
            // 
            // lblAddProductDescription
            // 
            this.lblAddProductDescription.AutoSize = true;
            this.lblAddProductDescription.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAddProductDescription.Location = new System.Drawing.Point(246, 7);
            this.lblAddProductDescription.Name = "lblAddProductDescription";
            this.lblAddProductDescription.Size = new System.Drawing.Size(64, 18);
            this.lblAddProductDescription.TabIndex = 11;
            this.lblAddProductDescription.Text = "Apraksts:";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAddProductName.Location = new System.Drawing.Point(12, 9);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(120, 18);
            this.lblAddProductName.TabIndex = 10;
            this.lblAddProductName.Text = "Preces nosaukums:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddProductBack
            // 
            this.btnAddProductBack.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnAddProductBack.Location = new System.Drawing.Point(249, 218);
            this.btnAddProductBack.Name = "btnAddProductBack";
            this.btnAddProductBack.Size = new System.Drawing.Size(75, 31);
            this.btnAddProductBack.TabIndex = 14;
            this.btnAddProductBack.Text = "Atpakaļ";
            this.btnAddProductBack.UseVisualStyleBackColor = true;
            this.btnAddProductBack.Click += new System.EventHandler(this.btnAddProductBack_Click);
            // 
            // frmAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.btnAddProductBack);
            this.Controls.Add(this.txtAddProductDescription);
            this.Controls.Add(this.txtAddProductName);
            this.Controls.Add(this.lblAddProductDescription);
            this.Controls.Add(this.lblAddProductName);
            this.Controls.Add(this.btnAddProductCreate);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.lblAddProductCategory);
            this.Controls.Add(this.txtAddProductPrice);
            this.Controls.Add(this.txtAddProductSpreader);
            this.Controls.Add(this.lblAddProductPrice);
            this.Controls.Add(this.lblAddProductManufacture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(430, 300);
            this.MinimumSize = new System.Drawing.Size(430, 300);
            this.Name = "frmAddProducts";
            this.Text = "Produkta pievienošana - LuX v0.21.";
            this.Load += new System.EventHandler(this.frmAddProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddProductManufacture;
        private System.Windows.Forms.Label lblAddProductPrice;
        private System.Windows.Forms.TextBox txtAddProductSpreader;
        private System.Windows.Forms.TextBox txtAddProductPrice;
        private System.Windows.Forms.Label lblAddProductCategory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnAddProductCreate;
        private System.Windows.Forms.TextBox txtAddProductDescription;
        private System.Windows.Forms.TextBox txtAddProductName;
        private System.Windows.Forms.Label lblAddProductDescription;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddProductBack;
    }
}