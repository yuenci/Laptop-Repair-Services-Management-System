using miniSys0._3.Controls.Others;
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
        public static UC_TaskList instance;
        public UC_TaskList()
        {
            instance = this;
            InitializeComponent();

            InitTheme();

            InitCurmbs();
            
            InitStyle();
            InitSwitchBtns();
            Initpagenation();

            
            //Init10Items();
            allCard.PerformClick(); 

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
                searchIcon.Location = new Point(1020, 46);

                dynamic[] lable = { label1, uiLabel6, uiLabel7, uiLabel8, uiLabel9, uiLabel10 };
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
        private void Initpagenation()
        {
            pagination.type = "list";
        }
        private void switchButton1_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(allCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Order' ORDER　BY Time DESC;";
            pagination.orderList = SQLCursor.Query(sql);

            //renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, pagination.currentPerNum);

            renderNewList(0,pagination.currentPerNum);
        }

        private void switchButton2_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(noStartCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Order' ORDER　BY Time;";
            pagination.orderList = SQLCursor.Query(sql);

            //renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, pagination.currentPerNum);

            renderNewList(0,pagination.currentPerNum);
        }

        private void switchButton3_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(repairingCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Progress' ORDER　BY Time;";
            pagination.orderList = SQLCursor.Query(sql);

            //renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, pagination.currentPerNum);

            renderNewList(0, pagination.currentPerNum);
        }

        private void switchButton4_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(dfinishedCard);

            string sql = "SELECT OrderID FROM Schedule WHERE Status = 'Completed' ORDER　BY Time DESC;";
            pagination.orderList = SQLCursor.Query(sql);
            //renderCard(pagination.orderList);
            pagination.Init(pagination.orderList.Length, pagination.currentPerNum);

            renderNewList(0, pagination.currentPerNum);
        }

        private void Init10Items()
        {
            for (int i = 0; i < 9; i++)
            {
                UC_Task_Item item = new UC_Task_Item();
                item.Location = new Point(0, i * 50);
                item.Init($"Ord0000000{i+1}");
                contentPanel.Controls.Add(item);

            }
           /* uC_Task_Item1.Init("Ord00000001");
            uC_Task_Item2.Init("Ord00000002");
            uC_Task_Item3.Init("Ord00000003");
            uC_Task_Item4.Init("Ord00000004");
            uC_Task_Item5.Init("Ord00000005");
            uC_Task_Item6.Init("Ord00000006");
            uC_Task_Item7.Init("Ord00000007");
            uC_Task_Item8.Init("Ord00000008");
            uC_Task_Item9.Init("Ord00000009");
            uC_Task_Item10.Init("Ord00000010");*/
        }


        public void renderNewList(int startIndex, int range)
        {
            contentPanel.Controls.Clear();
            int cardIndex  = 0;
            int end = startIndex + range;
            if (pagination.orderList.Length ==1)
            {
                UC_Task_Item item = new UC_Task_Item();
                item.Location = new Point(0, 0);
                item.Init(pagination.orderList[0]);
                contentPanel.Controls.Add(item);
            }
            else
            {
                for (int i = startIndex; i < end; i++)
                {
                    UC_Task_Item item = new UC_Task_Item();
                    item.Location = new Point(0, cardIndex * 50);
                    item.Init(pagination.orderList[startIndex][0]);
                    contentPanel.Controls.Add(item);
                    cardIndex++;
                    startIndex++;
                }
            }
            
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            string sql;
            if (searchBox.Text == null || searchBox.Text == "Search")
            {
                MessageBox.Show("Enter OrderID / Time please.");
            }
            else
            {
                string res =  Order_Search.search(searchBox.Text);
                if (Order_Search.type == "OrderID")
                {
                    sql = $"SELECT TOP 1 OrderID FROM Schedule WHERE  OrderID = '{res}';";
                    pagination.orderList = SQLCursor.Query(sql);
                    if (pagination.orderList.Length  == 0)
                    {
                        MessageBox.Show($"Order {res} dosen't exist");
                    }
                    else
                    {
                        pagination.Init(pagination.orderList.Length, pagination.currentPerNum);
                        renderNewList(0, pagination.currentPerNum);
                    }
                    
                }
                else if(Order_Search.type == "OrderNum")
                {
                    sql = $"SELECT TOP 1 OrderID FROM Schedule WHERE  OrderID = '{res}';";
                    pagination.orderList = SQLCursor.Query(sql);
                    if (pagination.orderList.Length == 0)
                    {
                        MessageBox.Show($"Order {res} dosen't exist");
                    }
                    else
                    {
                        pagination.Init(pagination.orderList.Length, pagination.currentPerNum);
                        renderNewList(0, pagination.currentPerNum);
                    }
                }
                else if (Order_Search.type == "OrderTime")
                {
                    pagination.orderList = SQLCursor.Query(res);
                    renderNewList(0, pagination.orderList.Length);
                }
                else if (Order_Search.type == "others")
                {
                    MessageBox.Show("Can't find any orders");
                }
                //renderCard(pagination.orderList);
                
            }
        }
    }
    public static class Order_Search
    {
        static int  orderNum ;
        static DateTime dtDate;
        public static string type;
        public static dynamic search(string str)
        {
            if (str == null)
            {
                return null;
            }
            else if (str.Length == 11 && str.Substring(0,3)== "Ord" )
            {
                type = "OrderID";
                return str;

            }
            else if (int.TryParse(str, out orderNum))
            {
                type = "OrderNum";
                return "Ord" + str;
            }
            else if (DateTime.TryParse(str, out dtDate))
            {
                type = "OrderTime";
                string sql = $"SELECT OrderID FROM Orders WHERE Time between '{str} 00:00:00' and '{str} 23:59:59' ";
                return sql;
            }
            type = "others";
            return null;
        }
    }
}
