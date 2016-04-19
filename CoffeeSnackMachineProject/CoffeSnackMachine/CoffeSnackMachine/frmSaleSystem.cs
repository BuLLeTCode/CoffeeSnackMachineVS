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
    public partial class frmSaleSystem : Form
    {
        public frmSaleSystem()
        {
            InitializeComponent();
            addProductTypePanels();
            //ListBox, kas attēlos Produktu grozu, DataSource būs Binding list
            lstSaleSystemBuyProductList.DataSource = chooseProductList;
            lblProductDescription.Text = "";
        }

        //Binding list tiks lietots, lai glabātu lietotāju izvēlētos produktus.
        public BindingList<string> chooseProductList = new BindingList<string>();
        private decimal costSumForCustomer = 0;//By default 0

        //Atkarība no Produkta tipa, tiks izveidots panelis, katram tipam savs.
        private void addProductTypePanels()
        {

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
                    tcSaleSystemProducts.TabPages.Add(productTypeReader[0].ToString());
                }

                //Ja paneļi ir veiksmīgi ievietoti, var pievienot produktus paneļiem.
                addProductsToPanels();
                productTypeConnection.Close();

            }
            catch (Exception firstException)
            {
                MessageBox.Show("ERROR Getting Product Type");
                productTypeConnection.Close();
            }
        }

        //Funkcija, kas pievieno produktus paneļiem.
        private void addProductsToPanels()
        {
            //Iet cauri izietajiem paneļiem.
            foreach (TabPage tb in tcSaleSystemProducts.TabPages)
            {

                OleDbConnection productInfoConnection = new OleDbConnection();
                productInfoConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
                productInfoConnection.Open();

                OleDbCommand getProductTypes = new OleDbCommand();
                getProductTypes.Connection = productInfoConnection;

                Console.WriteLine("Product Name:" + tb.Text);
                getProductTypes.CommandText = "SELECT AddProductName FROM TblAddProduct WHERE AddProductCategory = '" + tb.Text +"'";

                //Atkarībā no produkta paneļa nosaukuma, pievieno produktus.
                try
                {
                    OleDbDataReader productTypeReader = getProductTypes.ExecuteReader();
                    Console.WriteLine("Checking Products");

                    //Layout, kas glabās pogas... :)
                    FlowLayoutPanel flowLayOut = new FlowLayoutPanel();
                    //Tā lai pogas netiktu novietotas ārpus robežām.
                    flowLayOut.Dock = DockStyle.Fill;

                    //Veidojam pogas attiecīgajiem produktiem, kas ir zem konkrētā produkta tipa.
                    while (productTypeReader.Read())
                    {
                        //Tiek izveidots pogas objekts
                        Button b = new Button();
                        b.Size = new Size(100,100);
                        b.Tag = productTypeReader[0].ToString();//Tiek pieskirts tag, kas tiks izmantots, lai iegutu informāciju par produktu, kas ir izmantots.
                        b.Click += new EventHandler(updateChoosenProducts);//Event, ka produkts tiek izvēlēts.
                        b.Text = productTypeReader[0].ToString();//Produkta nosaukums.
                        b.MouseEnter += new EventHandler(b_MouseEnter);//Event, lai parādītu produkta aprakstu.
                        b.Font = new Font("Arial", 10, FontStyle.Bold,
                        GraphicsUnit.Point);
                        //Izveido ceļu uz direktoriju, lai attēlotu produktam konkrēto attēlu.
                        string dir = Path.GetDirectoryName(Application.ExecutablePath);
                        string filename = "";
                        if (tb.Text == "Aukstais dzēriens")
                        {
                            filename = Path.Combine(dir, @"cold_drinks_orange.png");
                        }else if(tb.Text == "Ēdiens"){
                            filename = Path.Combine(dir, @"snacks_edit_orange.png");
                        }
                        else if (tb.Text == "Karstais dzēriens")
                        {
                            filename = Path.Combine(dir, @"warm_drinks_orange.png");
                        }else{
                            filename = Path.Combine(dir, @"cold_drinks_orange.png");
                        }
                        // Piešķir pogai fona bildi, izmanto ThumbnailImage, lai pielāgotu bildi pogas izmēriem.
                        b.Image = Image.FromFile(filename).GetThumbnailImage(100, 100, null, new
                        IntPtr());
                        flowLayOut.Controls.Add(b);//Pievieno pogas Layout
                    }

                    tb.Controls.Add(flowLayOut);//Konkrētajam panelim tiek pievienots Layout ar pogām.

                    productInfoConnection.Close();

                }
                catch (Exception firstException)
                {
                    MessageBox.Show("ERROR Setting Buttons!!!" + firstException.Message.ToString());
                    productInfoConnection.Close();
                }
            }
        }
        //Šis event fiksē, kad pele ir uz konkrētā produkta, lai attēlotu produkta aprakstu.
        void b_MouseEnter(object sender, EventArgs e)
        {
            Button mouseEnter = (Button)sender;

            string productName = mouseEnter.Tag.ToString();
            string productDescription = "";

            OleDbConnection connectionForProductCost = new OleDbConnection();
            connectionForProductCost.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
            connectionForProductCost.Open();

            OleDbCommand getProductTypes = new OleDbCommand();
            getProductTypes.Connection = connectionForProductCost;

            getProductTypes.CommandText = "SELECT AddProductDescription FROM TblAddProduct WHERE AddProductName = '" + productName + "'";

            try
            {
                OleDbDataReader productPriceReader = getProductTypes.ExecuteReader();
                Console.WriteLine("Checking Products");

                while (productPriceReader.Read())
                {
                    productDescription = productPriceReader[0].ToString();
                }

                lblProductDescription.Text = "";
                if(productDescription == "")
                {
                    productDescription = "Apraksts nav pieejams.";
                }
                lblProductDescription.Text = productDescription;
               
                //chooseProductList.Add(productName + "    " + productCost);
                //updateCostSum(productCost);
                connectionForProductCost.Close();
            }
            catch (Exception priceException)
            {
                MessageBox.Show("Can`t find PRICE for this product!");
                connectionForProductCost.Close();
            }

        }

        private void btnSaleSystemBack_Click(object sender, EventArgs e)
        {
            frmMainMenu backToMainMenu = new frmMainMenu();
            this.Hide();
            backToMainMenu.Closed += (s, args) => this.Close();
            backToMainMenu.Show();
        }

        //Atkarībā no nospiestās pogas pievieno to Produktu grozam.
        void updateChoosenProducts(object sender, EventArgs e)
        {
            Button presed = (Button)sender;

            string productName = presed.Tag.ToString();
            string productCost = "";

            OleDbConnection connectionForProductCost = new OleDbConnection();
            connectionForProductCost.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
            connectionForProductCost.Open();

            //Console.WriteLine(tb.Text);
            OleDbCommand getProductTypes = new OleDbCommand();
            getProductTypes.Connection = connectionForProductCost;

            getProductTypes.CommandText = "SELECT AddProductPrice FROM TblAddProduct WHERE AddProductName = '" + productName + "'";

            try
            {
                OleDbDataReader productPriceReader = getProductTypes.ExecuteReader();
                Console.WriteLine("Checking Products");

                while (productPriceReader.Read())
                {
                    productCost = productPriceReader[0].ToString();
                }

                chooseProductList.Add(productName + "    " + productCost);
                updateCostSum(productCost);//Tiek atjaunināta kopējā maksājuma summa.
                connectionForProductCost.Close();
            }
            catch (Exception priceException)
            {
                MessageBox.Show("Can`t find PRICE for this product!");
                connectionForProductCost.Close();
            }

            //chooseProductList.Add(presed.Tag.ToString());
        }
        //Funkcija, kas atjauno kopējo maksājuma summu.
        private void updateCostSum(string costForIndividual)
        {
            try
            {
                costSumForCustomer += decimal.Parse(costForIndividual);

                txtSaleSystemSumCost.Text = String.Format("{0:c}", costSumForCustomer.ToString() + " €");//costSumForCustomer.ToString();
            }
            catch (Exception wrongPrice)
            {
                MessageBox.Show(wrongPrice.Message.ToString());
            }
        }

        private void frmSaleSystem_Load(object sender, EventArgs e)
        {

        }
        //Funkcija ar kuras palīdzību tiks izdzēsts produkts no produktu groza.
        private void btnSaleSystemDeleteFromList_Click(object sender, EventArgs e)
        {
         
            if (lstSaleSystemBuyProductList.SelectedItem == null)
            {
                MessageBox.Show("Nav izvēlēts elements no groza, kuru var izdzēst!");
                return;
            }

            int deleteIndex = lstSaleSystemBuyProductList.SelectedIndex;
            string deleteName = lstSaleSystemBuyProductList.SelectedItem.ToString();

            Console.WriteLine("DeleteIndex" + deleteIndex);
            Console.WriteLine("DeleteName" + deleteName);
            
            //Atdala informāciju.
            string[] tokens = deleteName.Split(' ');
         
            string retVal = tokens[0] + " " + tokens[1] + " " + tokens[2];

            Console.WriteLine("Cut String: " + retVal);

            //Get price for Delete Item
            //Noņem izdzēstā produkta vērtību no kopējās atmaksājamās summas.
            decimal priceToSubdivide = getProductPrice(retVal);
            Console.WriteLine("Price For Item:" + priceToSubdivide);
            costSumForCustomer -= priceToSubdivide;
            txtSaleSystemSumCost.Text = costSumForCustomer.ToString() + " €";

            //lstSaleSystemBuyProductList.Items.Remove(deleteIndex);

            chooseProductList.Remove(deleteName);

            lstSaleSystemBuyProductList.Refresh();

            Console.WriteLine("Things works?");

        }
        //Funkcija, kas atgriež produkta cenu.
        private decimal getProductPrice(string productName)
        {
            Console.WriteLine("ProductName:", productName);
            decimal priceToReturn = 0;

            OleDbConnection connectionForProductCost = new OleDbConnection();
            connectionForProductCost.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\lokal_data_base\TEST.mdb";
            connectionForProductCost.Open();

            //Console.WriteLine(tb.Text);
            OleDbCommand getProductTypes = new OleDbCommand();
            getProductTypes.Connection = connectionForProductCost;

            getProductTypes.CommandText = "SELECT AddProductPrice FROM TblAddProduct WHERE AddProductName = '" + productName + "'";

            try
            {
                OleDbDataReader productPriceReader = getProductTypes.ExecuteReader();
                Console.WriteLine("Checking Products");

                while (productPriceReader.Read())
                {
                    priceToReturn += decimal.Parse(productPriceReader[0].ToString());
                }

                Console.WriteLine("Price in Function: " + priceToReturn);
                connectionForProductCost.Close();

                return priceToReturn;
            }
            catch (Exception priceException)
            {
                MessageBox.Show("Can`t find PRICE for this product!");
                connectionForProductCost.Close();

                return priceToReturn;
            }

        }
        //Velos nopirkt konkrētos produktus.
        private void btnSaleSystemBuyProduct_Click(object sender, EventArgs e)
        {
            //Pārbauda vai produkta vispār ir pievienots produkts.
            Console.WriteLine(chooseProductList.Count());
            if (chooseProductList.Count()<=0)
            {
                MessageBox.Show("Produktu grozam nav pievienots neviens produkts.");
                return;
            }

            //Izsauc atmaksas logu.
            frmPaymentDialog paymentLog = new frmPaymentDialog();
            
            paymentLog.Show(this);

            //paymentLog.ShowDialog(this);
            //Informācija par maksājumu tiek nodota atmaksas logam
            paymentLog.setPriceForPayment(costSumForCustomer, chooseProductList);
            //No šīs formas informācija tiek noņemta.
            chooseProductList.Clear();

            costSumForCustomer = 0;

            txtSaleSystemSumCost.Text = costSumForCustomer.ToString();
        }
    }
}
