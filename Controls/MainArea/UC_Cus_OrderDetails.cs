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
            InitStyle();
            Init();
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
            string sqlOrderStaff = $"select TOP 1 Staff.Name,Schedule.Status" +
                $" From Schedule " +
                $"Inner join Staff On Staff.StaffID = Schedule.TechnicianID " +
                $"Where OrderID ='{ordIDCache}' Order by Time DESC";

            Console.WriteLine("----------------");
            Console.WriteLine(sqlOrderStaff);
            Console.WriteLine("----------------");
            dynamic[] data2 = SQLCursor.Query(sqlOrderStaff);

            if (data2.Length >0)
            {
                technician.Text = data2[0];
            }
            else
            {
                technician.Text = "";
            }
            

            status.Text = statusStr(data2[1]);
            setStatusButton(data2[1]);


            Console.WriteLine(statusStr(data2[1]));

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
                Console.WriteLine("YES------------------------");
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

            }
            else if(status == "Finished")
            {
                statusBtn.Enabled = false;
                statusBtn.Text = "End";
            }
            else
            {
                statusBtn.Enabled = false;
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
            string IfExist = SQLCursor.Query("Select Status From Schedule Where " +
                $"OrderID = '{ordIDCache}' and Status = 'Finished'")[0];

            if (IfExist == "")
            {
                infoBar.Show();
                string technicianID = SQLCursor.Query("Select Top1 TechnicianID From Schedule " +
                    $"Where OrderID = {ordIDCache}")[0];
                string time = DateTime.Now.ToString();
                string ScheduleID = SQLCursor.AddOneToLastID("ScheduleID", "Schedule");
                SQLCursor.Execute($"INSERT INTO Schedule VALUES('{ScheduleID}','Finished','{time}'," +
                    $"'{technicianID}','{ordIDCache}');");
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
