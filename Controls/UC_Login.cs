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
        public UC_Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
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
                login(name, password);
            }

            void login(string nameInput, string passwordInput)
            {
                string connStr = @"Data Source=LAPTOP-5ACE008F\SQLEXPRESS;Initial Catalog=CsharpRepairerInc;Integrated Security=True";

                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                //match staff
                string sql = $"SELECT Password FROM Staff WHERE Name = '{nameInput}'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (passwordInput == dr["Password"].ToString())
                    {
                        MessageBox.Show("Login success");
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
                    string sql1 = $"SELECT Password FROM Customer WHERE Name = '{nameInput}'";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    if (dr1.Read())
                    {
                        if (passwordInput == dr1["Password"].ToString())
                        {
                            MessageBox.Show("Login success");
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
            this.Hide();
            Control uc = new Control();
            addUserControl(uc);
        }
    }
}
