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
    public partial class UC_Cus_OrderDetails : UserControl
    {
        private string ordIDCache = null;
        private bool urgent;

        public UC_Cus_OrderDetails()
        {
            InitializeComponent();
            InitTheme();
            InitStyle();
            Init();
        }
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(18, 31, 43);

                UIUserControl[] controls = { uiUserControl1, uiUserControl2, uiUserControl3 };
                foreach (UIUserControl control in controls)
                {
                    control.FillColor = Color.FromArgb(28, 47, 70);
                    control.BackColor = Color.FromArgb(28, 47, 70);
                    control.RectColor = Color.Transparent;
                }

                dynamic[] lable = { crumbsHome, crumbText, uiLabel20, uiLabel1, orderID, uiLabel8, model, 
                    uiLabel9, uiLabel5, uiLabel2, receptionist, uiLabel3, receiveTime, price, status, 
                    uiLabel7, technician, uiLabel4, edit, uiLabel19, status1, status1Time, status2, 
                    status2Time, status3, status3Time, status4, status4Time, uiLabel10 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

                dynamic[] cards = { card1, card2, card3, card4 };
                foreach (var item in cards)
                {
                    item.InitTheme();
                }
            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.FromArgb(247, 248, 250);

                UIUserControl[] controls = { uiUserControl1, uiUserControl2, uiUserControl3 };
                foreach (UIUserControl control in controls)
                {
                    control.FillColor = Color.White;
                    control.BackColor = Color.White;
                    control.RectColor = Color.Gainsboro;
                }

                dynamic[] lable = { crumbsHome, crumbText, uiLabel20, uiLabel1, orderID, uiLabel8, model,
                    uiLabel9, uiLabel5, uiLabel2, receptionist, uiLabel3, receiveTime, price, status,
                    uiLabel7, technician, uiLabel4, edit, uiLabel19, status1, status1Time, status2,
                    status2Time, status3, status3Time, status4, status4Time, uiLabel10 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }

                dynamic[] cards = { card1, card2, card3, card4 };
                foreach (var item in cards)
                {
                    item.InitTheme();
                }
            }

        }
        private void InitStyle()
        {
            dot1.FillColor = Color.FromArgb(22, 93, 255);
            dot2.FillColor = Color.FromArgb(22, 93, 255);
            dot3.FillColor = Color.FromArgb(22, 93, 255);
            dot4.FillColor = Color.FromArgb(22, 93, 255);

            line1.LineColor = Color.FromArgb(22, 93, 255);
            line2.LineColor = Color.FromArgb(22, 93, 255);
            line3.LineColor = Color.FromArgb(22, 93, 255);

            line1.FillColor = Color.Transparent;
            line2.FillColor = Color.Transparent;
            line3.FillColor = Color.Transparent;
        }
        
        private void Init()
        {
            ordIDCache = SQLCursor.Query($"select Top 1 OrderId From Orders Where CustomerID = '{User_type.user_ID}' Order by Time DESC;")[0];

            // order info
            orderID.Text = ordIDCache;
            dynamic[] data = SQLCursor.Query("select Orders.Model, Customer.Name,Service.Type,Orders.Time " +
                ",Staff.Name, Orders.Price, Orders.Urgent " +
                "From Orders " +
                "Inner Join Customer On Customer.CustomerID = Orders.CustomerID  " +
                "Inner join Service On Service.ServiceID = Orders.Service_type  " +
                "Inner join Staff On Staff.StaffID = Orders.ReceptionistID  " +
                $"Where OrderID = '{ordIDCache}';");

            receptionist.Text = data[4];
            model.Text = data[0];
            receiveTime.Text = data[3];
            serviceType.Text = data[2];
            price.Text = "RM" +data[5];
            urgent = Convert.ToBoolean(int.Parse(data[6]));
            string customerName = data[1];

            // order staff
            if (SQLCursor.ifCurrentOrderNotStart())
            {
                string sqlOrderStaff = $"select TOP 1 Schedule.Status" +
                $" From Schedule " +
                $"Where OrderID ='{ordIDCache}' Order by Time DESC";
                dynamic[] data2 = SQLCursor.Query(sqlOrderStaff);
                technician.Text = "";
                status.Text = statusStr(data2[0]);
                setStatusButton(data2[0]);
            }
            else
            {
                string sqlOrderStaff = $"select TOP 1 Staff.Name,Schedule.Status" +
                $" From Schedule " +
                $"Inner join Staff On Staff.StaffID = Schedule.TechnicianID " +
                $"Where OrderID ='{ordIDCache}' Order by Time DESC";
                dynamic[] data2 = SQLCursor.Query(sqlOrderStaff);
                technician.Text = data2[0];
                status.Text = statusStr(data2[1]);
                setStatusButton(data2[1]);
            }


            //Console.WriteLine(statusStr(data2[1]));

            serviceType.Enabled = false;

            InitRecentRepair();
        }
        
        private void edit_Click(object sender, EventArgs e)
        {
            if (edit.Text =="Edit")
            {
                edit.Text = "OK";
                edit.ForeColor = Color.Green;
                serviceType.Enabled = true;
            }
            else if (edit.Text =="OK")
            {
                edit.Text = "Edit";
                edit.ForeColor = Color.FromArgb(22, 93, 255);
                if (serviceType.SelectedIndex !=-1)
                {
                    SQLCursor.Execute($"UPDATE Orders SET Service_type = " +
                        $"'{"Ser00" + (serviceType.SelectedIndex+1).ToString()}' " +
                        $"Where OrderID ='{ordIDCache}'");
                    string newPrice = "";
                    if (urgent)
                    {
                        newPrice = SQLCursor.Query("Select Urgent_fee From Service Where ServiceID =" +
                            $"'{"Ser00" + (serviceType.SelectedIndex + 1).ToString()}'")[0];
                    }
                    else
                    {
                        newPrice = "RM" + SQLCursor.Query("Select Normal_fee From Service Where ServiceID =" +
                            $"'{"Ser00" + (serviceType.SelectedIndex + 1).ToString()}'")[0];
                    }
                    price.Text = newPrice;
                    serviceType.Enabled = false;
                }
                else
                {
                    serviceType.Text = SQLCursor.Query("select Top 1 Service.Type  From Orders " +
                        "Inner Join Service On Service.ServiceID = Orders.Service_type " +
                        "Where CustomerID= 'Cus000001' Order By Time DESC;")[0];
                    serviceType.Enabled = false;
                }

            }
        }

        private string statusStr(string status)
        {
            
            if (status == "Order")
            {
                line1.LineColor = Color.FromArgb(242, 243, 245);
                line2.LineColor = Color.FromArgb(242, 243, 245);
                line3.LineColor = Color.FromArgb(242, 243, 245);
                dot2.FillColor = Color.FromArgb(242, 243, 245);
                dot3.FillColor = Color.FromArgb(242, 243, 245);
                dot4.FillColor = Color.FromArgb(242, 243, 245);

                status2.Visible = false;
                status2Time.Visible = false;
                status3.Visible = false;
                status3Time.Visible = false;
                status4.Visible = false;
                status4Time.Visible = false;

                status1Time.Text = getTime("Order");
                //Console.WriteLine("YES------------------------");
                return "Accept order";
            }
            else if (status == "Progress")
            {

                line2.LineColor = Color.FromArgb(242, 243, 245);
                line3.LineColor = Color.FromArgb(242, 243, 245);
                dot3.FillColor = Color.FromArgb(242, 243, 245);
                dot4.FillColor = Color.FromArgb(242, 243, 245);

                status3.Visible = false;
                status3Time.Visible = false;
                status4.Visible = false;
                status4Time.Visible = false;

                status1Time.Text = getTime("Order");
                status2Time.Text = getTime("Progress");

                return "Start repairing";
            }
            else if (status == "Completed")
            {

                line3.LineColor = Color.FromArgb(242, 243, 245);
                dot4.FillColor = Color.FromArgb(242, 243, 245);

                status4.Visible = false;
                status4Time.Visible = false;

                status1Time.Text = getTime("Order");
                status2Time.Text = getTime("Progress");
                status3Time.Text = getTime("Completed");


                return "Complete repair";
            }
            else if (status == "Finished")
            {
                status1Time.Text = getTime("Order");
                status2Time.Text = getTime("Progress");
                status3Time.Text = getTime("Completed");
                status4Time.Text = getTime("Finished");
                return "Order finish";
            }
            else
            {
                return null;
            }
        }
        
        private void setStatusButton(string status)
        {
            infoBar.Hide();
            if (status == "Completed" )
            {
                statusBtn.Enabled = true;
                statusBtn.FillColor = Color.FromArgb(0, 180, 42);
                statusBtn.FillHoverColor = Color.FromArgb(35, 195, 67);
                statusBtn.FillPressColor = Color.FromArgb(35, 195, 67);
                statusBtn.Text = "Finished";

            }
            else if(status == "Finished")
            {
                statusBtn.Enabled = false;
                statusBtn.Text = "End";
            }
            else if(status == "Progress")
            {
                statusBtn.Enabled = false;
                statusBtn.Text = "Repairing";
            }
            else if (status == "Order")
            {
                statusBtn.Enabled = false;
                statusBtn.Text = "Ordered";
            }
        }
        
        private string getTime(string type)
        {
            if (type == "Order")
            {


                string time = SQLCursor.Query("Select Time from Schedule Where " +
                    $"OrderID ='{ordIDCache}' " +
                    "And Status = 'Order';")[0];

                return time;
            }
            else if (type == "Progress")
            {
                string time = SQLCursor.Query("Select Time from Schedule Where " +
                                    $"OrderID ='{ordIDCache}' " +
                                    "And Status = 'Progress';")[0];

                return time;
            }
            else if (type == "Completed")
            {

                string time = SQLCursor.Query("Select Time from Schedule Where " +
                                    $"OrderID ='{ordIDCache}' " +
                                    "And Status = 'Completed';")[0];

                return time;
            }
            else if (type == "Finished")
            {
                string time = SQLCursor.Query("Select Time from Schedule Where " +
                    $"OrderID ='{ordIDCache}' " +
                    "And Status = 'Finished';")[0];

                return time;
            }
            else
            {
                return null;
            }
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            dynamic[] IfExist = SQLCursor.Query("Select Status From Schedule Where " +
                $"OrderID = '{ordIDCache}'");

            if (IfExist.Length == 3)
            {
                infoBar.Show();

                string sql1 = "Select Top 1 TechnicianID From Schedule " +
                    $"Where OrderID = '{ordIDCache}'";
                Console.WriteLine(sql1);
                string technicianID = SQLCursor.Query(sql1)[0];

                string time = DateTime.Now.ToString();
                string ScheduleID = SQLCursor.AddOneToLastID("ScheduleID", "Schedule");

                string sql2 = $"INSERT INTO Schedule VALUES('{ScheduleID}','Finished','{time}'," +
                    $"'{technicianID}','{ordIDCache}');";
                SQLCursor.Execute(sql2);

                statusBtn.Enabled = false;
            }


        }

        private void InitRecentRepair()
        {
            dynamic[] data = SQLCursor.Query($"select Top 4 OrderID From Orders " +
                $"Where CustomerID= '{User_type.user_ID}' Order By Time DESC ;");

            dynamic[] cards = { card1, card2, card3, card4 };

            int num = data.Length;

            for (int i = 0; i < num; i++)
            {
                cards[i].Init(data[i][0]);
            }

            for (int i = num; i < 4; i++)
            {
                cards[i].Visible = false;
            }
            
        }

        private void card1_Click(object sender, EventArgs e)
        {
            ordIDCache = card1.ordIDCache;
            Init();
            Console.WriteLine("111");
        
        }

        private void card2_Click(object sender, EventArgs e)
        {
            ordIDCache = card2.ordIDCache;
            Init();
            Console.WriteLine("222");
        }

        private void card3_Click(object sender, EventArgs e)
        {
            ordIDCache = card3.ordIDCache;
            Init();
            Console.WriteLine("333");
        }

        private void card4_Click(object sender, EventArgs e)
        {
            ordIDCache = card4.ordIDCache;
            Init();
            Console.WriteLine("444");
        }
    }
}
