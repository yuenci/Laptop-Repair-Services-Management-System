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
        public UC_Payment()
        {
            InitializeComponent();
            InitCurmbs();
        }
        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "Payment";
            urC_Crumbs1.crumbsHome.Text = " / Form / Payment";
        }
    }
}
