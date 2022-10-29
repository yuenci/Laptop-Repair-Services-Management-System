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
    public partial class UC_Recent_Repair_Card : UserControl
    {
        public string ordIDCache = "";

        public UC_Recent_Repair_Card()
        {
            InitializeComponent();  
            InitTheme();
        }

        public void InitTheme()
        {
            
            line.FillColor = Color.Transparent;
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(55, 55, 57);
                uiUserControl1.BackColor = Color.FromArgb(55, 55, 57);
                uiUserControl1.FillColor = Color.FromArgb(55, 55, 57);

                line.LineColor = Color.Gainsboro;

                dynamic[] lable = {model,serverType,time };

                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.White;
                uiUserControl1.BackColor = Color.White;
                uiUserControl1.FillColor = Color.White;

                line.LineColor = Color.Gainsboro;

                dynamic[] lable = { model, serverType, time };

                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }
            }
        }

        public void Init(string ordID)
        {
            ordIDCache = ordID;
            dynamic[] data = SQLCursor.Query($"select Orders.Model,Service.Type,Orders.Time  " +        
                $"from Orders " +
                $"Inner join Service On Service.ServiceID = Orders.Service_type  " +
                $"Where OrderID= '{ordID}' ;");
            model.Text = data[0];
            serverType.Text = data[1];
            time.Text = data[2];
        }

        private void showDetail(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.Init(ordIDCache);
            orderDetails.Show();
        }
    }
}
