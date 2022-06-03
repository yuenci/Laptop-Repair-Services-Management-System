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
                MessageBox.Show("Can't connect to the database, please contact the system administrator.");
            }


             void login(string nameInput, string passwordInput)
            {
                string connStr = Setting.DBString;

                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                //match staff
                string sql = $"SELECT Password,Name,Department,Post,StaffID," +
                    $"Country,Regtime,Gender,Phone_number,Email," +
                    $" ID_number FROM Staff WHERE Name = '{nameInput}'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (passwordInput == dr["Password"].ToString())
                    {
                        User_type.user_name = dr["Name"].ToString();
                        User_type.user_deparment = dr["Department"].ToString();
                        User_type.user_post = dr["Post"].ToString();
                        User_type.user_ID = dr["StaffID"].ToString();
                        User_type.user_Country = dr["Country"].ToString();
                        User_type.user_regtime = dr["Regtime"].ToString();
                        User_type.user_gender = dr["Gender"].ToString();
                        User_type.user_phone = dr["Phone_number"].ToString();
                        User_type.user_email = dr["Email"].ToString();
                        User_type.user_ID_number = dr["ID_number"].ToString() ;

                        Main main = new Main();
                        main.Show();
                        Login.login.Hide();
                        //MessageBox.Show("Login success");
                        dr.Close();
                    }

                    else
                    {
                        MessageBox.Show("Wrong password");
                        dr.Close();
                    }
                }
                else
                {
                    dr.Close();
                    //match customer
                    string sql1 = $"SELECT Password,Name,CustomerID FROM Customer WHERE Name = '{nameInput}'";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    if (dr1.Read())
                    {
                        if (passwordInput == dr1["Password"].ToString())
                        {
                            User_type.user_name = dr1["Name"].ToString();
                            User_type.user_ID = dr1["CustomerID"].ToString();
                            Main main = new Main();
                            main.Show();
                            Login.login.Hide();

                            //MessageBox.Show("Login success");

                            dr1.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong password");
                            dr1.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"{nameInput} does not exist");
                        dr1.Close();
                    }
                }

                conn.Close();
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
                MessageBox.Show("Please enter your name first");
            }
            else if (!UserValid())
            {
                MessageBox.Show($"{user_name_input} doesn't exist");
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

        private void loginToMain(string nameInput, string passwordInput)
        {
            
            dynamic resultStaff = SQLCursor.Query($"Select * From Staff Where Name = '{nameInput}'");
            if (resultStaff.Length != 0)
            {
                if (resultStaff[15] == passwordInput)
                {
                    // set department for user
                    string department = resultStaff[6];
                    if (department == "Admin")
                    {
                        User_type.user_deparment = "Admin";
                    }
                    else if(department == "Service department")
                    {
                        User_type.user_deparment = "Receptionist";
                    }
                    else if (department == "Technican department")
                    {
                        User_type.user_deparment = "Technician";
                    }

                    //Console.WriteLine(User_type.user_deparment);
                    Loading loading = new Loading();
                    loading.Show();
                    Login.login.Hide();
                    //MessageBox.Show("Login success")
                }
                else
                {
                    MessageBox.Show("Wrong password, try again please");
                }
            }
            else
            {
                dynamic resultCus = SQLCursor.Query($"Select * From Customer Where Name = '{nameInput}'");
                if (resultCus.Length != 0)
                {

                    if (resultCus[12] == passwordInput)
                    {
                        User_type.user_deparment = "Customer";
                        Loading loading = new Loading();
                        loading.Show();
                        Login.login.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password, try again please");
                    }
                }
                else
                {
                    MessageBox.Show($"{nameInput} does not exist");
                }
            }      
        }

        private bool IfDBConnect()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Setting.DBString))
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
