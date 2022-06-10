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
    public partial class NotificationForm : UIForm
    {
        /*public NotificationForm()
        {
            InitializeComponent();
        }*/

        public NotificationForm(string type, string contentText)
        {
            InitializeComponent();
            content.Text = contentText;
            InitStyle(type);
            InitSize(contentText);
            InitTheme();
            cancel.Hide();
        }
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(55, 55, 57);
                typeText.ForeColor = Color.White;
                content.ForeColor = Color.White;
                this.ShowShadow = false;
            }
            else
            {
                this.BackColor = Color.White;
                typeText.ForeColor = Color.Black;
                content.ForeColor = Color.Black;
                this.ShowShadow = true;
            }
        }


        private void InitStyle(string type)
        {
            type = type.ToLower();
            if (type == "notification")
            {
                icon.FillColor = Color.FromArgb(22, 93, 255);
                icon.Symbol = 61737;

                typeText.Text = "Notification";

            }
            else if (type == "success")
            {
                icon.FillColor = Color.FromArgb(0, 180, 42);
                icon.Symbol = 61452;

                typeText.Text = "Success";

            }
            else if (type == "warning")
            {
                icon.FillColor = Color.FromArgb(255, 125, 0);
                icon.Symbol = 61737;


                typeText.Text = "Warning";

            }
            else if (type == "error")
            {
                icon.FillColor = Color.FromArgb(245, 63, 63);
                icon.Symbol = 61453;

                typeText.Text = "Error";
            }
            else
            {
                icon.Hide();
                typeText.Location = new Point(22, 10);

                typeText.Text = "Normal";
            }
        }

        private void InitSize(string contentText)
        {
            if(contentText !="" || contentText != null)
            {
                if(contentText.Length > 70)
                {
                    this.Size = new Size(350, 200);

                    ok.Location = new Point(248, 156);

                    cancel.Location = new Point(149, 156);

                    content.Size = new Size(305,95);
                }
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
