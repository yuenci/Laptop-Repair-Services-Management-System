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
            InitTheme();
        }
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                dynamic[] lable = { uiLabel11, uiLabel12, uiLabel13, uiLabel14, uiLabel16 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
        }

        #region text box enter and leave event

        private void email_enter(object sender, EventArgs e)
        {
            if (email.Text == "Enter your email address")
            {
                email.RectColor = Color.White;
                email.Text = "";
                email.ForeColor = Color.Black;
            }

        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Enter your name")
            {
                name.RectColor = Color.White;
                name.Text = "";
                name.ForeColor = Color.Black;
            }
            
        }

        private void country_Enter(object sender, EventArgs e)
        {
            if (country.Text == "Enter your country")
            {
                country.RectColor = Color.White;
                country.Text = "";
                country.ForeColor = Color.Black;
            }
            
        }

        private void street_Enter(object sender, EventArgs e)
        {
            if (street.Text == "Enter the street where you live")
            {
                street.RectColor = Color.White;
                street.Text = "";
                street.ForeColor = Color.Black;
            }
            
        }



        private void profile_Enter(object sender, EventArgs e)
        {
            if (profile.Text == "Please enter your personal introduction with a maximum of 300 characters.")
            {
                profile.RectColor = Color.White;
                profile.Text = "";
                profile.ForeColor = Color.Black;
            }
            
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
            dynamic[] uITextBoxes = { email, name, country, street , profile };
            string[] textBoxContent = {
                "Enter your email address",
                "Enter your name",
                "Enter your country",
                "Enter the street where you live",
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
            if (ifAnyEmpty == false && RegexForInput.EmailVerify(email.Text))
            {
                dynamic[] uITextBox = { email,name,country,street,profile};

                string useId = User_type.user_ID;
                string useTable = "";
                string useIdType = "";
                if (User_type.user_deparment == "Customer")
                {
                    useTable = "Customer";
                    useIdType = "CustomerID";
                }
                else
                {
                    useTable = "Staff";
                    useIdType = "StaffID";
                }
                

                string[] placeHolders = { "","Enter your email address", "Enter your name", "Enter your country", 
                    "Enter the street where you live", "Enter the detailed address",
                    "Please enter your personal introduction with a maximum of 300 characters." };

                List<string> newCentent = new List<string>();
                if (placeHolders.Contains(email.Text) == false)
                {
                    newCentent.Add($"Email = '{email.Text}'");
                }
                 if (placeHolders.Contains(name.Text) == false)
                {
                    newCentent.Add($"Name = '{name.Text}'");
                }
                 if (placeHolders.Contains(country.Text) == false)
                {
                    newCentent.Add($"Country = '{country.Text}'");
                }
                 if(placeHolders.Contains(street.Text) == false )
                {
                    newCentent.Add($"Address = '{street.Text}'");
                }

                 if (placeHolders.Contains(profile.Text) == false)
                {
                    newCentent.Add($"About = '{profile.Text}'");
                }

                string sql = $"UPDATE {useTable}  SET " + String.Join(",", newCentent) + $" WHERE {useIdType} = '{useId}';";

                Console.WriteLine(sql);

                SQLCursor.Execute(sql);
                //MessageBox.Show("Profile modify successfully");
                NotificationForm messageBoxForm = new NotificationForm("success", "Profile modify successfully");
                messageBoxForm.ShowDialog();

                string sql1 = "";
                if (User_type.user_deparment == "Customer")
                {
                    sql1 = $"SELECT * FROM Customer WHERE Name = '{name.Text}';";
                }
                else
                {
                    sql1 = $"SELECT * FROM Staff WHERE Name = '{name.Text}';";
                }

                
                dynamic[] data = SQLCursor.Query(sql1);

                User_type.user_name = name.Text;
                User_type.user_email = data[3];
                User_type.user_Country = data[6];
                User_type.user_Address = data[7];
                User_type.user_about = data[8];
            }
            else
            {
                NotificationForm messageBoxForm = new NotificationForm("warning", "Invalid email input!");
                messageBoxForm.ShowDialog();
            }
        }

        private void profile_TextChanged(object sender, EventArgs e)
        {
            if (profile.Text.Length >290)
            {
                profile.Text = profile.Text.Substring(0, 290);
            }
            
        }
    }
}
