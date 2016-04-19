using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeSnackMachine
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        //Nodrošina to, lai ar konkrēto pogu tiktu atvērta konkrētā forma.
        private void btnMainMenuAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProducts openAddProduct = new frmAddProducts();
            this.Hide();
            openAddProduct.Closed += (s, args) => this.Close();
            openAddProduct.Show();
        }

        private void btnMainMenuProductList_Click(object sender, EventArgs e)
        {
            frmProductList openProductList = new frmProductList();
            this.Hide();
            openProductList.Closed += (s, args) => this.Close();
            openProductList.Show();
        }

        private void btnMainMenuSaleSystem_Click(object sender, EventArgs e)
        {
            frmSaleSystem openSaleSystem = new frmSaleSystem();
            this.Hide();
            openSaleSystem.Closed += (s, args) => this.Close();
            openSaleSystem.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
        //Menu list attēlotā informācija
        private void mnuMainMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void mnuMainMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autors:\nRaivis Rugelis\n'Programmēšanas II kursa darbs'");
        }
    }
}
