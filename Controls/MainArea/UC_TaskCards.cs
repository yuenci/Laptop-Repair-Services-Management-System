using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3.Controls.MainArea
{
    public partial class UC_TaskCards : UserControl
    {
        public static UC_TaskCards uc_TaskCards;
        public UC_TaskCards()
        {
            InitializeComponent();
            InitCurmbs();
            InitCard();
            uc_TaskCards = this;
            InitSwitchBtns();
        }

        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "Table";
            urC_Crumbs1.crumbsHome.Text = " / Table / Card list";
        }
        private void InitCard()
        {
            string sql1 = "WITH A AS(SELECT DISTINCT OrderID,Time from Schedule WhERE Status = 'Finished'),";
            sql1 += "B AS(SELECT DISTINCT OrderID,Time from Schedule)";
            sql1 += "select * from B where (select count(1) as num from A where A.OrderID = B.OrderID) = 0  Order by Time";

            dynamic[]  data = SQLCursor.Query(sql1);

            dynamic[] card = { uC_Task_Card1, uC_Task_Card2, uC_Task_Card3, uC_Task_Card4,
            uC_Task_Card5,uC_Task_Card6,uC_Task_Card7,uC_Task_Card8,uC_Task_Card9};

            for (int i = 0; i < card.Length; i++)
            {
                card[i].Init(data[i][0]);
            }

            pagination.Init(data.Length,9);
            pagination.ComboBox.Text = "9 / page";
            pagination.ComboBox.Enabled = false;
            pagination.type = "card";
        }

        private void InitSwitchBtns()
        {
            clearBtnStyle();
            clickBtnStyle(switchButton1);
        }
        private void clearBtnStyle()
        {
            UIButton[] btnList = { switchButton1, switchButton2, switchButton3, switchButton4 };
            foreach (var item in btnList)
            {
                //  basic
                item.BackColor = Color.White;
                item.FillColor=Color.White;
                item.ForeColor = Color.FromArgb(78, 89, 105);
                item.RectColor = Color.White;

                //hover
                item.BackColor = Color.White;
                item.FillHoverColor = Color.FromArgb(242, 243, 245);
                item.ForeHoverColor = Color.FromArgb(78, 89, 105);
                item.RectHoverColor = Color.White;

                //click
                item.BackColor = Color.White;
                item.FillPressColor = Color.FromArgb(242, 243, 245);
                item.ForePressColor = Color.FromArgb(78, 89, 105);
                item.RectPressColor = Color.White;
            }
        }
        private void clickBtnStyle(UIButton btn)
        {
            //  basic
            btn.BackColor = Color.White;
            btn.FillColor = Color.FromArgb(242, 243, 245);
            btn.ForeColor = Color.FromArgb(22, 93, 255);
            btn.RectColor = Color.White;

            //hover
            btn.BackColor = Color.White;
            btn.FillHoverColor = Color.FromArgb(242, 243, 245);
            btn.ForeHoverColor = Color.FromArgb(22, 93, 255);
            btn.RectHoverColor = Color.White;

            //click
            btn.BackColor = Color.White;
            btn.FillPressColor = Color.FromArgb(242, 243, 245);
            btn.ForePressColor = Color.FromArgb(22, 93, 255);
            btn.RectPressColor = Color.White;
        }
       

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text=="Search")
            {
                searchBox.Text = "";
            }
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Search";
            }
        }

        private void switchButton1_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(switchButton1);
        }

        private void switchButton2_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(switchButton2);
        }

        private void switchButton3_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(switchButton3);
        }

        private void switchButton4_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(switchButton4);
        }
    }
}
