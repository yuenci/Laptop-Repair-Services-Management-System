using miniSys0._3.Controls.MainArea;
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
    public partial class UC_Registe_Staff_Basicinfo : UserControl
    {
        public UC_Registe_Staff_Basicinfo()
        {
            InitializeComponent();
            InitTextBox();
            InitTheme();
        }

        private void InitTheme()
        {
            errorBar.Visible = false;
            successIcon.Visible = false;
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                dynamic[] lable = { uiLabel1, IDnumber, uiLabel2, uiLabel3 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.White;
                dynamic[] lable = { uiLabel1, IDnumber, uiLabel2, uiLabel3 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }
            }
            

        }


        private void InitTextBox()
        {
            TextBoxCE superTextbox = new TextBoxCE(nameTextBox, "Enter the user's name", Color.Gray);
            TextBoxCE superTextbox1 = new TextBoxCE(IDnumberTextBox, "Enter the user's ID number", Color.Gray);
        }
        

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            nameTextBox.RectSize = 1;

            errorBar.Visible = false;
            successIcon.Visible = false;

            nameTextBox.RectColor = Color.Gray;
        }
        
        
        private void IDnumberTextBox_Enter(object sender, EventArgs e)
        {
            IDnumberTextBox.RectSize = 1;
            nameTextBox.RectColor = Color.Gray;
        }


        private void selectDepartment_DropDown(object sender, EventArgs e)
        {
            selectDepartment.RectColor = Color.Gray;
            selectDepartment.RectSize = 1;
            selectPost.Enabled = true;
            selectPost.FillColor = Color.FromArgb(242, 243, 245);
        }


        private void selectDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectDepartment.SelectedItem.ToString() == "Service department")
            {
                selectPost.Items.Clear();
                selectPost.Items.Add("Receptionist");
                selectPost.Items.Add("Service department manager");
                selectPost.Items.Add("Service director");
                selectPost.Items.Add("Chief service officer");
            }
            else if (selectDepartment.SelectedItem.ToString() == "Technican department")
            {
                selectPost.Items.Clear();
                selectPost.Items.Add("Technican");
                selectPost.Items.Add("Technican department manager");
                selectPost.Items.Add("Technician Director");
                selectPost.Items.Add("Chief technician officer");
            }
        }


        private void selectDepartment_DropDownClosed(object sender, EventArgs e)
        {
            if (selectDepartment.SelectedIndex == -1)
            {
                selectDepartment.RectColor = Color.Red;
                selectDepartment.RectSize = 2;
            }
            else
            {
                selectDepartment.Font = new Font(".萍方-简", 12, FontStyle.Bold);
            }
        }


        private void selectPost_DropDown(object sender, EventArgs e)
        {
            selectPost.RectColor = Color.Gray;
            selectPost.RectSize = 1;
            
        }


        private void nextStepBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || nameTextBox.Text == "Enter the user's name")
            {
                nameTextBox.RectColor = Color.Red;
                nameTextBox.RectSize = 2;
            }
            if (IDnumberTextBox.Text == "" || IDnumberTextBox.Text == "Enter the user's ID number")
            {
                IDnumberTextBox.RectColor = Color.Red;
                IDnumberTextBox.RectSize = 2;
            }

            if (selectDepartment.SelectedIndex == -1)
            {
                selectDepartment.RectColor= Color.Red;
                selectDepartment.RectSize = 2;
            }

            if (nameTextBox.Text != "" && nameTextBox.Text != "Enter the user's name" && ifNameVerify && ifNumVerify)
            {
                if (IDnumberTextBox.Text != "" || IDnumberTextBox.Text != "Enter the user's ID number")
                {
                    if (selectDepartment.SelectedIndex != -1 && selectPost.SelectedIndex != -1 && ifUserNameExist ==false)
                    {
                        /*MessageBox.Show($"store [{nameTextBox.Text}," +
                            $"{selectDepartment.SelectedItem.ToString()}," +
                            $"{selectPost.SelectedItem.ToString()}]");*/

                        RegisterInfoCache.user_name = nameTextBox.Text;
                        RegisterInfoCache.user_ID_number = IDnumberTextBox.Text;
                        RegisterInfoCache.user_deparment = selectDepartment.SelectedItem.ToString();
                        RegisterInfoCache.user_post = selectPost.SelectedItem.ToString();

                        UC_Registration.iconSelect(UC_Registration.uc_Registration.icon2,
                UC_Registration.uc_Registration.iconLabel2);
                        UC_Registration.iconUnSelect(UC_Registration.uc_Registration.icon1,
                            UC_Registration.uc_Registration.iconLabel1);
                        UC_Registration.iconUnSelect(UC_Registration.uc_Registration.icon3,
                            UC_Registration.uc_Registration.iconLabel3);

                        RegisterInfoCache.step2Activate = true;

                        UC_Registe_detaildinfo uc = new UC_Registe_detaildinfo();
                        uc.Location = new Point(320,80);
                        AddUserControl.Add(uc, UC_Registration.uc_Registration.contentPanel);
                    }
                    else
                    {
                        //MessageBox.Show($"{nameTextBox.Text} has already existed, please try others");
                        NotificationForm messageBoxForm = new NotificationForm("warning", $"{nameTextBox.Text} has already existed, please try others");
                        messageBoxForm.ShowDialog();

                    }
                }   
            }
            
            
        }

       
        private void selectPost_DropDownClosed(object sender, EventArgs e)
        {
            if (selectPost.SelectedIndex == -1)
            {
                selectPost.RectColor = Color.Red;
                selectPost.RectSize = 2;
            }
            else
            {
                selectPost.Font = new Font(".萍方-简", 12, FontStyle.Bold);
            }
        }
        private bool ifUserNameExist = false;
        private bool ifNameVerify = false;
        private void nameTextBox_Leave(object sender, EventArgs e)
        {

            if (RegexForInput.TextVerify(nameTextBox.Text))
            {
                ifNameVerify = true;
            }


            if (SQLCursor.ifStaOrCus(nameTextBox.Text) !=null)
            {
                ifUserNameExist = true;
                errorBar.Visible = true;

            }
            else if (!ifNameVerify) 
            {
                //MessageBox.Show("Names can only consist of letters");
                NotificationForm messageBoxForm = new NotificationForm("warning", "Names can only consist of letters");
                messageBoxForm.ShowDialog();

                nameTextBox.RectColor = Color.Red;

            }
            else
            {
                successIcon.Visible = true;
                ifUserNameExist = false;
            }

            

            
        }
        private bool ifNumVerify = false;
        private void IDnumberTextBox_Leave(object sender, EventArgs e)
        {
            if (RegexForInput.PhoneNumVerify(IDnumberTextBox.Text))
            {
                ifNumVerify = true;
            }
            else
            {
                //MessageBox.Show("ID can only consist of numbers");
                NotificationForm messageBoxForm = new NotificationForm("warning", "ID can only consist of numbers");
                messageBoxForm.ShowDialog();

            }
        }
    }
}
