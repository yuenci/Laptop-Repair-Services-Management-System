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
        //use type(staff/customer) whose profile be watch 
        //if check by seld
        public ViewProfile()
        {
            InitializeComponent();
            initLabel();
            InitTheme();
        }
        private void InitTheme()
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
                

                dynamic[] icons = { uiAvatar1, uiAvatar2, uiAvatar3, uiAvatar4, uiAvatar5 };
                foreach (var item in icons)
                {
                    item.FillColor = Color.FromArgb(55, 55, 57);
                    item.ForeColor = Color.White;
                }
            }
        }
        private void initLabel()
        {
            string useType = "Staff";
            //string useType = "Customer";
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
            if (useType == "Staff")
            {
                // do nothing
            }
            else if (useType == "Customer")
            {
                post.Hide();
                department.Text = "Customer";
            }
            else
            {
                MessageBox.Show("Wrong arg in viewprofile in line 49");
            }
        }
    }
}
