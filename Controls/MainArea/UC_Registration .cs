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
            buttontest.Click += new EventHandler(buttonClickCallfuc);
        }

        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "Registration";
            urC_Crumbs1.crumbsHome.Text = " / Form / Register";
        }

        private void buttonClickCallfuc(object senter, EventArgs e)
        {
            MessageBox.Show("lalalla");
        }
    }
}
