using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace miniSys0._3.Controls
{
    public partial class UC_Login : UserControl
    {
        public static UC_Login Instance;
        public string userName;
        public string useIDCashe;
        public string useTypeCashe;
        // Customer; Staff
        public UC_Login()
        {
            InitializeComponent();
            Instance = this;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IfDBConnect())
            {
                string name = name_input.Text;
                string password = password_input.Text;
                bool agreementCheck = agreement.Checked;

                if (name == "Enter the user name" || name == "")
                {
                    name_input.RectColor = Color.Red;
                }

                if (password == "Enter your password" || name == "")
                {
                    password_input.RectColor = Color.Red;
                }

                if (!agreementCheck)
                {
                    agreement.CheckBoxColor = Color.Red;
                }

                if (name != "" && name != "Enter the user name" &&
                    password != "" && password != "Enter your password" &&
                    agreementCheck
                    )
                {
                    loginToMain(name, password);
                }
            }
            else
            {
                //MessageBox.Show("Can't connect to the database, please contact the system administrator.");
                NotificationForm messageBoxForm = new NotificationForm("error", "Can't connect to the database, please contact the system administrator.");
                messageBoxForm.ShowDialog();
            }

        }

        private void loginToMain(string nameInput, string passwordInput)
        {
            string userID = SQLCursor.ifStaOrCus(nameInput);
            if (userID != null)
            {
                if (userID.Length == 9)
                {
                    if (userID.Substring(0, 3) == "Cus")
                    {
                        if (SQLCursor.PasswordVerification(nameInput, passwordInput))
                        {
                            string sql = $"SELECT * FROM Customer WHERE Name = '{nameInput}';";
                            dynamic[] data = SQLCursor.Query(sql);

                            User_type.user_deparment = "Customer";
                            User_type.user_ID = data[0];
                            User_type.user_name = data[1];
                            User_type.user_phone = data[2];
                            User_type.user_email = data[3];
                            User_type.Birthday = data[4];
                            User_type.user_gender = data[5];
                            User_type.user_post = "Customer";
                            User_type.user_ID_number = "";
                            User_type.user_about = data[8];
                            User_type.user_Country = data[6];
                            User_type.user_Address = data[7];
                            User_type.user_regtime = data[9];
                            User_type.user_security_qustion = data[10];
                            User_type.user_security_answer = data[11];
                            User_type.user_password = data[12];
                            User_type.user_theme = "light";

                            Loading loading = new Loading();
                            loading.StartPosition = FormStartPosition.CenterScreen;
                            loading.Show();

                            /*Main main = new Main();
                            main.StartPosition = FormStartPosition.CenterScreen;
                            main.Show();*/

                            Login.login.Hide();
                        }
                        else
                        {
                            //MessageBox.Show("Wrong password");

                            NotificationForm messageBoxForm = new NotificationForm("warning", "Wrong password");
                            messageBoxForm.ShowDialog();

                        }


                    }
                    else if (userID.Substring(0, 3) == "Sta")
                    {
                        if (SQLCursor.PasswordVerification(nameInput, passwordInput))
                        {
                            string sql = $"SELECT * FROM Staff WHERE Name = '{nameInput}';";
                            dynamic[] data = SQLCursor.Query(sql);

                            if (data[7] == "Admin")
                            {
                                User_type.user_deparment = "Admin";
                            }
                            else if (data[7] == "Service department")
                            {
                                User_type.user_deparment = "Receptionist";
                            }
                            else if (data[7] == "Technican department")
                            {
                                User_type.user_deparment = "Technician";
                            }
                            User_type.user_ID = data[0];
                            User_type.user_name = data[1];
                            User_type.user_phone = data[2];
                            User_type.user_email = data[3];
                            User_type.Birthday = data[4];
                            User_type.user_gender = data[5];
                            User_type.user_post = data[6];
                            User_type.user_ID_number = data[10];
                            User_type.user_about = data[11];
                            User_type.user_Country = data[8];
                            User_type.user_Address = data[9];
                            User_type.user_regtime = data[12];
                            User_type.user_security_qustion = data[13];
                            User_type.user_security_answer = data[14];
                            User_type.user_password = data[15];
                            User_type.user_theme = "light";

                            Loading loading = new Loading();
                            loading.StartPosition = FormStartPosition.CenterScreen;
                            loading.Show();

                            /*Main main = new Main();
                            main.StartPosition = FormStartPosition.CenterScreen;
                            main.Show();*/

                            Login.login.Hide();
                        }
                        else
                        {
                            //MessageBox.Show("Wrong password");
                            NotificationForm messageBoxForm = new NotificationForm("warning", "Wrong password");
                            messageBoxForm.ShowDialog();
                        }
                    }
                    else
                    {
                        //MessageBox.Show($"{nameInput} doesn't exist");
                        NotificationForm messageBoxForm = new NotificationForm("warning", $"{nameInput} doesn't exist");
                        messageBoxForm.ShowDialog();
                    }
                }
                else
                {
                    //MessageBox.Show($"{nameInput} doesn't exist");
                    NotificationForm messageBoxForm = new NotificationForm("warning", $"{nameInput} doesn't exist");
                    messageBoxForm.ShowDialog();
                }
            }
            else
            {
                NotificationForm messageBoxForm = new NotificationForm("warning", $"{nameInput} doesn't exist");
                messageBoxForm.ShowDialog();
            }
            
            
        }

        private void name_enter(object sender, EventArgs e)
        {
            name_input.RectColor = Color.FromArgb(187, 191, 196);
            if (name_input.Text == "Enter the user name")
            {
                name_input.Text = "";
            }
        }

        private void pwd_enter(object sender, EventArgs e)
        {
            password_input.RectColor = Color.FromArgb(187, 191, 196);
            if (password_input.Text == "Enter your password")
            {
                password_input.Text = "";
                password_input.PasswordChar = '*';
            }
        }

        private void name_leave(object sender, EventArgs e)
        {
            if (name_input.Text == "")
            {
                name_input.Text = "Enter the user name";
            }
        }

        private void pws_leave(object sender, EventArgs e)
        {
            if (password_input.Text == "")
            {
                password_input.Text = "Enter your password";
            }
            if (password_input.Text == "Enter your password")
            {
                password_input.PasswordChar = '\0';
            }
        }

        private void showPws_CheckedChanged(object sender, EventArgs e)
        {
            if (showPws.Checked == false && password_input.Text != "Enter your password")
            {
                password_input.PasswordChar = '*';
            }
            else
            {
                password_input.PasswordChar = '\0';
            }
        }

        private void agreement_CheckedChanged(object sender, EventArgs e)
        {
            if (agreement.CheckBoxColor == Color.Red)
            {
                agreement.CheckBoxColor = Color.FromArgb(48, 100, 221);
            }
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Login.login.panelContainer.Controls.Clear();
            Login.login.panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void forgot_Click(object sender, EventArgs e)
        {
            string user_name_input = name_input.Text;
            if (user_name_input == "")
            {
                //MessageBox.Show("Please enter your name first");
                NotificationForm messageBoxForm = new NotificationForm("notification", "Please enter your name first");
                messageBoxForm.ShowDialog();

            }
            else if (!UserValid())
            {
                //MessageBox.Show($"{user_name_input} doesn't exist");
                NotificationForm messageBoxForm = new NotificationForm("warning", $"{user_name_input} doesn't exist");
                messageBoxForm.ShowDialog();


            }
            else
            {
                userName = user_name_input;
                this.Hide();
                Control uc = new Control();
                addUserControl(uc);
            }
        }
        
        
        private bool UserValid()
        {
            string user_name_input = name_input.Text;
            useIDCashe = SQLCursor.ifStaOrCus(user_name_input);
            if (useIDCashe != null)
            {
                if (useIDCashe.Substring(0, 3) == "Cus")
                {
                    useTypeCashe = "Customer";
                    return true;
                }
                else if (useIDCashe.Substring(0, 3) == "Sta")
                {
                    useTypeCashe = "Staff";
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

        private bool IfDBConnect()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AppSetting.DBString))
                {
                    conn.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://policies.google.com/privacy?hl=en-US");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://policies.google.com/terms?hl=en-US");
        }
    }
}
