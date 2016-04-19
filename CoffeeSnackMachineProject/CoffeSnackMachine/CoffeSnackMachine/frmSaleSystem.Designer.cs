namespace CoffeSnackMachine
{
    partial class frmSaleSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleSystem));
            this.tcSaleSystemProducts = new System.Windows.Forms.TabControl();
            this.btnSaleSystemBack = new System.Windows.Forms.Button();
            this.lstSaleSystemBuyProductList = new System.Windows.Forms.ListBox();
            this.lblSaleSystemProductListTitle = new System.Windows.Forms.Label();
            this.lblSaleSystemSumCost = new System.Windows.Forms.Label();
            this.txtSaleSystemSumCost = new System.Windows.Forms.TextBox();
            this.btnSaleSystemDeleteFromList = new System.Windows.Forms.Button();
            this.btnSaleSystemBuyProduct = new System.Windows.Forms.Button();
            this.lblSaleSystemDescriptionTitle = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tcSaleSystemProducts
            // 
            this.tcSaleSystemProducts.Location = new System.Drawing.Point(12, 12);
            this.tcSaleSystemProducts.Name = "tcSaleSystemProducts";
            this.tcSaleSystemProducts.SelectedIndex = 0;
            this.tcSaleSystemProducts.Size = new System.Drawing.Size(392, 263);
            this.tcSaleSystemProducts.TabIndex = 0;
            // 
            // btnSaleSystemBack
            // 
            this.btnSaleSystemBack.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnSaleSystemBack.Location = new System.Drawing.Point(584, 295);
            this.btnSaleSystemBack.Name = "btnSaleSystemBack";
            this.btnSaleSystemBack.Size = new System.Drawing.Size(75, 33);
            this.btnSaleSystemBack.TabIndex = 1;
            this.btnSaleSystemBack.Text = "Atpakaļ";
            this.btnSaleSystemBack.UseVisualStyleBackColor = true;
            this.btnSaleSystemBack.Click += new System.EventHandler(this.btnSaleSystemBack_Click);
            // 
            // lstSaleSystemBuyProductList
            // 
            this.lstSaleSystemBuyProductList.FormattingEnabled = true;
            this.lstSaleSystemBuyProductList.Location = new System.Drawing.Point(430, 39);
            this.lstSaleSystemBuyProductList.Name = "lstSaleSystemBuyProductList";
            this.lstSaleSystemBuyProductList.Size = new System.Drawing.Size(229, 199);
            this.lstSaleSystemBuyProductList.TabIndex = 2;
            // 
            // lblSaleSystemProductListTitle
            // 
            this.lblSaleSystemProductListTitle.AutoSize = true;
            this.lblSaleSystemProductListTitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSaleSystemProductListTitle.Location = new System.Drawing.Point(430, 12);
            this.lblSaleSystemProductListTitle.Name = "lblSaleSystemProductListTitle";
            this.lblSaleSystemProductListTitle.Size = new System.Drawing.Size(121, 22);
            this.lblSaleSystemProductListTitle.TabIndex = 3;
            this.lblSaleSystemProductListTitle.Text = "Produktu grozs:";
            // 
            // lblSaleSystemSumCost
            // 
            this.lblSaleSystemSumCost.AutoSize = true;
            this.lblSaleSystemSumCost.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSaleSystemSumCost.Location = new System.Drawing.Point(429, 247);
            this.lblSaleSystemSumCost.Name = "lblSaleSystemSumCost";
            this.lblSaleSystemSumCost.Size = new System.Drawing.Size(90, 18);
            this.lblSaleSystemSumCost.TabIndex = 4;
            this.lblSaleSystemSumCost.Text = "Kopējā summa:";
            // 
            // txtSaleSystemSumCost
            // 
            this.txtSaleSystemSumCost.Location = new System.Drawing.Point(525, 244);
            this.txtSaleSystemSumCost.Name = "txtSaleSystemSumCost";
            this.txtSaleSystemSumCost.ReadOnly = true;
            this.txtSaleSystemSumCost.Size = new System.Drawing.Size(60, 20);
            this.txtSaleSystemSumCost.TabIndex = 5;
            // 
            // btnSaleSystemDeleteFromList
            // 
            this.btnSaleSystemDeleteFromList.BackColor = System.Drawing.Color.Red;
            this.btnSaleSystemDeleteFromList.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnSaleSystemDeleteFromList.Location = new System.Drawing.Point(433, 283);
            this.btnSaleSystemDeleteFromList.Name = "btnSaleSystemDeleteFromList";
            this.btnSaleSystemDeleteFromList.Size = new System.Drawing.Size(75, 45);
            this.btnSaleSystemDeleteFromList.TabIndex = 6;
            this.btnSaleSystemDeleteFromList.Text = "Dzēsts produktu";
            this.btnSaleSystemDeleteFromList.UseVisualStyleBackColor = false;
            this.btnSaleSystemDeleteFromList.Click += new System.EventHandler(this.btnSaleSystemDeleteFromList_Click);
            // 
            // btnSaleSystemBuyProduct
            // 
            this.btnSaleSystemBuyProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaleSystemBuyProduct.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnSaleSystemBuyProduct.Location = new System.Drawing.Point(12, 284);
            this.btnSaleSystemBuyProduct.Name = "btnSaleSystemBuyProduct";
            this.btnSaleSystemBuyProduct.Size = new System.Drawing.Size(84, 44);
            this.btnSaleSystemBuyProduct.TabIndex = 7;
            this.btnSaleSystemBuyProduct.Text = "Pirkt produktus";
            this.btnSaleSystemBuyProduct.UseVisualStyleBackColor = false;
            this.btnSaleSystemBuyProduct.Click += new System.EventHandler(this.btnSaleSystemBuyProduct_Click);
            // 
            // lblSaleSystemDescriptionTitle
            // 
            this.lblSaleSystemDescriptionTitle.AutoSize = true;
            this.lblSaleSystemDescriptionTitle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSaleSystemDescriptionTitle.Location = new System.Drawing.Point(189, 295);
            this.lblSaleSystemDescriptionTitle.Name = "lblSaleSystemDescriptionTitle";
            this.lblSaleSystemDescriptionTitle.Size = new System.Drawing.Size(58, 36);
            this.lblSaleSystemDescriptionTitle.TabIndex = 9;
            this.lblSaleSystemDescriptionTitle.Text = "Produkta\r\napraksts\r\n";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProductDescription.Location = new System.Drawing.Point(253, 278);
            this.lblProductDescription.MaximumSize = new System.Drawing.Size(151, 56);
            this.lblProductDescription.MinimumSize = new System.Drawing.Size(151, 56);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Padding = new System.Windows.Forms.Padding(1);
            this.lblProductDescription.Size = new System.Drawing.Size(151, 56);
            this.lblProductDescription.TabIndex = 10;
            this.lblProductDescription.Text = "label1";
            // 
            // frmSaleSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 340);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblSaleSystemDescriptionTitle);
            this.Controls.Add(this.btnSaleSystemBuyProduct);
            this.Controls.Add(this.btnSaleSystemDeleteFromList);
            this.Controls.Add(this.txtSaleSystemSumCost);
            this.Controls.Add(this.lblSaleSystemSumCost);
            this.Controls.Add(this.lblSaleSystemProductListTitle);
            this.Controls.Add(this.lstSaleSystemBuyProductList);
            this.Controls.Add(this.btnSaleSystemBack);
            this.Controls.Add(this.tcSaleSystemProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(687, 378);
            this.MinimumSize = new System.Drawing.Size(687, 378);
            this.Name = "frmSaleSystem";
            this.Text = "Pārtikas automāts - LuX v0.21.";
            this.Load += new System.EventHandler(this.frmSaleSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcSaleSystemProducts;
        private System.Windows.Forms.Button btnSaleSystemBack;
        private System.Windows.Forms.ListBox lstSaleSystemBuyProductList;
        private System.Windows.Forms.Label lblSaleSystemProductListTitle;
        private System.Windows.Forms.Label lblSaleSystemSumCost;
        private System.Windows.Forms.TextBox txtSaleSystemSumCost;
        private System.Windows.Forms.Button btnSaleSystemDeleteFromList;
        private System.Windows.Forms.Button btnSaleSystemBuyProduct;
        private System.Windows.Forms.Label lblSaleSystemDescriptionTitle;
        private System.Windows.Forms.Label lblProductDescription;
    }
}