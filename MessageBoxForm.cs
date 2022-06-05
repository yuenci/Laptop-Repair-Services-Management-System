using miniSys0._3.Controls.Others;
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
    public partial class MessageBoxForm : UIForm
    {
        public static MessageBoxForm Instance;
        private Color btnColor = Color.Black;

        public MessageBoxForm()
        {
            InitializeComponent();
            Instance = this;
            InitEvent();
            InitTheme();
        }

        public void InitTheme()
        {
            dynamic[] lable = { mark,delect};
            uiLine1.FillColor = Color.Transparent;
            uiLine2.FillColor = Color.Transparent;
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                this.rectColor = Color.FromArgb(28, 47, 70);
                ShowShadow = false;
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

                uiLine1.LineColor = Color.FromArgb(55, 55, 57);
                uiLine2.LineColor = Color.FromArgb(55, 55, 57);

                btnColor = Color.White;
            }
            else if (User_type.user_theme=="light")
            {
                this.BackColor = Color.White;
                ShowShadow = true;
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }

                uiLine1.LineColor = Color.Gainsboro;
                uiLine2.LineColor = Color.Gainsboro;

                btnColor = Color.Black;
            }
        }


        public void Init(List<dynamic> messageInfoList)
        {
            InitTheme();
            panel.Controls.Clear();
            for (int i = 0; i < messageInfoList.Count; i++)
            {
                UC_Message_Card message_Card = new UC_Message_Card();
                message_Card.Location = new Point(0, i * 80);
                message_Card.Init(messageInfoList[i]);
                panel.Controls.Add(message_Card);
            }
        }

        private void InitEvent()
        {
            mark.MouseHover += new EventHandler(btnHover);
            delect.MouseHover += new EventHandler(btnHover);

            mark.MouseLeave += new EventHandler(btnLeave);
            delect.MouseLeave += new EventHandler(btnLeave);
        }


        private void btnHover(object sender, EventArgs e)
        {
            if (sender.Equals(mark))
            {
                mark.ForeColor = Color.FromArgb(22, 93, 255);
            }
            else if (sender.Equals(delect))
            {
                delect.ForeColor = Color.FromArgb(22, 93, 255);
            }
        }


        private void btnLeave(object sender, EventArgs e)
        {
            if (sender.Equals(mark))
            {
                mark.ForeColor = btnColor;
            }
            else if (sender.Equals(delect))
            {
                delect.ForeColor = btnColor;
            }
        }


        private void mark_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Messages SET Status = 1 WHERE " + curOrSta();
            SQLCursor.Execute(sql);

            Main.main.checkMessage();
            Init(Main.main.messagesList);
        }
        
        
        private void delect_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Messages SET Status = -1 WHERE " + curOrSta();
            SQLCursor.Execute(sql);

            Main.main.checkMessage();
            Init(Main.main.messagesList);
        }

        private string curOrSta()
        {
            //return receiverID_cus ==  'Sta000011';
            string useID = User_type.user_ID;
            string first = useID.Substring(0, 3);
            if (first == "Cus")
            {
                return $"receiverID_cus = '{useID}';";
            }
            else if (first == "Sta")
            {
                return $"receiverID_sta = '{useID}';";
            }
            return null;
        }


    }
}
