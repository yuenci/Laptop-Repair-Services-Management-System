using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            searchBox.Hide();
        }
        Point mPoint;
        private void drag_down(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void drag_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);

            }
        }

        private void profile_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void searchIcon_Click(object sender, EventArgs e)
        {
            searchBox.Show();
            searchBox.Focus();
        }

        private void search_enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void search_leave(object sender, EventArgs e)
        {
            searchBox.Text = "Type here to search";
        }

        private void panel_hover(object sender, EventArgs e)
        {
            dashBoardIcon.ForeColor = Color.FromArgb(51, 112, 255);
            dashBoardLable.ForeColor = Color.FromArgb(51, 112, 255);
            dashBoardDown.ForeColor = Color.FromArgb(51, 112, 255);
        }

        private void panel_leave(object sender, EventArgs e)
        {
            dashBoardIcon.ForeColor = Color.FromArgb(78, 89, 105);
            dashBoardLable.ForeColor = Color.FromArgb(78, 89, 105);
            dashBoardDown.ForeColor = Color.FromArgb(78, 89, 105);
        }
    }
}
