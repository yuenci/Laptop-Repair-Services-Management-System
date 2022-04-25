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
