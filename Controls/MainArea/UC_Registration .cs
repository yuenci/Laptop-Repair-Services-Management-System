using miniSys0._3.Controls.Others;
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

namespace miniSys0._3.Controls.MainArea
{
    public partial class UC_Registration : UserControl
    {
        public static UC_Registration uc_Registration;
        public Panel contentArea;

        public UC_Registration()
        {
            InitializeComponent();
            InitCurmbs();
            InitIcon();
            InitTheme();
            IconEventRegister();
            InitContent();
            uc_Registration = this;
            //button1.Click += new EventHandler(buttonClickCallfuc);

        }
        
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor= Color.FromArgb(28, 47, 70);
                Container.FillColor = Color.FromArgb(28, 47, 70);
                Container.BackColor = Color.FromArgb(28, 47, 70);
                Container.RectColor = Color.FromArgb(28, 47, 70);
                contentPanel.BackColor = Color.FromArgb(28, 47, 70);


                dynamic[] labelList = { label1, iconLabel1, iconLabel2, iconLabel3 };
                foreach (var item in labelList)
                {
                    item.ForeColor = Color.White;
                }
            }
        }
        
        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "Registration";
            urC_Crumbs1.crumbsHome.Text = " / Form / Register";
        }
        

        public static void iconSelect(UIAvatar icon,Label iconLabel)
        {
            icon.FillColor = Color.FromArgb(22, 93, 255);
            icon.ForeColor = Color.White;

            iconLabel.Font = new Font(".萍方-简", 12, FontStyle.Bold);
        }
        

        public static void iconUnSelect(UIAvatar icon, Label iconLabel)
        {
            icon.FillColor = Color.FromArgb(242, 243, 245);
            icon.ForeColor = Color.FromArgb(78, 89, 105);

            iconLabel.Font = new Font(".萍方-简", 12, FontStyle.Regular);
        }


        private void InitIcon()
        {
            iconSelect(icon1, iconLabel1);
            iconUnSelect(icon2, iconLabel2);
            iconUnSelect(icon3, iconLabel3);
        }


        private void  icon1OrLabel1Click(object senter, EventArgs e)
        {
            iconSelect(icon1, iconLabel1);
            iconUnSelect(icon2, iconLabel2);
            iconUnSelect(icon3, iconLabel3);


            if (User_type.user_deparment == "Admin")
            {
                UC_Registe_Staff_Basicinfo uc = new UC_Registe_Staff_Basicinfo();
                AddUserControl.Add(uc, contentPanel);
                string[] staffRegisterInfoCashe = { RegisterInfoCache.user_name ,
                RegisterInfoCache.user_ID_number,RegisterInfoCache.user_deparment,
                RegisterInfoCache.user_post
                };
                dynamic[] controlList = { uc.nameTextBox,uc.IDnumberTextBox,
                uc.selectDepartment,uc.selectPost
                };
                for (int i = 0; i < staffRegisterInfoCashe.Length; i++)
                {
                    controlList[i].Text = staffRegisterInfoCashe[i];
                    controlList[i].Font = new Font(".萍方-简", 12, FontStyle.Bold);
                }
            }
            else if (User_type.user_deparment == "Receptionist")
            {
                UC_Registe_Customer_Basicinfo uc = new UC_Registe_Customer_Basicinfo();
                AddUserControl.Add(uc, contentPanel);

                uc.nameTextBox.Text = RegisterInfoCache.user_name;
                uc.nameTextBox.Font = new Font(".萍方-简", 12, FontStyle.Bold);
            }
            
        }


        private void icon2OrLabel2Click(object senter, EventArgs e)
        {
            if (RegisterInfoCache.step2Activate == true)
            {
                iconSelect(icon2, iconLabel2);
                iconUnSelect(icon1, iconLabel1);
                iconUnSelect(icon3, iconLabel3);
                UC_Registe_detaildinfo uc = new UC_Registe_detaildinfo();
                AddUserControl.Add(uc, contentPanel);

                string[] controlsText = {
                    RegisterInfoCache.user_phone,
                    RegisterInfoCache.user_Birthday ,
                    RegisterInfoCache.user_email ,
                    RegisterInfoCache.user_gender ,
                    RegisterInfoCache.user_Country ,
                    RegisterInfoCache.user_Address ,
                    RegisterInfoCache.user_security_qustion ,
                    RegisterInfoCache.user_security_answer,
                    RegisterInfoCache.user_about 
                };

                dynamic[] controls = {
                    uc.phone,
                    uc.birthDatePicker,
                    uc.email,
                    uc.gender,
                    uc.country,
                    uc.address,
                    uc.squestion,
                    uc.sanswer,
                    uc.profile
                };

                for (int i = 0; i < controlsText.Length; i++)
                {
                    if(controlsText[i] != "")
                    {
                        controls[i].Text = controlsText[i];
                        controls[i].Font = new Font(".萍方-简", 12, FontStyle.Bold);
                    }
                }

                
            }
            
        }


        private void icon3OrLabel3Click(object senter, EventArgs e)
        {
            if (RegisterInfoCache.step3Activate == true)
            {
                iconSelect(icon3, iconLabel3);
                iconUnSelect(icon1, iconLabel1);
                iconUnSelect(icon2, iconLabel2);
                UC_Registe_Complete uc = new UC_Registe_Complete();
                AddUserControl.Add(uc, contentPanel);
            }
                
        }


        private void IconEventRegister()
        {
            icon1.Click += new EventHandler(icon1OrLabel1Click);
            iconLabel1.Click += new EventHandler(icon1OrLabel1Click);

            icon2.Click += new EventHandler(icon2OrLabel2Click);
            iconLabel2.Click += new EventHandler(icon2OrLabel2Click);

            icon3.Click += new EventHandler(icon3OrLabel3Click);
            iconLabel3.Click += new EventHandler(icon3OrLabel3Click);
        }


        private void InitContent()
        {
            if (User_type.user_deparment == "Admin")
            {
                UC_Registe_Staff_Basicinfo uc = new UC_Registe_Staff_Basicinfo();
                uc.Location = new Point(320, 80);
                AddUserControl.Add(uc, contentPanel);
            }
            else if (User_type.user_deparment == "Receptionist")
            {
                UC_Registe_Customer_Basicinfo uc = new UC_Registe_Customer_Basicinfo();
                uc.Location = new Point(320, 80);
                AddUserControl.Add(uc, contentPanel);
            }


            /*UC_Registe_detaildinfo uc = new UC_Registe_detaildinfo();
            uc.Location = new Point(320, 80);
            AddUserControl.Add(uc, contentPanel);*/

            /*UC_Registe_Complete uc = new UC_Registe_Complete();
            uc.Location = new Point(320, 80);
            AddUserControl.Add(uc, contentPanel);*/
        }
    }
}
