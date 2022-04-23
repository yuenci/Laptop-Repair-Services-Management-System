using miniSys0._3.Controls.Others;
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

namespace miniSys0._3.Controls.MainArea
{
    public partial class UC_UserSetting : UserControl
    {
        public UC_UserSetting()
        {
            InitializeComponent();
            InitIcon();
            InitUserInfo();
            //InitChangeButtonStyle();
            InitContentPanel();
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
        private void InitUserInfo()
        {
            uiLabel7.Text = User_type.user_name;
            uiLabel8.Text = User_type.user_ID;
            uiLabel9.Text = User_type.user_regtime;
            uiLabel10.Text = User_type.user_gender;
            phoneTextBox.Text = User_type.user_phone;
            emailTextBox.Text = User_type.user_email;
        }

        private void SelectedButtonStyle(dynamic button1)
        {
            //select(base)
            button1.RectColor = Color.Transparent;
            button1.FillColor = Color.FromArgb(242, 243, 245);
            button1.ForeColor = Color.FromArgb(22, 93, 255);

            //hover
            button1.RectColor = Color.Transparent;
            button1.FillColor = Color.FromArgb(242, 243, 245);
            button1.ForeColor = Color.FromArgb(22, 93, 255);

            //press
            button1.RectColor = Color.Transparent;
            button1.FillColor = Color.Silver;
            button1.ForeColor = Color.FromArgb(22, 93, 255);
        }
        private void UnSelectedButtonStyle(UIButton button)
        {
            //select(base)
            button.RectColor = Color.Transparent;
            button.FillColor = Color.Transparent;
            //button.ForeColor = Color.FromArgb(78, 89, 105);
            button.ForeColor = Color.Red;

            //hover
            button.RectColor = Color.Transparent;
            //button.FillColor = Color.FromArgb(242, 243, 245
            button.FillColor = Color.Red;
            button.ForeColor = Color.FromArgb(22, 93, 255);

            //press
            button.RectColor = Color.Transparent;
            button.FillColor = Color.Silver;
            button.ForeColor = Color.FromArgb(22, 93, 255);
        }

        private void InitChangeButtonStyle()
        {
            SelectedButtonStyle(changeButton1);
            UnSelectedButtonStyle(changeButton2);
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
            //UC_SecureSet
            addUserControl(uc);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            InitChangeButtonStyle();
        }
    }
}
