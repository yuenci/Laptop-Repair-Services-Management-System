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
using miniSys0._3.Controls;

namespace miniSys0._3
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            searchBox.Hide();    
            addNavMenu();
            addMainPanel();
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
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            navMenuPanel.Controls.Clear();
            navMenuPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void addNavMenu()
        {
            if (User_type.user_type == "Receptionist")
            {
                UC_R_Navmenu uc = new UC_R_Navmenu();
                addUserControl(uc);
            }
            else if (User_type.user_type == "Technician")
            {
                UC_T_Navmenu uc = new UC_T_Navmenu();
                addUserControl(uc);
            }
            else if (User_type.user_type == "Customer")
            {
                UC_C_Navmenu uc = new UC_C_Navmenu();
                addUserControl(uc);
            }
            else if (User_type.user_type == "Admin")
            {
                UC_A_Navmenu uc = new UC_A_Navmenu();
                addUserControl(uc);
            }
        }

        private void addMainPanel()
        {
            UC_main uc = new UC_main();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }
    }

    public class User_type
    {
        public static string user_type = "Admin";
        // Receptionist
        // Technician
        // Customer
        // Admin
        public static string user_name = "Innis Yu";
    }
}
