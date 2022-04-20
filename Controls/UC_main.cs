using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace miniSys0._3.Controls
{
    public partial class UC_main : UserControl
    {
        public UC_main()
        {
            InitializeComponent();
            InitializeChromeForMainLineChart();
            InitializeChromeForMainPieChart();
            initsunnyUI();
            initNotices();
            initNews();
            initName();
            initDataBanner();
            initShortcut();
        }

        void initsunnyUI()
        {
            upperTriangle.ForeColor = Color.Red;
            upperTriangle.FillColor = Color.Transparent;

            newsTopBar.RectColor = Color.Transparent;
            newsTopBar.FillColor = Color.FromArgb(242, 243, 245);
            news1.MarkColor = Color.FromArgb(242, 243, 245);
            news2.MarkColor = Color.FromArgb(242, 243, 245);
            news3.MarkColor = Color.FromArgb(242, 243, 245);
            news4.MarkColor = Color.FromArgb(242, 243, 245);
            news5.MarkColor = Color.FromArgb(242, 243, 245);

            refreshlButton1.FillColor = Color.White;
            refreshlButton1.FillHoverColor= Color.FromArgb(242, 243, 245);
            refreshlButton1.SymbolColor = Color.Black;
            refreshlButton1.SymbolHoverColor = Color.Black;
            refreshlButton1.SymbolPressColor = Color.Black;
            refreshlButton1.RectColor = Color.Transparent;
            refreshlButton1.RectHoverColor = Color.Transparent;
            refreshlButton1.RectPressColor = Color.Transparent;
            refreshlButton2.FillColor = Color.White;
            refreshlButton2.FillHoverColor = Color.FromArgb(242, 243, 245);
            refreshlButton2.SymbolColor = Color.Black;
            refreshlButton2.SymbolHoverColor = Color.Black;
            refreshlButton2.SymbolPressColor = Color.Black;
            refreshlButton2.RectColor = Color.Transparent;
            refreshlButton2.RectHoverColor = Color.Transparent;
            refreshlButton2.RectPressColor = Color.Transparent;
        }
        private void initName()
        {
            string greet = $"Welcome back，{User_type.user_name}";
            name_lable.Text = greet;
        }
        private dynamic getDataReader(string sql)
        {
            string connStr = @"Data Source=LAPTOP-5ACE008F\SQLEXPRESS;Initial Catalog=CsharpRepairerInc;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //string sql = $"SELECT TOP 5 Title, Views FROM Articles ORDER BY  Views DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dynamic[] connTools = { conn , dr };
            return connTools;
        }

        private List<int> getOneWeekOrderNum()
        {
            string allsql = "";
            for (int i = 0; i < 7; i++)
            {
                var sqlpart = $"select COUNT(*) from Orders where DateDiff(dd,Time,getdate())={i};";
                allsql += sqlpart;
            }
            dynamic[] connTools2 = getDataReader(allsql);
            SqlDataReader dr2 = connTools2[1];
            SqlConnection conn2 = connTools2[0];
            /*if (dr2.Read())
            {
                BannerLabel3.Text = dr2[0].ToString();
                Console.WriteLine(dr2.FieldCount);
                //BannerLabel4.Text = dr2[1].ToString();
            }*/
            List<int> result = new List<int>();
            do
            {
                dr2.Read();
                result.Add(int.Parse(dr2[0].ToString()));
            }
            while (dr2.NextResult());
            dr2.Close();
            conn2.Close();
            return result;
        }
        private void initDataBanner()
        {

            //allOrders
            dynamic[] connTools = getDataReader("SELECT COUNT(*) from Orders");
            SqlDataReader dr = connTools[1];
            SqlConnection conn = connTools[0];
            if (dr.Read())
            {
                BannerLabel1.Text = dr[0].ToString();
            }
            dr.Close();
            conn.Close();

            // servicing
            string sql = "WITH A AS(SELECT DISTINCT OrderID from Schedule WhERE Status = 'Finished'),";
            sql += "B AS(SELECT DISTINCT OrderID from Schedule)";
            sql += "select count(*) from B where (select count(1) as num from A where A.OrderID = B.OrderID) = 0";



            dynamic[] connTools1 = getDataReader(sql);
            SqlDataReader dr1 = connTools1[1];
            SqlConnection conn1 = connTools1[0];
            if (dr1.Read())
            {
                BannerLabel2.Text = dr1[0].ToString();
            }
            dr1.Close();
            conn1.Close();


            //todays and yestordays and a weeks
            List<int> weekOrderNum = getOneWeekOrderNum();
            //today
            int orderToday = weekOrderNum[0];
            BannerLabel3.Text = orderToday.ToString();
            //yesterday
            int orderYesterday = weekOrderNum[1];
            if (orderYesterday> orderToday)
            {
                upperTriangle.Symbol = 67;
                BannerLabel4.Text = (100 * (orderToday - orderYesterday) / orderToday).ToString() + "%";
            }
            else
            {
                BannerLabel4.Text = (100 * (orderToday - orderYesterday) / orderToday).ToString() + "%";
            }


        }
        private void initNews()
        {
            dynamic[] connTools = getDataReader("SELECT TOP 5 Title, Views FROM Articles ORDER BY  Views DESC");
            SqlDataReader dr = connTools[1];
            SqlConnection conn = connTools[0];
            dynamic[] newsList = { news1, news2 , news3 , news4 , news5 };
            dynamic[] newsLableList = { newslabel1, newslabel2, newslabel3, newslabel4, newslabel5 };
            for (int i = 0; dr.Read(); i++)
            {
                var title ="";
                var text = ""; 
                if (dr["Title"].ToString().Length > 30)
                {
                    title = dr["Title"].ToString().Substring(0, 30);
                    text = (i+1).ToString() + "      " + title + "...";
                }
                else
                {
                    title = dr["Title"].ToString();
                    text = (i + 1).ToString() + "      " + title;
                }
                newsList[i].Text = text;
                newsLableList[i].Text = dr["Views"].ToString();
            }
            dr.Close();
            conn.Close();
        }

        void noticeStyle(dynamic noticeObj,string type)
        {
            if (type == "Activity")
            {
                noticeObj.Text = "Activity";
                noticeObj.FillDisableColor = Color.FromArgb(255, 247, 232);
                noticeObj.ForeDisableColor = Color.FromArgb(255, 125, 0);
            }
            else if (type == "Message")
            {
                noticeObj.Text = "Message";
                noticeObj.FillDisableColor = Color.WhiteSmoke;
                noticeObj.ForeDisableColor = Color.FromArgb(15, 198, 194);
            }
            else if (type == "Advice")
            {
                noticeObj.Text = "Advice";
                noticeObj.FillDisableColor = Color.FromArgb(255, 247, 232);
                noticeObj.ForeDisableColor = Color.FromArgb(22, 93, 255);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        void initNotices()
        {
            notice1.RectDisableColor = Color.Transparent;
            notice2.RectDisableColor = Color.Transparent;
            notice3.RectDisableColor = Color.Transparent;
            notice4.RectDisableColor = Color.Transparent;
            notice5.RectDisableColor = Color.Transparent;
            noticeStyle(notice1, "Activity");
            noticeStyle(notice2, "Message");
            noticeStyle(notice3, "Advice");
            noticeStyle(notice4, "Advice");
            noticeStyle(notice5, "Message");
        }
        void initShortcut()
        {
             void addUserControl(UserControl userControl)
            {
                userControl.Dock = DockStyle.Fill;
                ShortcutPanel.Controls.Clear();
                ShortcutPanel.Controls.Add(userControl);
                userControl.BringToFront();
            }

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





        public ChromiumWebBrowser WebBrowser;

        //stop right click
        public class MenuHandler : IContextMenuHandler
        {
            public void OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
            {
                model.Clear();
            }
            public bool OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
            {
                return false;
            }
            public void OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
            {
            }
            public bool RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
            {
                return false;
            }
        }
        private void InitializeChromeForMainLineChart()
        {
            var setting = new CefSettings();
            setting.MultiThreadedMessageLoop = true;
            CefSharp.Cef.Initialize(setting);
            WebBrowser = new ChromiumWebBrowser(@"E:\Materials\【LOOP】\Assignment\miniSys0.3\Html\mainLineChart.html");
            WebBrowser.Dock = DockStyle.Fill;//铺满                                                                  
            WebBrowser.Dock = DockStyle.Fill;//设置停靠方式
            WebBrowser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true; //交互数据
            WebBrowser.MenuHandler = new MenuHandler();//阻止右键
            this.lineChartPanel.Controls.Add(WebBrowser);

            //refreshlButton.PerformClick();

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cef.Shutdown();
        }

        private async void refreshlButton_Click(object sender, EventArgs e)
        {
            await WebBrowser.GetBrowser().MainFrame.EvaluateScriptAsync("show([12, 19, 3, 5, 2, 3])");
        }

        public ChromiumWebBrowser WebBrowser1;
        private void InitializeChromeForMainPieChart()
        {
           /* var setting1 = new CefSettings();
            setting1.MultiThreadedMessageLoop = true;
            CefSharp.Cef.Initialize(setting1);*/
            WebBrowser1 = new ChromiumWebBrowser(@"E:\Materials\【LOOP】\Assignment\miniSys0.3\Html\mainPieChart.html");
            WebBrowser1.Dock = DockStyle.Fill;//铺满                                                                  
            WebBrowser1.Dock = DockStyle.Fill;//设置停靠方式
            WebBrowser1.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true; //交互数据
            WebBrowser1.MenuHandler = new MenuHandler();//阻止右键
            this.pieChartPanel.Controls.Add(WebBrowser1);

            //refreshlButton.PerformClick();

        }

        private async void refreshlButton2_Click(object sender, EventArgs e)
        {
            await WebBrowser1.GetBrowser().MainFrame.EvaluateScriptAsync("show1([12, 19, 3, 5, 2, 3])");
        }

        private void n1_hover(object sender, EventArgs e)
        {
            news1.ForeColor = Color.FromArgb(51, 112, 255);
            newslabel1.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void n2_hover(object sender, EventArgs e)
        {
            news2.ForeColor = Color.FromArgb(51, 112, 255);
            newslabel2.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void n3_hover(object sender, EventArgs e)
        {
            news3.ForeColor = Color.FromArgb(51, 112, 255);
            newslabel3.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void n4_hover(object sender, EventArgs e)
        {
            news4.ForeColor = Color.FromArgb(51, 112, 255);
            newslabel4.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void n5_hover(object sender, EventArgs e)
        {
            news5.ForeColor = Color.FromArgb(51, 112, 255);
            newslabel5.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void n1_leave(object sender, EventArgs e)
        {
            news1.ForeColor = Color.Black;
            newslabel1.ForeColor = Color.Black;

        }

        private void n2_leave(object sender, EventArgs e)
        {
            news2.ForeColor = Color.Black;
            newslabel2.ForeColor = Color.Black;
        }

        private void n3_leave(object sender, EventArgs e)
        {
            news3.ForeColor = Color.Black;
            newslabel3.ForeColor = Color.Black;
        }

        private void n4_leave(object sender, EventArgs e)
        {
            news4.ForeColor = Color.Black;
            newslabel4.ForeColor = Color.Black;
        }

        private void n5_leave(object sender, EventArgs e)
        {
            news5.ForeColor = Color.Black;
            newslabel5.ForeColor = Color.Black;
        }
    }
    
}
