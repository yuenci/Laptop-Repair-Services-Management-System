using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace miniSys0._3.Controls.MainArea
{
    public partial class UC_Cus_dashboard : UserControl
    {
        UC_Cus_dashboard uc_Cus_dashboard;
        public UC_Cus_dashboard()
        {
            InitializeComponent();
            InitName();
            InitStyle();
            InitBtnEvent();
            uc_Cus_dashboard = this;
            SetTimer();
        }

        private void UC_Cus_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void InitName()
        {
            name_lable.Text = $"Welcome back，{User_type.user_name}";
        }
        private void InitStyle()
        {
            shortcutButton1.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton2.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton3.FillColor = Color.FromArgb(242, 243, 245);
            shortcutButton1.SymbolColor = Color.Black;
            shortcutButton2.SymbolColor = Color.Black;
            shortcutButton3.SymbolColor = Color.Black;
            shortcutButton1.SymbolHoverColor = Color.Black;
            shortcutButton2.SymbolHoverColor = Color.Black;
            shortcutButton3.SymbolHoverColor = Color.Black;

            shortcutButton1.RectColor = Color.Transparent;
            shortcutButton2.RectColor = Color.Transparent;
            shortcutButton3.RectColor = Color.Transparent;

            imageBtn1.FillColor = Color.FromArgb(252, 210, 80);
            imageBtnLeft.FillColor = Color.White;
            imageBtnRight.FillColor = Color.White;
        }
        public void InitBtnEvent()
        {
            imageBtn1.Click += new EventHandler(Button_Click);
            imageBtn2.Click += new EventHandler(Button_Click);
            imageBtn3.Click += new EventHandler(Button_Click);
            imageBtnLeft.Click += new EventHandler(imageSwith);
            imageBtnRight.Click += new EventHandler(imageSwith);
        }
        private int imageID= 1;
        public void Button_Click(object senter, EventArgs e)
        {

            if (senter.Equals(imageBtn1))
            {
                pictureBox2.Image = Properties.Resources.banner_012;

                setBelowBtn(1);
            }
            else if (senter.Equals(imageBtn2))
            {
                pictureBox2.Image = Properties.Resources.banner_022;

                setBelowBtn(2);
            }
            else if (senter.Equals(imageBtn3))
            {
                pictureBox2.Image = Properties.Resources.banner_032;

                setBelowBtn(3);
            }
        }



        private void imageSwith(object sender, EventArgs e)
        {
            if (sender.Equals(imageBtnLeft))
            {
                if (imageID == 1)
                {
                    pictureBox2.Image = Properties.Resources.banner_032;
                    setBelowBtn(3);
                }
                else if (imageID == 2)
                {
                    pictureBox2.Image = Properties.Resources.banner_012;
                    setBelowBtn(1);
                }
                else if (imageID == 3)
                {
                    pictureBox2.Image = Properties.Resources.banner_022;
                    setBelowBtn(2);
                }
            }
            else if (sender.Equals(imageBtnRight))
            {
                if (imageID == 1)
                {
                    pictureBox2.Image = Properties.Resources.banner_022;
                    setBelowBtn(2);
                }
                else if (imageID == 2)
                {
                    pictureBox2.Image = Properties.Resources.banner_032;
                    setBelowBtn(3);
                }
                else if (imageID == 3)
                {
                    pictureBox2.Image = Properties.Resources.banner_012;
                    setBelowBtn(1);
                }
            }
        }

        private void setBelowBtn(int num)
        {
            UIUserControl[] imageBtns = { imageBtn1, imageBtn2, imageBtn3 };
            foreach (UIUserControl img in imageBtns)
            {
                img.FillColor = Color.White;
            }

            if (num == 1)
            {
                imageBtn1.FillColor = Color.FromArgb(252, 210, 80);
                imageID = 1;
            }
            else if (num == 2)
            {
                imageBtn2.FillColor = Color.FromArgb(252, 210, 80);
                imageID = 2;
            }
            else if (num == 3)
            {
                imageBtn3.FillColor = Color.FromArgb(252, 210, 80);
                imageID = 3;
            }
        }

        private  System.Timers.Timer aTimer;

        private  void SetTimer()
        {
            aTimer = new System.Timers.Timer(4000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private  void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (imageID == 1)
            {
                pictureBox2.Image = Properties.Resources.banner_022;
                setBelowBtn(2);
            }
            else if (imageID == 2)
            {
                pictureBox2.Image = Properties.Resources.banner_032;
                setBelowBtn(3);
            }
            else if (imageID == 3)
            {
                pictureBox2.Image = Properties.Resources.banner_012;
                setBelowBtn(1);
            }
        }

        private void shortcutButton3_Click(object sender, EventArgs e)
        {
            UC_UserSetting uc = new UC_UserSetting();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Main.main.mainPanel.Controls.Clear();
            Main.main.mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void shortcutButton1_Click(object sender, EventArgs e)
        {
            UC_Cus_OrderDetails uc = new UC_Cus_OrderDetails();
            addUserControl(uc);
        }

        private void shortcutButton2_Click(object sender, EventArgs e)
        {
            string cusID = User_type.user_ID;
            string OrderID = "Ord00005700";
            
            dynamic[] description = SQLCursor.Query($"select Top 1 Description from Orders where CustomerID = '{cusID}' Order by Time DESC;;");
            int length = description.Length;

            if (length>0)
            {
                if (description[0] != null)
                {
                    AddDescription addDescription = new AddDescription();
                    addDescription.cusInit(description[0]);
                    addDescription.Show();
                }
                else
                {
                    MessageBox.Show("Your order haven't description yet");
                }
            }
            else
            {
                MessageBox.Show("You haven't made any order");
            }
        }
    }
    
}
