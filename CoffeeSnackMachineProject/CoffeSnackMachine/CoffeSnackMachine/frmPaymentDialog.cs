using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Printing;

namespace CoffeSnackMachine
{
    public partial class frmPaymentDialog : Form
    {
        public frmPaymentDialog()
        {
            InitializeComponent();
        }
        //Mainīgie, lai glabātu informāciju priekš printēšanas.
        private decimal priceFromSystem = 0;
        private decimal backUpForPrinting = 0;

        private BindingList<string> listOfProductToBuy = new BindingList<string>();

        private void frmPaymentDialog_Load(object sender, EventArgs e)
        {
            txtPaymentPriceSum.Text = priceFromSystem.ToString() + " €";
           
        }
        //Uzstāda vērtības mainīgajiem, priekš printēšanas 
        public void setPriceForPayment(decimal setValue,BindingList<string> listOfUserProducts)
        {
            priceFromSystem += setValue;
            backUpForPrinting += setValue;

            //listOfProductToBuy listOfUserProducts;
            //listOfProductToBuy

            for (int g = 0; g < listOfUserProducts.Count(); g++ )
            {
                listOfProductToBuy.Add(listOfUserProducts[g].ToString());
            }

            Console.WriteLine("LISTOFPRODUCTS:" + listOfProductToBuy[0].ToString());
            Console.WriteLine("COUNT: " + listOfUserProducts.Count());

            txtPaymentPriceSum.Text = priceFromSystem.ToString() + " €";
        }

        //License - http://www.vcskicks.com/license.html
        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendStringA(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private void openDrive(string driveRoot)
        {
            string driveLetter = driveRoot[0].ToString();
            string returnString = string.Empty;

            //Set a name for the specified disk drive
            mciSendStringA("open " + driveLetter + ": type CDaudio alias drive" + driveLetter, returnString, 0, 0);

            //open the disk tray
            mciSendStringA("set drive" + driveLetter + " door open", returnString, 0, 0);
        }

        private void btnPaymentPayButton_Click(object sender, EventArgs e)
        {
            //Tiek izsaukta funkcija, kas atver lasītāju E.
            openDrive("E");
        }

        private void btnPaymentPayForProduct_Click(object sender, EventArgs e)
        {
            //Kredīta ievades apstrāde.
            if(txtPaymentYourCash.Text != "")
            {
                int firstCharacter = txtPaymentYourCash.Text.IndexOf(",");
                if (firstCharacter == -1)
                {
                    MessageBox.Show("Kredīta ievadē jaizmanto komants!");
                    txtPaymentYourCash.Clear();
                    return;
                }

                try
                {
                    decimal yourCashPaying = decimal.Parse(txtPaymentYourCash.Text);
                    //Ja summa apmaksāta, parāda atlikumu kā arī piedāvā izprintēt čeku.
                    if (yourCashPaying >= priceFromSystem)
                    {
                        decimal atlikums = yourCashPaying - priceFromSystem;

                        MessageBox.Show("Atlikums: " + atlikums + " €");

                        switch (MessageBox.Show("Vai ir nepieciešams čeks?",
                                  "Vai ir nepieciešams čeks?",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                printRecipe();
                                this.Close();
                                break;

                            case DialogResult.No:
                                this.Close();
                                break;

                        }

                    }
                    else if (yourCashPaying < priceFromSystem)
                    {
                        //Ja ievadīta mazāka valūta, samazina summu, kas jaatmaksā.
                        try
                        {
                            priceFromSystem = priceFromSystem - yourCashPaying;
                            txtPaymentPriceSum.Text = priceFromSystem.ToString() + " €";
                            txtPaymentYourCash.Clear();
                        }
                        catch
                        {
                            txtPaymentYourCash.Clear();
                            MessageBox.Show("Ir problēmas ar Jūsu ievadīto naudu!");
                        }
                    }
                }
                catch
                {
                    txtPaymentYourCash.Clear();
                    MessageBox.Show("Ir problēmas ar Jūsu ievadīto naudu!"); 
                }
            }
        }


        private void printRecipe()
        {
            //Printēšanas dialogs.
            PrintDialog dialogForPrinting = new PrintDialog();
            //Documents, kas tiks printets
            PrintDocument printRecipe = new PrintDocument();

            dialogForPrinting.Document = printRecipe;
            //Events priekš satura.
            printRecipe.PrintPage += new PrintPageEventHandler(printRecipe_PrintPage);

            DialogResult resultOfPrintDialog = dialogForPrinting.ShowDialog();

            if(resultOfPrintDialog == DialogResult.OK)
            {
                //Ja dialoga ir apstiprināta printēšana, var printēt.
                printRecipe.Print();
            }

        }

        void printRecipe_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Grafiskais elements, kas attēlos tekstus.
            Graphics graphicElementPrinting = e.Graphics;

            //Fonti, kas tiks izmantoti čeku izveidei.
            Font fontForTitleRecipe = new Font("Batang", 18);
            Font fontForRecipeBase = new Font("Batang", 12);
            Font fontForRecipeDate = new Font("Batang", 10);

            //Atstarpes
            float heightBetweenFonts = fontForTitleRecipe.GetHeight();

            int whiteSpaceX = 10;
            int whiteSpaceY = 10;
            int offset = 40;

            //Pirmais grafiskais elements
            graphicElementPrinting.DrawString("Esi Sveicināts LuX uzkodu un dzērienu automātā!",
                fontForTitleRecipe, new SolidBrush(Color.Black), whiteSpaceX, whiteSpaceY);

            Console.WriteLine("How many products in List:" + listOfProductToBuy.Count());

            try
            {

                for (int i = 0; i < listOfProductToBuy.Count(); i++)
                {
                    string productwithPriceToPrint = listOfProductToBuy[i].ToString();
                    Console.WriteLine("Printejamais:" + productwithPriceToPrint);
                    //Produkts / produkti, kas iegādāti.
                    graphicElementPrinting.DrawString("Produkts: " + productwithPriceToPrint, fontForRecipeBase, new SolidBrush(Color.Black), whiteSpaceX, whiteSpaceY + offset);
                    //Palielina attālu
                    offset = offset + (int)FontHeight + 5;
                }

                offset += 20;

                string totalPriceToPay = backUpForPrinting.ToString();
                //Summa, kas tika apmaksata
                graphicElementPrinting.DrawString("Kopā tika samaksāts:".PadRight(30) + totalPriceToPay + " €", fontForRecipeBase, new SolidBrush(Color.Black), whiteSpaceX, whiteSpaceY + offset);

                //Datums, kad pirkums tika veikts
                DateTime buyDate = DateTime.Now;

                string dateNow = buyDate.ToShortDateString();

                offset += 40;

                graphicElementPrinting.DrawString("Pirkums tika veikts: " + dateNow, fontForRecipeDate, new SolidBrush(Color.Black), whiteSpaceX, whiteSpaceY + offset);
            }
            catch
            {
                MessageBox.Show("Tehniska problēma ar čeka izveidošanu! Mēģiniet, Lūdzu, vēlreiz!");
            }

        }

    }
}
