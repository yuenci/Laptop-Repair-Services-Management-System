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
    public partial class UC_Registe_Complete : UserControl
    {
        public UC_Registe_Complete()
        {
            InitializeComponent();
            InitData();
            InitWarningBar();
            InitTheme();
        }


        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                dynamic[] lable = { successful , uiLabel1 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
        }


        private void viewMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("agreement");
        }
        
        
        private void InitData()
        {
            name.Text = RegisterInfoCache.user_name;
            account.Text = RegisterInfoCache.user_ID;
            password.Text = RegisterInfoCache.user_password;

            password.RectColor = Color.Transparent;
            password.BackColor = Color.Transparent;
            password.FillColor = Color.FromArgb(242, 243, 245);
        }
        
        
        private void InitWarningBar()
        {
            warningBar.BackColor = Color.FromArgb(255, 247, 232);
            warningBar.SymbolColor = Color.FromArgb(255, 125, 0);
        }
        
        
        private void again_Click(object sender, EventArgs e)
        {

            UC_Registration.iconSelect(UC_Registration.uc_Registration.icon1, 
                UC_Registration.uc_Registration.iconLabel1);
            UC_Registration.iconUnSelect(UC_Registration.uc_Registration.icon2,
                UC_Registration.uc_Registration.iconLabel2);
            UC_Registration.iconUnSelect(UC_Registration.uc_Registration.icon3,
                UC_Registration.uc_Registration.iconLabel3);

            string[] controlsText = {
                            RegisterInfoCache.user_deparment ,
                            RegisterInfoCache.user_ID,
                            RegisterInfoCache.user_name ,
                            RegisterInfoCache.user_phone ,
                            RegisterInfoCache.user_email ,
                            RegisterInfoCache.user_Birthday,
                            RegisterInfoCache.user_gender ,
                            RegisterInfoCache.user_post ,
                            RegisterInfoCache.user_ID_number ,
                            RegisterInfoCache.user_about ,
                            RegisterInfoCache.user_Country ,
                            RegisterInfoCache.user_Address ,
                            RegisterInfoCache.user_regtime ,
                            RegisterInfoCache.user_security_qustion ,
                            RegisterInfoCache.user_security_answer ,
                            RegisterInfoCache.user_password
                };

            bool[] contorlStatus = {
                            RegisterInfoCache.step1Activate,
                            RegisterInfoCache.step2Activate ,
                            RegisterInfoCache.step3Activate ,
            };
            for (int i = 0; i < controlsText.Length; i++)
            {
                controlsText[i] = "";
            }
            for (int i = 0; i < contorlStatus.Length; i++)
            {
                contorlStatus[i] = false;
            }


            UC_Registe_Staff_Basicinfo uc = new UC_Registe_Staff_Basicinfo();
            uc.Location = new Point(320, 80);
            AddUserControl.Add(uc, UC_Registration.uc_Registration.contentPanel);
        }


        private void CheckButton_Click(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile();
            viewProfile.ShowInTaskbar = false;
            viewProfile.Show();
        }
    }
}
