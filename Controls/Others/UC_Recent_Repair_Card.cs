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
        public UC_Recent_Repair_Card()
        {
            InitializeComponent();
            line.LineColor = Color.Gainsboro;
            line.FillColor = Color.Transparent;
        }
        public string  ordIDCache ="";
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
    }
}
