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
            InitTheme();
        }
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                TitleColor = Color.FromArgb(28, 47, 70);
                TitleForeColor = Color.White;
                ControlBoxForeColor = Color.White;
                rectColor = Color.FromArgb(55, 55, 57);
                uiLine2.LineColor = Color.FromArgb(55, 55, 57);


                textBox.FillColor  = Color.FromArgb(55, 55, 57);


                dynamic[] lable = { textBox };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
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
            if(User_type.user_deparment == "Customer")
            {
                this.Close();
            }
            else
            {
                if (textBox.Text != "" && OrderID != "")
                {
                    SQLCursor.Execute($"UPDATE Orders SET Description = '{textBox.Text}' " +
                        $"WHERE OrderID ='{OrderID}';");
                    uiSymbolLabel.Visible = true;

                }
                else if (textBox.Text == "")
                {
                    textBox.RectColor = Color.Red;
                }
            }
            
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            textBox.RectColor = Color.FromArgb(22, 93, 255);
        }

        public void cusInit(string  str)
        {
            cancel.Hide();
            textBox.Text = str;
            textBox.Enabled = false;
        }
    }
}
