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

namespace miniSys0._3.Controls.Others
{
    public partial class UC_BasicInfo : UserControl
    {
        public UC_BasicInfo()
        {
            InitializeComponent();
        }

        #region text box enter and leave event

        private void email_enter(object sender, EventArgs e)
        {
            email.RectColor = Color.White;
            email.Text = "";
            email.ForeColor = Color.Black;
        }

        private void name_Enter(object sender, EventArgs e)
        {
            name.RectColor = Color.White;
            name.Text = "";
            name.ForeColor = Color.Black;
        }

        private void country_Enter(object sender, EventArgs e)
        {
            country.RectColor = Color.White;
            country.Text = "";
            country.ForeColor = Color.Black;
        }

        private void street_Enter(object sender, EventArgs e)
        {
            street.RectColor = Color.White;
            street.Text = "";
            street.ForeColor = Color.Black;
        }

        private void address_Enter(object sender, EventArgs e)
        {
            address.RectColor = Color.White;
            address.Text = "";
            address.ForeColor = Color.Black;
        }

        private void profile_Enter(object sender, EventArgs e)
        {
            profile.RectColor = Color.White;
            profile.Text = "";
            profile.ForeColor = Color.Black;
        }

        

        private void email_Leave_1(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Enter your email address";
                email.ForeColor= Color.Gray;
            }
        }

        private void name_Leave_1(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Enter your name";
                name.ForeColor = Color.Gray;
            }
        }

        private void country_Leave_1(object sender, EventArgs e)
        {
            if (country.Text == "")
            {
                country.Text = "Enter your country";
                country.ForeColor = Color.Gray;
            }
        }

        private void street_Leave_1(object sender, EventArgs e)
        {
            if (street.Text == "")
            {
                street.Text = "Enter the street where you live";
                street.ForeColor = Color.Gray;
            }
        }

        private void address_Leave_1(object sender, EventArgs e)
        {
            if (address.Text == "")
            {
                address.Text = "Enter the detailed address";
                address.ForeColor = Color.Gray;
            }
        }

        private void profile_Leave_1(object sender, EventArgs e)
        {
            if (profile.Text == "")
            {
                profile.Text = "Please enter your personal introduction with a maximum of 300 characters.";
                profile.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void ResetButton_Click(object sender, EventArgs e)
        {
            dynamic[] uITextBoxes = { email, name, country, street ,address, profile };
            string[] textBoxContent = {
                "Enter your email address",
                "Enter your name",
                "Enter your country",
                "Enter the street where you live",
                "Enter the detailed address",
                "Please enter your personal introduction with a maximum of 300 characters."
            };
            for (int i = 0; i < textBoxContent.Length; i++)
            {
                uITextBoxes[i].Text = textBoxContent[i];
                uITextBoxes[i].ForeColor = Color.Gray;
                
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            UITextBox[] uITextBoxes = { email, name, country, street };
            string[] textBoxContent = {
                "Enter your email address",
                "Enter your name",
                "Enter your country",
                "Enter the street where you live",
            };
            bool ifAnyEmpty = false;
            for (int i = 0; i < textBoxContent.Length; i++)
            {
                if (uITextBoxes[i].Text == "" || uITextBoxes[i].Text == textBoxContent[i])
                {
                    uITextBoxes[i].RectColor = Color.Red;
                    ifAnyEmpty = true;
                }
            }
            if (ifAnyEmpty == false)
            {

                MessageBox.Show("sent all info to db!");
            }
        }
    }
}
