using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3
{
    public partial class SearchBox : UIForm
    {
        public static SearchBox Instance;
        private Color userControlBgcColor = Color.Transparent;
        private Color userControlHoverColor = Color.FromArgb(115, 179, 255);
        public SearchBox()
        {
            Instance = this;
            InitializeComponent();
            InitTheme();
            InitEvent();
        }
        
        public void InitTheme()
        {

            dynamic[] userControls = { uiUserControl1, uiUserControl4, uiUserControl2, uiUserControl3 };
            dynamic[] icons = { uiAvatar1, uiAvatar4, uiAvatar2, uiAvatar3 };
            dynamic[] texts = { uiLabel1, uiLabel4, uiLabel2, uiLabel3 };
            dynamic[] lines = { uiLine1, uiLine2, uiLine3 };

            Color userControlRectColor = Color.Transparent;
            Color userControlFillColor = Color.Transparent;
            Color symbleColor = Color.Black;
            Color fontColor = Color.Black;
            Color lineFillColor = Color.Transparent;
            Color LineColor = Color.Gainsboro;

            if (User_type.user_theme == "light")
            {
                this.BackColor = Color.White;

                userControlRectColor = Color.Transparent;
                userControlFillColor = Color.Transparent;

                symbleColor = Color.Black;
                fontColor = Color.Black;
                lineFillColor = Color.Transparent;
                LineColor = Color.Gainsboro;

                userControlHoverColor= Color.FromArgb(115, 179, 255);
                userControlBgcColor = Color.White;
            }
            else if (User_type.user_theme == "dark")
            {
                //userControlBgcColor = Color.FromArgb(55, 55, 57);
                userControlBgcColor = Color.FromArgb(55, 55, 57);

                symbleColor = Color.FromArgb(22, 93, 255);
                fontColor = Color.White;
                this.BackColor = Color.FromArgb(55, 55, 57);
                this.rectColor = Color.Transparent;
                LineColor = Color.FromArgb(28, 47, 70);

            }

            foreach (var item in userControls)
            {
                item.RectColor = userControlRectColor;
                item.FillColor = userControlFillColor;
            }

            foreach (var item in icons)
            {
                item.ForeColor = symbleColor;
                item.FillColor = Color.Transparent;
            }

            foreach (var item in texts)
            {
                item.ForeColor = fontColor;
            }

            foreach (var item in lines)
            {
                item.FillColor = lineFillColor;
                item.LineColor = LineColor;
            }
        }

        private void userControl_hover(object sender, EventArgs e)
        {

            if (sender.Equals(uiUserControl1) || sender.Equals(uiAvatar1)|| sender.Equals(uiLabel1))
            {
                uiUserControl1.FillColor = userControlHoverColor;
            }
            else if (sender.Equals(uiUserControl2) || sender.Equals(uiAvatar2) || sender.Equals(uiLabel2))
            {
                uiUserControl2.FillColor = userControlHoverColor;
            }
            else if (sender.Equals(uiUserControl3) || sender.Equals(uiAvatar3) || sender.Equals(uiLabel3))
            {
                uiUserControl3.FillColor = userControlHoverColor;
            }
            else if (sender.Equals(uiUserControl4) || sender.Equals(uiAvatar4) || sender.Equals(uiLabel4))
            {
                uiUserControl4.FillColor = userControlHoverColor;
            }
        }


        private void userControl_leave(object sender, EventArgs e)
        {

            if (sender.Equals(uiUserControl1))
            {
                uiUserControl1.FillColor = userControlBgcColor;
            }
            else if (sender.Equals(uiUserControl2))
            {
                uiUserControl2.FillColor = userControlBgcColor;
            }
            else if (sender.Equals(uiUserControl3))
            {
                uiUserControl3.FillColor = userControlBgcColor;
            }
            else if (sender.Equals(uiUserControl4))
            {
                uiUserControl4.FillColor = userControlBgcColor;
            }
        }


        private void userControl_click(object sender, EventArgs e)
        {
            if (Main.main.searchBox.Text  == "" || Main.main.searchBox.Text == "Type here to search")
            {
                Main.main.searchBox.RectColor = Color.Red;
            }

            else if (sender.Equals(uiUserControl1) || sender.Equals(uiAvatar1) || sender.Equals(uiLabel1))
            {
                clickEvent(1);
            }
            else if (sender.Equals(uiUserControl2) || sender.Equals(uiAvatar2) || sender.Equals(uiLabel2))
            {
                clickEvent(2);
            }
            else if (sender.Equals(uiUserControl3) || sender.Equals(uiAvatar3) || sender.Equals(uiLabel3))
            {
                clickEvent(3);
            }
            else if (sender.Equals(uiUserControl4) || sender.Equals(uiAvatar4) || sender.Equals(uiLabel4))
            {
                clickEvent(4);
            }
        }


        private void InitEvent()
        {
            dynamic[] userControls = { uiUserControl1, uiUserControl4, uiUserControl2, uiUserControl3 };

            foreach (var item in userControls)
            {
                item.MouseHover += new EventHandler(userControl_hover);
                item.MouseLeave += new EventHandler(userControl_leave);
                item.Click += new EventHandler(userControl_click);
            }

            dynamic[] icons_texts = { uiAvatar1, uiAvatar4, uiAvatar2, uiAvatar3 , uiLabel1, uiLabel4, uiLabel2, uiLabel3 };
            foreach(var item in icons_texts)
            {
                item.MouseHover += new EventHandler(userControl_hover);
                item.Click += new EventHandler(userControl_click);
            }
        }


        private void clickEvent(int num)
        {
            string content = Main.main.searchBox.Text.ToLower();
            if (num==1)
            {
                if (content == "user info" || content == "profile" || content == "info")
                {
                    Main.main.add_UC_UserInfo();
                    empty_hide_search_box();
                }
                else if (content.Contains("setting"))
                {
                    Main.main.add_UC_UserSetting();
                    empty_hide_search_box();
                }
                else if (User_type.user_deparment == "Receptionist")
                {
                    if (content == "dashboard" || content == "workbench")
                    {
                        Main.main.add_UC_Mainto_Panel();
                    }
                    else if (content.Contains("regist"))
                    {
                        Main.main.add_UC_registration();
                        empty_hide_search_box();
                    }
                    else if (content.Contains("payment"))
                    {
                        Main.main.add_UC_Payment();
                        empty_hide_search_box();
                    }
                    else
                    {
                        MessageBox.Show($"page {content} doesn't exist");
                    }
                }
                else if (User_type.user_deparment == "Technician")
                {
                    if (content == "dashboard" || content == "workbench")
                    {
                        Main.main.add_UC_Mainto_Panel();
                        empty_hide_search_box();
                    }
                    else if (content.Contains("list"))
                    {
                        Main.main.add_task_table();
                        empty_hide_search_box();
                    }
                    else if (content.Contains("card"))
                    {
                        Main.main.add_task_cards();
                        empty_hide_search_box();
                    }
                    else
                    {
                        MessageBox.Show($"Page {content} doesn't exist");
                    }
                }
                else if (User_type.user_deparment == "Customer")
                {
                    if (content == "dashboard" || content == "workbench")
                    {
                        Main.main.add_UC_Cus_dashboard();
                        empty_hide_search_box();
                    }
                    else if (content.Contains("order"))
                    {
                        Main.main.add_Cus_OrderDetails();
                        empty_hide_search_box();
                    }
                    else
                    {
                        MessageBox.Show($"page {content} doesn't exist");
                    }
                }
                else if (User_type.user_deparment == "Admin")
                {
                    if (content == "dashboard" || content == "workbench")
                    {
                        Main.main.add_UC_Mainto_Panel();
                        empty_hide_search_box();
                    }
                    else if (content.Contains("regist"))
                    {
                        Main.main.add_UC_registration();
                        empty_hide_search_box();
                    }
                    else if (content=="service report" ||  content.Contains("report"))
                    {
                        Main.main.add_UC_ServiceReport();
                        empty_hide_search_box();
                    }
                    else if (content == "income analysis" || content.Contains("income"))
                    {
                        Main.main.add_UC_IncomeAnalysis();
                        empty_hide_search_box();
                    }
                    else
                    {
                        MessageBox.Show($"page {content} doesn't exist");
                    }
                }
            }
            else if (num==2)
            {
                
                string targetUserID = formatInput(content,"customer");
                string ifallowSearch = UserSettings.GetSettingsValue(targetUserID, "allowSearch");
                string ifPrivateMode = UserSettings.GetSettingsValue(targetUserID, "privateMode");

                //Console.WriteLine($"ifallowSearch:{ifallowSearch}");
                //Console.WriteLine($"ifPrivateMode:{ifPrivateMode}");


                if (targetUserID != null)
                {
                    if (ifallowSearch == "Off" || ifPrivateMode == "On")
                    {
                        MessageBox.Show($"{content} doesn't exist");
                    }
                    else
                    {
                        ViewProfile viewProfile = new ViewProfile();
                        viewProfile.ShowInTaskbar = false;
                        viewProfile.InitCus(targetUserID);
                        empty_hide_search_box();
                        viewProfile.Show();
                    }
                }
                
            }
            else if (num==3)
            {
              
                string targetUserID = formatInput(content, "staff");
                string ifallowSearch = UserSettings.GetSettingsValue(targetUserID, "allowSearch");
                string ifPrivateMode = UserSettings.GetSettingsValue(targetUserID, "privateMode");

                /*Console.WriteLine($"ifallowSearch:{ifallowSearch}");
                Console.WriteLine($"ifPrivateMode:{ifPrivateMode}");*/
                //Console.WriteLine(targetUserID);

                if (targetUserID != null)
                {
                    if (ifallowSearch == "Off" || ifPrivateMode == "On")
                    {
                        MessageBox.Show($"{content} doesn't exist");
                    }
                    else
                    {
                        ViewProfile viewProfile = new ViewProfile();
                        viewProfile.ShowInTaskbar = false;
                        viewProfile.InitStaff(targetUserID);
                        empty_hide_search_box();
                        viewProfile.Show();
                    }
                }
            }
            else if (num==4)
            {
                if (User_type.user_deparment =="Customer")
                {
                    string target = formatOrder(content);
                    if (target != null)
                    {
                        string cusID = SQLCursor.Query("SELECT CustomerID FROM Orders " +
                            $"WHERE OrderID = '{target}';")[0];
                        if (cusID == User_type.user_ID)
                        {
                            OrderDetails orderDetails = new OrderDetails();
                            orderDetails.Init(target);
                            empty_hide_search_box();
                            orderDetails.Show();
                        }
                        else
                        {
                            MessageBox.Show("Insufficient authority");
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show($"Order {content} doesn't exist");
                    }
                }
                else
                {
                    string target = formatOrder(content);
                    //Console.WriteLine(target);
                    if (target!=null)
                    {
                        OrderDetails orderDetails = new OrderDetails();
                        orderDetails.Init(target);
                        empty_hide_search_box();
                        orderDetails.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Order {content} doesn't exist");
                    }
                }
            }
        }


        private void empty_hide_search_box()
        {
            this.Visible = false;
            uiLabel1.Text = "Go to page";
            uiLabel2.Text = "Search customer:";
            uiLabel3.Text = "Search staff:";
            uiLabel4.Text = "Search order:";
        }
        

        private dynamic formatInput(string str, string type)
        {
            // return null / useID(11)
            //type = customer, staff
            int IDnum = 0;

            //all number
            if (int.TryParse(str, out IDnum))
            {
                if (str.Length < 7)
                {
                    if (type == "customer")
                    {
                        return "Cus" + str.PadLeft(6, '0');
                    }
                    else if (type == "staff")
                    {
                        return "Sta" + str.PadLeft(6, '0');
                    }
                }
                else
                {
                    return null;
                }
            }
            //all string or string+number
            else
            {
  
                // length == 9 and have sta/cus
                if (str.Length == 9 && int.TryParse(str.Substring(3, 6), out IDnum))
                {
                    
                    if (str.Substring(0, 3).ToLower() == "sta")
                    {
                        return "Sta" + str.Substring(3, 6); ;
                    }
                    else if ( str.Substring(0, 3).ToLower() == "cus")
                    {
                        return "Cus" + str.Substring(3, 6); ;
                    }
                }
                else
                {
                    string sql = "";
                    if (type == "customer")
                    {
                        sql = $"SELECT CustomerID FROM Customer WHERE Name = '{str}';";
                    }
                    else if (type == "staff")
                    {
                        sql = $"  SELECT StaffID FROM Staff WHERE Name = '{str}';";
                    }
                    dynamic[] data = SQLCursor.Query(sql);
                    if (data.Length == 0)
                    {
                        return null;
                    }
                    else
                    {
                        Console.WriteLine(data[0]);
                        return data[0];
                    }
                }
            }
            return null;
        }


        private dynamic formatOrder(string str)
        {
            int num =0;

            //all num
            if (int.TryParse(str,out num))
            {
                if (str.Length<=8)
                {
                    string  idStr  = str.PadLeft(8, '0');
                    string sql = $"SELECT OrderID FROM Orders WHERE OrderID = 'Ord{idStr}';";
                    dynamic[] data = SQLCursor.Query(sql);
                    if (data.Length == 0)
                    {
                        return null;
                    }
                    else
                    {
                        Console.WriteLine(data[0]);
                        return data[0];
                    }
                }
                else
                {
                    return null;
                }
            }
            // all string Or string+num
            else
            {
                if (str.Length == 11 && int.TryParse(str.Substring(3, 8), out num))
                {
                    string start = str.Substring(0, 3).ToLower();
                    if (start == "ord")
                    {
                        string sql = $"SELECT OrderID FROM Orders WHERE OrderID = 'Ord{str.Substring(3, 8)}';";
                        dynamic[] data = SQLCursor.Query(sql);
                        if (data.Length == 0)
                        {
                            return null;
                        }
                        else
                        {
                            Console.WriteLine(data[0]);
                            return data[0];
                        }
                    }
                    
                }
                else
                {
                    return null;
                }
            }

            return null;
        }
    }
}
