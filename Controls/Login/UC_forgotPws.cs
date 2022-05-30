using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3.Controls
{
    public partial class Control : UserControl
    {
        public Control()
        {
            InitializeComponent();
            allBlack();
            phone.ForeColor = Color.FromArgb(51, 112, 255);
            phone_line.Show();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Login.login.panelContainer.Controls.Clear();
            Login.login.panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UC_Login uc = new UC_Login();
            addUserControl(uc);
        }

        private void allBlack()
        {
            phone.ForeColor = Color.Black;
            email.ForeColor = Color.Black;
            valid.ForeColor = Color.Black;
           
            phone_line.Hide();
            email_line.Hide();
            valid_line.Hide();
        }

        private void phone_Click(object sender, EventArgs e)
        {
            allBlack();
            phone.ForeColor = Color.FromArgb(51, 112, 255);
            phone_line.Show();
        }

        private void email_Click(object sender, EventArgs e)
        {
            allBlack();
            email.ForeColor = Color.FromArgb(51, 112, 255);
            email_line.Show();
            name_input.Text = "Enter your email address";
        }

        private void valid_Click(object sender, EventArgs e)
        {
            allBlack();
            valid.ForeColor = Color.FromArgb(51, 112, 255);
            valid_line.Show();

            name_input.Text = "Enter your email address";
        }
    }
}
