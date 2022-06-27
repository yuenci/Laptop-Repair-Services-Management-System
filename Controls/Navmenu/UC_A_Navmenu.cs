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
                //NavMenu.BackColor = Color.Blue;

                // the hover bgc
                NavMenu.HoverColor = Color.FromArgb(55, 55, 57);

                // the bgc of choose item
                NavMenu.SelectedColor = Color.FromArgb(55, 55, 57);

                //font color
                NavMenu.ForeColor = Color.FromArgb(78, 89, 105);

                for (int i = 0; i < 4; i++)
                {
                    NavMenu.Nodes[i].ImageIndex = 8 +i;
                    NavMenu.Nodes[i].SelectedImageIndex = 12+i;
                }

               
            }
            else if (User_type.user_theme == "light")
            {
                // nav have item part bgc
                NavMenu.FillColor = Color.White;
                
                // the whole bgc
                NavMenu.BackColor = Color.White;

                // the hover bgc
                NavMenu.HoverColor = Color.FromArgb(242, 243, 245);

                // the bgc of choose item
                NavMenu.SelectedColor = Color.FromArgb(242, 243, 245);


                //font color
                NavMenu.ForeColor = Color.FromArgb(78, 89, 105);

                for (int i = 0; i < 4; i++)
                {
                    NavMenu.Nodes[i].ImageIndex = i*2;
                    NavMenu.Nodes[i].SelectedImageIndex = i*2+1;
                }
            }
        }
        
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Main.main.mainPanel.Controls.Clear();
            Main.main.mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
            Main.main.closeCurrentMainPageObj();
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
                Main.main.currentMainPage = "UC_UserInfo";
            }
            else if (nodeSelect == "User settings")
            {
                UC_UserSetting uc = new UC_UserSetting();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_UserSetting";
            }
            else if (nodeSelect == "Workbench")
            {
                UC_main uc = new UC_main();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_main";
            }
            else if (nodeSelect == "Register")
            {
                UC_Registration uc = new UC_Registration();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_Registration";
            }
            else if (nodeSelect == "Post")
            {
                UC_MessageWriter uc = new UC_MessageWriter();
                addUserControl(uc);
                Main.main.currentMainPage = "post_system_message";
            }
            else if (nodeSelect == "Service report")
            {
                UC_ServiceReport uc = new UC_ServiceReport();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_ServiceReport";
            }
            else if (nodeSelect == "Income analysis")
            {
                UC_IncomeAnalysis uc = new UC_IncomeAnalysis();
                addUserControl(uc);
                Main.main.currentMainPage = "UC_IncomeAnalysis";
            }
            else if (nodeSelect == "Price")
            {
                UC_PriceModify uc = new UC_PriceModify();
                addUserControl(uc);
                Main.main.currentMainPage = "Modify_price";
            }
        }
    }
}
