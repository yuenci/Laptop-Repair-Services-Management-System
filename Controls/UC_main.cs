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
            sunnyUIinit();
            InitializeChromeForMainLineChart();
            InitializeChromeForMainPieChart();
            setNotices();
            initNews();
        }

        void sunnyUIinit()
        {
            upperTriangle.ForeColor = Color.Red;
            upperTriangle.FillColor = Color.Transparent;

            shortcutButton1.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton2.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton3.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton1.SymbolColor = Color.Black;
            shortcutButton2.SymbolColor = Color.Black;
            shortcutButton3.SymbolColor = Color.Black;
            shortcutButton1.RectColor = Color.Transparent;
            shortcutButton2.RectColor = Color.Transparent;
            shortcutButton3.RectColor = Color.Transparent;
            newsTopBar.RectColor = Color.Transparent;
            newsTopBar.FillColor = Color.FromArgb(242, 243, 245);
            news1.MarkColor = Color.FromArgb(242, 243, 245);
            news2.MarkColor = Color.FromArgb(242, 243, 245);
            news3.MarkColor = Color.FromArgb(242, 243, 245);
            news4.MarkColor = Color.FromArgb(242, 243, 245);
            news5.MarkColor = Color.FromArgb(242, 243, 245);
        }

        private void initNews()
        {
            string connStr = @"Data Source=LAPTOP-5ACE008F\SQLEXPRESS;Initial Catalog=CsharpRepairerInc;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = $"SELECT TOP 5 Title, Views FROM Articles ORDER BY  Views DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            dynamic[] newsList = { news1, news2 , news3 , news4 , news5 };

            for (int i = 0; dr.Read(); i++)
            {
                var title ="";
                var text = ""; 
                if (dr["Title"].ToString().Length > 30)
                {
                     title = dr["Title"].ToString().Substring(0, 30);
                     text = (i+1).ToString() + "        " + title + "...";
                }
                else
                {
                    title = dr["Title"].ToString();
                    text = (i + 1).ToString() + "        " + title;
                }
                int textLength = text.Length;
                string numStr = dr["Views"].ToString();
                int numberLength = numStr.Length;
                string spaces  = new string(' ', 53 - textLength- numberLength);
                string wholeText = text + spaces + numStr;
                Console.WriteLine(wholeText);
                newsList[i].Text = wholeText;

            }
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

        void setNotices()
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
    }
    
}
