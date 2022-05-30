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
    public partial class UC_Payment : UserControl
    {
        public static UC_Payment uc_Payment;
        public UC_Payment()
        {
            InitializeComponent();
            uc_Payment = this;
            InitCurmbs();
            InitTheme();
            Initcontent();
            
        }
        
        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                contentPanel.BackColor = Color.FromArgb(28, 47, 70);
                Container.BackColor = Color.FromArgb(28, 47, 70);
                Container.FillColor = Color.FromArgb(28, 47, 70);
                Container.RectColor = Color.Transparent;

                dynamic[] lable = { label1 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
        }

        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "Payment";
            urC_Crumbs1.crumbsHome.Text = " / Form / Payment";
        }

        private void Initcontent()
        {
            UC_ReciptSubmit uc = new UC_ReciptSubmit();
            AddUserControl.Add(uc, contentPanel);

            /*UC_ReciptComplete uc = new UC_ReciptComplete();
            AddUserControl.Add(uc, contentPanel);*/
        }


    }
}
