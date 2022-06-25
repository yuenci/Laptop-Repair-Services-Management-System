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
    public partial class UC_Report_table : UserControl
    {
        private string type;
        //service , income
        public UC_Report_table(string type)
        {
            InitializeComponent();
            InitTheme();
            InitYear();
            this.type = type;
            InitTopbar(DateTime.Now.ToString("yyyy"));
            CreatCard(0, DateTime.Now.ToString("yyyy"), 0);
        }
        private void InitTopbar(string year)
        {
            int month = 0;
            int sum = 0;
            int max = 0;
            if (year == DateTime.Now.ToString("yyyy"))
            {
                month = int.Parse(DateTime.Now.ToString("MM"));
            }
            else
            {
                month = 12;
            }

            if (Main.main.currentMainPage == "UC_ServiceReport")
            {
                uiLabel1.Text = "Average monthly service quantity";
                uiLabel2.Text = "Total service quantity";
                uiLabel3.Text = "Maximum monthly service quantity";

                string sql = "SELECT COUNT(*) FROM Orders Where year(Time) = 2022;" +
                "SELECT TOP 1 COUNT(*) FROM Orders Where year(Time) = 2022" +
                "GROUP BY year(Time),month(Time)" +
                "ORDER BY COUNT(*) DESC; ";

                dynamic[] data = SQLCursor.QueryMany(sql);
                if (data.Length >0)
                {
                    double ave = int.Parse(data[0][0]) / month;
                    aveLabel.Text = ave.ToString("#0.00");
                    totalLabel.Text = data[0][0];
                    maxLabel.Text = data[1][0];
                }
            }
            else if (Main.main.currentMainPage == "UC_IncomeAnalysis")
            {
                uiLabel1.Text = "Average monthly income quantity";
                uiLabel2.Text = "Total income quantity";
                uiLabel3.Text = "Maximum monthly income quantity";

                string sql = "SELECT SUM(Price) FROM Orders Where year(Time) = 2022;" +
                "SELECT TOP 1 SUM(Price) FROM Orders Where year(Time) = 2022" +
                "GROUP BY year(Time),month(Time)" +
                "ORDER BY SUM(Price) DESC;";
                dynamic[] data = SQLCursor.QueryMany(sql);
                if (data.Length > 0)
                {
                    double ave = int.Parse(data[0][0]) / month;
                    aveLabel.Text = ave.ToString("#0.00");
                    totalLabel.Text = data[0][0];
                    maxLabel.Text = data[1][0];
                }
            }
        }
        private void InitTheme()
        {
            order.RectColor = Color.Gainsboro;
            dateTIme.RectColor = Color.Gainsboro;
            serviceType.RectColor = Color.Gainsboro;
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(18, 31, 43);

                uiUserControl1.FillColor = Color.FromArgb(28, 47, 70);
                uiUserControl1.BackColor = Color.FromArgb(28, 47, 70);
                reportContainer.FillColor = Color.FromArgb(28, 47, 70);
                reportContainer.BackColor = Color.FromArgb(28, 47, 70);
                uiUserControl1.RectColor = Color.Transparent;
                reportContainer.RectColor = Color.Transparent;

                dynamic[] lable = { uiLabel2, uiLabel1, uiLabel3, maxLabel, aveLabel, totalLabel };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.White;

                uiUserControl1.FillColor = Color.White;
                uiUserControl1.RectColor = Color.Gainsboro;
                uiUserControl1.BackColor = Color.White;

                reportContainer.BackColor = Color.White;
                reportContainer.FillColor = Color.White;
                reportContainer.RectColor = Color.Gainsboro;

                dynamic[] lable = { uiLabel2, uiLabel1, uiLabel3, maxLabel, aveLabel, totalLabel };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }
            }
        }

        private void InitYear()
        {
            string sql = "SELECT TOP 1 YEAR(Time)   FROM Orders ORDER BY Time ASC ;" +
                "SELECT TOP 1 YEAR(Time)   FROM Orders ORDER BY Time DESC;";

            dynamic[] data = SQLCursor.QueryMany(sql);
            if (data.Length >0)
            {
                int start = int.Parse(data[0][0]);
                int end = int.Parse(data[1][0]);
                for (int i = 0; i <= end -start ; i++)
                {
                    int date = end - i;
                    dateTIme.Items.Add(date.ToString());
                }
                //SQLCursor()
            }


        }



        private string CreateSQL(string year)
        {
            //order = desc/asc
            return $"SELECT year(Time),month(Time),COUNT(*) FROM Orders Where year(Time) = {year}" +
                          "GROUP BY year(Time),month(Time)" +
                          $"ORDER BY month(Time); ";
        }

        private string CreateSQL(string year, int order,int typeID)
        {
            //order = desc/asc
            string[] orderList = { "month(Time) ASC", "month(Time) DESC", "COUNT(*) ASC", "COUNT(*) DESC" };
            if (type == "service")
            {
                if (typeID == 0)
                {
                    return $"SELECT year(Time),month(Time),COUNT(*) FROM Orders Where year(Time) = {year}" +
                          "GROUP BY year(Time),month(Time)" +
                          $"ORDER BY {orderList[order]}; ";
                }

                else
                {
                    return $"SELECT year(Time),month(Time),COUNT(*) FROM Orders Where year(Time) = {year}" +
                          $"AND Service_type ='Ser00{typeID}'" +
                          "GROUP BY year(Time),month(Time)" +
                          $"ORDER BY {orderList[order]}; ";
                }
            }
            else if(type == "income")
            {
                if (typeID == 0)
                {
                    return $"SELECT year(Time),month(Time),SUM(Price) FROM Orders Where year(Time) = {year}" +
                          "GROUP BY year(Time),month(Time)" +
                          $"ORDER BY {orderList[order]}; ";
                }

                else
                {
                    return $"SELECT year(Time),month(Time),SUM(Price) FROM Orders Where year(Time) = {year}" +
                          $"AND Service_type ='Ser00{typeID}'" +
                          "GROUP BY year(Time),month(Time)" +
                          $"ORDER BY {orderList[order]}; ";
                }
            }
            return null;
            
        }

        private void CreatCard(int serviceType, string dateTime,int order)
        {
            caedsPanel.Controls.Clear();
            string sql = CreateSQL(dateTime, order, serviceType);
            dynamic[] data= SQLCursor.Query(sql);
            if (data.Length >0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    string time = data[i][0] + "-" + data[i][1].PadLeft(2, '0');
                    int num = int.Parse(data[i][2]);
                    int total = GetTotal(dateTime);
                    int month = GetAllMonth(data);

                    UC_ReportTable_card uC_ReportTable_Card = new UC_ReportTable_card();
                    uC_ReportTable_Card.Init(time, num, total, month);
                    uC_ReportTable_Card.Location = new Point(0,  i * 60);
                    caedsPanel.Controls.Add(uC_ReportTable_Card);
                }
            }
        }

        private int GetTotal(string dateTime)
        {
            //service , income
            if (type == "service")
            {
                string sql = $"SELECT COUNT(*)  FROM Orders WHERE year(Time) = {dateTime}";
                return int.Parse(SQLCursor.Query(sql)[0]);
            }
            else if (type == "income")
            {
                string sql = $"SELECT SUM(Price)  FROM Orders WHERE year(Time) = {dateTime}";
                return int.Parse(SQLCursor.Query(sql)[0]);
            }
            return 0;
        }

        private int GetAllMonth(dynamic data)
        {
            string currentYeat = DateTime.Now.ToString("yyyy");
            if (data[0][0] == currentYeat)
            {
                return int.Parse(DateTime.Now.ToString("MM"));
            }
            else
            {
                return 12;
            }
        }

        private void serviceType_DropDownClosed(object sender, EventArgs e)
        {
            string[] res = GetAllComboboxData();
            CreatCard(int.Parse(res[0]), res[1], int.Parse(res[2]));
            InitTopbar(res[1]);
        }

        private void dateTIme_DropDownClosed(object sender, EventArgs e)
        {
            string[] res = GetAllComboboxData();
            CreatCard(int.Parse(res[0]), res[1], int.Parse(res[2]));
            InitTopbar(res[1]);
        }

        private void order_DropDownClosed(object sender, EventArgs e)
        {
            string[] res = GetAllComboboxData();
            CreatCard(int.Parse(res[0]), res[1], int.Parse(res[2]));
            InitTopbar(res[1]);
        }

        private string[] GetAllComboboxData()
        {
            string serviceTypeText;
            string datetimeText;
            string orderText;

            if (serviceType.SelectedIndex == -1)
            {
                serviceTypeText = "0";
            }
            else
            {
                serviceTypeText = serviceType.SelectedIndex.ToString();
            }

            if (order.SelectedIndex == -1)
            {
                orderText = "0";
            }
            else
            {
                orderText = order.SelectedIndex.ToString();
            }

            try
            {
                datetimeText = dateTIme.SelectedItem.ToString();
            }
            catch
            {
                datetimeText = DateTime.Now.ToString("yyyy");
            }

            string[] res = { serviceTypeText, datetimeText, orderText };
            return res;
        }
    }
}
