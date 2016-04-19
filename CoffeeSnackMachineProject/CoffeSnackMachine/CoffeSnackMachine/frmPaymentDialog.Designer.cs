namespace CoffeSnackMachine
{
    partial class frmPaymentDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentDialog));
            this.lblPaymentSumToPay = new System.Windows.Forms.Label();
            this.txtPaymentPriceSum = new System.Windows.Forms.TextBox();
            this.lblPaymentYouCash = new System.Windows.Forms.Label();
            this.txtPaymentYourCash = new System.Windows.Forms.TextBox();
            this.btnPaymentPayPutMoney = new System.Windows.Forms.Button();
            this.btnPaymentPayForProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPaymentSumToPay
            // 
            this.lblPaymentSumToPay.AutoSize = true;
            this.lblPaymentSumToPay.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblPaymentSumToPay.Location = new System.Drawing.Point(13, 13);
            this.lblPaymentSumToPay.Name = "lblPaymentSumToPay";
            this.lblPaymentSumToPay.Size = new System.Drawing.Size(99, 18);
            this.lblPaymentSumToPay.TabIndex = 0;
            this.lblPaymentSumToPay.Text = "Summa atmaksai:";
            // 
            // txtPaymentPriceSum
            // 
            this.txtPaymentPriceSum.Location = new System.Drawing.Point(118, 13);
            this.txtPaymentPriceSum.Name = "txtPaymentPriceSum";
            this.txtPaymentPriceSum.ReadOnly = true;
            this.txtPaymentPriceSum.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentPriceSum.TabIndex = 1;
            // 
            // lblPaymentYouCash
            // 
            this.lblPaymentYouCash.AutoSize = true;
            this.lblPaymentYouCash.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblPaymentYouCash.Location = new System.Drawing.Point(13, 49);
            this.lblPaymentYouCash.Name = "lblPaymentYouCash";
            this.lblPaymentYouCash.Size = new System.Drawing.Size(79, 18);
            this.lblPaymentYouCash.TabIndex = 2;
            this.lblPaymentYouCash.Text = "Jūsu kredīts:";
            // 
            // txtPaymentYourCash
            // 
            this.txtPaymentYourCash.Location = new System.Drawing.Point(118, 47);
            this.txtPaymentYourCash.Name = "txtPaymentYourCash";
            this.txtPaymentYourCash.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentYourCash.TabIndex = 3;
            // 
            // btnPaymentPayPutMoney
            // 
            this.btnPaymentPayPutMoney.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnPaymentPayPutMoney.Location = new System.Drawing.Point(16, 100);
            this.btnPaymentPayPutMoney.Name = "btnPaymentPayPutMoney";
            this.btnPaymentPayPutMoney.Size = new System.Drawing.Size(76, 46);
            this.btnPaymentPayPutMoney.TabIndex = 4;
            this.btnPaymentPayPutMoney.Text = "Ievietot naudu";
            this.btnPaymentPayPutMoney.UseVisualStyleBackColor = true;
            this.btnPaymentPayPutMoney.Click += new System.EventHandler(this.btnPaymentPayButton_Click);
            // 
            // btnPaymentPayForProduct
            // 
            this.btnPaymentPayForProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPaymentPayForProduct.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnPaymentPayForProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPaymentPayForProduct.Location = new System.Drawing.Point(134, 100);
            this.btnPaymentPayForProduct.Name = "btnPaymentPayForProduct";
            this.btnPaymentPayForProduct.Size = new System.Drawing.Size(75, 46);
            this.btnPaymentPayForProduct.TabIndex = 5;
            this.btnPaymentPayForProduct.Text = "Apmaksāt";
            this.btnPaymentPayForProduct.UseVisualStyleBackColor = false;
            this.btnPaymentPayForProduct.Click += new System.EventHandler(this.btnPaymentPayForProduct_Click);
            // 
            // frmPaymentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 159);
            this.Controls.Add(this.btnPaymentPayForProduct);
            this.Controls.Add(this.btnPaymentPayPutMoney);
            this.Controls.Add(this.txtPaymentYourCash);
            this.Controls.Add(this.lblPaymentYouCash);
            this.Controls.Add(this.txtPaymentPriceSum);
            this.Controls.Add(this.lblPaymentSumToPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(355, 187);
            this.MinimumSize = new System.Drawing.Size(355, 187);
            this.Name = "frmPaymentDialog";
            this.Text = "Apmaksa - LuX v0.21.";
            this.Load += new System.EventHandler(this.frmPaymentDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaymentSumToPay;
        private System.Windows.Forms.TextBox txtPaymentPriceSum;
        private System.Windows.Forms.Label lblPaymentYouCash;
        private System.Windows.Forms.TextBox txtPaymentYourCash;
        private System.Windows.Forms.Button btnPaymentPayPutMoney;
        private System.Windows.Forms.Button btnPaymentPayForProduct;
    }
}