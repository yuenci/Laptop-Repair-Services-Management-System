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
        }

        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                dynamic[] lable = { };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
            else if (User_type.user_theme == "light")
            {

            }
        }

        private void InitYear()
        {
            string sql = "SELECT TOP 1 YEAR(Time)   FROM Orders ORDER BY Time ASC ;" +
                "SELECT TOP 1 YEAR(Time)   FROM Orders ORDER BY Time DESC;";

            dynamic[] data = SQLCursor.Query(sql);
            if (data.Length >0)
            {
                int start = int.Parse(data[0][0]);
                int end = int.Parse(data[1][0]);
                for (int i = start; i < end - start; i++)
                {
                    dateTIme.Items.Add(start);
                }
                //SQLCursor()
            }


        }

        private void Init()
        {
            string year = DateTime.Now.ToString("yyyy");

            string sql = CreateSQL(year);
            dynamic[] data= SQLCursor.Query(sql);
            if (data.Length >0)
            {
                
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
            string sql = CreateSQL(dateTime, order, serviceType);
            dynamic[] data= SQLCursor.Query(sql);
            if (data.Length >0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    string time = data[i][0] + "-" + data[i][1];
                    int num = int.Parse(data[i][2]);
                    int total = GetTotal(dateTime);
                    int month = GetAllMonth(data);

                    UC_ReportTable_card uC_ReportTable_Card = new UC_ReportTable_card();
                    uC_ReportTable_Card.Location = Point(40, 70 + i * 50);

                }
            }
        }

        private int GetTotal(string dateTime)
        {
            //service , income
            if (type == "service")
            {
                string sql = $"SELECT COUNT(*)  FROM Orders WHERE year(Time) = {dateTime}";
                return SQLCursor.Query(sql)[0];
            }
            else if (type == "income")
            {
                string sql = $"SELECT SUM(Price)  FROM Orders WHERE year(Time) = {dateTime}";
                return SQLCursor.Query(sql)[0];
            }
            return 0;
        }

        private int GetAllMonth(dynamic data)
        {
            string currentYeat = DateTime.Now.ToString("yyyy");
            if (data[0][0] == currentYeat)
            {
                return data.Length();
            }
            else
            {
                return 12;
            }
        }
    }
}
