using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3.Controls.Setting
{
    public partial class UC_Setting_General : UserControl
    {
        public static UC_Setting_General Instance ;
        public UC_Setting_General()
        {
            InitializeComponent();
            Instance = this;
        }
        public void InitTheme()
        {
            uiLine1.FillColor = Color.Transparent;
            
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(55, 55, 57);
                uiLine1.LineColor = Color.Gainsboro;
                dynamic[] lable = { uiLabel1, uiLabel2, uiLabel3, uiLabel4 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.White;
                uiLine1.LineColor = Color.Gainsboro;
                dynamic[] lable = { uiLabel1, uiLabel2, uiLabel3, uiLabel4 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }

            }
        }
        public void InitStatus()
        {
            UserSettings.DisplayStatus(theme, UserSettings.theme);
            UserSettings.DisplayStatus(auto, UserSettings.autoTheme);
            homePage.Text = UserSettings.homePage;
            InitPageCombox();
        }

        private void theme_Click(object sender, EventArgs e)
        {
            UserSettings.SetStatus("theme", theme.Active);

            //UserSettings.ShowAllPropertyValue();
        }

        private void auto_Click(object sender, EventArgs e)
        {
            UserSettings.SetStatus("autoTheme", auto.Active);

            //UserSettings.ShowAllPropertyValue();
        }

        private void InitPageCombox()
        {
            string department = User_type.user_deparment;

            if (homePage.Items.Count == 0)
            {
                if (department == "Customer")
                {
                    string[] pagesList = { "Dashboard", "Order Detail", "User Info", "User settings" };
                    InsertData(pagesList);
                }
                else if (department == "Receptionist")
                {
                    string[] pagesList = { "Dashboard", "Customer Register", "Payment and Receipt", "User settings" };
                    InsertData(pagesList);
                }
                else if (department == "Technician")
                {
                    string[] pagesList =  { "Dashboard", "Requests Card View", "Requests List View",
                    "User Info", "User settings" };
                    InsertData(pagesList);

                }
                else if (department == "Admin")
                {
                    string[] pagesList = { "Dashboard", "Staff Register", "Service Report", "Total Income",
                    "User Info", "User settings"};
                    InsertData(pagesList);
                }
            }
             
            void InsertData(string[] pagesList)
            {
                for (int i = 0; i < pagesList.Length; i++)
                {
                    if (pagesList[i] != null)
                    {
                        homePage.Items.Add(pagesList[i]);
                    }
                }
            }
        }

        private void homePage_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                string value = homePage.SelectedItem.ToString();
                UserSettings.SetStatus("homePage", value);
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
            //UserSettings.ShowAllPropertyValue();
        }
    }
}
