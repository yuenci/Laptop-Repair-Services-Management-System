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
            else if (nodeSelect == "Register")
            {
                UC_Registration uc = new UC_Registration();
                addUserControl(uc);
            }
            else if (nodeSelect == "Service report")
            {
                UC_ServiceReport uc = new UC_ServiceReport();
                addUserControl(uc);
            }
            else if (nodeSelect == "Income analysis")
            {
                UC_IncomeAnalysis uc = new UC_IncomeAnalysis();
                addUserControl(uc);
            }
        }
    }
}
