namespace CoffeSnackMachine
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnMainMenuAddProduct = new System.Windows.Forms.Button();
            this.btnMainMenuProductList = new System.Windows.Forms.Button();
            this.btnMainMenuSaleSystem = new System.Windows.Forms.Button();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMenuAddProduct
            // 
            this.btnMainMenuAddProduct.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnMainMenuAddProduct.Location = new System.Drawing.Point(12, 47);
            this.btnMainMenuAddProduct.Name = "btnMainMenuAddProduct";
            this.btnMainMenuAddProduct.Size = new System.Drawing.Size(147, 28);
            this.btnMainMenuAddProduct.TabIndex = 0;
            this.btnMainMenuAddProduct.Text = "Pievienot produktu";
            this.btnMainMenuAddProduct.UseVisualStyleBackColor = true;
            this.btnMainMenuAddProduct.Click += new System.EventHandler(this.btnMainMenuAddProduct_Click);
            // 
            // btnMainMenuProductList
            // 
            this.btnMainMenuProductList.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnMainMenuProductList.Location = new System.Drawing.Point(12, 91);
            this.btnMainMenuProductList.Name = "btnMainMenuProductList";
            this.btnMainMenuProductList.Size = new System.Drawing.Size(147, 27);
            this.btnMainMenuProductList.TabIndex = 1;
            this.btnMainMenuProductList.Text = "Produktu saraksts";
            this.btnMainMenuProductList.UseVisualStyleBackColor = true;
            this.btnMainMenuProductList.Click += new System.EventHandler(this.btnMainMenuProductList_Click);
            // 
            // btnMainMenuSaleSystem
            // 
            this.btnMainMenuSaleSystem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnMainMenuSaleSystem.Location = new System.Drawing.Point(12, 135);
            this.btnMainMenuSaleSystem.Name = "btnMainMenuSaleSystem";
            this.btnMainMenuSaleSystem.Size = new System.Drawing.Size(147, 27);
            this.btnMainMenuSaleSystem.TabIndex = 2;
            this.btnMainMenuSaleSystem.Text = "Pārdošanas sistēma";
            this.btnMainMenuSaleSystem.UseVisualStyleBackColor = true;
            this.btnMainMenuSaleSystem.Click += new System.EventHandler(this.btnMainMenuSaleSystem_Click);
            // 
            // pbMainMenu
            // 
            this.pbMainMenu.BackgroundImage = global::CoffeSnackMachine.Properties.Resources.small_5160_8787126;
            this.pbMainMenu.InitialImage = global::CoffeSnackMachine.Properties.Resources.small_5160_8787126;
            this.pbMainMenu.Location = new System.Drawing.Point(226, 49);
            this.pbMainMenu.Name = "pbMainMenu";
            this.pbMainMenu.Size = new System.Drawing.Size(84, 105);
            this.pbMainMenu.TabIndex = 3;
            this.pbMainMenu.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuFile,
            this.mnuMainMenuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "mnuMainMenu";
            // 
            // mnuMainMenuFile
            // 
            this.mnuMainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuExit});
            this.mnuMainMenuFile.Name = "mnuMainMenuFile";
            this.mnuMainMenuFile.Size = new System.Drawing.Size(42, 20);
            this.mnuMainMenuFile.Text = "Fails";
            // 
            // mnuMainMenuExit
            // 
            this.mnuMainMenuExit.Name = "mnuMainMenuExit";
            this.mnuMainMenuExit.Size = new System.Drawing.Size(95, 22);
            this.mnuMainMenuExit.Text = "Iziet";
            this.mnuMainMenuExit.Click += new System.EventHandler(this.mnuMainMenuExit_Click);
            // 
            // mnuMainMenuHelp
            // 
            this.mnuMainMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuAbout});
            this.mnuMainMenuHelp.Name = "mnuMainMenuHelp";
            this.mnuMainMenuHelp.Size = new System.Drawing.Size(66, 20);
            this.mnuMainMenuHelp.Text = "Palīdzība";
            // 
            // mnuMainMenuAbout
            // 
            this.mnuMainMenuAbout.Name = "mnuMainMenuAbout";
            this.mnuMainMenuAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuMainMenuAbout.Text = "Par applikāciju";
            this.mnuMainMenuAbout.Click += new System.EventHandler(this.mnuMainMenuAbout_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 233);
            this.Controls.Add(this.pbMainMenu);
            this.Controls.Add(this.btnMainMenuSaleSystem);
            this.Controls.Add(this.btnMainMenuProductList);
            this.Controls.Add(this.btnMainMenuAddProduct);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(360, 271);
            this.MinimumSize = new System.Drawing.Size(360, 271);
            this.Name = "frmMainMenu";
            this.Text = "Pārtikas automāts - LuX v0.21.";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenuAddProduct;
        private System.Windows.Forms.Button btnMainMenuProductList;
        private System.Windows.Forms.Button btnMainMenuSaleSystem;
        private System.Windows.Forms.PictureBox pbMainMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuAbout;
    }
}