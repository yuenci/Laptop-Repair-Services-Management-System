using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3.Controls.Setting
{
    
    public partial class UC_Setting_Message : UserControl
    {
        public static UC_Setting_Message Instance;
        public UC_Setting_Message()
        {
            InitializeComponent();
            Instance = this;
        }
        public void InitTheme()
        {
            uiLine1.FillColor = Color.Transparent;
            
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(55, 55, 57);
                uiLine1.LineColor = Color.Gainsboro;
                dynamic[] lable = { uiLabel1, uiLabel2, uiLabel3, uiLabel4 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.White;
                uiLine1.LineColor = Color.Gainsboro;
                dynamic[] lable = { uiLabel1, uiLabel2, uiLabel3, uiLabel4 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }

            }
        }
        public void InitStatus()
        {
            UserSettings.DisplayStatus(rejectAllMs, UserSettings.rejectAllMs);
            UserSettings.DisplayStatus(rejectAllSy, UserSettings.rejectAllSy);
            UserSettings.DisplayStatus(rejectAllCus, UserSettings.rejectAllCus);
        }

        private void rejectAllMs_Click(object sender, EventArgs e)
        {
            UserSettings.SetStatus("rejectAllMs", rejectAllMs.Active);
            Main.main.checkMessage();
        }

        private void rejectAllSy_Click(object sender, EventArgs e)
        {
            UserSettings.SetStatus("rejectAllSy", rejectAllSy.Active);
            Main.main.checkMessage();
        }

        private void rejectAllCus_Click(object sender, EventArgs e)
        {
            UserSettings.SetStatus("rejectAllCus", rejectAllCus.Active);
        }
    }
}
