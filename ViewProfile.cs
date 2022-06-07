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

namespace miniSys0._3
{
    public partial class ViewProfile : UIForm
    {
        public static ViewProfile Instance;
        private string userID_cache;
        //use type(staff/customer) whose profile be watch 
        //if check by seld
        public ViewProfile()
        {
            Instance = this;
            InitializeComponent();
            initLabel();
            InitTheme();
            Main.main.ifViewProfileExist = true;
        }
        public void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(18, 31, 43);
                container.BackColor = Color.FromArgb(18, 31, 43);
                TitleColor = Color.FromArgb(28, 47, 70);
                TitleForeColor = Color.White;
                ControlBoxForeColor = Color.White;
                rectColor = Color.FromArgb(55, 55, 57);

                about.FillColor = Color.FromArgb(55, 55, 57);
                about.RectColor = Color.Transparent;


                dynamic[] lable = { name, post, country, phone, department, email, label2, 
                    about, label1, uiLabel9, gender, uiLabel8, birthday, uiLabel10, address, 
                    uiLabel7, useID, uiLabel11, regtime };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

                dynamic[] containers = { uiUserControl1, uiUserControl2, uiUserControl3 };
                foreach (var item in containers)
                {
                    item.FillColor = Color.FromArgb(28, 47, 70);
                    item.BackColor = Color.FromArgb(28, 47, 70);
                    item.RectColor = Color.FromArgb(55, 55, 57);
                }
                

                dynamic[] icons = { uiAvatar1, uiAvatar2, uiAvatar3, uiAvatar4, contact };
                foreach (var item in icons)
                {
                    item.FillColor = Color.FromArgb(55, 55, 57);
                    item.ForeColor = Color.White;
                }

                
            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.FromArgb(247, 248, 250);
                container.BackColor = Color.White;
                TitleColor = Color.FromArgb(64, 128, 255);
                TitleForeColor = Color.White;
                ControlBoxForeColor = Color.White;
                rectColor = Color.FromArgb(64, 128, 255);

                about.FillColor = Color.White;
                about.RectColor = Color.Gainsboro;


                dynamic[] lable = { name, post, country, phone, department, email, label2,
                    about, label1, uiLabel9, gender, uiLabel8, birthday, uiLabel10, address,
                    uiLabel7, useID, uiLabel11, regtime };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }

                dynamic[] containers = { uiUserControl1, uiUserControl2, uiUserControl3 };
                foreach (var item in containers)
                {
                    item.FillColor = Color.White;
                    item.BackColor = Color.White;
                    item.RectColor = Color.Gainsboro;
                }


                dynamic[] icons = { uiAvatar1, uiAvatar2, uiAvatar3, uiAvatar4, contact };
                foreach (var item in icons)
                {
                    item.FillColor = Color.Transparent;
                    item.ForeColor = Color.FromArgb(64, 128, 255);
                }
            }
        }
        

        private void initLabel()
        {

            name.Text = RegisterInfoCache.user_name;
            post.Text = RegisterInfoCache.user_post;
            country.Text = RegisterInfoCache.user_Country;
            post.Text = RegisterInfoCache.user_post;
            phone.Text = RegisterInfoCache.user_phone;
            email.Text = RegisterInfoCache.user_email;
            gender.Text = RegisterInfoCache.user_gender;
            birthday.Text = RegisterInfoCache.user_Birthday;
            address.Text = RegisterInfoCache.user_Address;
            useID.Text = RegisterInfoCache.user_ID;
            regtime.Text = RegisterInfoCache.user_regtime;
            about.Text = RegisterInfoCache.user_about;
            if (User_type.user_deparment == "Admin")
            {
                // do nothing
            }
            else if (User_type.user_deparment == "Receptionist")
            {
                post.Hide();
                department.Text = "Customer";
            }

            userID_cache = RegisterInfoCache.user_ID;
        }
        

        private void privacy(string staffID)
        {
            string ifallowShowProfile = UserSettings.GetSettingsValue(userID_cache, "allowShowProfile");
            string ifPrivateMode = UserSettings.GetSettingsValue(userID_cache, "privateMode");
            

            if (ifallowShowProfile == "Off" || ifPrivateMode == "On")
            {
                dynamic[] lables = { post, country, phone, department, email, about, gender, birthday, address, useID, regtime };
                foreach (var lable in lables)
                {
                    lable.Text = "********";
                }
            }
            else if (User_type.user_deparment == "Customer")
            {
                phone.Text = "********";
                regtime.Text = "********";
                address.Text = "********";
                birthday.Text = "********";
                again.Visible = false;
                //about.Enabled = false;
            }
            else if (User_type.user_deparment != "Admin")
            {
                if(staffID != User_type.user_ID)
                {
                    again.Visible = false;
                    //about.Enabled = false;
                }
            }
        }


        public void InitStaff(string staffID)
        {
            dynamic[] data = SQLCursor.Query("SELECT Name, Post,Country,Phone_number,Email," +
                "Gender,Birthday,Address,StaffID,Regtime,About  " +
                $"FROM Staff WHERE StaffID = '{staffID}';");

            if (data.Length == 0)
            {
                MessageBox.Show($"{staffID} doesn't exist");
            }
            else
            {
                name.Text = data[0];
                post.Text = data[1];
                country.Text = data[2];
                phone.Text = data[3];
                email.Text = data[4];
                gender.Text = data[5];
                birthday.Text = data[6];
                address.Text = data[7];
                useID.Text = data[8];
                regtime.Text = data[9];
                about.Text = data[10];

                userID_cache = data[8];

                post.Show();
                privacy(staffID);

                
            }
            
        }


        public void InitCus(string cusID)
        {
            string sql = "SELECT Name,Country,Phone_number,Email," +
                "Gender,Birthday,Address,CustomerID,Regtime,About " +
                $"FROM Customer WHERE CustomerID = '{cusID}';";
            Console.WriteLine(sql);
            dynamic[] data = SQLCursor.Query(sql);
            if (data.Length == 0)
            {
                MessageBox.Show($"{cusID} doesn't exist,lalalallal");
            }
            else
            {
                name.Text = data[0];
                country.Text = data[1];
                phone.Text = data[2];
                email.Text = data[3];
                gender.Text = data[4];
                birthday.Text = data[5];
                address.Text = data[6];
                useID.Text = data[7];
                regtime.Text = data[8];
                about.Text = data[9];
                
                userID_cache = data[7];

                privacy(cusID);

            }
           

        }


        private void contact_Click(object sender, EventArgs e)
        {
            string userType = User_type.user_ID.Substring(0, 3);
            string ifrejectAllCus = UserSettings.GetSettingsValue(userID_cache, "rejectAllCus");
            string ifPrivateMode = UserSettings.GetSettingsValue(userID_cache, "privateMode");

            /*Console.WriteLine($"userType:{userType}");
            Console.WriteLine($"ifrejectAllCus:{ifrejectAllCus}");
            Console.WriteLine($"ifPrivateMode:{ifPrivateMode}");*/

            if ((userType == "Cus" && ifrejectAllCus == "On") || ifPrivateMode == "On")
            {
                string useName = SQLCursor.getName(userID_cache);
                MessageBox.Show($"Can't send messages, {useName} has turned off the private chat");
            }
            else
            {
                AddDescription addDescription = new AddDescription();
                addDescription.InitChatting(userID_cache, name.Text);
                //recvicer id
                addDescription.Show();
            }
            
        }
    }
}
