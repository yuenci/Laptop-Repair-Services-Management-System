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
            sunnyUIinit();
            addNavMenu();
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
            TreeNode parent = receptionistNavMenu.CreateNode("DashBoard", pageIndex);
            receptionistNavMenu.CreateChildNode(parent, "Workbench", ++pageIndex);
            receptionistNavMenu.CreateChildNode(parent, "条目2", ++pageIndex);
            pageIndex = 200;
            parent = receptionistNavMenu.CreateNode("Form", pageIndex);
            receptionistNavMenu.CreateChildNode(parent, "Register", ++pageIndex);
            receptionistNavMenu.CreateChildNode(parent, "Payment", ++pageIndex);
            pageIndex = 300;
            parent = receptionistNavMenu.CreateNode("Profile", pageIndex);
            receptionistNavMenu.CreateChildNode(parent, "User info", ++pageIndex);
            receptionistNavMenu.CreateChildNode(parent, "User settings", ++pageIndex);
        }

        /*void addIcon()
        {
            for (int i = 0; i < receptionistNavMenu.Nodes.Count; i++)
            {
                receptionistNavMenu.ImageList = receptionistNavMenuImageList;
                if (i == 0)
                {
                    //NavMenu.Nodes[i].Text = "\ue901";
                    receptionistNavMenu.Nodes[i].ImageIndex = 0;
                    //NavMenu.Nodes[i].NodeFont = new Font(IconfontHelper.PFCC.Families[0], 15);
                }
            }

            *//*label33.Text = "\ue902 Dashboard";
            label33.Font = new Font(IconfontHelper.PFCC.Families[0], 20);*/


            /*foreach (TreeNode item in NavMenu.Nodes)
            {
                item.Text = "lala";
            }*//*
        }*/

        void sunnyUIinit()
        {
            upperTriangle.ForeColor = Color.Red;
            upperTriangle.FillColor = Color.Transparent;

            shortcutButton1.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton2.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton3.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton1.SymbolColor = Color.Black;
            shortcutButton2.SymbolColor = Color.Black;
            shortcutButton3.SymbolColor = Color.Black;
            shortcutButton1.RectColor = Color.Transparent;
            shortcutButton2.RectColor = Color.Transparent;
            shortcutButton3.RectColor = Color.Transparent;
            newsTopBar.RectColor = Color.Transparent;
            newsTopBar.FillColor = Color.FromArgb(242, 243, 245);
            news1.MarkColor = Color.FromArgb(242, 243, 245);
            news2.MarkColor = Color.FromArgb(242, 243, 245);
            news3.MarkColor = Color.FromArgb(242, 243, 245);
            news4.MarkColor = Color.FromArgb(242, 243, 245);
            news5.MarkColor = Color.FromArgb(242, 243, 245);
            //noticeButton1.

            receptionistNavMenu.SelectedHighColor = Color.Transparent;


        }

        private void node_click(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                /*if (e.Node.Level == 0)
                {
                    //e.Node.Text = "<span style ='color:red'>lalala</span>";
                    //ForeColor = Color.Red;
                    //e.Node.ForeColor = Color.Red;
                    MessageBox.Show(e.Node.Text);
                }*/
                if (e.Node.Level == 1)                              
                {

                    //MessageBox.Show(e.Node.Parent.Text);
                    //e.Node.Parent.Text = "laaa";
                }
            }
        }

        private void addNavMenu()
        {

        }
    }

    public class User_type
    {
        public static string user_type = "";
    }
}
