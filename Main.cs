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
using miniSys0._3.Controls.Navmenu;

namespace miniSys0._3
{

    public partial class Main : Form
    {
        public static Main main;
        private Point mPoint;
        private static FormFloating uniqueInstance;
        private SearchBox searchBox_instance = null;
        public bool ifViewProfileExist = false;
        public List<dynamic> messagesList = new List<dynamic>();
        private bool ifReciveNewMessage;
        private MessageBoxForm messageBox_instance = null;

        public Main()
        {
            InitializeComponent();
            main = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitCef();
            InitProfile();
            InitReader();
            

            Init_search_box();
            checkMessage();
            //show_message();

            InitTheme();

            //left bat
            addNavMenu();
            searchBox.Hide();
            //topbar
            randomLogoColor();

            //insert data to js to prepare first time load
            prepareData();

            // main area loading

            add_UC_Mainto_Panel();
            //add_UC_UserInfo();
            //add_UC_UserSetting();
            //add_UC_registration();
            //add_UC_Payment();
            //add_task_cards();
            //add_task_table();
            //add_Cus_OrderDetails();
            //add_UC_ServiceReport();
            //add_UC_IncomeAnalysis();
            //add_UC_Cus_dashboard();



        }
       
        private void InitCef()
        {
            if (!User_type.ifCefInit)
            {
                var setting = new CefSettings();
                setting.MultiThreadedMessageLoop = true;
                CefSharp.Cef.Initialize(setting);
                User_type.ifCefInit = true;
            }
        }


        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(18, 31, 43);
                panelTop.BackColor = Color.FromArgb(28, 47, 70);
                label1.ForeColor = Color.White;
                uiUserControl1.BackColor = Color.FromArgb(28, 47, 70);
                uiUserControl1.FillColor = Color.FromArgb(28, 47, 70);
                uiUserControl1.RectColor = Color.FromArgb(28, 47, 70);
                copyRight.ForeColor = Color.FromArgb(22, 93, 255);

                //uiUserControl2.BackColor = Color.FromArgb(28, 47, 70);
                navMenuPanel.BackColor = Color.FromArgb(28, 47, 70);
                
            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.FromArgb(247, 248, 250);
                panelTop.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                uiUserControl1.BackColor = Color.White;
                uiUserControl1.FillColor = Color.White;
                uiUserControl1.RectColor = Color.Gainsboro;
                copyRight.ForeColor = Color.Black;

                //uiUserControl2.BackColor = Color.FromArgb(28, 47, 70);
                navMenuPanel.BackColor = Color.White;
            }
            set_notice_color();
        }
        

        private void InitReader()
        {
            Reader reader = new Reader();
        }
        

        private void InitProfile()
        {
            this.profile.Text = User_type.user_name.Substring(0, 1);
            searchBox.Visible = false;
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

                if (searchBox_instance != null)
                {
                    searchBox_instance.Location = new Point(this.Location.X + 615 + e.X - mPoint.X, this.Location.Y + 50 + e.Y - mPoint.Y);
                }

                if (messageBox_instance != null)
                {
                    messageBox_instance.Location = new Point(this.Location.X + 877 + e.X - mPoint.X, this.Location.Y + 68 + e.Y - mPoint.Y);
                }
            }
            
        }
        

        private void profile_Click(object sender, EventArgs e)
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new FormFloating();
                int PositionX = this.Location.X;
                int PositionY = this.Location.Y;
                uniqueInstance.StartPosition = FormStartPosition.Manual;
                uniqueInstance.Location = (Point)new Size(PositionX + 1080, PositionY + 68);

                hideOtherControls();

                uniqueInstance.Visible =true;
            }
            else if  (uniqueInstance.Visible == false)
            {
                hideOtherControls();
                uniqueInstance.Visible = true;
            }
            else if (uniqueInstance.Visible == true)
            {
                uniqueInstance.Visible = false;
            }

        }


        private void searchIcon_Click(object sender, EventArgs e)
        {
            searchBox.RectColor = Color.FromArgb(187, 191, 196);
            if (searchBox.Visible && searchBox.Text == "")
            {
                searchBox.Visible = false;
                searchBox_instance.Visible = false;
                empty_search_box_content();

            }
            else if (searchBox.Visible && searchBox.Text == "Type here to search")
            {
                searchBox.Visible = false;
                searchBox_instance.Visible = false;
                empty_search_box_content();
            }
            else if(!searchBox.Visible)
            {
                hideOtherControls();
                searchBox.Visible = true;
                searchBox.Focus();
                show_search();
            }
            
        }
        

        private void empty_search_box_content()
        {
            SearchBox.Instance.uiLabel1.Text = "Go to page";
            SearchBox.Instance.uiLabel4.Text = "Search customer:" ;
            SearchBox.Instance.uiLabel2.Text = "Search staff:"  ;
            SearchBox.Instance.uiLabel3.Text = "Search order:" ;
        }


        private void search_enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
            show_search();
        }


        private void search_leave(object sender, EventArgs e)
        {
            searchBox.Text = "Type here to search";
        }
        

        private void Init_search_box()
        {
            SearchBox searchBoxForm = new SearchBox();
            searchBox_instance = searchBoxForm;
        }


        private void show_search()
        {
            int PositionX = this.Location.X;
            int PositionY = this.Location.Y;
            searchBox_instance.StartPosition = FormStartPosition.Manual;
            searchBox_instance.Location = (Point)new Size(PositionX + 615, PositionY + 50);
            searchBox_instance.Visible = true;    
        }


        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            navMenuPanel.Controls.Clear();
            navMenuPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        

        private void addNavMenu()
        {
            /*UC_Test uc = new UC_Test();
            addUserControl(uc);*/


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
        

        private void randomLogoColor()
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

            if (User_type.user_theme == "dark")
            {
                Content += "; theme = 'dark';";
            }
            else
            {
                Content += "; theme = 'light';";
            }

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


        public void prepareData()
        {
            List<int> weekOrderNum = UC_main.getOneWeekOrderNum();
            List<int> monthOrderNRatio = UC_main.getOnemonthratio();
            writeDataToJsFIle("lineChart",weekOrderNum);
            writeDataToJsFIle("pieChart",monthOrderNRatio);
        }


        #region
        public string currentMainPage;

        private void addUserControlToMain(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void add_UC_Mainto_Panel()
        {

            if (User_type.user_deparment == "Customer")
            {
                UC_Cus_dashboard uc = new UC_Cus_dashboard();
                addUserControlToMain(uc);
            }
            else
            {
                UC_main uc = new UC_main();
                addUserControlToMain(uc);
            }
            currentMainPage = "UC_main";
        }

        public void  add_UC_UserInfo()
        {
            UC_UserInfo uc = new UC_UserInfo();
            addUserControlToMain(uc);
            currentMainPage = "UC_UserInfo";
        }

        public void add_UC_UserSetting()
        {
            UC_UserSetting uc = new UC_UserSetting();
            addUserControlToMain(uc);
            currentMainPage = "UC_UserSetting";
        }
        public void add_UC_registration()
        {
            UC_Registration uc = new UC_Registration();
            addUserControlToMain(uc);
            currentMainPage = "UC_Registration";
        }
        public void add_UC_Payment()
        {
            UC_Payment uc = new UC_Payment();
            addUserControlToMain(uc);
            currentMainPage = "UC_Payment";
        }

        public void  add_task_cards()
        {
            UC_TaskCards uc = new UC_TaskCards();
            addUserControlToMain(uc);
            currentMainPage = "UC_TaskCards";
        }

        public void add_Cus_OrderDetails()
        {
            UC_Cus_OrderDetails uc = new UC_Cus_OrderDetails();
            addUserControlToMain(uc);
            currentMainPage = "UC_Cus_OrderDetails";
        }

        public void add_UC_ServiceReport()
        {
            UC_ServiceReport uc = new UC_ServiceReport();
            addUserControlToMain(uc);
            currentMainPage = "UC_ServiceReport";
        }

        public void add_UC_IncomeAnalysis()
        {
            UC_IncomeAnalysis uc = new UC_IncomeAnalysis();
            addUserControlToMain(uc);
            currentMainPage = "UC_IncomeAnalysis";
        }

        public void add_UC_Cus_dashboard()
        {
            UC_Cus_dashboard uc = new UC_Cus_dashboard();
            addUserControlToMain(uc);
            currentMainPage = "UC_Cus_dashboard";
        }

        public void add_task_table()
        {
            UC_TaskList uc = new UC_TaskList();
            addUserControlToMain(uc);
            currentMainPage = "UC_TaskList";
        }
        #endregion

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            if (User_type.user_theme == "light")
            {
                User_type.user_theme = "dark";
                prepareData();
                InitTheme();
                lodaNewMainPage(currentMainPage);
                addNavMenu();
                InitOtherPageTheme();
            }
            else if (User_type.user_theme == "dark")
            {
                User_type.user_theme = "light";
                prepareData();
                InitTheme();
                lodaNewMainPage(currentMainPage);
                addNavMenu();
                InitOtherPageTheme();
            } 
        }
        

        private void InitOtherPageTheme()
        {
            SearchBox.Instance.InitTheme();

            if (ifViewProfileExist)
            {
                ViewProfile.Instance.InitTheme();
            }
        }
        

        private void lodaNewMainPage(string currentControlStr)
        {
            Console.WriteLine(currentControlStr);
            if (currentControlStr == ("UC_main"))
            {
                add_UC_Mainto_Panel();
            }
            else if(currentControlStr == ("UC_UserInfo"))
            {
                add_UC_UserInfo();
            }
            else if (currentControlStr == ("UC_UserSetting"))
            {
                add_UC_UserSetting();
            }
            else if (currentControlStr == ("UC_Registration"))
            {
                add_UC_registration();

            }
            else if (currentControlStr == ("UC_Payment"))
            {
                add_UC_Payment();
            }
            else if (currentControlStr == ("UC_TaskCards"))
            {
                add_task_cards();
            }
            else if (currentControlStr == ("UC_Cus_OrderDetails"))
            {
                add_Cus_OrderDetails();
            }
            else if (currentControlStr == ("UC_ServiceReport"))
            {
                add_UC_ServiceReport();

            }
            else if (currentControlStr == ("UC_IncomeAnalysis"))
            {
                add_UC_IncomeAnalysis();
            }
            else if (currentControlStr == ("UC_Cus_dashboard"))
            {
                add_UC_Cus_dashboard(); 
            }
            else if (currentControlStr == ("UC_TaskList"))
            {
                add_task_table();
            }
        }


        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchBox.RectColor = Color.FromArgb(187, 191, 196);
            if (!searchBox_instance.Visible )
            {
                searchBox_instance.Visible = true;
            }
            if (searchBox.Text!= "Type here to search")
            {
                SearchBox.Instance.uiLabel1.Text = "Go to page: " + searchBox.Text;
                SearchBox.Instance.uiLabel2.Text = "Search customer: " + searchBox.Text;
                SearchBox.Instance.uiLabel3.Text = "Search staff: " + searchBox.Text;
                SearchBox.Instance.uiLabel4.Text = "Search order: " + searchBox.Text;
            }
            
        }
    
        
        public void checkMessage()
        {
            Init_message_data();

            if (messagesList.Count >0)
            {
                ifReciveNewMessage =  true;
                set_notice_color();
            }
            else
            {
                ifReciveNewMessage = false;
                set_notice_color();
            }
        }


        private void Init_message_data()
        {
            messagesList.Clear();
            string sql_messageToall = "SELECT　Message,Type,Time,SenderID_cus,receiverID_cus,Status　FROM  Messages " +
    "WhERE Type ='@all' AND Status = 0  Order By Time DESC ;";
            dynamic[] data1 = SQLCursor.Query(sql_messageToall);

            addMessageTolist(data1);

            string reciverType = "";
            if (User_type.user_deparment == "Customer")
            {
                reciverType = "receiverID_cus";
            }
            else
            {
                reciverType = "receiverID_sta";
            }

            string sql2 = $"SELECT　Message,Type,Time,SenderID_cus,SenderID_sta,Status　" +
                $"FROM  Messages WhERE Type ='message' " +
                $"AND Status = 0 AND {reciverType} = '{User_type.user_ID}'  Order By Time DESC;";
            dynamic[] data2 = SQLCursor.Query(sql2);
            addMessageTolist(data2);

            string sql3 = $"SELECT　Message,Type,Time,SenderID_cus,SenderID_sta,Status　" +
                $"FROM  Messages WhERE Type ='message' " +
                $"AND Status = 1 AND {reciverType} = '{User_type.user_ID}'  Order By Time DESC;";
            dynamic[] data3 = SQLCursor.Query(sql3);
            addMessageTolist(data3);
        }
        

        private void set_notice_color()
        {
            if (ifReciveNewMessage)
            {
                message.FillColor = Color.FromArgb(245, 63, 63);
                message.FillHoverColor = Color.Red;
            }
            else
            {
                message.FillColor = Color.White;
                message.FillHoverColor = Color.FromArgb(242, 243, 245);
            }
        }


        private void addMessageTolist(dynamic messages)
        {
            try
            {
                string res = messages[0][0];
                for (int i = 0; i < messages.Length; i++)
                {
                    if (messages[i].Length != 0)
                    {
                        messagesList.Add(messages[i]);
                    } 
                }
            }
            catch
            {
                if (messages.Length != 0)
                {
                    messagesList.Add(messages);
                }
               
            }
        }


        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            if (messageBox_instance == null)
            {
                messageBox_instance = new MessageBoxForm();
                int PositionX = this.Location.X;
                int PositionY = this.Location.Y;
                messageBox_instance.StartPosition = FormStartPosition.Manual;
                messageBox_instance.Location = (Point)new Size(PositionX + 877, PositionY + 68);

                messageBox_instance.Init(messagesList);

                hideOtherControls();
                messageBox_instance.Visible = true;
            }
            else if (messageBox_instance.Visible == false)
            {
                messageBox_instance.Init(messagesList);

                hideOtherControls();
                messageBox_instance.Visible = true;


            }
            else if (messageBox_instance.Visible == true)
            {
                messageBox_instance.Visible = false;
            }
        }
        

        private void hideOtherControls()
        {  
            if (uniqueInstance != null && uniqueInstance.Visible)
            {
                uniqueInstance.Visible = false;
            }

            if (searchBox_instance != null && searchBox_instance.Visible)
            {
                searchBox_instance.Visible = false;
                searchBox.Visible = false;
            }

            if (messageBox_instance != null && messageBox_instance.Visible)
            {
                messageBox_instance.Visible = false;
            }
        }
    }


}
