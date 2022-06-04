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

namespace miniSys0._3.Controls.Others
{
    public partial class UC_Task_Item : UserControl
    {
        private string orderIDcache;

        public UC_Task_Item()
        {
            InitializeComponent();
            InitTheme();
        }

        private void InitTheme()
        {
            dynamic[] btns = { start, finish };
            foreach (dynamic item in btns)
            {
                item.ForeColor = Color.FromArgb(22, 93, 255);
                item.ForeHoverColor = Color.FromArgb(22, 93, 255);
                item.ForePressColor = Color.FromArgb(22, 93, 255);
            }

            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(55, 55, 57);
                dynamic[] lable = { orderId, description, statusText, updateTime };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
        }

        
        public void Init(string orderID)
        {
            orderIDcache = orderID;
            orderId.Text = orderID.Substring(3,8);

            string sql = $"SELECT TOP 1 Status,Time FROM Schedule " +
                $"WHERE OrderID = '{orderID}' " +
                $"ORDER BY Time DESC;";

            dynamic[] Data = SQLCursor.Query(sql);

            //Console.WriteLine(sql);
            
                
            setStatus(Data[0]);
            //updateTime.Text = Data[1].Substring(0, 19);
            updateTime.Text = Data[1];

            dynamic[] Data2 = SQLCursor.Query($"SELECT Description FROM Orders " +
                $"WHERE OrderID = '{orderID}';");

            if (Data2[0] =="")
            {
                description.Text = "No description, click to add one";
            }
            else
            {
                description.Text = Data2[0];
            }
            
        }


        private void setStatus(string status)
        {
            if (status == "Order")
            {
                statusText.Text = "Ordered";
                statusIcon.FillColor = Color.Gray;

            }
            else if (status == "Progress")
            {
                statusText.Text = "Repairing";
                statusIcon.FillColor = Color.FromArgb(22, 93, 255);
                start.Enabled = false;
            }
            else if (status == "Completed" || status == "Finished")
            {
                statusText.Text = "Finished";
                statusIcon.FillColor = Color.FromArgb(0, 192, 0);
                start.Enabled = false;
                finish.Enabled = false;
            }
        }


        private void description_TextChanged(object sender, EventArgs e)
        {
            AddDescription descriptionForm = new AddDescription();
            descriptionForm.Init(orderIDcache);
            descriptionForm.Show();
        }


        private void start_TextChanged(object sender, EventArgs e)
        {
            //blue
            statusIcon.FillColor = Color.FromArgb(22, 93, 255);
            statusText.Text = "Repairing";
            string schID = SQLCursor.AddOneToLastID("ScheduleID", "Schedule");
            string time = DateTime.Now.ToString();
            SQLCursor.Execute($"INSERT INTO Schedule VALUES ('{schID}','Progress','{time}','{User_type.user_ID}','{orderIDcache}')");
            start.Enabled = false;
            updateTime.Text = time;

            string updateSQL = $"UPDATE Schedule  SET TechnicianID = '{User_type.user_ID}' " +
                $"WHERE OrderID = '{orderIDcache}' AND Status ='Order';";
            SQLCursor.Execute(updateSQL);
        }


        private void finish_TextChanged(object sender, EventArgs e)
        {
            //green
            statusIcon.FillColor = Color.FromArgb(0, 192, 0);
            statusText.Text = "Finished";
            string schID = SQLCursor.AddOneToLastID("ScheduleID", "Schedule");
            string time = DateTime.Now.ToString();
            SQLCursor.Execute($"INSERT INTO Schedule VALUES ('{schID}','Completed','{time}','{User_type.user_ID}','{orderIDcache}')");
            start.Enabled = false;
            finish.Enabled = false;
            updateTime.Text = time;
        }


        private void orderId_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.Init(orderIDcache);
            orderDetails.Show();
        }
    }
}
