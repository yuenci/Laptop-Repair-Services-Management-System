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


        public void InitTheme()
        {
            info.BackColor = Color.Transparent;
            info.ForeColor = Color.White;
            info.FillColor = Color.FromArgb(57, 117, 255);
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                Container.BackColor = Color.FromArgb(28, 47, 70);
                Container.FillColor = Color.FromArgb(28, 47, 70);
                Container.RectColor = Color.Transparent;
                contentPanel.BackColor = Color.FromArgb(28, 47, 70);
                searchIcon.Size = new Size(35, 35);
                searchIcon.Location = new Point(1007, 46);

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

            dynamic[] data = SQLCursor.Query(sql);
            if (data.Length>0)
            {
                pagination.orderList = SQLCursor.Query(sql);

                //renderCard(pagination.orderList);
                pagination.Init(pagination.orderList.Length, pagination.currentPerNum);

                renderNewList(0, pagination.currentPerNum);
            }
            else
            {
                contentPanel.Controls.Clear();
                pagination.Init(0, pagination.currentPerNum);
            }


        }


        private void switchButton2_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(noStartCard);

            string sql = "Select OrderID From Schedule Where OrderID in " +
                "(select OrderID from Schedule group by OrderID having COUNT(*) =1) " +
                "Order by Time ;";

            dynamic[] data = SQLCursor.Query(sql);
            if (data.Length > 0)
            {
                pagination.orderList = SQLCursor.Query(sql);
                //Console.WriteLine(sql);



                //renderCard(pagination.orderList);
                pagination.Init(pagination.orderList.Length, pagination.currentPerNum);

                renderNewList(0, pagination.currentPerNum);
            }
            else
            {
                contentPanel.Controls.Clear();
                pagination.Init(0, pagination.currentPerNum);
            }



        }


        private void switchButton3_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(repairingCard);

            string sql = "Select OrderID From Schedule Where OrderID in " +
                "(select OrderID from Schedule group by OrderID having COUNT(*) =2) " +
                "AND Status= 'Progress' Order by Time ;";
            Console.WriteLine(sql);
            dynamic[] data = SQLCursor.Query(sql);
            if (data.Length > 0)
            {
                pagination.orderList = SQLCursor.Query(sql);

                //renderCard(pagination.orderList);
                pagination.Init(pagination.orderList.Length, pagination.currentPerNum);

                renderNewList(0, pagination.currentPerNum);
            }
            else
            {
                contentPanel.Controls.Clear();
                pagination.Init(0, pagination.currentPerNum);
            }



        }


        private void switchButton4_Click(object sender, EventArgs e)
        {
            clearBtnStyle();
            clickBtnStyle(dfinishedCard);

            string sql = "Select OrderID From Schedule Where Status= 'Completed' " +
                "Order by Time DESC;";

            dynamic[] data = SQLCursor.Query(sql);
            if (data.Length > 0)
            {
                pagination.orderList = SQLCursor.Query(sql);
                //renderCard(pagination.orderList);
                pagination.Init(pagination.orderList.Length, pagination.currentPerNum);

                renderNewList(0, pagination.currentPerNum);
            }
            else
            {
                contentPanel.Controls.Clear();
                pagination.Init(0, pagination.currentPerNum);
            }

            
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
            if (pagination.orderList.Length == 1)
            {
                UC_Task_Item item = new UC_Task_Item();
                item.Location = new Point(0, 0);
                item.Init(pagination.orderList[0]);
                contentPanel.Controls.Add(item);
            }
            else if (pagination.pageNum == 1)
            {
                for (int i = 0; i < pagination.orderList.Length; i++)
                {
                    UC_Task_Item item = new UC_Task_Item();
                    item.Location = new Point(0, i * 50);
                    item.Init(pagination.orderList[i][0]);
                    contentPanel.Controls.Add(item);
                }
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
            #region
            /*string sql;
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
                
            }*/
            #endregion

            SearchEvent();
        }

        private void SearchEvent()
        {
            if (searchBox.Text == null || searchBox.Text == "Search")
            {
                MessageBox.Show("Invalid value, empty input");
            }
            else
            {
                string sql = OrderSearch.search(searchBox.Text);
                Console.WriteLine(sql);
                if (sql != null)
                {
                    dynamic[] res = SQLCursor.Query(sql);
                    if (res.Length > 0)
                    {
                        pagination.orderList = res;
                        //renderNewList(0, pagination.orderList.Length);
                        pagination.Init(pagination.orderList.Length, pagination.currentPerNum);
                        renderNewList(0, pagination.currentPerNum);
                    }
                    else
                    {
                        MessageBox.Show($"Can't find order from {searchBox.Text}");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid input");
                }

            }
        }

        private void info_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter Order ID or Customer ID,\nor Technican ID or Datetime to search ", info);
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEvent();
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

    public static class OrderSearch {
        public static string search(string str)
        {
            int num;
            // num
            if (int.TryParse(str, out num))
            {
                if (str.Length<9)
                {
                    string sql = $"SELECT DISTINCT OrderID FROM Schedule Where OrderID = 'Ord{str.PadLeft(8, '0')}';";
                    return sql;
                }
                else
                {
                    return null;
                }
            }
            // str
            else if(str.Length==9 && str.Substring(0,3).ToLower()=="cus")
            {
                string sql = $"SELECT  DISTINCT OrderID FROM Orders WHERE CustomerID = '{str}';";
                return sql;
            }
            else if (str.Length == 9 && str.Substring(0, 3).ToLower() == "sta")
            {
                string sql = $"SELECT DISTINCT OrderID FROM Schedule WHERE TechnicianID = '{str}';";
                return sql;
            }
            else if (str.Length == 11 && str.Substring(0, 3).ToLower() == "ord")
            {
                string sql = $"SELECT DISTINCT OrderID FROM Orders WHERE OrderID = '{str}';";
                return sql;
            }
            else if (IfADate(str))
            {
                if (str.Length == 10)
                {
                    string sql = $"SELECT  DISTINCT OrderID FROM Schedule WHERE Time BETWEEN '{str} 0:0:0' AND '{str} 23:59:59';";
                    return sql;
                }
                else if (str.Length == 21)
                {
                    string[] data = str.Split("-");
                    string t1 = $"{data[0]}-{data[1]}-{data[2]}";
                    string t2 = $"{data[3]}-{data[4]}-{data[5]}";

                    string sql = $"SELECT  DISTINCT OrderID FROM Schedule WHERE Time BETWEEN '{t1} 0:0:0' AND '{t2} 23:59:59';";
                    return sql;
                }
            }
            else
            {
                string userID = SQLCursor.ifStaOrCus(str);
                if (userID !=null)
                {
                    if (userID.Substring(0,3) == "Cus")
                    {
                        string sql = $"SELECT OrderID FROM Orders WHERE CustomerID = '{userID}';";
                        return sql;
                    }
                    else if (userID.Substring(0, 3) == "Sta")
                    {
                        string sql = $"SELECT DISTINCT OrderID FROM Schedule WHERE TechnicianID = '{userID}';";
                        return sql;
                    }
                }
                else 
                {
                    return null;
                }
            }
            return null;
        }

        private static bool IfADate(string str)
        {
            string[] data = str.Split("-");
            if(data.Length == 3)
            {
                bool flag = true;
                int num = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    if (!int.TryParse(data[i], out num))
                    {
                        flag = false;
                    }
                }

                if (data[0].Length == 4 && data[1].Length == 2 && data[2].Length == 2)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

                if (flag == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
            }
            else if (data.Length == 6)
            {
                bool flag = true;
                int num = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    if (!int.TryParse(data[i], out num))
                    {
                        flag = false;
                    }
                }

                if (data[0].Length == 4 && data[1].Length == 2 && data[2].Length == 2)
                {
                    if (data[3].Length == 4 && data[4].Length == 2 && data[5].Length == 2)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }            
                }
                else
                {
                    flag = false;
                }

                if (flag == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }
    }

}
