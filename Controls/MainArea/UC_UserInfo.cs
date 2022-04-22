using miniSys0._3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3.Controls.MainArea
{
    public partial class UC_UserInfo : UserControl
    {
        public UC_UserInfo()
        {
            InitializeComponent();

            InitUserInfoBar();
            InitDeviceCard();
            //InitRlatedStaff();

        }

        private void InitUserInfoBar()
        {
            picContainer.FillColor = User_type.LogoBkg;
            Console.WriteLine(User_type.user_ID);
            UserFirstLeeter.Text = User_type.user_name.Substring(0, 1);
            UserFirstLeeter.ForeColor = User_type.LogoFore;

            ButtonEditPhoto.Parent = pictureBg;
            ButtonEditPhoto.Location = new Point(615, 82);
            LableUsername.Parent = pictureBg;
            LableUsername.Location = new Point(523, 115);
            LableUsername.Text = User_type.user_name;

            if (User_type.user_deparment != "Customer")
            {
                ButtonUserPost.FillColor = Color.Transparent;
                ButtonUserDepart.FillColor = Color.Transparent;
                ButtonUserCoutry.FillColor = Color.Transparent;
                ButtonUserPost.RectDisableColor = Color.Transparent;
                ButtonUserDepart.RectDisableColor = Color.Transparent;
                ButtonUserCoutry.RectDisableColor = Color.Transparent;

                ButtonUserPost.Text = User_type.user_post;
                ButtonUserPost.Parent = pictureBg;
                ButtonUserPost.Location = new Point(250, 150);

                ButtonUserDepart.Text = User_type.user_deparment;
                ButtonUserDepart.Parent = pictureBg;
                ButtonUserDepart.Location = new Point(490, 150);     

                ButtonUserCoutry.Text = User_type.user_Country;
                ButtonUserCoutry.Parent = pictureBg;
                ButtonUserCoutry.Location = new Point(660, 150);
            }
        }
        private void InitDeviceCard()
        {
            this.macLabel.Parent = this.pictureBoxMacbook;
            macLabel.Location = new Point(55, 25);

            this.iphonrLabel.Parent = this.pictureBoxIphone;
            iphonrLabel.Location = new Point(55, 25);

            ButtonEdit1.Parent = this.pictureBoxIphone;
            ButtonEdit1.Location = new Point(30, 180);
            ButtonEdit2.Parent = this.pictureBoxMacbook;
            ButtonEdit2.Location = new Point(30, 180);
            buttonGarbage1.Parent = this.pictureBoxIphone;
            buttonGarbage1.Location = new Point(150, 180);
            buttonGarbage2.Parent = this.pictureBoxMacbook;
            buttonGarbage2.Location = new Point(150, 180);

            ButtonEdit1.Hide();
            ButtonEdit2.Hide();
            buttonGarbage1.Hide();
            buttonGarbage2.Hide();

            
        }

        private void InitRlatedStaff(string[] stuffArry)
        {
            if (stuffArry.Length != 4)
            {
                
            }

            uC_StaffCard1.pictureHead.Image = Resources.head1;
            uC_StaffCard2.pictureHead.Image = Resources.head2;
            uC_StaffCard3.pictureHead.Image = Resources.head3;
            uC_StaffCard4.pictureHead.Image = Resources.head4;

            dynamic[] staffCardObjArray = { uC_StaffCard1 , uC_StaffCard2 , uC_StaffCard3 , uC_StaffCard4 };

            //nameLable
            //deparName

            /*string allsql = "";
            for (int i = 0; i < 8; i++)
            {
                var sqlpart = $"select COUNT(*) from Orders where month(Time) = month(getdate()) and " +
                    $"year(Time) = year(getdate()) and Service_type = 'Ser00{i + 1}';";
                allsql += sqlpart;
            }
            dynamic[] connTools2 = getDataReader(allsql);
            SqlDataReader dr2 = connTools2[1];
            SqlConnection conn2 = connTools2[0];
            List<int> result = new List<int>();
            do
            {
                dr2.Read();
                result.Add(int.Parse(dr2[0].ToString()));
            }
            while (dr2.NextResult()); //next method
            dr2.Close();
            conn2.Close();*/
        }

        private void phone_hover(object sender, EventArgs e)
        {
            ButtonEdit1.Show();
            buttonGarbage1.Show();
        }

        private async void phone_leave(object sender, EventArgs e)
        {
            var result = sleepForms(3000);
            string rrr = await result;
            ButtonEdit1.Hide();
            buttonGarbage1.Hide();
        }

        private async void macCard_leave(object sender, EventArgs e)
        {
            var result = sleepForms(3000);
            string rrr = await result;
            ButtonEdit2.Hide();
            buttonGarbage2.Hide();
        }

        private Task<string> sleepForms(int ms)
        {
            var task = Task.Run(() =>
            {
                Thread.Sleep(ms);
                return "";
            });

            return task;
        }

        private void mac_hover(object sender, EventArgs e)
        {
            ButtonEdit2.Show();
            buttonGarbage2.Show();
        }

        private async void mac_leave(object sender, EventArgs e)
        {
            var result = sleepForms(2000);
            string rrr = await result;
            ButtonEdit2.Hide();
            buttonGarbage2.Hide();
        }
    }
}
