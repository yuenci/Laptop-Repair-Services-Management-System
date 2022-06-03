using miniSys0._3.Controls.MainArea;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3.Controls.Others
{
    public partial class UC_ReciptSubmit : UserControl
    {
        private static string customerIDCashe = "";
        private string Card_Account_ID;

        public UC_ReciptSubmit()
        {
            InitializeComponent();
            InitLabels();
            InitTheme();
            InitComboBox();
            errorBar.Visible = false;
            successIcon.Visible = false;
            cardID.Visible = false;
        }


        private void InitTheme()
        {
            
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                successIcon.FillColor = Color.FromArgb(28, 47, 70);
                successIcon.BackColor = Color.FromArgb(28, 47, 70);

                dynamic[] lable = { uiLabel1, uiLabel2, uiLabel3, uiLabel4, uiLabel5 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
            else
            {
                this.BackColor = Color.White;
                successIcon.FillColor = Color.Transparent;
                successIcon.BackColor = Color.Transparent;

                dynamic[] lable = { uiLabel1, uiLabel2, uiLabel3, uiLabel4, uiLabel5 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }
            }
        }


        private void InitLabels()
        {
            TextBoxCE superName = new TextBoxCE(name, "Enter customer's name", Color.Gray);
            TextBoxCE superBrand = new TextBoxCE(brand, "Customer's computer Brand", Color.Gray);
            TextBoxCE superMdel = new TextBoxCE(model, "Customer's computer model", Color.Gray);

            
            name.RectColor = Color.Gray;
            name.FillColor = Color.FromArgb(242, 243, 245);
            brand.RectColor = Color.Gray;
            brand.FillColor = Color.FromArgb(242, 243, 245);
            model.RectColor = Color.Gray;
            model.FillColor = Color.FromArgb(242, 243, 245);
            cardID.RectColor = Color.Gray;
            cardID.FillColor = Color.FromArgb(242, 243, 245);
            cardID.Enabled = false;

        }
        

        private void InitComboBox()
        {
            switch1.ActiveColor = Color.FromArgb(255, 128, 128);
            ComboBoxCE superType = new ComboBoxCE(type, Color.Gray);
            ComboBoxCE superMethod = new ComboBoxCE(method, Color.Gray);

            type.RectColor = Color.Gray;
            type.FillColor = Color.FromArgb(242, 243, 245);
            method.RectColor = Color.Gray;
            method.FillColor = Color.FromArgb(242, 243, 245);

        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            bool flag1 = false;
            
            if (name.Text == "" || name.Text == "Enter customer's name")
            {
                name.RectColor = Color.Red;
                name.RectSize = 2;
            }
            else
            {
                flag1 = true;
            }

            bool flag2 = false;
            if (brand.Text == "" || brand.Text == "Customer's computer Brand")
            {
                brand.RectColor = Color.Red;
                brand.RectSize = 2;
            }
            else
            {
                flag2 = true;
            }

            bool flag3 = false;
            if (model.Text == "" || model.Text == "Customer's computer model")
            {
                model.RectColor = Color.Red;
                model.RectSize = 2;
            }
            else
            {
                flag3 = true;
            }

            bool flag4 = false;
            if (type.SelectedIndex == -1)
            {
                type.RectColor = Color.Red;
                type.RectSize = 2;
            }
            else
            {
                flag4 = true;
            }

            bool flag5 = false;
            if (method.SelectedIndex == -1)
            {
                method.RectColor = Color.Red;
                method.RectSize = 2;
            }
            else
            {
                flag5 = true;
            }

            if (flag1 && flag2 && flag3 && flag4 && flag5 &&!errorBar.Visible&& IfcardIDOKTosubmit())
            {
                //MessageBox.Show("Submit success");

                ReceiptInfoCache.customer_name = name.Text;

                ReceiptInfoCache.orderID = SQLCursor.AddOneToLastID("OrderID", "Orders");
                ReceiptInfoCache.service_Type = getService_Type();
                ReceiptInfoCache.service_Name = type.SelectedItem.ToString();
                ReceiptInfoCache.customerID = customerIDCashe;
                ReceiptInfoCache.receptionist = User_type.user_ID;
                ReceiptInfoCache.urgent = ifUrgent().ToString();
                ReceiptInfoCache.model = brand.Text +"-"+ model.Text;
                ReceiptInfoCache.time = DateTime.Now.ToString();
                ReceiptInfoCache.price = TotalPrice().ToString();
                ReceiptInfoCache.payment_method = method.SelectedItem.ToString();
                ReceiptInfoCache.Card_Account_ID = Card_Account_ID;
                //ReceiptInfoCache.ShowALLPropertyValue();


                UC_ReciptComplete uc = new UC_ReciptComplete();
                AddUserControl.Add(uc, UC_Payment.uc_Payment.contentPanel);

                string sql = $"INSERT INTO Orders VALUES ("
                    + $"'{ReceiptInfoCache.orderID}',"
                    + $"'Ser{ReceiptInfoCache.service_Type}',"
                    + $"'{ReceiptInfoCache.customerID}',"
                    + $"'{ReceiptInfoCache.receptionist}',"
                    + $"{ReceiptInfoCache.urgent},"
                    + $"'{ReceiptInfoCache.model}',"
                    + $"'{ReceiptInfoCache.time}',"
                    + $"null," //description
                    + $"{ReceiptInfoCache.price},"
                    + $"'{ReceiptInfoCache.payment_method}',"
                    + $"null," //start
                    + $"'{ReceiptInfoCache.Card_Account_ID}'"
                    + ");";

                //Console.WriteLine(sql);
                SQLCursor.Execute(sql);

                string schID = SQLCursor.AddOneToLastID("ScheduleID", "Schedule");
                string sqlSch = $"INSERT INTO Schedule VALUES ('{schID}','Order'" +
                    $",'{ReceiptInfoCache.time}',null,'{ReceiptInfoCache.orderID}')";
                SQLCursor.Execute(sqlSch);
            }


        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            UITextBox[] Labels = { name, brand, model };
            string[] labelsStr = { "Enter customer's name", "Customer's computer Brand", "Customer's computer model" };
            UIComboBox[] comboBoxes = { type, method };
            string[] comboBoxesStr = { "Select a service type", "Select a Payment Method" };
            for (int i = 0; i < labelsStr.Length; i++)
            {
                Labels[i].Text = labelsStr[i];
                Labels[i].Font = new Font(".萍方-简", 12, FontStyle.Regular);
                Labels[i].RectColor = Color.Gray;
                Labels[i].RectSize = 1;
            }
            for (int i = 0; i < comboBoxesStr.Length; i++)
            {
                comboBoxes[i].Text = comboBoxesStr[i];
                comboBoxes[i].Font = new Font(".萍方-简", 12, FontStyle.Regular);
                comboBoxes[i].RectColor = Color.Gray;
                comboBoxes[i].RectSize = 1;
            }
            switch1.Active = false;

        }
        
        
        private void name_Leave(object sender, EventArgs e)
        {
            var customerID = SQLCursor.Query($"Select CustomerID From  Customer Where Name =  '{name.Text}'");
            if(customerID.Length == 0)
            {
                errorBar.Visible =true;
                errorBar.Text = $"{name.Text} does not exist, please register first.";
            }
            else
            {
                successIcon.Visible = true;
                customerIDCashe = customerID[0];
            }
        }


        private void name_Enter(object sender, EventArgs e)
        {
            errorBar.Visible = false;
            successIcon.Visible = false;
        }
        

        private int ifUrgent()
        {
            if (switch1.ActiveText =="Yes")
            {
                return 1;
            }else if(switch1.ActiveText == "No")
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        
        
        private string getService_Type()
        {
            int index = type.SelectedIndex +1;
            string serverID = index.ToString().PadLeft(3, '0');
            return serverID;
        }
        
        
        private int TotalPrice()
        {
            int[,] pricelist = { { 50, 80 }, { 60, 90 }, { 380, 430 }, { 160, 200 },
                                  {180,210 },{ 100,150},{80,130 },{ 70,100}
            };

            int col = ifUrgent();
            int row = type.SelectedIndex;
            return pricelist[row, col];
        }


        private void method_DropDownClosed(object sender, EventArgs e)
        {
            cardID.Enabled = true;
            cardID.Visible = true;
            if (method.SelectedIndex == 0)
            {
                cardID.Text = "Enter customer's Bank card number";
            }
            else if (method.SelectedIndex == 1)
            {
                cardID.Text = "Enter customer's Paypal account number";
            }
            else if (method.SelectedIndex == 2)
            {
                cardID.Visible = false;
            }
            else if (method.SelectedIndex == 3)
            {
                cardID.Text = "Enter customer's Check number";
            }

        }


        private void cardID_Enter(object sender, EventArgs e)
        {
            cardID.RectColor = Color.Gray;
            cardID.RectSize = 1;
            cardID.Text = "";
        }
        

        private bool IfcardIDOKTosubmit()
        {
            if (method.SelectedIndex == 2)
            {
                Card_Account_ID = "";
                return true;
            }

            if (cardID.Text == "Enter bank card / Account  ID"|| cardID.Text =="")
            {
                cardID.RectColor = Color.Red;
                cardID.RectSize = 2;
                return false;
            }
            else
            {
                Card_Account_ID = cardID.Text;
                return true;
            
            }
                
        }

    }
}
