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

namespace miniSys0._3.Controls
{
    public partial class Control : UserControl
    {
        public Control()
        {
            InitializeComponent();
            allBlack();
            Init_event();
            phone.ForeColor = Color.FromArgb(51, 112, 255);
            phone_line.Show();
        }
        private void Init_event()
        {
            UITextBox[] textBoxes = { name_input,pin_code_input,new_pws_input };
            foreach (var item in textBoxes)
            {
                item.Enter += new EventHandler(input_enter);
                item.Leave += new EventHandler(input_leave);
            }
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
            name_input.Text = "Enter your phone number";
            pin_code_input.Text = "Enter the PIN code";
            sendBtn.Show();
            name_input.Size = new Size(387, 50);
        }

        private void email_Click(object sender, EventArgs e)
        {
            allBlack();
            email.ForeColor = Color.FromArgb(51, 112, 255);
            email_line.Show();
            name_input.Text = "Enter your email address";
            pin_code_input.Text = "Enter the PIN code";
            sendBtn.Show();
            name_input.Size = new Size(387, 50);
        }

        private void valid_Click(object sender, EventArgs e)
        {
            allBlack();
            valid.ForeColor = Color.FromArgb(51, 112, 255);
            valid_line.Show();

            name_input.Text = "Enter your security question";
            pin_code_input.Text = "Enter the security answer";

            name_input.Size = new Size(463,50);
            sendBtn.Hide();
        }

        private void input_enter(object sender, EventArgs e)
        {
            if (sender.Equals(name_input))
            {
                if (name_input.Text  == "Enter your phone number" || 
                    name_input.Text == "Enter your email address" || 
                    name_input.Text == "Enter your security question")
                {
                    name_input.Text = "";
                }
            }
            else if (sender.Equals(pin_code_input))
            {
                if (pin_code_input.Text == "Enter the PIN code" || pin_code_input.Text == "Enter the security answer")
                {
                    pin_code_input.Text = "";
                }
            }
            else if (sender.Equals(new_pws_input))
            {
                if(new_pws_input.Text == "Enter the New password")
                {
                    new_pws_input.Text = "";
                }
            }

            UITextBox[] uITextBoxes = { name_input, pin_code_input, new_pws_input };
            foreach (UITextBox uITextBox in uITextBoxes)
            {
                uITextBox.RectColor = Color.FromArgb(187, 191, 196);
            }
        }

        private void input_leave(object sender, EventArgs e)
        {
            Color blue = Color.FromArgb(51, 112, 255);
            if (sender.Equals(name_input))
            {
                if (name_input.Text == "" )
                {
                    if (phone.ForeColor == blue)
                    {
                        name_input.Text = "Enter your phone number";
                    }
                    else if (email.ForeColor == blue)
                    {
                        name_input.Text = "Enter your email address";
                    }
                    else if (valid.ForeColor == blue)
                    {
                        name_input.Text = "Enter your security question";
                    }
                }
            }
            else if (sender.Equals(pin_code_input))
            {
                
                if (pin_code_input.Text == "")
                {
                     if (email.ForeColor == blue || phone.ForeColor == blue)
                    {
                        pin_code_input.Text = "Enter the PIN code";
                    }
                    else if (valid.ForeColor == blue)
                    {
                        pin_code_input.Text = "Enter the security answer";
                    }
                }
            }
            else if (sender.Equals(new_pws_input))
            {
                
                if (new_pws_input.Text == "")
                {
                    new_pws_input.Text = "Enter the New password";
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Color blue = Color.FromArgb(51, 112, 255);
            string userName = UC_Login.Instance.userName;
            bool status = true;

            UITextBox[] uITextBoxes = { name_input ,pin_code_input,new_pws_input}; 
            string[] placeHodles = {
                "Enter your phone number",
                "Enter your email address",
                "Enter your security question",
                "Enter the PIN code",
                "Enter the security answer",
                "Enter the New password",
            };
            foreach (var item in uITextBoxes)
            {
                if (placeHodles.Contains(item.Text))
                {
                    item.RectColor = Color.Red;
                    status = false;
                }
            }

            if (status)
            {
                if (phone.ForeColor == blue)
                {
                    if (pin_code_input.Text == "123456")
                    {
                        resetPWD(userName);
                    }
                    else
                    {
                        //MessageBox.Show("Wrong PIN code!");
                        NotificationForm messageBoxForm = new NotificationForm("error", "Wrong PIN code!");
                        messageBoxForm.ShowDialog();
                    }
                }
                else if (email.ForeColor == blue)
                {
                    if (pin_code_input.Text == "123456")
                    {
                        resetPWD(userName);
                    }
                    else
                    {
                        //MessageBox.Show("Wrong PIN code!");

                        NotificationForm messageBoxForm = new NotificationForm("warning", "Wrong PIN code!");
                        messageBoxForm.ShowDialog();

                    }
                }
                else if (valid.ForeColor == blue)
                {
                    if (securityValidInfo())
                    {
                        resetPWD(userName);
                    }
                    else
                    {
                        //MessageBox.Show("Wrong input, please try again");
                        NotificationForm messageBoxForm = new NotificationForm("warning", "Wrong input, please try again");
                        messageBoxForm.ShowDialog();

                    }
                }
            }
            

        }

        private bool securityValidInfo()
        {
            string userName = UC_Login.Instance.userName;
            string useIDCashe = UC_Login.Instance.useIDCashe;

            string question = name_input.Text;
            string answer = pin_code_input.Text;
            
            if (useIDCashe != null)
            {
                if (useIDCashe.Substring(0,3) == "Cus")
                {
                    string sql = $"SELECT Name FROM Customer WHERE  Name = '{userName}' " +
                        $"AND Validation_problem = '{question}' " +
                        $"AND Validation_answer = '{answer}';";
                    dynamic[] res = SQLCursor.Query(sql);
                    if (res.Length > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (useIDCashe.Substring(0, 3) == "Sta")
                {
                    string sql = $"SELECT Name FROM Staff WHERE Name = '{userName}' " +
                        $"AND Validation_problem = '{question}' " +
                        $"AND Validation_answer = '{answer}';";
                    Console.WriteLine(sql);
                    dynamic[] res = SQLCursor.Query(sql);
                    if (res.Length > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private void resetPWD(string name)
        {
            string useIDCashe = UC_Login.Instance.useIDCashe;
            string useTypeCashe = UC_Login.Instance.useTypeCashe;
            string sql = "";
            string newPws = new_pws_input.Text;
            if (useTypeCashe == "Customer")
            {
                sql  = $"UPDATE Customer SET  Password = '{newPws}' WHERE " +
                $"Name = '{name}' AND CustomerID = '{useIDCashe}';";    
            }
            else if (useTypeCashe == "Staff")
            {
                sql = $"UPDATE Staff SET  Password = '{newPws}' WHERE " +
               $"Name = '{name}' AND StaffID = '{useIDCashe}';";
            }
            SQLCursor.Execute(sql);
            //MessageBox.Show("Password reset successfully");
            NotificationForm messageBoxForm = new NotificationForm("success", "Password reset successfully");
            messageBoxForm.ShowDialog();

        }
    }
}
