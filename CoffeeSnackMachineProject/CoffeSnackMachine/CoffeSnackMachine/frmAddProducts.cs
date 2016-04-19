using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace CoffeSnackMachine
{
    public partial class frmAddProducts : Form
    {
        public frmAddProducts()
        {
            InitializeComponent();
        }

        //private Byte[] byteForFileStream;

        private void lblAddProductManufacture_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            //Izmantojot DB tiek atjaunināts kategoriju saraksts.
            OleDbConnection productTypeConnection = new OleDbConnection();
            productTypeConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
            productTypeConnection.Open();

            OleDbCommand getProductTypes = new OleDbCommand();
            getProductTypes.Connection = productTypeConnection;
            getProductTypes.CommandText = "SELECT ProductType FROM TblProductTypes";

            try
            {
                OleDbDataReader productTypeReader = getProductTypes.ExecuteReader();
                Console.WriteLine("Checking ProductTypes");

                while (productTypeReader.Read())
                {
                    cmbCategories.Items.Add(productTypeReader[0].ToString());
                }



                productTypeConnection.Close();

            }
            catch (Exception firstException)
            {
                MessageBox.Show("ERROR Getting Product Type");
                productTypeConnection.Close();
            }
        }

        private void btnAddProductionUpload_Click(object sender, EventArgs e)
        {
            /*
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                FileStream fsFileSteam = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                byteForFileStream = new Byte[fsFileSteam.Length];

                fsFileSteam.Read(byteForFileStream, 0, byteForFileStream.Length);

                fsFileSteam.Close();

                MemoryStream msFileStream = new MemoryStream(byteForFileStream);

                pbImage.Image = Image.FromStream(msFileStream);
            }
            */
        }

        private void btnAddProductCreate_Click(object sender, EventArgs e)
        {

            //Preces nosaukuma pārbaude
            if(txtAddProductName.Text == "")
            {
                MessageBox.Show("Ir jaizpilda lauks: 'Preces nosaukums'");
                return;
            }

            //Izplatītājs pārbaude
            if(txtAddProductSpreader.Text == "")
            {
                MessageBox.Show("Ir jaizpilda lauks: 'Izplatītājs'");
                return;
            }

            //Cenas pārbaude
            try
            {
                decimal priceForProduct = decimal.Parse(txtAddProductPrice.Text);
            }
            catch
            {
                MessageBox.Show("Cena ir ievadita nekorekti");
                return;
            }

            int firstCharacter = txtAddProductPrice.Text.IndexOf(",");
            if (firstCharacter == -1)
            {
                MessageBox.Show("Cenas ievadei jaizmanto komants!");
                txtAddProductPrice.Clear();
                return;
            }

            //Kategorija pārbaude
            if (cmbCategories.SelectedItem == null)
            {
                MessageBox.Show("Ir jaizpilda lauks: 'Kategorija'");
                return;
            }

            //Ievieto produktu DB un notīra ievades laukus.
            OleDbConnection addProductConnection = new OleDbConnection();
            addProductConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
            addProductConnection.Open();

            OleDbCommand addProducts = new OleDbCommand();
            addProducts.Connection = addProductConnection;
            OleDbCommand cmd = new OleDbCommand("INSERT INTO TblAddProduct (AddProductSpreader, AddProductName, AddProductPrice, AddProductCategory, AddProductDescription) VALUES(@spreader, @name, @price, @category, @description)", addProductConnection);
            if (addProductConnection.State == ConnectionState.Open)//Parbaude vai ir savienojums
            {
                cmd.Parameters.Add("@spreader", OleDbType.Char, 100).Value = txtAddProductSpreader.Text;
                cmd.Parameters.Add("@name", OleDbType.Char, 100).Value = txtAddProductName.Text;
                cmd.Parameters.Add("@price", OleDbType.Currency, 100).Value = decimal.Parse(txtAddProductPrice.Text);
                cmd.Parameters.Add("@category", OleDbType.Char, 100).Value = cmbCategories.SelectedItem.ToString();
                cmd.Parameters.Add("@description", OleDbType.Char, 100).Value = txtAddProductDescription.Text;
                //cmd.Parameters.Add("@picture", OleDbType.IUnknown, 100).Value = byteForFileStream;

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("DB UPDATE");
                    MessageBox.Show("Produkts pievienots");
                    txtAddProductSpreader.Clear();
                    txtAddProductName.Clear();
                    txtAddProductPrice.Clear();
                    txtAddProductDescription.Clear();
                    addProductConnection.Close();
                }
                catch (Exception er)
                {
                    Console.WriteLine("NOP");
                    MessageBox.Show(er.GetBaseException().ToString());
                    addProductConnection.Close();
                }

            }

      
        }

        private void btnAddProductBack_Click(object sender, EventArgs e)
        {
            //Lai atgrieztos uz Menu logu...
            frmMainMenu backToMainMenu = new frmMainMenu();
            this.Hide();
            backToMainMenu.Closed += (s, args) => this.Close();
            backToMainMenu.Show();
        }
    }
}
