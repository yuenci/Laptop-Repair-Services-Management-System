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
        private string mode = null;
        private string OrderID = "";
        private string recevicerIDCache;

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

        
        public void Init(string ordID)
        {
            this.OrderID= ordID;
            textBox.Text = SQLCursor.Query($"select Description from Orders where OrderID = '{OrderID}';")[0];
            mode = "add_description";
        }
        

        private void ok_Click(object sender, EventArgs e)
        {
            if(mode== "cus_view")
            {
                this.Close();
            }
            else if(mode == "add_description")
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
            else if (mode == "chatting")
            {
                string message = textBox.Text;
                string status = "0";
                string time = DateTime.Now.ToString();
                string type = "message";

                string peopleInfo = getSenderRecevicerInfo();

                if (message.Length <280)
                {
                    string sql = $"insert into Messages values ( " +
                        $"'{message}', {status},'{time}','{type}'," + peopleInfo + ");";
                    SQLCursor.Execute(sql);
                    uiSymbolLabel.Visible =true;
                }
                else
                {
                    MessageBox.Show("Message cannot exceed 280 characters");
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
            textBox.ReadOnly = true;
            mode = "cus_view";
        }

        
        public void InitChatting(string receiverID,string  receiverName)
        {
            mode = "chatting";
            cancel.Show();
            this.Text = $"Send Message to {receiverName}";
            uiSymbolLabel.Text = "Message sent successfully";
            recevicerIDCache = receiverID;
        }


        private string getSenderRecevicerInfo()
        {
            string[] data = { "null", "null", "null", "null" };

            string sender3 = User_type.user_ID.Substring(0, 3);
            string reveiver3 = recevicerIDCache.Substring(0, 3);

            if (sender3 == "Cus")
            {
                data[0] = $"'{User_type.user_ID}'";
            }
            else
            {
                data[1] = $"'{User_type.user_ID}'";
            }

            if (reveiver3 == "Cus")
            {
                data[2] = $"'{recevicerIDCache}'";
            }
            else
            {
                data[3] = $"'{recevicerIDCache}'";
            }

            return String.Join(",", data);
        }
    }
}
