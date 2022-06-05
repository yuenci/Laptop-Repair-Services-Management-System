
using miniSys0._3.Controls.Setting;
using Sunny.UI;
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
    public partial class SettingForm : UIForm
    {
        private Color lineColor = Color.Gainsboro;
        private Color IconForeColor = Color.Black;
        private Panel panelBlueLine = new Panel();
        private Color ForeBlue = Color.FromArgb(22, 93, 255);
        public static SettingForm Instance;
        public SettingForm()
        {
            InitializeComponent();
            InitContorl();
            InitTheme();
            Instance= this;
        }

        public void InitTheme()
        {
            line.BackColor = Color.Transparent;
            line.FillColor = Color.Transparent;

            panelBlueLine.Size = new Size(80, 2);
            panelBlueLine.BackColor = Color.FromArgb(22, 93, 255);
            panelBlueLine.Location = new Point(0, 28);
            general.Controls.Add(panelBlueLine);

            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(28, 47, 70);
                this.rectColor = Color.FromArgb(28, 47, 70);
                ShowShadow = false;
                lineColor = Color.FromArgb(55, 55, 57);
                line.LineColor = lineColor;
                IconForeColor = Color.White;
                dynamic[] lable = { general,message,privacy,export};
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

            }
            else if(User_type.user_theme == "light")
            {
                this.BackColor = Color.White;
                this.rectColor = Color.Gainsboro;
                ShowShadow = true;
                lineColor = Color.Gainsboro;
                line.LineColor = lineColor;
                IconForeColor = Color.Black;
                dynamic[] lable = { general, message, privacy, export };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }

            }
            UC_Setting_Privacy.Instance.InitTheme();
            UC_Setting_Message.Instance.InitTheme();
            UC_Setting_General.Instance.InitTheme();
            UC_Setting_Expost.Instance.InitTheme();

            general.ForeColor = Color.FromArgb(22, 93, 255);
        }
        private void addUserControl(UserControl userControl)
        { 
            //panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void InitContorl()
        {
            UC_Setting_General uc = new UC_Setting_General();
            uc.InitStatus();
            uc.InitTheme();
            addUserControl(uc);


            UC_Setting_Message uc1 = new UC_Setting_Message();
            uc1.Location = new Point(0, 200);
            uc1.InitStatus();
            uc1.InitTheme();
            addUserControl(uc1);

            UC_Setting_Privacy uc2 = new UC_Setting_Privacy();
            uc2.Location = new Point(0, 400);
            uc2.InitStatus();
            uc2.InitTheme();
            addUserControl(uc2);

            UC_Setting_Expost uc3 = new UC_Setting_Expost();
            uc3.Location = new Point(0, 600);
            uc3.InitTheme();
            addUserControl(uc3);

            panel1.MouseWheel += new MouseEventHandler(panel1_MouseWheel);
        }
        private int SlideDistance = 0;
        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
           
            if (SlideDistance + e.Delta >= -600 && SlideDistance + e.Delta <=0)
            {
                SlideDistance += e.Delta;
            }

            if (SlideDistance ==0)
            {
                ClearForeColor();
                general.ForeColor = ForeBlue;
                general.Controls.Add(panelBlueLine);
            }
            else if (SlideDistance ==-120 )
            {
                ClearForeColor();
                general.ForeColor = ForeBlue;
                general.Controls.Add(panelBlueLine);
            }
            else if (SlideDistance == -240)
            {
                ClearForeColor();
                message.ForeColor = ForeBlue;
                message.Controls.Add(panelBlueLine);
            }
            else if (SlideDistance == -360)
            {
                ClearForeColor();
                privacy.ForeColor = ForeBlue;
                privacy.Controls.Add(panelBlueLine);
            }
            else if (SlideDistance == -480)
            {
                ClearForeColor();
                export.ForeColor = ForeBlue;
                export.Controls.Add(panelBlueLine);
            }
            else if (SlideDistance == -600)
            {
                //pass
            }

            //Console.WriteLine(SlideDistance);
        }
        private void ClearForeColor()
        {
            UILabel[] textes = { general,message,privacy,export};
            foreach (UILabel texte in textes)
            {
                texte.ForeColor = IconForeColor;
                texte.Controls.Clear();
            }
        }

        private void general_Click(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 0;

            ClearForeColor();
            general.ForeColor = ForeBlue;
            general.Controls.Add(panelBlueLine);
        }

        private void message_Click(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 210;

            ClearForeColor();
            message.ForeColor = ForeBlue;
            message.Controls.Add(panelBlueLine);
        }

        private void privacy_Click(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 410;

            ClearForeColor();
            privacy.ForeColor = ForeBlue;
            privacy.Controls.Add(panelBlueLine);
        }

        private void export_Click(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 610;

            ClearForeColor();
            export.ForeColor = ForeBlue;
            export.Controls.Add(panelBlueLine);
        }

        public void ReInitStatus()
        {
            UC_Setting_Privacy.Instance.InitStatus();
            UC_Setting_Message.Instance.InitStatus();
            UC_Setting_General.Instance.InitStatus();
        }
    }
}
