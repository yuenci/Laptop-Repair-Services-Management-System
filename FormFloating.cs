using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using miniSys0._3.Controls;
using Sunny.UI;
namespace miniSys0._3
{
    public partial class FormFloating : UIForm
    {
        public static FormFloating profileFloating;
        public FormFloating()
        {
            InitializeComponent();
            profileFloating = this;
            userName.Text = User_type.user_name ;
            userPost.Text = "";
            if (User_type.user_deparment != "Customer")
            {
                userPost.Text = User_type.user_post + " | " + User_type.user_ID;
            }
            else
            {
                userPost.Text = User_type.user_ID;
            }
            icon.Text = User_type.user_name.Substring(0,1);
            icon.ForeColor = User_type.LogoFore;
            icon.FillColor = User_type.LogoBkg;
            InitTheme();
        }
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                rectColor = Color.Transparent;

                dynamic[] lable = { userName, userPost };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

                dynamic[] btns = { logoutButton2, exitButton1 };
                foreach (var item in btns)
                {
                    item.ForeColor = Color.White;
                    item.SymbolColor = Color.White;
                    item.FillColor = Color.FromArgb(55, 55, 57);
                }
               
                //logoutButton2.SymbolColor = Color.White;
            }
        }


        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            FormFloating.profileFloating.Dispose();
            Main.main.Dispose();    
            //UC_main.WebBrowser.Dispose();
            //UC_main.WebBrowser1.Dispose();
            //Reader.reader.Dispose();
            //Cef.Shutdown();
            Environment.Exit(0);
        }

        private void logoutButton2_Click(object sender, EventArgs e)
        {

            //UC_main.WebBrowser.Dispose();
            //UC_main.WebBrowser1.GetBrowser().CloseBrowser(true);
            //UC_main.WebBrowser1.Dispose();
            //Cef.Shutdown();
            User_type.loginStatus = "Relogin";
            Login login = new Login();
            login.Show();
            this.Hide();
            Main.main.Hide();
        }
    }
}
