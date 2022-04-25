using miniSys0._3.Controls.MainArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3.Controls.Others
{
    public partial class UC_ReciptComplete : UserControl
    {
        public UC_ReciptComplete()
        {
            InitializeComponent();
            InitStyle();
            intiData();
            creatQRCode();
        }

        private string datatimeCache;
        private string customerCache;
        private string receptionstCache;
        private string addressCache;
        private string receiptNumCache;
        private string invoiceNumCache;
        private string pymentMethodCache;
        private string cardNumberCache;
        private string orderNumCache;
        private string serviceCache;
        private string priceCache;
        private string urgentCache;
        private void InitStyle()
        {
            uiLine1.LineColor = Color.Gainsboro;
            uiLine1.FillColor = Color.Transparent;

            uiLine2.LineColor = Color.Gainsboro;
            uiLine2.FillColor = Color.Transparent;

            uiLine3.LineColor = Color.Gainsboro;
            uiLine3.FillColor = Color.Transparent;

            uiLine4.LineColor = Color.Gainsboro;
            uiLine4.FillColor = Color.Transparent;

            printInvoice.FillColor = Color.Transparent;
            printInvoice.RectColor = Color.Transparent;
            printInvoice.RectHoverColor = Color.Transparent;
            printInvoice.RectPressColor = Color.Transparent;
            printInvoice.ForeColor  =   Color.FromArgb(78, 89, 105);
            printInvoice.ForeHoverColor = Color.Black;
            printInvoice.ForePressColor = Color.Black;
            printInvoice.SymbolColor= Color.FromArgb(78, 89, 105);
            printInvoice.SymbolHoverColor = Color.Black;
            printInvoice.SymbolPressColor = Color.Black;

            printReceipt.FillColor = Color.Transparent;
            printReceipt.RectColor = Color.Transparent;
            printReceipt.RectHoverColor = Color.Transparent;
            printReceipt.RectPressColor = Color.Transparent;
            printReceipt.ForeColor = Color.FromArgb(78, 89, 105);
            printReceipt.ForeHoverColor = Color.Black;
            printReceipt.ForePressColor = Color.Black;
            printReceipt.SymbolColor = Color.FromArgb(78, 89, 105);
            printReceipt.SymbolHoverColor = Color.Black;
            printReceipt.SymbolPressColor = Color.Black;
        }
        private void intiData()
        {
            datetime.Text = ReceiptInfoCache.time;
            datatimeCache = datetime.Text;


            customerName.Text = ReceiptInfoCache.customer_name;
            customerCache = customerName.Text;

            address.Text = "Kuala Lumpur";
            addressCache = address.Text;

            receptionstName.Text = User_type.user_name;
            receptionstCache = receptionstName.Text;

            moneyLable();

            mmmTime.Text = getDateTIme("MMM");

            method.Text = ReceiptInfoCache.payment_method;
            pymentMethodCache = method.Text;


            orderNum.Text = "Recipt " + "Ord" + ReceiptInfoCache.orderID.Substring(3, 4) + "-" +
                ReceiptInfoCache.orderID.Substring(7, 4);
            orderNumCache = "Ord" + ReceiptInfoCache.orderID.Substring(3, 4) + "-" +
                ReceiptInfoCache.orderID.Substring(7, 4);

            server.Text = ReceiptInfoCache.service_Name;
            serviceCache= server.Text;

            urgent.Text = getUrgent();
            urgentCache = urgent.Text;
            setReciptInvoiceID();

            if (ReceiptInfoCache.payment_method== "Cash")
            {
                cardNumberLabel.Hide();
                cardNumber.Hide();
                cardNumberLabel.Text = "Paid-in";
                cardNumber.Text = priceCache;
            }
            else if (ReceiptInfoCache.payment_method == "Cash")
            {
                cardNumberLabel.Text = "Bank card number";
                cardNumber.Text = ReceiptInfoCache.Card_Account_ID;
            }
            else if (ReceiptInfoCache.payment_method == "Cash")
            {
                cardNumberLabel.Text = "Paypal account numbe";
                cardNumber.Text = ReceiptInfoCache.Card_Account_ID;
            }
            else if (ReceiptInfoCache.payment_method == "Cash")
            {
                cardNumberLabel.Text = "Check number";
                cardNumber.Text = ReceiptInfoCache.Card_Account_ID;
            }
            cardNumberCache = cardNumber.Text;

    }
    private string getDateTIme(string type)
        {
            if(type =="MMM")
            {
                string Datetime = DateTime.Now.ToString("dd-MMM-yyyy", new System.Globalization.CultureInfo("en-US"));
                //25-Apr-2022
                string[] args = Datetime.Split('-');
                return args[1].ToUpper() + " " + args[0] + ", "+args[2];

            }
            else if(type == "MMMM")
            {
                string Datetime =  DateTime.Now.ToString("dd-MMMM-yyyy", new System.Globalization.CultureInfo("en-US"));
                //25 - April - 2022
                string[] args = Datetime.Split('-');
                return args[1] + " " + args[0] + ", " + args[2];
            }
            return null;
        }
        private void moneyLable()
        {
            money.Text = "RM"+ ReceiptInfoCache.price;
            price.Text = "RM" + ReceiptInfoCache.price;
            totalPrice.Text = "RM" + ReceiptInfoCache.price;
            amountPrice.Text = "RM" + ReceiptInfoCache.price;
            priceCache = money.Text;
        }
        private string getUrgent()
        {
            if (ReceiptInfoCache.urgent == "1")
            {
                return "Urgent";
            }
            else if (ReceiptInfoCache.urgent == "0")
            {
                return "Normal";
            }
            else
            {
                return null;
            }
            
        }

        private void setReciptInvoiceID()
        {
            string[] randomNum = new string[4];
            Random rd = new Random();
            for (int i = 0; i < 4; i++)
            {  
                randomNum[i] = rd.Next(1000, 9999).ToString();
            }
            receiptNum.Text = randomNum[0] +"-"+ randomNum[1];
            invoiceNum.Text = randomNum[2] +"-"+ randomNum[3];


            receiptNumCache = receiptNum.Text;
            invoiceNumCache = invoiceNum.Text;
        
    }

        public static Bitmap QRCode(string msg, int version, int pixel, string icon_path, int icon_size, int icon_border, bool white_edge)
        {

            QRCoder.QRCodeGenerator code_generator = new QRCoder.QRCodeGenerator();

            Console.WriteLine(msg.Length);
            QRCoder.QRCodeData code_data = code_generator.CreateQrCode(msg, QRCoder.QRCodeGenerator.ECCLevel.L, true, true, QRCoder.QRCodeGenerator.EciMode.Utf8, version);

            QRCoder.QRCode code = new QRCoder.QRCode(code_data);

            Bitmap icon = new Bitmap(icon_path);

            Bitmap bmp = code.GetGraphic(pixel, Color.Black, Color.White, icon, icon_size, icon_border, white_edge);

            return bmp;

        }


        private void creatQRCode()
        {
            string QRData = $"Receipt from C# Computer repair{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Datetime: {datatimeCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Customer: {customerCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Receptionist: {receptionstCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Address: {addressCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Receipt number: {receiptNumCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Invoice number: {invoiceNumCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Pyment method: {pymentMethodCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"{cardNumberLabel.Text}: {cardNumberCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Order number: {orderNumCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Service type: {serviceCache}({urgentCache}){Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Amount paid: {priceCache}{Convert.ToChar(10)}{Convert.ToChar(10)}"
                + $"Contact us at 789123456";
            int version = -1;
            int pixel = 5;
            string str_msg = QRData;
            int int_icon_size = 20;
            int int_icon_border = 5;
            bool b_we = false;
            string iconLocation = Setting.path + "\\Html\\LogoPic1.png";
            Bitmap bmp = QRCode(str_msg, version, pixel, iconLocation, int_icon_size, int_icon_border, b_we);
            QRpictureBox.Image = bmp;
        }

        public static void PrintControl(string docName, string printerName, Panel ucToPrint, bool isPrintView)
        {
            using (var printDoc = new PrintDocument())
            {
                if (!string.IsNullOrEmpty(printerName))
                {
                    printDoc.DefaultPageSettings.PrinterSettings.PrinterName = printerName;
                    printDoc.DefaultPageSettings.Landscape = true;
                }
                printDoc.DocumentName = docName;
                printDoc.PrintPage += (sender, e) =>
                {
                    ucToPrint.Show();

                    var bitMap = new Bitmap(ucToPrint.Width, ucToPrint.Height);
                    ucToPrint.DrawToBitmap(bitMap, new Rectangle(0, 0, ucToPrint.Width, ucToPrint.Height));

                    //e.Graphics.DrawImageUnscaled(bitMap, Point.Empty);
                    e.Graphics.DrawImage(bitMap, Point.Empty);
                };

                if (isPrintView)
                {
                    using (var printViewDlg = new PrintPreviewDialog())
                    {
                        printViewDlg.Document = printDoc;

                        (printViewDlg as Form).WindowState = FormWindowState.Maximized;
                        printViewDlg.ShowDialog();
                    }
                }
                else
                {
                    printDoc.Print();
                }
            }
        }

        private void printReceipt_Click(object sender, EventArgs e)
        {
            PrintControl("recepti", "Microsoft Print to PDF", UC_Payment.uc_Payment.contentPanel, true);
        }

        private void printInvoice_Click(object sender, EventArgs e)
        {
            PrintControl("recepti", "Microsoft Print to PDF", UC_Payment.uc_Payment.contentPanel, true);
        }
    }
}
