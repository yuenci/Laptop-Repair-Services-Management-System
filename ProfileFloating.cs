using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
namespace miniSys0._3
{
    public partial class ProfileFloating : UIForm
    {
        public ProfileFloating()
        {
            InitializeComponent();
            userName.Text = User_type.user_name;
            userPost.Text = User_type.post;
            icon.Text = User_type.user_name.Substring(0,1);
            icon.ForeColor = User_type.LogoFore;
            icon.FillColor = User_type.LogoBkg;
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
