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
    public partial class UC_Message_Card : UserControl
    {
        private string messageCache;

        public UC_Message_Card()
        {
            InitializeComponent();
            InitTheme();
            InitEvent();
        }
        
        public void Init(dynamic  userUnfo)
        {
            string useID = userUnfo[3] + userUnfo[4];
            //picture
            if (userUnfo[1] == "@all")
            {
                pictureBox1.Image = Properties.Resources.starShip;
            }
            else
            {
                if (SQLCursor.getGender(useID) == "male")
                {
                    pictureBox1.Image = Properties.Resources.avatar_male;
                }
                else if (SQLCursor.getGender(useID) == "female")
                {
                    pictureBox1.Image = Properties.Resources.avatar_female;
                }
            }

            //name
            string nameRes = SQLCursor.getName(useID);
            if (nameRes == null)
            {
                name.Text = "System";
            }
            else
            {
                name.Text = nameRes;
            }

            //messgae
            message.Text = userUnfo[0];
            messageCache = userUnfo[0];

            //time
            time.Text = userUnfo[2];


            //type
            //unread
            string theme = User_type.user_theme;
            if (userUnfo[5]== "0")
            {
                if (theme == "dark")
                {
                    tag.ForeColor = Color.FromArgb(22, 93, 255);
                    tag.FillColor = Color.FromArgb(55, 55, 57);
                    tag.Text = "Unread";
                }
                else if (theme == "light")
                {
                    tag.ForeColor = Color.FromArgb(22, 93, 255);
                    tag.FillColor = Color.White;
                    tag.Text = "Unread";
                }
               
            }
            // read
            else if (userUnfo[5] == "1")
            {
                if (theme == "dark")
                {
                    tag.ForeColor = Color.WhiteSmoke;
                    tag.FillColor = Color.FromArgb(55, 55, 57);
                    tag.Text = "Read";
                }
                else if (theme == "light")
                {
                    tag.ForeColor = Color.Gray;
                    tag.FillColor = Color.White;
                    tag.Text = "Read";
                }

            }
        }

        public void InitTheme()
        {
            dynamic[] lable = { uiLabel1 ,name,message};
            uiLine1.FillColor = Color.Transparent;
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);

                time.ForeColor = Color.Silver;

                
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

                uiLine1.LineColor = Color.FromArgb(55, 55, 57);

            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.White;

                time.ForeColor = Color.FromArgb(78, 89, 105);

                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }
                uiLine1.LineColor = Color.Gainsboro;
            }

           
        }

        private void InitEvent()
        {
            dynamic[] controls = { pictureBox1, uiLabel1, name, tag, message, time };
            foreach (var control in controls)
            {
                control.Click += new EventHandler(clickEvent);
            }
        }

        private void clickEvent(object sender, EventArgs e)
        {
            AddDescription addDescription = new AddDescription();
            addDescription.cusInit(messageCache);
            addDescription.Show();
        }
    }
}
