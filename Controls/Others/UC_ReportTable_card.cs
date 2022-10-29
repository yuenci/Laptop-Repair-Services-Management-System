using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3.Controls.Others
{
    public partial class UC_ReportTable_card : UserControl
    {
        private string time;
        private int num;
        private int totalNum;
        private int months;
        public UC_ReportTable_card()
        {
            InitializeComponent();
            InitTheme();

        }
        private void InitTheme()
        {
            uiAvatar1.ForeColor = Color.White;
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(55, 55, 57);
                dynamic[] lable = { dataTime ,quantity,ratio};
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.FromArgb(242, 243, 245);
                dynamic[] lable = { dataTime, quantity, ratio };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }
            }
        }

        public void Init(string time, int num, int totalNum, int months)
        {
            this.time = time;
            this.num = num;
            this.totalNum = totalNum;
            this.months = months;
            InitAvatar();
            InitLabel();
        }

        private void InitAvatar()
        {
            if (num >= totalNum/ months)
            {
                uiAvatar1.FillColor = Color.FromArgb(89, 126, 247);
            }
            else
            {
                uiAvatar1.FillColor = Color.FromArgb(54, 207, 201);
            }

            string[] montheList = { "Jan", "Feb", "Mar", "Apr ", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
            uiAvatar1.Text = montheList[int.Parse(time.Substring(5, 2))-1];
        }

        private void InitLabel()
        {
            dataTime.Text = time;

            if (Main.main.currentMainPage == "UC_ServiceReport")
            {
                quantity.Text = num.ToString() + " Orders";
            }
            else if (Main.main.currentMainPage == "UC_IncomeAnalysis")
            {
                quantity.Text = "RM " + num.ToString();
            }


            var processValue = (float)num*100 / totalNum;

            ProcessBar.Value = (int)processValue;
            ratio.Text = processValue.ToString("#0.00") + "%";

        }

        private void uiAvatar1_MouseHover(object sender, EventArgs e)
        {
           
            if (uiAvatar1.FillColor == Color.FromArgb(89, 126, 247))
            {
                toolTip1.Show("Above average", uiAvatar1);
            }
            else
            {
                toolTip1.Show("Below average", uiAvatar1);
            }
        }
    }
}
