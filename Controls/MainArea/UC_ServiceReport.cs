using CefSharp.WinForms;
using miniSys0._3.Controls.Others;
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
    public partial class UC_ServiceReport : UserControl
    {
        public UC_ServiceReport()
        {
            InitializeComponent();
            InitCrumb();
            InitTheme();
            InitCef();
            InDateNum();
            InitData();
        }
        public static ChromiumWebBrowser WebBrowserSR;
        private int dateNum;
        private void InitCrumb()
        {
            urC_Crumbs1.crumbText.Text = "Service report";
            urC_Crumbs1.crumbsHome.Text = " / Data /            rt";
        }
        public void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
            }
        }

        private void InitCef()
        {
            chartPanel.Controls.Clear();
            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")) + 
                $"Html\\adminServiceReport.html";
            WebBrowserSR = new ChromiumWebBrowser(path);
            WebBrowserSR.Dock = DockStyle.Fill;                                                                 
            WebBrowserSR.Dock = DockStyle.Fill;
            WebBrowserSR.MenuHandler = new MenuHandler();
            this.chartPanel.Controls.Add(WebBrowserSR);
        }


        private async void refreshlButton2_Click(object sender, EventArgs e)
        {
            InitData();
            await WebBrowserSR.GetBrowser().MainFrame.EvaluateScriptAsync("refresh()");
        }
        private string dataset1 = "";
        private string dataset2 = "";
        private string dataset3 = "";
        private string dataset4 = "";
        private string dataset5 = "";
        private string dataset6 = "";
        private string dataset7 = "";
        private string dataset8 = "";
        private string monthOrders = "";
        private string monthFinised = "";
        private string monthCustomers = "";
        private string topServiceVolumeLabel = "";
        private string topServiceVolumeData = "";
        private string topRepairVolumeLabel = "";
        private string topRepairVolumeData = "";
        private string averageService = "";
        private string averageRepair = "";
        private string order_quantity = "";
        private string order_quantity_per = "";
        private string order_quantity_month = "";
        private string new_customers = "";
        private string new_customers_per = "";
        private string new_customers_month = "";
        private string service_score = "";
        private string service_score_per = "";
        private string service_score_month = "";
        private string completion_speed = "";
        private string completion_speed_per = "";
        private string completion_speed_month = "";
        private string serverTypeRatio = "";
        private string starRatio = "";
        private string speedRatio = "";
        private void InDateNum()
        {
            dateNum = int.Parse(DateTime.Now.ToString("dd"));
        }
        //UC_IncomeAnalysis.arrayToListStr
        //UC_IncomeAnalysis.arrayToStrList
        private void InitData()
        {

            //monthOrders = SQLCursor.Query(monthOrders_sql)[0];
            string monthOrders_sql = "select COUNT(*) from Orders where datediff(MONTH,Time,getdate()) = 0";
            dynamic[] monthOrders_data = SQLCursor.Query(monthOrders_sql);
            if (monthOrders_data.Length >0)
            {
                monthOrders = monthOrders_data[0];
            }
            else
            {
                monthOrders = "0";
            }
            
            //monthFinised = SQLCursor.Query("select COUNT(*) from Schedule where datediff(MONTH,Time,getdate()) = 0 and Status ='Completed';")[0];
            string monthFinised_sql = "select COUNT(*) from Schedule where datediff(MONTH,Time,getdate()) = 0 and Status ='Completed';";
            dynamic[] monthFinised_data = SQLCursor.Query(monthFinised_sql);
            if (monthFinised_data.Length >0)
            {
                monthFinised = monthFinised_data[0];
            }
            else
            {
                monthFinised = "0";
            }


            //monthCustomers = SQLCursor.Query("SELECT  COUNT( DISTINCT CustomerID) from Orders where datediff(MONTH,Time,getdate()) = 0")[0];
            string monthCustomers_sql = "";
            dynamic[] monthCustomers_data = SQLCursor.Query(monthCustomers_sql);
            if (monthCustomers_data.Length>0)
            {
                monthCustomers = monthCustomers_data[0];
            }
            else
            {
                monthCustomers = "0";
            }

            // multi line chart
            dataset1 = UC_IncomeAnalysis.arrayToListStr(get12MonthsServerTpyeData($"Ser00{1}"));
            dataset2 = UC_IncomeAnalysis.arrayToListStr(get12MonthsServerTpyeData($"Ser00{2}"));
            dataset3 = UC_IncomeAnalysis.arrayToListStr(get12MonthsServerTpyeData($"Ser00{3}"));
            dataset4 = UC_IncomeAnalysis.arrayToListStr(get12MonthsServerTpyeData($"Ser00{4}"));
            dataset5 = UC_IncomeAnalysis.arrayToListStr(get12MonthsServerTpyeData($"Ser00{5}"));
            dataset6 = UC_IncomeAnalysis.arrayToListStr(get12MonthsServerTpyeData($"Ser00{6}"));
            dataset7 = UC_IncomeAnalysis.arrayToListStr(get12MonthsServerTpyeData($"Ser00{7}"));
            dataset8 = UC_IncomeAnalysis.arrayToListStr(get12MonthsServerTpyeData($"Ser00{8}"));



            //top service
            dynamic[] topServicerData = SQLCursor.Query("with temp AS ( select Orders.Time, Orders.ReceptionistID, Staff.Name From Orders " +
                "INNER JOIN Staff ON Staff.StaffID = Orders.ReceptionistID) " +
                "Select TOP 5 temp.Name,COUNT(*) From temp " +
                "where datediff(DD, temp.Time, getdate()) <= 30 " +
                "GROUP BY temp.Name " +
                "ORDER BY COUNT(*) DESC; ");
            string[] topServicerNameList = new string[5];
            string[] topServicerValueList = new string[5];
            for (int i = 0; i < topServicerData.Length; i++)
            {
                topServicerNameList[i] = topServicerData[i][0];
                topServicerValueList[i] = topServicerData[i][1];
            }
            topServiceVolumeLabel = UC_IncomeAnalysis.arrayToStrList(topServicerNameList);
            topServiceVolumeData = UC_IncomeAnalysis.arrayToListStr(topServicerValueList);

            //top repair
            string topRepairSql = "with temp AS (select Schedule.Time,Schedule.Status, Schedule.TechnicianID, Staff.Name From Schedule " +
                "INNER JOIN Staff ON Staff.StaffID = Schedule.TechnicianID ) " +
                "Select TOP 5 temp.Name,COUNT(*) From temp " +
                "where datediff(DD, temp.Time, getdate()) <= 30 and temp.Status ='Completed' " +
                "GROUP BY temp.Name " +
                "ORDER BY COUNT(*) DESC; ";
            //Console.WriteLine(topRepairSql);
            dynamic topRepairData = SQLCursor.Query(topRepairSql);
            string[] topRepairNameList = new string[5];
            string[] topRepairValueList = new string[5];
            for (int i = 0; i < topRepairData.Length; i++)
            {
                topRepairNameList[i] = topRepairData[i][0];
                topRepairValueList[i] = topRepairData[i][1];
            }
            topRepairVolumeLabel = UC_IncomeAnalysis.arrayToStrList(topRepairNameList);
            topRepairVolumeData = UC_IncomeAnalysis.arrayToListStr(topRepairValueList);

            string NumReceptionist = SQLCursor.Query("select COUNT(*) from Staff Where Post = 'Receptionist';")[0];
            string NumTechnican = SQLCursor.Query("select COUNT(*) from Staff Where Post = 'Technican';")[0];
            averageService = (int.Parse(monthOrders) / int.Parse(NumReceptionist)).ToString();
            averageRepair = (int.Parse(monthFinised) / int.Parse(NumTechnican)).ToString();

            //order quantity
            string SQLOrderNum = "";
            for (int i = 11; i >= 0; i--)
            {
                string sql = $"select COUNT(*) from Orders where datediff(MONTH,Time,getdate()) = {i}";
                SQLOrderNum += sql;
            }
            dynamic[] SQLOrderData = SQLCursor.QueryMany(SQLOrderNum);

            string[] orderNUmLIst = new string[12];
            for (int i = 0; i < SQLOrderData.Length; i++)
            {
                orderNUmLIst[i] = SQLOrderData[i][0];
            }
            order_quantity = orderNUmLIst[11];
            int orderIncreace = (int.Parse(order_quantity) - int.Parse(orderNUmLIst[10]))/int.Parse(order_quantity);
            order_quantity_per = orderIncreace.ToString();
            order_quantity_month = UC_IncomeAnalysis.arrayToListStr(orderNUmLIst);

            // new customers
            string SQLNewCus = "";
            for (int i = 11; i >= 0; i--)
            {
                string sql = $"SELECT  COUNT( DISTINCT CustomerID) from Orders where datediff(MONTH,Time,getdate()) =  {i}";
                SQLNewCus += sql;
            }
            dynamic[] SQLCUSData = SQLCursor.QueryMany(SQLNewCus);

            string[] newCusLIst = new string[12];
            for (int i = 0; i < SQLOrderData.Length; i++)
            {
                newCusLIst[i] = SQLCUSData[i][0];
            }
            new_customers = newCusLIst[11];
            int newCusIncreace = (int.Parse(order_quantity) - int.Parse(newCusLIst[10])) / int.Parse(order_quantity);
            new_customers_per = newCusIncreace.ToString();
            new_customers_month = UC_IncomeAnalysis.arrayToListStr(newCusLIst);

            //server star
            string SQLStar = "";
            for (int i = 11; i >= 0; i--)
            {
                string sql = $"select AVG(Star) from Orders where datediff(MONTH,Time,getdate()) =  {i}";
                SQLStar += sql;
            }
            dynamic[] SQLStarData = SQLCursor.QueryMany(SQLStar);

            string[] newStarLIst = new string[12];
            for (int i = 0; i < SQLStarData.Length; i++)
            {
                newStarLIst[i] = SQLStarData[i][0];

            }
            service_score = newStarLIst[11];
            int newStarIncreat = (int.Parse(service_score) - int.Parse(newStarLIst[10])) / int.Parse(service_score);
            service_score_per = newStarIncreat.ToString();
            service_score_month = UC_IncomeAnalysis.arrayToListStr(newStarLIst);

            // complation speed
            
           
            string[] speedList = new string[12];
            for (int i = 11; i >=0; i--)
            {
                List<int> speedData = completeSpeed(i);
                int average = speedData.Sum() / speedData.Count;
                speedList[11-i] = average.ToString();
            }
            completion_speed = speedList[11];
            int speedIncrease = (int.Parse(completion_speed) - int.Parse(speedList[10])) / int.Parse(completion_speed);
            completion_speed_per = speedIncrease.ToString();
            completion_speed_month = UC_IncomeAnalysis.arrayToListStr(speedList);

            //pie service type
            string SQLSerViceType = "";
            for (int i = 0; i < 8; i++)
            {
                string sql = $"Select COUNT(*) From Orders Where datediff(MONTH,Time,getdate()) = 0  and Service_type = 'Ser00{i + 1}';";
                SQLSerViceType += sql;
            }

            dynamic[] SQLServerTypeData = SQLCursor.QueryMany(SQLSerViceType);

            string[] newServerTypeLIst = new string[8];
            for (int i = 0; i < SQLServerTypeData.Length; i++)
            {
                newServerTypeLIst[i] = SQLServerTypeData[i][0];
            }
            serverTypeRatio = UC_IncomeAnalysis.arrayToListStr(newServerTypeLIst);

            //pie star
            string SQLStar2 = "";
            for (int i = 0; i < 5; i++)
            {
                string sql = $"select COUNT(*) from Orders where datediff(MONTH,Time,getdate()) = 0 and Star ={i + 1};";
                SQLStar2 += sql;
            }

            dynamic[] SQLStarData2 = SQLCursor.QueryMany(SQLStar);
            string[] starDataLIst = new string[5];
            for (int i = 0; i < 5; i++)
            {
                starDataLIst[i] = SQLStarData2[i][0];
            }
            starRatio = UC_IncomeAnalysis.arrayToListStr(starDataLIst);

            //pie speed
            List<int> speedDataThisMonth = completeSpeed(0);
            int[] timeNunList = { 0,0,0,0,0};
            for (int i = 0; i < speedDataThisMonth.Count; i++)
            {
                int time = speedDataThisMonth[i];
                if(time > 0 && time <= 24)
                {
                    timeNunList[0]++;
                }
                else if (time > 24 && time <= 72)
                {
                    timeNunList[1]++;
                }
                else if (time > 72 && time <= 120)
                {
                    timeNunList[2]++;
                }
                else if (time > 120 && time <= 168)
                {
                    timeNunList[3]++;
                }
                else if (time > 168)
                {
                    timeNunList[4]++;
                }
            }
            speedRatio = UC_IncomeAnalysis.arrayToListStr(timeNunList);
            storeToFile();
        }
        private string[] get12MonthsServerTpyeData(string typeID)
        {
            //typeID Ser001 - Ser008
            string SQLDatasets = "";
            for (int i = 11; i >= 0; i--)
            {
                string sql = $"select COUNT(*) from Orders where datediff(MONTH,Time,getdate()) = {i} and Service_type ='{typeID}';";
                SQLDatasets += sql;
            }
            dynamic dataOfDatasets = SQLCursor.QueryMany(SQLDatasets);
            string[] result = new string[12];
            for (int i = 0; i < 12; i++)
            {
                result[i] = dataOfDatasets[i][0];
            }
            
            return result;
        }

        private List<int> completeSpeed(int monthDiff)
        {
            string SQLSpeed = $"WITH A AS(Select OrderID,Time From Schedule Where datediff(MONTH,Time,getdate()) = {monthDiff}  and Status = 'Order'), " +
                $"B AS(Select OrderID, Time From Schedule Where datediff(MONTH, Time, getdate()) =  {monthDiff}  " +
                $"and Status = 'Completed') " +
                "SELECT A.time,B.Time,A.OrderID From A " +
                "INNER JOIN B ON B.OrderID = A.OrderID; ";
            //Console.WriteLine(SQLSpeed);
            dynamic speedData = SQLCursor.Query(SQLSpeed);
            List<int> result = new List<int>();
            for (int i = 0; i < speedData.Length; i++)
            {
                result.Add(int.Parse(diffTime(speedData[i][0], speedData[i][1])));
            }
            return result;
        }



        private string diffTime(string startTime, string endTime)
        {
            DateTime yesTime1 = Convert.ToDateTime(startTime);
            DateTime yesTime2 = Convert.ToDateTime(endTime);
            TimeSpan ts = yesTime2 - yesTime1;
            string time = ts.TotalHours.ToString("f0");
            return time;
        }
        private void storeToFile()
        {
            string[] data = new string[33];
            data[0] = "dataset1 " + "=" + dataset1 + ";";
            data[1] = "dataset2 " + "=" + dataset2 + ";";
            data[2] = "dataset3 " + "=" + dataset3 + ";";
            data[3] = "dataset4 " + "=" + dataset4 + ";";
            data[4] = "dataset5 " + "=" + dataset5 + ";";
            data[5] = "dataset6 " + "=" + dataset6 + ";";
            data[6] = "dataset7 " + "=" + dataset7 + ";";
            data[7] = "dataset8 " + "=" + dataset8 + ";";
            data[8] = "monthOrders " + "=" + monthOrders + ";";
            data[9] = "monthFinised " + "=" + monthFinised + ";";
            data[10] = "monthCustomers " + "=" + monthCustomers + ";";
            data[11] = "topServiceVolumeLabel " + "=" + topServiceVolumeLabel + ";";
            data[12] = "topServiceVolumeData " + "=" + topServiceVolumeData + ";";
            data[13] = "topRepairVolumeLabel " + "=" + topRepairVolumeLabel + ";";
            data[14] = "topRepairVolumeData " + "=" + topRepairVolumeData + ";";
            data[15] = "averageService " + "=" + averageService + ";";
            data[16] = "averageRepair " + "=" + averageRepair + ";";
            data[17] = "order_quantity " + "=" + order_quantity + ";";
            data[18] = "order_quantity_per " + "=" + order_quantity_per + ";";
            data[19] = "order_quantity_month " + "=" + order_quantity_month + ";";
            data[20] = "new_customers " + "=" + new_customers + ";";
            data[21] = "new_customers_per " + "=" + new_customers_per + ";";
            data[22] = "new_customers_month " + "=" + new_customers_month + ";";
            data[23] = "service_score " + "=" + service_score + ";";
            data[24] = "service_score_per " + "=" + service_score_per + ";";
            data[25] = "service_score_month " + "=" + service_score_month + ";";
            data[26] = "completion_speed " + "=" + completion_speed + ";";
            data[27] = "completion_speed_per " + "=" + completion_speed_per + ";";
            data[28] = "completion_speed_month " + "=" + completion_speed_month + ";";
            data[29] = "serverTypeRatio " + "=" + serverTypeRatio + ";";
            data[30] = "starRatio " + "=" + starRatio + ";";
            data[31] = "speedRatio " + "=" + speedRatio + ";";
            data[32] = $"; theme = '{User_type.user_theme}';";

            // read file content 
            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")) +
                $"Html\\parameterForServiceReport.js";

            //empty old file
            FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite);
            fs.Close();
            //stor new to js file
            for (int i = 0; i < data.Length; i++)
            {
                File.AppendAllText(path, data[i] + Environment.NewLine);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (ok.Text == "Table view")
            {
                ok.Text = "Chart view";
                InitTable();
            }
            else if (ok.Text == "Chart view")
            {
                ok.Text = "Table view";
                InitCef();
            }

            
        }

        private void InitTable()
        {
            chartPanel.Controls.Clear();
            if (Main.main.currentMainPage == "UC_ServiceReport")
            {
                UC_Report_table uC_Report_table = new UC_Report_table("service");
                chartPanel.Controls.Add(uC_Report_table);
            }
            else if (Main.main.currentMainPage == "UC_IncomeAnalysis")
            {
                UC_Report_table uC_Report_table = new UC_Report_table("income");
                chartPanel.Controls.Add(uC_Report_table);
            }
        }
    }
}
