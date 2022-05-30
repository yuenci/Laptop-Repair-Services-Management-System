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
        private string ordIDCache = "";
        private string name = "";


        public UC_Task_Card()
        {
            InitializeComponent();
            InitStyle();
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
        }


        private void InitStyle() 
        {
            uiLine1.FillColor = Color.Transparent;
            uiLine1.LineColor = Color.FromArgb(242, 243, 245);
            edit.FillColor = Color.Transparent;
            edit.BackColor = Color.Transparent;
            more.FillColor = Color.Transparent;
            more.BackColor = Color.Transparent;
            start.FillColor = Color.Transparent;
            start.BackColor = Color.Transparent;
            done.FillColor = Color.Transparent;
            done.BackColor = Color.Transparent;
            edit.ForeColor = Color.Silver;
            more.ForeColor = Color.Silver;
            start.ForeColor = Color.Silver;
            done.ForeColor = Color.Silver;
            avatar.FillColor = Color.FromArgb(64, 128, 255);
            avatar.ForeColor = Color.White;

        }
       
        public void Init(string ordID)
        {
            clearStyle();
            this.Show();

            dynamic[] data = SQLCursor.Query("select Orders.Model, Customer.Name,Service.Type,Orders.Time " +
                "From Orders " +
                "Inner Join Customer On Customer.CustomerID = Orders.CustomerID " +
                "Inner join Service On Service.ServiceID = Orders.Service_type " +
                $"Where OrderID = '{ordID}';");

            model.Text = data[0];
            name = data[1];
            avatar.Text = name.Substring(0,1);
            service.Text = data[2];
            time.Text = data[3];
            ordIDCache = ordID;

            string status = SQLCursor.Query($"select TOP 1 Status From Schedule Where OrderID ='{ordIDCache}' Order by Time DESC")[0];
            InitStatus(status);

            string description = SQLCursor.Query($"select Description From Orders Where OrderID ='{ordIDCache}'")[0];
            InitDescriptionIcon(description);

       
        }
        
        private  void clearStyle()
        {
            uiUserControl1.FillColor = Color.White;
            start.ForeColor = Color.Silver;
            done.ForeColor = Color.Silver;
            edit.ForeColor = Color.Silver;
            more.ForeColor = Color.Silver;
        }
        
        
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
            uiUserControl1.FillColor = Color.FromArgb(255, 247, 232);

        }


        private void done_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            done.ForeColor = Color.Green;
            string schID = SQLCursor.AddOneToLastID("ScheduleID", "Schedule");
            string time = DateTime.Now.ToString();
            SQLCursor.Execute($"INSERT INTO Schedule VALUES ('{schID}','Completed','{time}','{User_type.user_ID}','{ordIDCache}')");
            done.Enabled = false;
            uiUserControl1.FillColor = Color.FromArgb(232, 255, 234);
        }


        private void InitStatus(string status)
        {
            if (status == "Order")
            {
                start.Enabled=true;
                start.ForeColor=Color.Silver;

                done.Enabled=false;
                done.ForeColor = Color.Silver;
            }else if (status == "Progress")
            {
                start.Enabled = false;
                start.ForeColor = Color.Green;

                done.Enabled = true;
                done.ForeColor = Color.Silver;
                uiUserControl1.FillColor = Color.FromArgb(255, 247, 232);
            }
            else if (status == "Completed" || status == "Finished")
            {
                start.Enabled = false;
                start.ForeColor = Color.Green;

                done.Enabled = false;
                done.ForeColor = Color.Green;
                uiUserControl1.FillColor = Color.FromArgb(232, 255, 234);
            }
        }


        private void InitDescriptionIcon(string description)
        {
            if (description != "")
            {
                edit.ForeColor = Color.Green;
                edit.Enabled = true;
            }
            else
            {
                edit.ForeColor = Color.Silver;
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
            AddDescription addDescription = new AddDescription();
            addDescription.Init(ordIDCache);
            addDescription.Show();
        }


        private void start_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Start repair", start);
        }


        private void done_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Complete repair", done);
        }
    }
}
