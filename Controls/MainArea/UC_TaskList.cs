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
    public partial class UC_TaskList : UserControl
    {
        public UC_TaskList()
        {
            InitializeComponent();
            InitCurmbs();
            InitStyle();
            InitSwitchBtns();
            uC_Task_Item1.Init("Ord00000001");
            uC_Task_Item2.Init("Ord00000002");
        }

        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "Table";
            urC_Crumbs1.crumbsHome.Text = " / Table / Card list";
        }

        private void InitStyle()
        {
            /*dynamic[] lables = { uiLabel1, uiLabel2, uiLabel3, uiLabel4, uiLabel5 };
            foreach (var lable in lables)
            {
                lable.RectColor = Color.White;
            }*/

            searchBox.RectColor = Color.White;
            searchBox.FillColor = Color.FromArgb(242, 243, 245);

            searchIcon.FillColor = Color.FromArgb(242, 243, 245);
            searchIcon.ForeColor = Color.FromArgb(78, 89, 105);
        }

        private void InitSwitchBtns()
        {
            clearBtnStyle();
            clickBtnStyle(allCard);
        }
        private void clearBtnStyle()
        {
            UIButton[] btnList = { allCard, noStartCard, repairingCard, dfinishedCard };
            foreach (var item in btnList)
            {
                //  basic
                item.BackColor = Color.White;
                item.FillColor = Color.White;
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
            if (searchBox.Text == "Search")
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
            clickBtnStyle(allCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Order' ORDER　BY Time DESC;";
            pagination.orderList = SQLCursor.Query(sql);

            //renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);
        }

        private void switchButton2_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(noStartCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Order' ORDER　BY Time;";
            pagination.orderList = SQLCursor.Query(sql);

            //renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);
        }

        private void switchButton3_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(repairingCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Progress' ORDER　BY Time;";
            pagination.orderList = SQLCursor.Query(sql);

            //renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);
        }

        private void switchButton4_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(dfinishedCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Completed' ORDER　BY Time DESC;";
            pagination.orderList = SQLCursor.Query(sql);
            //renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);
        }
    }
}
