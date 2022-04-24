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
using System.Web.Security;
using System.Text.RegularExpressions;

namespace miniSys0._3.Controls.Others
{
    public partial class UC_Registe_detaildinfo : UserControl
    {
        public UC_Registe_detaildinfo()
        {
            InitializeComponent();
            InitAllBox();
        }

        private void InitAllBox()
        {
            TextBoxCE superPhone = new TextBoxCE(phone, "Enter user's phone", Color.Gray);
            TextBoxCE superEmial = new TextBoxCE(email, "Enter user's email", Color.Gray);
            TextBoxCE superCountry = new TextBoxCE(country, "Enter user's country", Color.Gray);
            TextBoxCE superAddress = new TextBoxCE(address, "Enter user's address", Color.Gray);
            TextBoxCE superAnswer = new TextBoxCE(sanswer, "Enter a answer", Color.Gray);

            ComboBoxCE superGender = new ComboBoxCE(gender, Color.Gray);
            ComboBoxCE superSquestion = new ComboBoxCE(squestion, Color.Gray);

            RichTextBoxCE superProfile = new RichTextBoxCE(profile,
                "Enter user's personal introduction with a maximum of 300 characters.", Color.Gray);
        }

        private void nextStepBtn_Click(object sender, EventArgs e)
        {
            if (phone.Text == "" || phone.Text == "Enter user's phone")
            {
                phone.RectColor =Color.Red;
            }
            else
            {
                string genderStr = "";
                string squestionStr = "";
                if (gender.SelectedIndex != -1)
                {
                    genderStr = gender.SelectedItem.ToString();
                }
                if (squestion.SelectedIndex != -1)
                {
                    squestionStr = squestion.SelectedItem.ToString();
                }

                MessageBox.Show($"{phone.Text}" +
                    $"{birthDatePicker.Text}" +
                    $"{email.Text}" +
                    $"{genderStr}" +
                    $"{country.Text}" +
                    $"{address.Text}" +
                    $"{squestionStr}" +
                    $"{sanswer.Text}" +
                    $"{profile.Text}" );
                if (phone.Text != "Enter user's phone" && phone.Text != "")
                {
                    RegisterInfoCache.user_phone = phone.Text;
                }
                if (birthDatePicker.Text != "")
                {
                    RegisterInfoCache.user_Birthday = birthDatePicker.Text;
                }
                if (email.Text != "Enter user's email" && email.Text != "")
                {
                    RegisterInfoCache.user_email = email.Text;
                }
                if (genderStr != "")
                {
                    RegisterInfoCache.user_gender = genderStr;
                }
                if (country.Text != "Enter user's country" && country.Text != "")
                {
                    RegisterInfoCache.user_Country = country.Text;
                }
                if (address.Text != "Enter user's address" && address.Text != "")
                {
                    RegisterInfoCache.user_Address = address.Text;
                }
                if (squestionStr != "")
                {
                    RegisterInfoCache.user_security_qustion = squestionStr;
                }
                if (sanswer.Text != "Enter a answer" && sanswer.Text != "")
                {
                    RegisterInfoCache.user_security_answer = sanswer.Text;
                }
                if (profile.Text != "Enter user's personal introduction with a maximum of 300 characters." 
                    && profile.Text != "")
                {
                    RegisterInfoCache.user_about = profile.Text;
                }
                RegisterInfoCache.user_password = generatePWD();
                

                if (User_type.user_deparment =="Admin")
                {
                    RegisterInfoCache.user_ID = SQLCursor.AddOneToLastID("StaffID", "Staff");
                }
                else if(User_type.user_deparment == "Receptionist")
                {
                    RegisterInfoCache.user_ID = SQLCursor.AddOneToLastID("CustomerID", "Customer");
                }


                RegisterInfoCache.step3Activate = true;

                UC_Registration.iconSelect(UC_Registration.uc_Registration.icon3,
                UC_Registration.uc_Registration.iconLabel3);
                UC_Registration.iconUnSelect(UC_Registration.uc_Registration.icon2,
                    UC_Registration.uc_Registration.iconLabel2);
                UC_Registration.iconUnSelect(UC_Registration.uc_Registration.icon1,
                    UC_Registration.uc_Registration.iconLabel1);
                UC_Registe_Complete uc = new UC_Registe_Complete();
                uc.Location = new Point(320, 80);
                AddUserControl.Add(uc, UC_Registration.uc_Registration.contentPanel);
            }
        }
        
        private string generatePWD()
        {
            string chars = "0123456789ABCDEFGHIJKLMNOPQSTUVWXYZabcdefghijklmnpqrstuvwxyz";
            Random randrom = new Random(getNewSeed());

            string str = "";
            for (int j = 0; j < 50; j++)
            {
                str = "";
                for (int i = 0; i < 8; i++)
                {
                    str += chars[randrom.Next(chars.Length)];//randrom.Next(int i)返回一个小于所指定最大值的非负随机数
                }
                //不符合正则，重新生成
                if (!Regex.IsMatch(str, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$"))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            return str;
            int getNewSeed()
            {
                byte[] rndBytes = new byte[4];
                System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
                rng.GetBytes(rndBytes);
                return BitConverter.ToInt32(rndBytes, 0);
            }
        }
    }
}
