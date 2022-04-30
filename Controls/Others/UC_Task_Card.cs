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
    public partial class UC_Task_Card : UserControl
    {
        public UC_Task_Card()
        {
            InitializeComponent();
        }
        private  string ordIDCache = "";
        public void Init(string ordID)
        {
            dynamic[] data = SQLCursor.Query("select Orders.Model, Customer.Name,Service.Type,Orders.Time " +
                "From Orders " +
                "Inner Join Customer On Customer.CustomerID = Orders.CustomerID " +
                "Inner join Service On Service.ServiceID = Orders.Service_type " +
                $"Where OrderID = '{ordID}';");

            model.Text = data[0];
            name = data[1];
            service.Text = data[2];
            time.Text = data[3];
            ordIDCache = ordID;

            string status = SQLCursor.Query($"select TOP 1 Status From Schedule Where OrderID ='{ordIDCache}' Order by Time DESC")[0];
            InitStatus(status);

            string description = SQLCursor.Query($"select Description From Orders Where OrderID ='{ordIDCache}'")[0];
            InitDescriptionIcon(description);
        }
        private string  name ="";
        private void avatar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show($"{name}", avatar);
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.ForeColor = Color.Green;
            string schID = SQLCursor.AddOneToLastID("ScheduleID", "Schedule");
            string time = DateTime.Now.ToString();
            SQLCursor.Execute($"INSERT INTO Schedule VALUES ('{schID}','Progress','{time}','{User_type.user_ID}','{ordIDCache}')");
            done.Enabled = true;

        }

        private void done_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            string schID = SQLCursor.AddOneToLastID("ScheduleID", "Schedule");
            string time = DateTime.Now.ToString();
            SQLCursor.Execute($"INSERT INTO Schedule VALUES ('{schID}','Completed','{time}','{User_type.user_ID}','{ordIDCache}')");
            done.Enabled = false;
        }

        private void InitStatus(string status)
        {
            if (status == "Order")
            {
                start.Enabled=true;
                start.ForeColor=Color.FromArgb(242, 243, 245);

                done.Enabled=false;
                done.ForeColor = Color.FromArgb(242, 243, 245);
            }else if (status == "Progress")
            {
                start.Enabled = false;
                start.ForeColor = Color.Green;

                done.Enabled = true;
                done.ForeColor = Color.FromArgb(242, 243, 245);
            }else if (status == "Completed" || status == "Finished")
            {
                start.Enabled = false;
                start.ForeColor = Color.Green;

                done.Enabled = false;
                done.ForeColor = Color.Green;
            }
        }

        private void InitDescriptionIcon(string description)
        {
            if (description == "")
            {
                edit.ForeColor = Color.Green;
                edit.Enabled = false;
            }
            else
            {
                edit.ForeColor = Color.FromArgb(242, 243, 245);
                edit.Enabled = true;
            }
        }

        private void more_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.Init(ordIDCache);
            orderDetails.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("edit");
        }
    }
}
