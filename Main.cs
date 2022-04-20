using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace miniSys0._3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            searchBox.Hide();
            //InitMain();
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

        private void profile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void searchIcon_Click(object sender, EventArgs e)
        {
            searchBox.Show();
            searchBox.Focus();
        }

        private void search_enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void search_leave(object sender, EventArgs e)
        {
            searchBox.Text = "Type here to search";
        }


        public void InitMain()
        {
            int pageIndex = 100;
            TreeNode parent = NavMenu.CreateNode("DashBoard", pageIndex);
            NavMenu.CreateChildNode(parent, "Workbench", ++pageIndex);
            NavMenu.CreateChildNode(parent, "条目2", ++pageIndex);
            pageIndex = 200;
            parent = NavMenu.CreateNode("Form", pageIndex);
            NavMenu.CreateChildNode(parent, "Register", ++pageIndex);
            NavMenu.CreateChildNode(parent, "Payment", ++pageIndex);
            pageIndex = 300;
            parent = NavMenu.CreateNode("Profile", pageIndex);
            NavMenu.CreateChildNode(parent, "User info", ++pageIndex);
            NavMenu.CreateChildNode(parent, "User settings", ++pageIndex);
        }

    }
}
