using CefSharp;
using miniSys0._3.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3
{
    public partial class Login : Form
    {
        public static Login login;
        public Login()
        {
            InitializeComponent();
            UC_Login uc = new UC_Login();
            addUserControl(uc);
            login = this;
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ProfileFloating.profileFloating.Dispose();
            Main.main.Dispose();
            UC_main.WebBrowser.Dispose();
            UC_main.WebBrowser1.Dispose();
            Reader.reader.Dispose();
            Cef.Shutdown();
            Environment.Exit(0);
        }
        Point mPoint;
        private void drag_down(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void drag_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);

            }
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

    }

    /*public class user_type
    {
        public string type = "";
    }*/
}
