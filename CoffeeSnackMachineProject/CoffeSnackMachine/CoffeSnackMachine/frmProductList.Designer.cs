namespace CoffeSnackMachine
{
    partial class frmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductList));
            this.dgvProductLis = new System.Windows.Forms.DataGridView();
            this.btnProductListBack = new System.Windows.Forms.Button();
            this.cmbProductListFiltering = new System.Windows.Forms.ComboBox();
            this.lblProductListSorting = new System.Windows.Forms.Label();
            this.btnProductListDelete = new System.Windows.Forms.Button();
            this.btnProductListCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductLis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductLis
            // 
            this.dgvProductLis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductLis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductLis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductLis.Location = new System.Drawing.Point(12, 28);
            this.dgvProductLis.Name = "dgvProductLis";
            this.dgvProductLis.Size = new System.Drawing.Size(572, 262);
            this.dgvProductLis.TabIndex = 0;
            // 
            // btnProductListBack
            // 
            this.btnProductListBack.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnProductListBack.Location = new System.Drawing.Point(509, 296);
            this.btnProductListBack.Name = "btnProductListBack";
            this.btnProductListBack.Size = new System.Drawing.Size(75, 33);
            this.btnProductListBack.TabIndex = 2;
            this.btnProductListBack.Text = "Atpakaļ";
            this.btnProductListBack.UseVisualStyleBackColor = true;
            this.btnProductListBack.Click += new System.EventHandler(this.btnProductListBack_Click);
            // 
            // cmbProductListFiltering
            // 
            this.cmbProductListFiltering.FormattingEnabled = true;
            this.cmbProductListFiltering.Location = new System.Drawing.Point(62, 307);
            this.cmbProductListFiltering.Name = "cmbProductListFiltering";
            this.cmbProductListFiltering.Size = new System.Drawing.Size(121, 21);
            this.cmbProductListFiltering.TabIndex = 3;
            this.cmbProductListFiltering.SelectionChangeCommitted += new System.EventHandler(this.FilteringEvent);
            // 
            // lblProductListSorting
            // 
            this.lblProductListSorting.AutoSize = true;
            this.lblProductListSorting.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblProductListSorting.Location = new System.Drawing.Point(12, 311);
            this.lblProductListSorting.Name = "lblProductListSorting";
            this.lblProductListSorting.Size = new System.Drawing.Size(44, 18);
            this.lblProductListSorting.TabIndex = 4;
            this.lblProductListSorting.Text = "Sķirot:";
            // 
            // btnProductListDelete
            // 
            this.btnProductListDelete.BackColor = System.Drawing.Color.Red;
            this.btnProductListDelete.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnProductListDelete.Location = new System.Drawing.Point(383, 295);
            this.btnProductListDelete.Name = "btnProductListDelete";
            this.btnProductListDelete.Size = new System.Drawing.Size(75, 34);
            this.btnProductListDelete.TabIndex = 5;
            this.btnProductListDelete.Text = "Dzēst";
            this.btnProductListDelete.UseVisualStyleBackColor = false;
            this.btnProductListDelete.Click += new System.EventHandler(this.btnProductListDelete_Click);
            // 
            // btnProductListCancel
            // 
            this.btnProductListCancel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnProductListCancel.Location = new System.Drawing.Point(222, 295);
            this.btnProductListCancel.Name = "btnProductListCancel";
            this.btnProductListCancel.Size = new System.Drawing.Size(75, 44);
            this.btnProductListCancel.TabIndex = 6;
            this.btnProductListCancel.Text = "Atcelt meklēšanu";
            this.btnProductListCancel.UseVisualStyleBackColor = true;
            this.btnProductListCancel.Click += new System.EventHandler(this.btnProductListCancel_Click);
            // 
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 346);
            this.Controls.Add(this.btnProductListCancel);
            this.Controls.Add(this.btnProductListDelete);
            this.Controls.Add(this.lblProductListSorting);
            this.Controls.Add(this.cmbProductListFiltering);
            this.Controls.Add(this.btnProductListBack);
            this.Controls.Add(this.dgvProductLis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(612, 384);
            this.MinimumSize = new System.Drawing.Size(612, 384);
            this.Name = "frmProductList";
            this.Text = "Produktu saraksts - LuX v0.21.";
            this.Load += new System.EventHandler(this.frmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductLis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductLis;
        private System.Windows.Forms.Button btnProductListBack;
        private System.Windows.Forms.ComboBox cmbProductListFiltering;
        private System.Windows.Forms.Label lblProductListSorting;
        private System.Windows.Forms.Button btnProductListDelete;
        private System.Windows.Forms.Button btnProductListCancel;
    }
}