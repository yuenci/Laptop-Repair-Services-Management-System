using miniSys0._3.Controls.Others;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3.Controls.MainArea
{
    public partial class UC_UserSetting : UserControl
    {
        public UC_UserSetting()
        {
            InitializeComponent();
            InitCurmbs();
            InitIcon();
            InitUserInfo();
            InitContentPanel();
            InitChangeButton();
        }
        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "User setting";

        }
        private void InitIcon()
        {
            //urC_Crumbs1.crumbText.Text = "User Setting";

            icon.Text = User_type.user_name.Substring(0, 1);
            icon.ForeColor = User_type.LogoFore;
            icon.FillColor = User_type.LogoBkg;




            /*ButtonEditPhoto.Parent = icon;
            ButtonEditPhoto.Location = new Point(70, 95);*/


        }
        private string encryptedPhoneNum(string phoneNum)
        {
            double lengthdouble = phoneNum.Length - (phoneNum.Length % 3) ;
            double numLength = Math.Floor(lengthdouble / 3);
            int numLengthInt = Convert.ToInt32(numLength);

            int lengthInt = phoneNum.Length;
            
            string start =   phoneNum.Substring(0, numLengthInt);
            string end = phoneNum.Substring(lengthInt - numLengthInt, numLengthInt);
            string asterisks  = new string('*', lengthInt - 2 * numLengthInt);

            return start + asterisks + end;


        }
        private void InitUserInfo()
        {
            uiLabel7.Text = User_type.user_name;
            uiLabel8.Text = User_type.user_ID;
            uiLabel9.Text = User_type.user_regtime;
            uiLabel10.Text = User_type.user_gender;
            phoneTextBox.Text = encryptedPhoneNum(User_type.user_phone);
            phoneTextBox.RectColor = Color.White;
            phoneTextBox.Enabled = false;


        }

        private void SelectedButtonStyle(UIUserControl userControl,Label lable)
        {
            lable.ForeColor = Color.FromArgb(22, 93, 255);
            lable.Font =   new Font(".萍方-简", 12, FontStyle.Bold);

            userControl.FillColor = Color.FromArgb(242, 243, 245);

        }
        private void UnSelectedButtonStyle(UIUserControl userControl, Label lable)
        {
            lable.ForeColor = Color.FromArgb(78, 89, 105);
            lable.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            userControl.FillColor = Color.Transparent;
        }
        private void InitChangeButton()
        {
            SelectedButtonStyle(bgBI, labelBI);
            UnSelectedButtonStyle(bgSS,labelSS);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void InitContentPanel()
        {
            UC_BasicInfo uc = new UC_BasicInfo();
            //UC_SecureSet uc = new UC_SecureSet();
            addUserControl(uc);
        }


        private void labelSS_Click(object sender, EventArgs e)
        {
            SelectedButtonStyle(bgSS, labelSS);
            UnSelectedButtonStyle(bgBI, labelBI);
            UC_SecureSet uc = new UC_SecureSet();
            addUserControl(uc);
        }

        private void labelBI_Click(object sender, EventArgs e)
        {
            SelectedButtonStyle(bgBI, labelBI);
            UnSelectedButtonStyle(bgSS, labelSS);
            UC_BasicInfo uc = new UC_BasicInfo();
            addUserControl(uc);
        }

        private void editPhone_Click(object sender, EventArgs e)
        {
            string oldPhoneNum = phoneTextBox.Text;
            Console.WriteLine($"begin:{oldPhoneNum}");
            if (editPhone.Text == "Edit")
            {
                phoneTextBox.Enabled = true;
                phoneTextBox.Text = "";
                phoneTextBox.RectColor = Color.FromArgb(80, 160, 255);
                phoneTextBox.Focus();
                editPhone.Text = "OK";
            }else if (editPhone.Text == "OK")
            {
                if (phoneTextBox.Text == "")
                {
                    MessageBox.Show("Empty input, Enter phone number please");
                }
                else if (phoneTextBox.Text != User_type.user_phone)
                {
                    try
                    {
                        Console.WriteLine("!=!=!==");
                        Regex.IsMatch(phoneTextBox.Text, @"Expression");
                        phoneTextBox.Enabled = false;
                        string orginalNum = phoneTextBox.Text;
                        string encryNum = encryptedPhoneNum(phoneTextBox.Text);
                        phoneTextBox.Text = encryNum;
                        phoneTextBox.RectColor = Color.White;
                        editPhone.Text = "Edit";
                        User_type.user_phone = orginalNum;
                        MessageBox.Show($"send new phone:{orginalNum} to db");
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input, Enter number please");
                    }
                }
                else if (phoneTextBox.Text == User_type.user_phone)
                {
                    phoneTextBox.Text = encryptedPhoneNum(phoneTextBox.Text); 
                    phoneTextBox.Enabled = false;
                    phoneTextBox.RectColor = Color.White; 
                    editPhone.Text = "Edit";
                }  
            }


        }

        private UITextBox idCardNum = new UITextBox();
        private void editIDCardNum_Click(object sender, EventArgs e)
        {
            if (editIDCardNum.Text == "Edit")
            {
                authStatus.Hide();
                idCardNum.Text = User_type.user_ID_number;
                idCardNum.Location = new Point(733, 102);
                idCardNum.Size = new Size(240, 30);
                idCardNum.ForeColor = Color.Gray;
                container1.Controls.Add(idCardNum);

                editIDCardNum.Text = "OK";
            }
            else if (editIDCardNum.Text == "OK")
            {
                if (idCardNum.Text != User_type.user_ID_number)
                {
                    string id_num = idCardNum.Text;
                    container1.Controls.Remove(idCardNum);
                    authStatus.Show();
                    editIDCardNum.Text = "Edit";
                    MessageBox.Show($"send new id num:{id_num} to db");
                }
                else
                {
                    container1.Controls.Remove(idCardNum);
                    authStatus.Show();
                    editIDCardNum.Text = "Edit";
                }
            }
        }
    }
}
