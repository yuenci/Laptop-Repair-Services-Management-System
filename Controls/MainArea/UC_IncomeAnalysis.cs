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
    public partial class UC_IncomeAnalysis : UserControl
    {
        public UC_IncomeAnalysis()
        {
            InitializeComponent();
            InitCrumb();
            InitCef();
        }
        public static ChromiumWebBrowser WebBrowserIA;
        private void InitCrumb()
        {
            urC_Crumbs1.crumbText.Text = "Income Analysis";
            urC_Crumbs1.crumbsHome.Text = " / Data /            rt";
        }
        private void InitCef()
        {

            

            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")) + 
                $"Html\\adminIncomeAnalysis.html";
            WebBrowserIA = new ChromiumWebBrowser(path);
            WebBrowserIA.Dock = DockStyle.Fill;//铺满                                                                  
            WebBrowserIA.Dock = DockStyle.Fill;//设置停靠方式
            //WebBrowser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true; //交互数据
            WebBrowserIA.MenuHandler = new MenuHandler();//阻止右键
            this.chartPanel.Controls.Add(WebBrowserIA);

        }

        private async void refreshlButton2_Click(object sender, EventArgs e)
        {
            await WebBrowserIA.GetBrowser().MainFrame.EvaluateScriptAsync("refresh()");
        }
    }
}
