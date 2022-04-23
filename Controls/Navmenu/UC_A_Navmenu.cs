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
    public partial class UC_A_Navmenu : UserControl
    {
        public UC_A_Navmenu()
        {
            InitializeComponent();
            NavMenu.ImageList = imageList1;
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

            if (nodeSelect == "User info")
            {
                UC_UserInfo uc = new UC_UserInfo();
                addUserControl(uc);
            }
            else if (nodeSelect == "User settings")
            {
                UC_UserSetting uc = new UC_UserSetting();
                addUserControl(uc);
            }
            else if (nodeSelect == "Workbench")
            {
                UC_main uc = new UC_main();
                addUserControl(uc);
            }
        }
    }
}
