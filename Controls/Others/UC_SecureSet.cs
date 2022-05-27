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
    public partial class UC_SecureSet : UserControl
    {
        public UC_SecureSet()
        {
            InitializeComponent();
            HideAllTextBox();
            ShowInfoLable("all");
            InitTheme();
        }
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                dynamic[] lable = { uiLabel19 , uiLabel20 , uiLabel21 , uiLabel22 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
        }


        #region textboxes enter and leave event


        private void password1_Enter(object sender, EventArgs e)
        {
            password1.RectColor = Color.White;
            if (password1.Text == "Enter new password")
            {
                password1.Text = "";
                password1.PasswordChar = '*';
            }
            
        }


        private void password2_Enter(object sender, EventArgs e)
        {
            password2.RectColor = Color.White;
            if (password2.Text == "Repeat new password") {
                password2.RectColor = Color.White;
                password2.Text = "";
                password2.PasswordChar = '*';
            }
        }

        private void secure2_Enter(object sender, EventArgs e)
        {
            secure2.RectColor = Color.White;
            if (secure2.Text == "Enter your answer")
            {
                secure2.Text = "";
            }
        }

        private void phone1_Enter(object sender, EventArgs e)
        {
            phone1.RectColor = Color.White;
            if (phone1.Text == "Enter new number")
            {
                phone1.Text = "";
            }
        }

        private void phone2_Enter(object sender, EventArgs e)
        {
            phone2.RectColor = Color.White;
            if (phone2.Text == "Enter the PIN code")
            {
                phone2.Text = "";
            }
        }

        private void email1_Enter(object sender, EventArgs e)
        {
            email1.RectColor = Color.White;
            if (email1.Text == "Enter new eamil")
            {
                email1.Text = "";
            }
        }

        private void email2_Enter(object sender, EventArgs e)
        {
            email2.RectColor = Color.White;
            if (email2.Text == "Enter the PIN code")
            {
                email2.Text = "";
            }
        }

        private void password1_leave(object sender, EventArgs e)
        {
            if (password1.Text == "")
            {
                password1.Text = "Enter new password";
                password1.PasswordChar = '\0';
            }
        }

        private void password2_Leave(object sender, EventArgs e)
        {
            if (password2.Text == "")
            {
                password2.Text = "Repeat new password";
                password2.PasswordChar = '\0';
            }
        }

        private void secure2_Leave(object sender, EventArgs e)
        {
            if (secure2.Text == "")
            {
                secure2.Text = "Enter your answer";
            }
        }

        private void phone1_Leave(object sender, EventArgs e)
        {
            
        }

        private void phone2_Leave(object sender, EventArgs e)
        {
            if (phone2.Text == "")
            {
                phone2.Text = "Enter the PIN code";
            }
        }

        private void email1_Leave(object sender, EventArgs e)
        {
            if (email1.Text == "")
            {
                email1.Text = "Enter new eamil";
            }
        }

        private void email2_Leave(object sender, EventArgs e)
        {
            if (email2.Text == "")
            {
                email2.Text = "Enter the PIN code";
            }
        }

        #endregion

        private void HideAllTextBox()
        {
            password1.Hide();
            password2.Hide();
            secureComb.Hide();
            secure2.Hide();
            phone1.Hide();
            phone2.Hide();
            email1.Hide();
            email2.Hide();
            sendButton1.Hide();
            sendButton2.Hide();
        }
        private void ShowInfoLable(int num)
        {
            if (num == 1)
            {
                password1.Show();
                password2.Show();
            }
            else if (num == 2)
            {
                secureComb.Show();
                secure2.Show();
            }
            else if (num == 3)
            {
                phone1.Show();
                phone2.Show();
                sendButton1.Show();
                
            }
            else if (num == 4)
            {
                email1.Show();
                email2.Show();
                sendButton2.Show();
            }
        }
        UILabel passwordLable = new UILabel();
        UILabel secriteLable = new UILabel();
        UILabel phoneLable = new UILabel();
        UILabel eamilLable = new UILabel();

        private void ShowInfoLable(string all)
        {
            

            passwordLable.Size = new Size(738, 29);
            secriteLable.Size = new Size(738, 29);
            phoneLable.Size = new Size(738, 29);
            eamilLable.Size = new Size(738, 29);

            passwordLable.ForeColor = Color.FromArgb(78, 89, 105);
            secriteLable.ForeColor = Color.FromArgb(78, 89, 105);
            phoneLable.ForeColor = Color.FromArgb(78, 89, 105);
            eamilLable.ForeColor = Color.FromArgb(78, 89, 105);

            passwordLable.Font =  new Font(".萍方-简", 12, FontStyle.Regular);
            secriteLable.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            phoneLable.Font = new Font(".萍方-简", 12, FontStyle.Regular);
            eamilLable.Font = new Font(".萍方-简", 12, FontStyle.Regular);

            passwordLable.Location = new Point(207,18);
            secriteLable.Location = new Point(207,98);
            phoneLable.Location = new Point(207,187);
            eamilLable.Location = new Point(207,269);


            passwordLable.Text = "Already set. At least six characters in the password, and must contain numbers and letters.";
            if (User_type.user_security_qustion == "")
            {
                secriteLable.Text = "Please set security question";
            }
            else
            {
                secriteLable.Text = "Already set security question";
            }

            if (User_type.user_phone == "")
            {
                phoneLable.Text = "Please set your phone number";
            }
            else
            {
                phoneLable.Text = $"Bound: {User_type.user_phone}";
            }

            if (User_type.user_email == "")
            {
                eamilLable.Text = "Please set your eamil address";
            }
            else
            {
                eamilLable.Text = $"Bound: {User_type.user_email}";
            }

            this.Controls.Add(passwordLable);
            this.Controls.Add(secriteLable);
            this.Controls.Add(phoneLable);
            this.Controls.Add(eamilLable);
        }

        private void editPassword_Click(object sender, EventArgs e)
        {
            if (editPassword.Text == "Edit")
            {
                passwordLable.Hide();
                editPassword.Text = "OK";
                ShowInfoLable(1);

            }
            else if(editPassword.Text == "OK")
            {
                if (password1.Text == "" || password1.Text == "Enter new password" || password2.Text == "" || password2.Text == "Repeat new password")
                {
                    if (password1.Text == "" || password1.Text == "Enter new password")
                    {
                        password1.RectColor = Color.Red;
                    }
                    if (password2.Text == "" || password2.Text == "Repeat new password")
                    {
                        password2.RectColor = Color.Red;
                    }
                }
                else
                {
                    if (password1.Text != password2.Text)
                    {
                        MessageBox.Show("You entered different passwords twice.");
                    }
                    else
                    {
                        if (password1.Text != User_type.user_password)
                        {
                            MessageBox.Show($"send new pwd {password1.Text} to db");
                        }
                        password1.Hide();
                        password2.Hide();
                        passwordLable.Show();
                        editPassword.Text = "Edit";

                    }
                }  
            }

            


        }

        private void editQuestion_Click(object sender, EventArgs e)
        {



            if (editQuestion.Text == "Edit")
            {
                secriteLable.Hide();
                editQuestion.Text = "OK";
                ShowInfoLable(2);

            }
            else if (editQuestion.Text == "OK")
            {
                if (secure2.Text == "" || secure2.Text == "Enter your answer" || secureComb.SelectedIndex == -1)
                {
                    if (secure2.Text == "" || secure2.Text == "Enter your answer")
                    {
                        secure2.RectColor = Color.Red;
                    }
                    if (secureComb.SelectedIndex == -1)
                    {
                        secureComb.RectColor = Color.Red;
                        secureComb.RectSize = 3;
                    }
                }
                else
                {
                    string question = secureComb.SelectedItem.ToString();
                    string answer = secure2.Text;
                    if (question == User_type.user_security_qustion && answer == User_type.user_security_answer)
                    {
                        // do nothing
                    }
                    else
                    {
                        MessageBox.Show($"send Q:{question} and A:{answer} to db");
                    }
                }

                
                    
                    
            }
            
            
           
            
        }

        private void editPhone_Click(object sender, EventArgs e)
        {
            

            if (editPhone.Text == "Edit")
            {

                phoneLable.Hide();
                editPhone.Text = "OK";
                ShowInfoLable(3);
            }
            else if (editPhone.Text == "OK")
            {
                if (phone1.Text == "" || phone1.Text == "Enter new number" || phone2.Text == "" || phone2.Text == "Enter the PIN code")
                {
                    if (phone1.Text == "" || phone1.Text == "Enter new number")
                    {
                        phone1.RectColor = Color.Red;
                    }
                    if (phone2.Text == "" || phone2.Text == "Enter the PIN code")
                    {
                        phone2.RectColor = Color.Red;
                    }
                }
                else
                {
                    if (phone1.Text == User_type.user_phone)
                    {
                        // do nothing
                    }
                    else
                    {
                        MessageBox.Show($"send new phone: {phone1.Text} to db");
                    }
                }
                
            }

            
            
            
        }

        private void editEmail_Click(object sender, EventArgs e)
        {
            

            if (editEmail.Text == "Edit")
            {
                eamilLable.Hide();
                editEmail.Text = "OK";
                ShowInfoLable(4);

            }
            else if (editEmail.Text == "OK")
            {
                if (email1.Text == "" || email1.Text == "Enter new eamil" || email2.Text == "" || email2.Text == "Enter the PIN code")
                {
                    if (email1.Text == "" || email1.Text == "Enter new eamil")
                    {
                        email1.RectColor = Color.Red;
                    }
                    if (email2.Text == "" || email2.Text == "Enter the PIN code")
                    {
                        email2.RectColor = Color.Red;
                    }
                }
                else
                {
                    if (email1.Text == User_type.user_email)
                    {
                        // do nothing
                    }
                    else
                    {
                        MessageBox.Show($"send new phone: {email1.Text} to db");
                    }
                }
                
            }

            
            
            
        }

        private void sendButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Verified code has been sent to {phone1.Text}, please check");
        }

        private void sendButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Verified code has been sent to {email1.Text}, please check");
        }

        private void secureComb_DropDown(object sender, EventArgs e)
        {
            secureComb.RectColor = Color.Gray;
        }
    }
}
