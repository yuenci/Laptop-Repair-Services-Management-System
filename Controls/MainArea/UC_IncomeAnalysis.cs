using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static miniSys0._3.Controls.UC_main;

namespace miniSys0._3.Controls.MainArea
{
    public partial class UC_IncomeAnalysis : UserControl
    {
        public static ChromiumWebBrowser WebBrowserIA;
        private int dateNum;
        private string totalIncome = "";
        private string totalIncome_AD = "";
        private string weekOn = "";
        private string dayOn = "";
        private string paymentsNum = "";
        private string paymentsNum_month = "";
        private string paymentsNum_AD = "";
        private string ATV = "";
        private string ATV_month = "";
        private string ATV_AD = "";
        private string HRE = "";
        private string HRE_month = "";
        private string HRE_AD = "";
        private string month_Income = "";
        private string top_saler = "";
        private string top_saler_value = "";
        private string time_income_value = "";
        private string time_order_value = "";
        private string server_type_income = "";
        private string payment_method = "";

        public UC_IncomeAnalysis()
        {
            InitializeComponent();
            InitCrumb();
            InitTheme();
            InitCef();
            InDateNum();
            InitData();
        }
        
        private void InitCrumb()
        {
            urC_Crumbs1.crumbText.Text = "Income Analysis";
            urC_Crumbs1.crumbsHome.Text = " / Data /            rt";
        }


        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
            }
        }
        
        private void InitCef()
        {
            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")) + 
                $"Html\\adminIncomeAnalysis.html";
            WebBrowserIA = new ChromiumWebBrowser(path);
            WebBrowserIA.Dock = DockStyle.Fill;                                                  
            WebBrowserIA.Dock = DockStyle.Fill;
            WebBrowserIA.MenuHandler = new MenuHandler();
            this.chartPanel.Controls.Add(WebBrowserIA);

        }

        private async void refreshlButton2_Click(object sender, EventArgs e)
        {
            InitData();
            await WebBrowserIA.GetBrowser().MainFrame.EvaluateScriptAsync("refresh()");
        }
        
        private void InDateNum()
        {
            dateNum = int.Parse(DateTime.Now.ToString("dd"));
        }
        
        private void InitData()
        {
            // card1
            totalIncome = SQLCursor.Query("select sum(Price) from Orders where datediff(MONTH,Time,getdate()) = 0")[0];
            totalIncome_AD = (int.Parse(totalIncome) / dateNum).ToString();

            string incomeThisWeek = SQLCursor.Query("select sum(Price) from Orders where datediff(week,Time,getdate()) = 0")[0];
            int incomeThisWeekInt = int.Parse(incomeThisWeek);

            string incomeLastWeek = SQLCursor.Query("select sum(Price) from Orders where datediff(week,Time,getdate()) = 1")[0];
            int incomeLastWeekInt = int.Parse(incomeLastWeek);

            double weekOnDou = ((double)incomeThisWeekInt - (double)incomeLastWeekInt) / (double)incomeThisWeekInt;
            weekOn = weekOnDou.ToString();

            string incomeToday = SQLCursor.Query("select sum(Price) from Orders where datediff(DAY,Time,getdate()) = 0")[0];
            int incomeTodayInt = int.Parse(incomeToday);

            string incomeYestoday = SQLCursor.Query("select sum(Price) from Orders where datediff(DAY,Time,getdate()) = 1")[0];
            int incomeYestodayInt = int.Parse(incomeYestoday);

            double dayOnDou = ((double)incomeTodayInt - (double)incomeYestodayInt) / (double)incomeTodayInt;
            dayOn = dayOnDou.ToString();

            //card2
            paymentsNum = SQLCursor.Query("select COUNT(*) from Orders where datediff(MONTH,Time,getdate()) = 0")[0];

            string SQLs = "";
            for (int i = 11; i >= 0; i--)
            {
                string sql = $"select COUNT(*) from Orders where datediff(MONTH,Time,getdate()) = {i};";
                SQLs += sql;
            }
            dynamic[] paymentsNum_month_data = SQLCursor.QueryMany(SQLs);
            paymentsNum_month = arrayToListStr(paymentsNum_month_data);
            paymentsNum_AD = (int.Parse(paymentsNum) / dateNum).ToString();

            //card3
            string diffCus = SQLCursor.Query("SELECT  COUNT( DISTINCT CustomerID) from Orders where datediff(MONTH,Time,getdate()) = 0")[0];
            string incomeThisMonth = SQLCursor.Query("select sum(Price) from Orders where datediff(MONTH,Time,getdate()) = 0")[0];
            ATV = (int.Parse(incomeThisMonth) / int.Parse(diffCus)).ToString();

            // how many different customer each month
            string SQLcus = "";
            for (int i = 11; i >= 0; i--)
            {
                string sql = $"SELECT  COUNT( DISTINCT CustomerID) from Orders where datediff(MONTH,Time,getdate()) = {i};";
                SQLcus += sql;
            }
            dynamic dataCus = SQLCursor.QueryMany(SQLcus);

            // how income got  each month
            string SQLinc = "";
            for (int i = 11; i >= 0; i--)
            {
                string sql = $"select sum(Price) from Orders where datediff(MONTH,Time,getdate()) = {i};";
                SQLinc += sql;
            }
            dynamic dataInc = SQLCursor.QueryMany(SQLinc);

            string[] ATV_month_list = new string[12];

            for (int i = 0; i < 12; i++)
            {
                int result   = int.Parse(dataInc[i][0]) / int.Parse(dataCus[i][0]);
                ATV_month_list[i] = result.ToString();
            }
            ATV_month = arrayToListStr(ATV_month_list);

            ATV_AD = (int.Parse(ATV) / dateNum).ToString();

            //card 4

            string staffNum = SQLCursor.Query("SELECT count(Name) From Staff;")[0];
            int staffNumInt = int.Parse(staffNum);
            HRE = (int.Parse(totalIncome) / staffNumInt).ToString();


            //from now to last year {"2021-03":"2";}
            Dictionary<string, string> newStaffNUm = new Dictionary<string, string>();

            dynamic[] newStaffData = SQLCursor.Query("SELECT TOP 12  format(Regtime, 'yyyy-MM'),count(Name) " +
                "FROM Staff GROUP BY format(Regtime, 'yyyy-MM') " +
                "Order By format(Regtime, 'yyyy-MM') DESC; ");

            for (int i = 0; i < newStaffData.Length; i++)
            {
                newStaffNUm.Add(newStaffData[i][0], newStaffData[i][1]);
            }

            DateTime dt = DateTime.Now;
            Dictionary<string, string> newStaffNUmOneYear = new Dictionary<string, string>();
            for (int i = 0; i < 12; i++)
            {
                string year_month = dt.AddMonths(-i).ToString("yyyy-MM");
                if (newStaffNUm.ContainsKey(year_month))
                {
                    newStaffNUmOneYear.Add(year_month, newStaffNUm[year_month]);
                }
                else
                {
                    newStaffNUmOneYear.Add(year_month, "0");
                }
            }


            Dictionary<string, string>.ValueCollection newStaffEachMonth = newStaffNUmOneYear.Values;


            //last yeat to this year
            string[] staffNumEachMonth = new string[12];
            int eachMonthStaffNum = staffNumInt;
            for (int i = 0; i < 12; i++)
            {
                eachMonthStaffNum = eachMonthStaffNum - int.Parse(newStaffEachMonth.ToArray()[i]);
                staffNumEachMonth[11 - i] = eachMonthStaffNum.ToString();
            }
            HRE_month = arrayToListStr(staffNumEachMonth);
            HRE_AD = (int.Parse(HRE) / dateNum).ToString();


            //lineChart1
            string[] each_month_income = new string[12];
            for(int i = 0; i < 12; i++)
            {
                each_month_income[i] = dataInc[i][0];
            }
            month_Income = arrayToListStr(each_month_income);

            //topRank
            dynamic dataTopSaler = SQLCursor.Query("Select TOP 7 SUM(Price),ReceptionistID  From Orders " +
                "where datediff(MONTH, Time, getdate()) = 0 " +
                "GROUP BY ReceptionistID ORDER BY SUM(Price) DESC; ");

            string[] top_saler_valueList = new string[7];

            string[] top_salerID = new string[7];

            for (int i = 0; i < 7; i++)
            {
                top_saler_valueList[i] = dataTopSaler[i][0];
                top_salerID[i] = dataTopSaler[i][1];
            }

            string[] top_salerName = new string[7];

            for (int i = 0; i < 7; i++)
            {
                top_salerName[i] = SQLCursor.Query($"Select Name From Staff Where StaffID = '{top_salerID[i]}'")[0];
            }
            top_saler = arrayToStrList(top_salerName);
            top_saler_value = arrayToListStr(top_saler_valueList);

            //lineChart2Hour
            dynamic dataHour = SQLCursor.Query("SELECT Sum(Price) " +
                "FROM Orders where datediff(MONTH, Time, getdate()) = 0 " +
                "GROUP BY DATEPART(HOUR, Time)");

            string[] time_value_list = new string[24];
            for (int i = 0; i < dataHour.Length; i++)
            {
                time_value_list[i] = dataHour[i][0];
            }
            time_income_value = arrayToListStr(time_value_list);

            dynamic dataHourOrder = SQLCursor.Query("SELECT Count(*) " +
                "FROM Orders where datediff(MONTH, Time, getdate()) = 0 " +
                "GROUP BY DATEPART(HOUR, Time)");

            string[] time_value_Order_list = new string[24];
            for (int i = 0; i < dataHourOrder.Length; i++)
            {
                time_value_Order_list[i] = dataHourOrder[i][0];
            }
            time_order_value = arrayToListStr(time_value_Order_list);


            // pie1ServiceTpye
            dynamic[] data_server_type = SQLCursor.Query("Select SUM(Price) " +
                "From Orders where datediff(MONTH, Time, getdate()) = 0 " +
                "GROUP BY Service_type; ");

            string[] server_type_income_list = new string[8];
            for (int i = 0; i < data_server_type.Length; i++)
            {
                server_type_income_list[i] = data_server_type[i][0];
            }
            server_type_income = arrayToListStr(server_type_income_list);

            //pie2PaymentMethod
            dynamic[] data_method = SQLCursor.Query("Select Payment_Method,SUM(Price) From Orders " +
                "where datediff(MONTH, Time, getdate()) = 0 " +
                "GROUP BY Payment_Method; ");

            Dictionary<string, string> paymentMethod = new Dictionary<string, string>();
            for (int i = 0; i < data_method.Length; i++)
            {
                paymentMethod.Add(data_method[i][0], data_method[i][1]);
            }

            string[] payment_method_list = { paymentMethod["Credit Card"], paymentMethod["Paypal"]
                    , paymentMethod["Cash"], paymentMethod["Check"]};

            payment_method = arrayToListStr(payment_method_list);

            storeToFile();
        }

        private void storeToFile()
        {
            string[] data = new string[21];
            data[0]= "totalIncome" + "=" + totalIncome+";" ;
            data[1]= "totalIncome_AD" + "=" + totalIncome_AD + ";";
            data[2]= "weekOn" + "=" + weekOn + ";";
            data[3] = "dayOn" + "=" + dayOn + ";";
            data[4]= "paymentsNum" + "=" + paymentsNum + ";";
            data[5]= "paymentsNum_month" + "=" + paymentsNum_month + ";";
            data[6]= "paymentsNum_AD" + "=" + paymentsNum_AD + ";";
            data[7] = "ATV" + "=" + ATV + ";";
            data[8] = "ATV_month" + "=" + ATV_month + ";";
            data[9] = "ATV_AD" + "=" + ATV_AD + ";";
            data[10] = "HRE" + "=" + HRE + ";";
            data[11] = "HRE_month" + "=" + HRE_month + ";";
            data[12] = "HRE_AD" + "=" + HRE_AD + ";";
            data[13] = "month_Income" + "=" + month_Income + ";";
            data[14] = "top_saler" + "=" + top_saler + ";";
            data[15] = "top_saler_value" + "=" + top_saler_value + ";";
            data[16] = "time_income_value" + "=" + time_income_value + ";";
            data[17] = "time_order_value" + "=" + time_order_value + ";";
            data[18] = "server_type_income" + "=" + server_type_income + ";";
            data[19] = "payment_method" + "=" + payment_method + ";";
            data[20] = $"; theme = '{User_type.user_theme}';";

            // read file content 
            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")) +
                $"Html\\paramentForIncomeAnalysis.js";

            //empty old file
            FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite);
            fs.Close();
            //stor new to js file
            for (int i = 0; i < data.Length; i++)
            {
                File.AppendAllText(path, data[i] + Environment.NewLine);
            }
        }

        public static dynamic arrayToListStr(dynamic array)
        {
            string result = "[";
            try
            {
                string temp = array[0][0];
                for (int i = 0; i < array.Length; i++)
                {
                    result += array[i][0] + ",";
                }
                return result + "]";

            }
            catch
            {
                for (int i = 0; i < array.Length; i++)
                {
                    result += array[i] + ",";
                }
                return result + "]";
            }
            
        }
        
        public static dynamic arrayToStrList(dynamic array)
        {
            string result = "[";
            for (int i = 0; i < array.Length; i++)
            {
                result += "'" + array[i] +"'" + ",";
            }
            return result + "]";
        }
    }
}
