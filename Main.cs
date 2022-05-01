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
using System.IO;
using miniSys0._3.Controls.MainArea;
using CefSharp.WinForms;

namespace miniSys0._3
{

    public partial class Main : Form
    {
        public static Main main;
        public Main()
        {
            InitializeComponent();
            main = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitCef();


            //left bat
            addNavMenu();
            searchBox.Hide();
            //topbar
            randomLogoColor();

            //insert data to js to prepare first time load
            prepareData();

            // main area loading

            //add_UC_Mainto_Panel();
            //add_UC_UserInfo();
            //add_UC_UserSetting();
            //add_UC_registration
            //add_UC_Payment();
            //add_task_cards();
            //add_Cus_OrderDetails();
            //add_UC_ServiceReport();
            add_UC_IncomeAnalysis();




        }
        Point mPoint;
        private void InitCef()
        {
            var setting = new CefSettings();
            setting.MultiThreadedMessageLoop = true;
            CefSharp.Cef.Initialize(setting);
        }

        private void drag_down(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void drag_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);

                if (uniqueInstance != null)
                {
                    uniqueInstance.Location = new Point(this.Location.X + 1080 + e.X - mPoint.X, this.Location.Y + 68 + e.Y - mPoint.Y);
                }
            }
            
        }
        private static FormFloating uniqueInstance;
        private void profile_Click(object sender, EventArgs e)
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new FormFloating();
                int PositionX = this.Location.X;
                int PositionY = this.Location.Y;
                uniqueInstance.StartPosition = FormStartPosition.Manual;
                uniqueInstance.Location = (Point)new Size(PositionX + 1080, PositionY + 68);
                uniqueInstance.Show();
            }
            else
            {
                uniqueInstance.Close();
                uniqueInstance = null;
            }

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

            label33.Text = "\ue902 Dashboard";
            label33.Font = new Font(IconfontHelper.PFCC.Families[0], 20);


            foreach (TreeNode item in NavMenu.Nodes)
            {
                item.Text = "lala";
            }
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
            if (User_type.user_deparment == "Receptionist")
            {
                UC_R_Navmenu uc = new UC_R_Navmenu();
                addUserControl(uc);
            }
            else if (User_type.user_deparment == "Technician")
            {
                UC_T_Navmenu uc = new UC_T_Navmenu();
                addUserControl(uc);
            }
            else if (User_type.user_deparment == "Customer")
            {
                UC_C_Navmenu uc = new UC_C_Navmenu();
                addUserControl(uc);
            }
            else if (User_type.user_deparment == "Admin")
            {
                UC_A_Navmenu uc = new UC_A_Navmenu();
                addUserControl(uc);
            }
        }

        

        void initShortcut()
        {
            /*void addUserControl(UserControl userControl)
            {
                userControl.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(userControl);
                userControl.BringToFront();
            }*/

            /*if (User_type.user_type == "Receptionist")
            {
                UC_R_Shortcut uc = new UC_R_Shortcut();
                addUserControl(uc);
            }
            else if (User_type.user_type == "Technician")
            {
                UC_T_Shortcut uc = new UC_T_Shortcut();
                addUserControl(uc);
            }
            else if (User_type.user_type == "Customer")
            {
                UC_C_Shortcut uc = new UC_C_Shortcut();
                addUserControl(uc);
            }
            else if (User_type.user_type == "Admin")
            {
                UC_A_Shortcut uc = new UC_A_Shortcut();
                addUserControl(uc);
            }
*/
        }
        void randomLogoColor()
        {
            Color[] colorListR = { //6

                ColorTranslator.FromHtml("#F53F3F") , //red
                ColorTranslator.FromHtml("#F77234") , //orange
                ColorTranslator.FromHtml("#FF7D00") , //orange
                //pink
                ColorTranslator.FromHtml("#551DB0") ,
                ColorTranslator.FromHtml("#B010B6"),
                ColorTranslator.FromHtml("#F5319D") ,
             };
            Color[] colorListG = { //5

                //yellow
                ColorTranslator.FromHtml("#9FDB1D"), //yellow
                ColorTranslator.FromHtml("#FADC19") , //yellow
                //green
                ColorTranslator.FromHtml("#FF0000"), //green
                ColorTranslator.FromHtml("#00B42A") , //green
                ColorTranslator.FromHtml("#14C9C9"), //green

                //grey
                ColorTranslator.FromHtml("#86909C")
            };
            Color[] colorListB = { //2

                //blue
                ColorTranslator.FromHtml("#3491FA") ,
                ColorTranslator.FromHtml("#0E42D2"),
            };


            dynamic[] colorList2D = { colorListR , colorListG, colorListB };

            int checkNum(int num)
            {
                int maxNum = -1;
                if (num == 0 || num == 1)
                {
                    maxNum = 6;
                }
                else
                {
                    maxNum = 2;
                }
                return maxNum;
            }

            //LogoFore
            int randomNumber1;
            int randomNumber2;

            Random r1 = new Random();
            randomNumber1 = r1.Next(0, 2);

            Random r2 = new Random();
            randomNumber2 = r2.Next(1, checkNum(randomNumber1));

            User_type.LogoFore = colorList2D[randomNumber1][randomNumber2];

            //LogoBkg
            int randomNumber3;
            int randomNumber4;
            while (true)
            {
                Random r3 = new Random();
                randomNumber3 = r3.Next(0, 2);

                if (randomNumber3!= randomNumber1)
                {
                    break;
                }
            }
            Random r4 = new Random();
            randomNumber4 = r4.Next(1, checkNum(randomNumber3));

            User_type.LogoBkg = colorList2D[randomNumber3][randomNumber4];

            profile.ForeColor = User_type.LogoFore;
            profile.FillColor = User_type.LogoBkg;
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void writeDataToJsFIle(string type, List<int> parameter)
        {
            string fileName = "";
            string Content = "dataset = [";
            if (type == "lineChart")
            {
                fileName = "parameterForLineChart.js";
                for (int i = 6; i >=0; i--)
                {
                    string part = $"{{x: {i + 1},y: {parameter[i]}}},";
                    Content += part;
                }
            } 
            else if (type == "pieChart")
            {
                fileName = "parameterForPieChart.js";
                for (int i = 0; i < parameter.Count; i++)
                {
                    Content += $"{parameter[i]},";
                }
            }
            Content += "]";
            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")) + $"Html\\{fileName}";
            //empty old js file
            FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite);
            fs.Close();
            // add new 
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path, true, System.Text.Encoding.Default);
            sw.Write(Content);
            sw.Close();
            sw.Dispose();
        }

        private void prepareData()
        {
            List<int> weekOrderNum = UC_main.getOneWeekOrderNum();
            List<int> monthOrderNRatio = UC_main.getOnemonthratio();
            writeDataToJsFIle("lineChart",weekOrderNum);
            writeDataToJsFIle("pieChart",monthOrderNRatio);
        }

        #region
        private void add_UC_Mainto_Panel()
        {
            UC_main uc = new UC_main();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void  add_UC_UserInfo()
        {
            UC_UserInfo uc = new UC_UserInfo();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void add_UC_UserSetting()
        {
            UC_UserSetting uc = new UC_UserSetting();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void add_UC_registration()
        {
            UC_Registration uc = new UC_Registration();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }
        private void add_UC_Payment()
        {
            UC_Payment uc = new UC_Payment();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();

        }

        private void  add_task_cards()
        {
            UC_TaskCards uc = new UC_TaskCards();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void add_Cus_OrderDetails()
        {
            UC_Cus_OrderDetails uc = new UC_Cus_OrderDetails();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void add_UC_ServiceReport()
        {
            UC_ServiceReport uc = new UC_ServiceReport();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }

        private void add_UC_IncomeAnalysis()
        {
            UC_IncomeAnalysis uc = new UC_IncomeAnalysis();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }
        #endregion
    }


}
