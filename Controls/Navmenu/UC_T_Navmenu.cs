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

namespace miniSys0._3.Controls
{
    public partial class UC_T_Navmenu : UserControl
    {
        public UC_T_Navmenu()
        {
            InitializeComponent();
            NavMenu.ImageList = imageList1;
            InitTheme();
        }
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                // nav have item part bgc
                NavMenu.FillColor = Color.FromArgb(28, 47, 70);

                // the whole bgc
                NavMenu.BackColor = Color.FromArgb(28, 47, 70);

                // the hover bgc
                NavMenu.HoverColor = Color.FromArgb(55, 55, 57);

                // the bgc of choose item
                NavMenu.SelectedColor = Color.FromArgb(55, 55, 57);


                dynamic[] nodeText = { NavMenu.Nodes[0], NavMenu.Nodes[1], NavMenu.Nodes[2] };
                foreach (dynamic node in nodeText)
                {
                    node.ForeColor = Color.White;
                }

                for (int i = 0; i < 3; i++)
                {
                    NavMenu.Nodes[i].ImageIndex = 6 + i;
                    NavMenu.Nodes[i].SelectedImageIndex = 9 + i;
                }
            }
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Main.main.mainPanel.Controls.Clear();
            Main.main.mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void NavMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodeSelect = "";
            if (e.Button == MouseButtons.Left)
            {
                if (e.Node.Level == 1)
                {
                    nodeSelect = e.Node.Text;
                }
            }

            if (nodeSelect == "Workbench")
            {
                UC_main uc = new UC_main();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_main";

            }
            else if (nodeSelect == "List view")
            {
                UC_TaskList uc = new UC_TaskList();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_TaskList";

            }
            else if (nodeSelect == "Card view")
            {
                UC_TaskCards uc = new UC_TaskCards();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_TaskCards";

            }
            else if (nodeSelect == "User info")
            {
                UC_UserInfo uc = new UC_UserInfo();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_UserInfo";

            }
            else if (nodeSelect == "User settings")
            {
                UC_UserSetting uc = new UC_UserSetting();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_UserSetting";

            }
        }


        
    }
}
