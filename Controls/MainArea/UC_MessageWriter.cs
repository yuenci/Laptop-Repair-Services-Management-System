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
    public partial class UC_MessageWriter : UserControl
    {
        public UC_MessageWriter()
        {
            InitializeComponent();
            InitCurmbs();
            InitCurrentNum();
            InitTheme();
        }

        private void InitTheme()
        {
            delect.FillColor = Color.FromArgb(22, 93, 255);
            delect.FillHoverColor = Color.FromArgb(64, 128, 255);
            delect.FillPressColor = Color.FromArgb(64, 128, 255);
            delect.RectColor = Color.Transparent;

            ok.FillColor = Color.FromArgb(22, 93, 255);
            ok.FillHoverColor = Color.FromArgb(64, 128, 255);
            ok.FillPressColor = Color.FromArgb(64, 128, 255);
            ok.RectColor = Color.Transparent;

            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(18, 31, 43);
                Container.BackColor = Color.FromArgb(28, 47, 70);
                Container.FillColor = Color.FromArgb(28, 47, 70);
                Container.RectColor = Color.Transparent;
                textbox.RectColor = Color.Transparent;
                textbox.FillColor = Color.FromArgb(55, 55, 57);

                
                dynamic[] lable = { showMessageNum , counter, textbox , pageTitle };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
            else if(User_type.user_theme == "light")
            {
                this.BackColor = Color.FromArgb(247, 248, 250);
                Container.BackColor = Color.White;
                Container.FillColor = Color.White;
                Container.RectColor = Color.Gainsboro;

                textbox.RectColor = Color.Gainsboro;
                textbox.FillColor = Color.White;

                dynamic[] lable = { showMessageNum, counter, textbox, pageTitle };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }
            }
        }


        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "Payment";
            urC_Crumbs1.crumbsHome.Text = " / Form / Payment";
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            int length = textbox.Text.Length;
            counter.Text = $"{length}/280";
            if (length>280)
            {
                textbox.Text = textbox.Text.Substring(0,280);
            }
            //Console.WriteLine(textbox.Text);
        }

        private void InitCurrentNum()
        {
            string sql = "SELECT　COUNT(*) FROM Messages WHERE Type = '@all';";
            dynamic[] data = SQLCursor.Query(sql);
            if (data.Length>0)
            {
                string num = data[0];
                if (num =="0")
                {
                    showMessageNum.Text = "0 system message currently";
                }
                else if (num == "1")
                {
                    showMessageNum.Text = "1 system message currently";
                }
                else
                {
                    showMessageNum.Text = $"{num} system messages currently";
                }
            }
            else
            {
                showMessageNum.Text = "0 system message currently";
            }
        }

        private void delect_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Messages WHERE Type = '@all';";
            SQLCursor.Execute(sql);

            NotificationForm messageBoxForm = new NotificationForm("success", "Delect successfully");
            messageBoxForm.ShowDialog();

            InitCurrentNum();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (textbox.Text.Length>0)
            {
                string message = textbox.Text;
                string time = DateTime.Now.ToLocalTime().ToString();
                string sql = $"INSERT INTO Messages VALUES ('{message}', 0, '{time}','@all',null ,null,null,null) ;";
                SQLCursor.Execute(sql);

                InitCurrentNum();


                NotificationForm messageBoxForm = new NotificationForm("success", "Post messages successfully");
                messageBoxForm.ShowDialog();

                
            }
            
        }
    }
}
