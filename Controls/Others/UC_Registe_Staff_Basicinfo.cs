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
        }
        private void InitTextBox()
        {
            TextBoxCE superTextbox = new TextBoxCE(nameTextBox, "Enter the user's name", Color.Gray);
            TextBoxCE superTextbox1 = new TextBoxCE(IDnumberTextBox, "Enter the user's ID number", Color.Gray);
        }
        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            nameTextBox.RectSize = 1;
        }
        private void IDnumberTextBox_Enter(object sender, EventArgs e)
        {
            IDnumberTextBox.RectSize = 1;
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

            if (nameTextBox.Text != "" && nameTextBox.Text != "Enter the user's name")
            {
                if (IDnumberTextBox.Text != "" || IDnumberTextBox.Text != "Enter the user's ID number")
                {
                    if (selectDepartment.SelectedIndex != -1 && selectPost.SelectedIndex != -1)
                    {
                        MessageBox.Show($"store [{nameTextBox.Text}," +
                            $"{selectDepartment.SelectedItem.ToString()}," +
                            $"{selectPost.SelectedItem.ToString()}]");
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


    }
}
