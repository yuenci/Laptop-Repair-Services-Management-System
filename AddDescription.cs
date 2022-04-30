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

namespace miniSys0._3
{
    public partial class AddDescription : UIForm
    {
        public AddDescription()
        {
            InitializeComponent();
            uiSymbolLabel.Visible = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string OrderID = "";
        public void Init(string ordID)
        {
            this.OrderID= ordID;
            textBox.Text = SQLCursor.Query($"select Description from Orders where OrderID = '{OrderID}';")[0];
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && OrderID!="")
            {
                SQLCursor.Execute($"UPDATE Orders SET Description = '{textBox.Text}' " +
                    $"WHERE OrderID ='{OrderID}';");
                uiSymbolLabel.Visible = true;

            }
            else if(textBox.Text == "")
            {
                textBox.RectColor = Color.Red;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            textBox.RectColor = Color.FromArgb(22, 93, 255);
        }
    }
}
