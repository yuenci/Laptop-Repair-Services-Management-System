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
        public UC_Registration()
        {
            InitializeComponent();
            InitCurmbs();
            InitIcon();
            IconEventRegister();

            InitContent();
            //button1.Click += new EventHandler(buttonClickCallfuc);
        }

        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "Registration";
            urC_Crumbs1.crumbsHome.Text = " / Form / Register";
        }
        private void iconSelect(UIAvatar icon,Label iconLabel)
        {
            icon.FillColor = Color.FromArgb(22, 93, 255);
            icon.ForeColor = Color.White;

            iconLabel.Font = new Font(".萍方-简", 12, FontStyle.Bold);
        }
        private void iconUnSelect(UIAvatar icon, Label iconLabel)
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

        private void icon1OrLabel1Click(object senter, EventArgs e)
        {
            iconSelect(icon1, iconLabel1);
            iconUnSelect(icon2, iconLabel2);
            iconUnSelect(icon3, iconLabel3);
        }

        private void icon2OrLabel2Click(object senter, EventArgs e)
        {
            iconSelect(icon2, iconLabel2);
            iconUnSelect(icon1, iconLabel1);
            iconUnSelect(icon3, iconLabel3);
        }

        private void icon3OrLabel3Click(object senter, EventArgs e)
        {
            iconSelect(icon3, iconLabel3);
            iconUnSelect(icon1, iconLabel1);
            iconUnSelect(icon2, iconLabel2);
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
            UC_Registe_Staff_Basicinfo  uc= new UC_Registe_Staff_Basicinfo();
            uc.Location = new Point(320,80);
            AddUserControl.Add(uc, contentPanel);
        }
    }
}
