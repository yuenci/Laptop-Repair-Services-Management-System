using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class ProfileFloating : UIForm
    {
        public ProfileFloating()
        {
            InitializeComponent();
            Console.WriteLine(User_type.user_name);
            Console.WriteLine(User_type.user_deparment);
            Console.WriteLine(User_type.user_post);
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
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Cef.Shutdown();
            Application.Exit();
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
