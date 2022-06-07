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
    public partial class UC_Setting_Privacy : UserControl
    {
        public static UC_Setting_Privacy Instance;
        public UC_Setting_Privacy()
        {
            InitializeComponent();
            Instance = this;
        }
        public void InitTheme()
        {
            uiLine1.FillColor = Color.Transparent;
            info.BackColor = Color.Transparent;
            info.ForeColor = Color.White;
            info.FillColor = Color.FromArgb(57, 117, 255);
            if (User_type.user_theme == "dark")
            {
                uiLine1.LineColor = Color.Gainsboro;
                this.BackColor = Color.FromArgb(55, 55, 57);
                dynamic[] lable = { uiLabel1, uiLabel2, uiLabel3, uiLabel4 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

            }
            else if (User_type.user_theme == "light")
            {
                uiLine1.LineColor = Color.Gainsboro;
                this.BackColor = Color.White;
                dynamic[] lable = { uiLabel1, uiLabel2, uiLabel3, uiLabel4 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }

            }
        }
        public void InitStatus()
        {
            UserSettings.DisplayStatus(allowSearch, UserSettings.allowSearch);
            UserSettings.DisplayStatus(allowShowProfile, UserSettings.allowShowProfile);
            UserSettings.DisplayStatus(privateMode, UserSettings.privateMode);
        }


        private void allowSearch_Click(object sender, EventArgs e)
        {
            UserSettings.SetStatus("allowSearch", allowSearch.Active);
        }

        private void allowShowProfile_Click(object sender, EventArgs e)
        {
            UserSettings.SetStatus("allowShowProfile", allowShowProfile.Active);
        }

        private void privateMode_Click(object sender, EventArgs e)
        {
            UserSettings.SetStatus("privateMode", privateMode.Active);
        }

        private void info_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Turning on the privacy mode means that you will refuse to receive any messages,\n" +
                "and your personal information will be hidden and cannot be searched.", info);
        }
    }
}
