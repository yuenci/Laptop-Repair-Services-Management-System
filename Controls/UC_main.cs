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
            initReader();
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

            shortcutButton1.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton2.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton3.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton1.SymbolColor  = Color.Black;
            shortcutButton2.SymbolColor = Color.Black;
            shortcutButton3.SymbolColor = Color.Black;
            shortcutButton1.SymbolHoverColor = Color.Black;
            shortcutButton2.SymbolHoverColor = Color.Black;
            shortcutButton3.SymbolHoverColor = Color.Black;

            shortcutButton1.RectColor = Color.Transparent;
            shortcutButton2.RectColor = Color.Transparent;
            shortcutButton3.RectColor = Color.Transparent;

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
        public  static  dynamic getDataReader(string sql)
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

        public static List<int> getOneWeekOrderNum()
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

        public static List<int> getOnemonthratio()
        {
            string allsql = "";
            for (int i = 0; i < 8; i++)
            {
                var sqlpart = $"select COUNT(*) from Orders where month(Time) = month(getdate()) and " +
                    $"year(Time) = year(getdate()) and Service_type = 'Ser00{i+1}';";
                allsql += sqlpart;
            }
            dynamic[] connTools2 = getDataReader(allsql);
            SqlDataReader dr2 = connTools2[1];
            SqlConnection conn2 = connTools2[0];
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


            dynamic[] connTools = getDataReader("select top 5 Title,Type from Articles Order by Time desc");
            SqlDataReader dr = connTools[1];
            SqlConnection conn = connTools[0];

            dynamic[] moticeList = { notice1, notice2, notice3, notice4, notice5 };
            dynamic[] noticeTextList = { noticeText1 , noticeText2, noticeText3, noticeText4 , noticeText5 };

            for (int i = 0; i < 5; i++)
            {
                dr.Read();
                noticeTextList[i].Text = dr[0].ToString().Substring(0,18)+"...";
                if (dr[1].ToString() == "Activity")
                {
                    noticeStyle(moticeList[i], "Activity");
                }
                else if (dr[1].ToString() == "Message")
                {
                    noticeStyle(moticeList[i], "Message");
                }
                else if (dr[1].ToString() == "Advice")
                {
                    noticeStyle(moticeList[i], "Advice");
                }
            }


            dr.Close();
            conn.Close();

        }
        void initShortcut()
        {

            if (User_type.user_deparment == "Receptionist")
            {
                shortcutButton1.Symbol = 62004;
                shortcutButton2.Symbol = 105;
                shortcutButton3.Symbol = 62144;
                shortcutButton1.SymbolSize = 28;
                shortcutButton2.SymbolSize = 24;
                shortcutButton3.SymbolSize = 26;
                shortcutText1.Text = "Register";
                shortcutText2.Text = "Receipt";
                shortcutText3.Text = "Profile";

            }
            else if (User_type.user_deparment == "Technician")
            {
                shortcutButton1.Symbol = 57397;
                shortcutButton2.Symbol = 61670;
                shortcutButton3.Symbol = 62144;
                shortcutButton1.SymbolSize = 24;
                shortcutButton2.SymbolSize = 30;
                shortcutButton3.SymbolSize = 26;
                shortcutText1.Text = "Requests";
                shortcutText2.Text = "Describe";
                shortcutText3.Text = "Profile";
            }
            else if (User_type.user_deparment == "Customer")
            {
                shortcutButton1.Symbol = 57397;
                shortcutButton2.Symbol = 61670;
                shortcutButton3.Symbol = 62144;
                shortcutButton1.SymbolSize = 24;
                shortcutButton2.SymbolSize = 30;
                shortcutButton3.SymbolSize = 26;
                shortcutText1.Text = "Requests";
                shortcutText2.Text = "Describe";
                shortcutText3.Text = "Profile";
            }
            else if (User_type.user_deparment == "Admin")
            {
                shortcutButton1.Symbol = 57608;
                shortcutButton2.Symbol = 57580;
                shortcutButton3.Symbol = 105;
                shortcutButton1.SymbolSize = 28;
                shortcutButton2.SymbolSize = 28;
                shortcutButton3.SymbolSize = 28;
                shortcutText1.Text = "Register";
                shortcutText2.Text = "Report";
                shortcutText3.Text = "Income";
            }
            
        }


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
        
        public ChromiumWebBrowser WebBrowser;

        
        private void InitializeChromeForMainLineChart()
        {
            if (User_type.loginStatus !=  "Relogin")
            {
                var setting = new CefSettings();
                setting.MultiThreadedMessageLoop = true;
                CefSharp.Cef.Initialize(setting);
            }
            
            WebBrowser = new ChromiumWebBrowser(@"E:\Materials\【LOOP】\Assignment\miniSys0.3\Html\mainLineChart.html");
            WebBrowser.Dock = DockStyle.Fill;//铺满                                                                  
            WebBrowser.Dock = DockStyle.Fill;//设置停靠方式
            WebBrowser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true; //交互数据
            WebBrowser.MenuHandler = new MenuHandler();//阻止右键
            this.lineChartPanel.Controls.Add(WebBrowser);

            //refreshlButton.PerformClick();

        }
        private async void refreshlButton_Click(object sender, EventArgs e)
        {
            await WebBrowser.GetBrowser().MainFrame.EvaluateScriptAsync("refresh()");
        }

        public  ChromiumWebBrowser WebBrowser1;
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
            await WebBrowser1.GetBrowser().MainFrame.EvaluateScriptAsync("refresh1()");
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

        private void noticeText1_hover(object sender, EventArgs e)
        {
            noticeText1.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void noticeText2_hover(object sender, EventArgs e)
        {
            noticeText2.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void noticeText3_hover(object sender, EventArgs e)
        {
            noticeText3.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void noticeText4_hover(object sender, EventArgs e)
        {
            noticeText4.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void noticeText5_hover(object sender, EventArgs e)
        {
            noticeText5.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void noticeText1_leave(object sender, EventArgs e)
        {
            noticeText1.ForeColor = Color.FromArgb(78, 89, 105);
        }

        private void noticeText2_leave(object sender, EventArgs e)
        {
            noticeText2.ForeColor = Color.FromArgb(78, 89, 105);
        }

        private void noticeText3_leave(object sender, EventArgs e)
        {
            noticeText3.ForeColor = Color.FromArgb(78, 89, 105);
        }

        private void noticeText4_leave(object sender, EventArgs e)
        {
            noticeText4.ForeColor = Color.FromArgb(78, 89, 105);
        }

        private void noticeText5_leave(object sender, EventArgs e)
        {
            noticeText5.ForeColor = Color.FromArgb(78, 89, 105);
        }

        private void doc1_hover(object sender, EventArgs e)
        {
            doc1.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void doc2_hover(object sender, EventArgs e)
        {
            doc2.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void doc3_hover(object sender, EventArgs e)
        {
            doc3.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void doc4_hover(object sender, EventArgs e)
        {
            doc4.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void doc1_leave(object sender, EventArgs e)
        {
            doc1.ForeColor = Color.FromArgb(78, 89, 105);
        }

        private void doc2_leave(object sender, EventArgs e)
        {
            doc2.ForeColor = Color.FromArgb(78, 89, 105);
        }

        private void doc3_leave(object sender, EventArgs e)
        {
            doc3.ForeColor = Color.FromArgb(78, 89, 105);
        }

        private void doc4_leave(object sender, EventArgs e)
        {
            doc4.ForeColor = Color.FromArgb(78, 89, 105);
        }
        public ChromiumWebBrowser WebBrowser2;
        void initReader()
        {
            Reader readerInst= new Reader();
        }

        private void news1_Click(object sender, EventArgs e)
        {
            Reader.reader.WebBrowser2.Load("http://www.google.ca");
            Reader.reader.Show();
        }

        private void news2_Click(object sender, EventArgs e)
        {
            Reader.reader.Show();
        }

        private void news3_Click(object sender, EventArgs e)
        {
            Reader.reader.Show();
        }

        private void news4_Click(object sender, EventArgs e)
        {
            Reader.reader.Show();
        }

        private void news5_Click(object sender, EventArgs e)
        {
            Reader.reader.Show();
        }

        private void noticeText1_Click(object sender, EventArgs e)
        {
            Reader.reader.Show();
        }

        private void noticeText2_Click(object sender, EventArgs e)
        {
            Reader.reader.Show();
        }

        private void noticeText3_Click(object sender, EventArgs e)
        {
            Reader.reader.Show();
        }

        private void noticeText4_Click(object sender, EventArgs e)
        {
            Reader.reader.Show();
        }

        private void noticeText5_Click(object sender, EventArgs e)
        {
            Reader.reader.Show();
        }
    }
    
}
