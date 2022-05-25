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
        public UC_Task_Item()
        {
            InitializeComponent();
            InitStyle();
        }
        private void InitStyle()
        {
            
        }
        private string orderIDcache;
        public void Init(string orderID)
        {
            orderIDcache = orderID;
            orderId.Text = orderID.Substring(3,8);
            dynamic[] Data = SQLCursor.Query($"SELECT TOP 1 Status,Time FROM Schedule " +
                $"WHERE OrderID = '{orderID}' " +
                $"ORDER BY Time DESC;");

            
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
    }
}
