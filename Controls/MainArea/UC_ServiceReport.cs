using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static miniSys0._3.Controls.UC_main;

namespace miniSys0._3.Controls.MainArea
{
    public partial class UC_ServiceReport : UserControl
    {
        public UC_ServiceReport()
        {
            InitializeComponent();
            InitCrumb();
            InitCef();
        }
        public static ChromiumWebBrowser WebBrowserSR;
        private void InitCrumb()
        {
            urC_Crumbs1.crumbText.Text = "Service report";
            urC_Crumbs1.crumbsHome.Text = " / Data /            rt";
        }
        private void InitCef()
        {

            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")) + 
                $"Html\\adminServiceReport.html";
            WebBrowserSR = new ChromiumWebBrowser(path);
            WebBrowserSR.Dock = DockStyle.Fill;//铺满                                                                  
            WebBrowserSR.Dock = DockStyle.Fill;//设置停靠方式
            //WebBrowser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true; //交互数据
            WebBrowserSR.MenuHandler = new MenuHandler();//阻止右键
            this.chartPanel.Controls.Add(WebBrowserSR);

        }


        private async void refreshlButton2_Click(object sender, EventArgs e)
        {
            await WebBrowserSR.GetBrowser().MainFrame.EvaluateScriptAsync("refresh()");
        }

        private void urC_Crumbs1_Load(object sender, EventArgs e)
        {

        }
    }
}
