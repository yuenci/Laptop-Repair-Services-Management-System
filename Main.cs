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
            //initShortcut();

            randomLogoColor();
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

                if (uniqueInstance != null)
                {
                    uniqueInstance.Location = new Point(this.Location.X + 1090 + e.X - mPoint.X, this.Location.Y + 65 + e.Y - mPoint.Y);
                }
            }
            
        }
        private static ProfileFloating uniqueInstance;
        private void profile_Click(object sender, EventArgs e)
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ProfileFloating();
                int PositionX = this.Location.X;
                int PositionY = this.Location.Y;
                uniqueInstance.StartPosition = FormStartPosition.Manual;
                uniqueInstance.Location = (Point)new Size(PositionX + 1090, PositionY + 65);
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

        void initShortcut()
        {
            /*void addUserControl(UserControl userControl)
            {
                userControl.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(userControl);
                userControl.BringToFront();
            }*/

            if (User_type.user_type == "Receptionist")
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
    }

    public class User_type
    {
        public static string user_type = "Customer";
        // Receptionist
        // Technician
        // Customer
        // Admin
        public static string user_name = "Innis Yu";
        public static string post = "CEO";
        public static Color LogoFore = Color.Black;
        public static Color LogoBkg = Color.FromArgb(70, 141, 255);
    }
}
