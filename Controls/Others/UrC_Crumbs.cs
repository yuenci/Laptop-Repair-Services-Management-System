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
    public partial class UrC_Crumbs : UserControl
    {
        public UrC_Crumbs()
        {
            InitializeComponent();
            InitTheme();
        }

        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                crumbsHome.ForeColor = Color.Red;
                crumbsHome.BackColor = Color.FromArgb(28, 47, 70);
                crumbsHome.SymbolColor = Color.Red;

                crumbText.ForeColor = Color.White;
                crumbText.BackColor = Color.FromArgb(28, 47, 70);
            }
        }
    }
}
