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
    public partial class UC_StaffCard : UserControl
    {
        public UC_StaffCard()
        {
            InitializeComponent();
            initStyle();
        }
        private void initStyle()
        {
            staffNameLable.Font = new Font(".萍方-简", 15);
            deparNameLable.Font = new Font(".萍方-简", 12);
            staffNameLable.Location = new Point(40, 1);
            deparNameLable.Location = new Point(40, 15);
        }
    }
}
