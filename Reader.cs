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
using miniSys0._3.Controls;
using Sunny.UI;
using static miniSys0._3.Controls.UC_main;

namespace miniSys0._3
{
    public partial class Reader : UIForm
    {
        public static Reader reader;
        public Reader()
        {
            InitializeComponent();
            InitializeChromeForMainLineChart();
            reader = this;
            InitTheme();
        }

        public ChromiumWebBrowser WebBrowser2;
        private void InitializeChromeForMainLineChart()
        {

            /*var setting = new CefSettings();
            setting.MultiThreadedMessageLoop = true;
            CefSharp.Cef.Initialize(setting);*/
            string url_path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")) + "Html\\Articles\\index.html";
            WebBrowser2 = new ChromiumWebBrowser(url_path);
            WebBrowser2.Dock = DockStyle.Fill;//铺满                                                                  
            WebBrowser2.Dock = DockStyle.Fill;//设置停靠方式
            WebBrowser2.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true; //交互数据
            WebBrowser2.JavascriptObjectRepository.Register("bound", new BoundObject(), isAsync: false, options: BindingOptions.DefaultBinder); //交互数据
            WebBrowser2.MenuHandler = new MenuHandler();//阻止右键
            panelBrower.Controls.Add(WebBrowser2);


        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                TitleColor = Color.FromArgb(28, 47, 70);
                TitleForeColor = Color.White;
                ControlBoxForeColor = Color.White;
                rectColor = Color.FromArgb(55, 55, 57);
            }
        }

    }
    public class BoundObject
    {
        public string MessageText { get; set; }
        public void Getvalue()
        {
            MessageBox.Show("call c#.\n\r" + MessageText);
        }
        public void GetValueArg(string inss)
        {
            MessageBox.Show("call with argument.\n\r" + inss);
        }
        public void add1ToLikes()
        {
           //Console.WriteLine("get");

            if (ArticlesInfo.currentArticleType == "news")
            {
                int no = ArticlesInfo.currentnewsLablelD;
                string likes = ArticlesInfo.likesParaList[no];
                ArticlesInfo.likesParaList[no] = (int.Parse(likes) + 1).ToString();
                add1ToViewsOrLikesToDB("likes","news");
            }
            else if (ArticlesInfo.currentArticleType == "notice")
            {
                int no = NoticeInfo.currentnoticeLablelD;
                string likes = NoticeInfo.likesParaList[no];
                NoticeInfo.likesParaList[no] = (int.Parse(likes) + 1).ToString();
                add1ToViewsOrLikesToDB("likes","notice");
            }
            

        }

    }
}
