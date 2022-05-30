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
    public partial class UC_StaffCard1 : UserControl
    {
        public UC_StaffCard1()
        {      
            InitializeComponent();
            InitTheme();
        }

        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                dynamic[] lable = { nameLabel , postLabel };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
        }

    }
}
