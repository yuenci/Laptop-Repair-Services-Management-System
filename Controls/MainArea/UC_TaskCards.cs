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
            InitTheme();
            InitCard();
            InitStyle();
            uc_TaskCards = this;
            InitSwitchBtns();
        }
        

        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                Container.BackColor = Color.FromArgb(28, 47, 70);
                Container.FillColor = Color.FromArgb(28, 47, 70);
                Container.RectColor = Color.Transparent;
                contentPanel.BackColor = Color.FromArgb(28, 47, 70);
                searchIcon.Size = new Size(35, 35);
                searchIcon.Location = new Point(1020, 48);

                dynamic[] lable = { label1 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

                pagination.InitTheme();
            }
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

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Order' ORDER　BY Time DESC;";
            pagination.orderList = SQLCursor.Query(sql);

            renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);


            //pagination.Init(data.Length,9);
            pagination.ComboBox.Text = "9 / page";
            pagination.ComboBox.Enabled = false;
            pagination.type = "card";
        }
        
        
        private void InitStyle()
        {
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
            if (User_type.user_theme == "dark")
            {
                foreach (var item in btnList)
                {
                    //  basic
                    item.BackColor = Color.Transparent;
                    item.FillColor = Color.FromArgb(242, 243, 245);
                    item.ForeColor = Color.FromArgb(78, 89, 105);
                    item.RectColor = Color.White;
                    item.Font = new Font(".萍方-简", 12, FontStyle.Regular);

                    //hover
                    item.BackColor = Color.Transparent;
                    item.FillHoverColor = Color.FromArgb(242, 243, 245);
                    item.ForeHoverColor = Color.FromArgb(78, 89, 105);
                    item.RectHoverColor = Color.Transparent;

                    //click
                    item.BackColor = Color.Transparent;
                    item.FillPressColor = Color.FromArgb(242, 243, 245);
                    item.ForePressColor = Color.FromArgb(78, 89, 105);
                    item.RectPressColor = Color.Transparent;
                }
            }
            else
            {
                foreach (var item in btnList)
                {
                    //  basic
                    item.BackColor = Color.White;
                    item.FillColor = Color.Transparent;
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
            
        }
        
        
        private void clickBtnStyle(UIButton btn)
        {
            if (User_type.user_theme == "dark")
            {
                //  basic
                btn.BackColor = Color.Transparent;
                btn.FillColor = Color.FromArgb(242, 243, 245);
                btn.ForeColor = Color.FromArgb(22, 93, 255);
                btn.RectColor = Color.White;
                btn.Font = new Font(".萍方-简", 12, FontStyle.Bold);


                //hover
                btn.BackColor = Color.Transparent;
                btn.FillHoverColor = Color.FromArgb(242, 243, 245);
                btn.ForeHoverColor = Color.FromArgb(22, 93, 255);
                btn.RectHoverColor = Color.White;

                //click
                btn.BackColor = Color.Transparent;
                btn.FillPressColor = Color.FromArgb(242, 243, 245);
                btn.ForePressColor = Color.FromArgb(22, 93, 255);
                btn.RectPressColor = Color.White;
            }
            else
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
            clickBtnStyle(allCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Order' ORDER　BY Time DESC;";
            pagination.orderList = SQLCursor.Query(sql);

            renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);
        }


        private void switchButton2_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(noStartCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Order' ORDER　BY Time;";
            pagination.orderList = SQLCursor.Query(sql);

            renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);
        }

        private void switchButton3_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(repairingCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Progress' ORDER　BY Time;";
            pagination.orderList = SQLCursor.Query(sql);

            renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);
        }

        private void switchButton4_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(dfinishedCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Completed' ORDER　BY Time DESC;";
            pagination.orderList = SQLCursor.Query(sql);
            renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);
        }

        private void renderCard(dynamic orderlist)
        {
            dynamic[] cards = { uC_Task_Card1 , uC_Task_Card2 , uC_Task_Card3,
                                 uC_Task_Card4, uC_Task_Card5, uC_Task_Card6,
                                 uC_Task_Card7, uC_Task_Card8, uC_Task_Card9};
            if (orderlist.Length >= 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    cards[i].Init(orderlist[i][0]);
                }
            }
            if (orderlist.Length == 1)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (i < 1)
                    {
                        cards[i].Init(orderlist[0]);
                    }
                    else
                    {
                        cards[i].Hide();
                    }

                }
            }
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    if (i < orderlist.Length)
                    {
                        cards[i].Init(orderlist[i][0]);
                    }
                    else
                    {
                        cards[i].Hide();
                    }

                }
            }
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            string orderID = searchBox.Text;
            string sql = $"SELECT TOP 1  OrderID FROM Schedule WHERE OrderID = '{orderID}';";
            pagination.orderList = SQLCursor.Query(sql);
            renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, 9);
        }
    }
}
