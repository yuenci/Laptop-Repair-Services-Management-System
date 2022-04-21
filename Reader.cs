using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
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
            WebBrowser2.MenuHandler = new MenuHandler();//阻止右键
            panelBrower.Controls.Add(WebBrowser2);


            

        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


    }
}
