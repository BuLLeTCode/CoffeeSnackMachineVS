using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CoffeSnackMachine
{
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        //DataSet tiek izmantots, lai iekšs DataGrid attēlotu informāciju no DB par produktiem.
        DataSet ds = new DataSet();
        DataSet gs = new DataSet();

        private void frmProductList_Load(object sender, EventArgs e)
        {
            //Nodrošina, lai ielādējot formu tiktu attēlotu informācija.
            string connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
            string sql = "SELECT * FROM TblAddProduct";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            connection.Open();
            //Ar DataApdater palīdzību, Dataset tiek papildināts ar informāciju, kā arī tiek noradīts informācijas avots priekš DataGrid
            dataadapter.Fill(ds, "TblAddProduct");
            connection.Close();
            dgvProductLis.DataSource = ds;
            dgvProductLis.DataMember = "TblAddProduct";

            //Viena collona tiek slēpta, jo nav nepieciešams to attēlot.
            dgvProductLis.Columns["AddProductPicture"].Visible = false;

            //Tiek iegūta informācija no DB priekš šķirošanas - Produktu tipi.
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
                    cmbProductListFiltering.Items.Add(productTypeReader[0].ToString());
                }



                productTypeConnection.Close();

            }
            catch (Exception firstException)
            {
                MessageBox.Show("ERROR Getting Product Type");
                productTypeConnection.Close();
            }

            
        }

        private void btnProductListBack_Click(object sender, EventArgs e)
        {
            frmMainMenu backToMainMenu = new frmMainMenu();
            this.Hide();
            backToMainMenu.Closed += (s, args) => this.Close();
            backToMainMenu.Show();
        }
        //Funkcija, kas nodrošina šķirošanu.
        private void FilteringEvent(object sender, EventArgs e)
        {
            //Pirms sķirošanas tiek nodzēsta līdzšinējā informācija.
            gs.Clear();

            string connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
            string sql = "SELECT * FROM TblAddProduct WHERE AddProductCategory = '" + cmbProductListFiltering.SelectedItem.ToString() + "'";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(gs, "TblAddProduct");
            connection.Close();
            dgvProductLis.DataSource = gs;
            dgvProductLis.DataMember = "TblAddProduct";

            dgvProductLis.Columns["AddProductPicture"].Visible = false;
            
            /*
            string filterstring = "AddProductDescription = 'Sula'";
            string sortstring = "type Desc";
            ds.Merge(ds.Tables[0].Select(filterstring, sortstring));//Problēma Tables[0]
            */
            /*
            DataView dv;
            dv = new DataView(ds.Tables["TblAddProduct"], "AddProductDescription = 'Sula' ", "type Desc", DataViewRowState.CurrentRows);
            dgvProductLis.DataSource = dv;
            dgvProductLis.DataMember = "TblAddProduct";
            */
        }
        //Funkcija, kas nodrošina dzēšananu.
        private void btnProductListDelete_Click(object sender, EventArgs e)
        {
            //Pārbaude vai ir izvēlēta rinda, lai izdzēstu attiecīgo ierakstu.
            if (dgvProductLis.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Izvēlies rindu, kuru vēlies dzēst!");
                return;
            }

            //Tiek iziet cauri kollonām, lai iegūtu informāciju, kas tiks norādīta pie dzēšanas.
            foreach (DataGridViewRow row in dgvProductLis.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                string value3 = row.Cells[2].Value.ToString();
                string value4 = row.Cells[3].Value.ToString();
                string value5 = row.Cells[4].Value.ToString();
                string value6 = row.Cells[5].Value.ToString();
                //string value7 = row.Cells[6].Value.ToString();
                Console.WriteLine("Izvēlētais ID:" + value1);
                Console.WriteLine("Izvēlētais AddProductSpreader:" + value2);
                Console.WriteLine("Izvēlētais AddProductName:" + value3);
                Console.WriteLine("Izvēlētais AddProductPrice:" + value4);
                Console.WriteLine("Izvēlētais AddProductCategory:" + value5);
                Console.WriteLine("Izvēlētais AddProductDescription:" + value6);
                //Console.WriteLine("Izvēlētais AddProductPicture:" + value7);
                //...
                OleDbConnection deleteProductConnection = new OleDbConnection();
                deleteProductConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
                deleteProductConnection.Open();

                 OleDbCommand deleteCommand = new OleDbCommand();
                 deleteCommand.Connection = deleteProductConnection;
                //PieteikumsRazotajs, PieteikumsMarka, PieteikumsKrasa, PieteikumsPakalpojums
                // deleteCommand.CommandText = "DELETE FROM TblAddProduct WHERE ID='" + int.Parse(value1) + "' AND AddProductName='" + value3 + "'";
                 deleteCommand.CommandText = "DELETE FROM TblAddProduct WHERE AddProductName='" + value3 + "' AND AddProductSpreader='" + value2 + "' AND AddProductDescription='" + value6 + "'";
                //Izdzeš izvēlēto pieteikumu.
                try
                {
                    deleteCommand.ExecuteNonQuery();//Neko neatgriež
                    MessageBox.Show("Dzēšana veiksmīga!");
                    deleteProductConnection.Close();
                    //Update dataGridView
                    ds.Clear();
                    //Atjaunina DataGrid pēc dzēšanas.
                    string connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
                    string sql = "SELECT * FROM TblAddProduct";
                    OleDbConnection connection = new OleDbConnection(connetionString);
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                    connection.Open();
                    dataadapter.Fill(ds, "TblAddProduct");
                    connection.Close();
                    dgvProductLis.DataSource = ds;
                    dgvProductLis.DataMember = "TblAddProduct";

                    dgvProductLis.Columns["AddProductPicture"].Visible = false;

                }
                catch (Exception deleteException)
                {
                    MessageBox.Show("ERROR: Nevar izdzēst rindu." + deleteException.Message.ToString());
                    deleteProductConnection.Close();
                }
            }
        }

        private void btnProductListCancel_Click(object sender, EventArgs e)
        {
            gs.Clear();
            //Tiek atcelta šķirošana, parāda visu informāciju.
            string connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Raivis\Desktop\TEST.mdb";
            string sql = "SELECT * FROM TblAddProduct";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(gs, "TblAddProduct");
            connection.Close();
            dgvProductLis.DataSource = gs;
            dgvProductLis.DataMember = "TblAddProduct";

            dgvProductLis.Columns["AddProductPicture"].Visible = false;
        }
    }
}
