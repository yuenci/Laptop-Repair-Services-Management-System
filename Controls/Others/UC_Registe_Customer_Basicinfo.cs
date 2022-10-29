using miniSys0._3.Controls.MainArea;
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
    public partial class UC_Registe_Customer_Basicinfo : UserControl
    {
        public UC_Registe_Customer_Basicinfo()
        {
            InitializeComponent();
            InitTheme();
            TextBoxCE superName = new TextBoxCE(nameTextBox, "Enter Customer's name",Color.Gray);
        }

        private void InitTheme()
        {
            errorBar.Visible = false;
            successIcon.Visible = false;
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                nextStepBtn.RectColor = Color.Transparent;
                pictureBox1.Image = Properties.Resources.Ask_me_anything_dark;

                dynamic[] lable = { uiLabel1 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
        }

        private void nextStepBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text =="" || nameTextBox.Text == "Enter Customer's name")
            {
                nameTextBox.RectColor = Color.Red;
            }

            bool ifNameVerify = false;

            if (RegexForInput.NameVerify(nameTextBox.Text))
            {
                ifNameVerify = true;
            }
            else
            {
                //MessageBox.Show("Names can only consist of letters");
                NotificationForm messageBoxForm = new NotificationForm("warning", "Invalid input. Please note that the name can only contain letters");
                messageBoxForm.ShowDialog();

            }

            if (nameTextBox.Text != "" && nameTextBox.Text != "Enter Customer's name" && ifNameVerify)
            {
                if (SQLCursor.ifStaOrCus(nameTextBox.Text) !=null)
                {
                    //MessageBox.Show($"{nameTextBox.Text} has already existed, please try others");

                    NotificationForm messageBoxForm = new NotificationForm("warning", $"{nameTextBox.Text} has already existed, please try others");
                    messageBoxForm.ShowDialog();

                }
                else
                {
                    RegisterInfoCache.user_name = nameTextBox.Text;

                    RegisterInfoCache.step2Activate = true;

                    UC_Registration.iconSelect(UC_Registration.uc_Registration.icon2,
                    UC_Registration.uc_Registration.iconLabel2);
                    UC_Registration.iconUnSelect(UC_Registration.uc_Registration.icon1,
                        UC_Registration.uc_Registration.iconLabel1);
                    UC_Registration.iconUnSelect(UC_Registration.uc_Registration.icon3,
                        UC_Registration.uc_Registration.iconLabel3);

                    UC_Registe_detaildinfo uc = new UC_Registe_detaildinfo();
                    uc.Location = new Point(320, 80);
                    AddUserControl.Add(uc, UC_Registration.uc_Registration.contentPanel);
                }
                
            }

            
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            errorBar.Visible = false;
            successIcon.Visible = false;
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (SQLCursor.ifStaOrCus(nameTextBox.Text) != null)
            {
                errorBar.Visible = true;
            }
            else
            {
                successIcon.Visible = false;
            }
            
        }
    }
}
