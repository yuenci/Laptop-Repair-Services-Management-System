using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace miniSys0._3.Controls.MainArea
{
    public partial class UC_Cus_dashboard : UserControl
    {
        public UC_Cus_dashboard uc_Cus_dashboard;
        private int imageID = 1;
        private System.Timers.Timer aTimer;
        private string cusID = User_type.user_ID;
        private string[] urls;
        private Color newsForeColor = Color.Black;

        public UC_Cus_dashboard()
        {
            InitializeComponent();
            InitName();
            InitStyle();
            
            InitBtnEvent();
            InitProcess();
            InitNewsStyle();
            InitNewsContent();
            InitNewsEvents();

            InitTheme();

            uc_Cus_dashboard = this;
            SetTimer();
        }
        
        public void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                newsForeColor = Color.White;
                this.BackColor = Color.FromArgb(18, 31, 43);

                dynamic[] container = { uiUserControl1, uiUserControl2, uiUserControl4, uiUserControl5, uiUserControl6 };
                foreach (var item in container)
                {
                    item.FillColor = Color.FromArgb(28, 47, 70);
                    item.BackColor = Color.FromArgb(28, 47, 70);
                    item.RectColor = Color.Transparent;
                }



                dynamic[] lable = { name_lable, label14, shortcutText1, shortcutText2, shortcutText3,
                    orderStatus, modelText, staffName, label19, doc1, doc2, doc3, doc4, label16, 
                     news1, news2, news3, news4, news5, newslabel1, newslabel2, newslabel3, 
                    newslabel4, newslabel5 };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }

                modelIcon.BackColor = Color.FromArgb(55, 55, 57);
                modelIcon.FillColor = Color.FromArgb(55, 55, 57);
                modelIcon.ForeColor = Color.FromArgb(22, 93, 255);


                staffIcon.BackColor = Color.FromArgb(55, 55, 57);
                staffIcon.FillColor = Color.FromArgb(55, 55, 57);
                staffIcon.ForeColor = Color.FromArgb(22, 93, 255);

                imageBtnRight.FillColor = Color.FromArgb(28, 47, 70);
                imageBtnLeft.FillColor = Color.FromArgb(28, 47, 70);
                imageBtnRight.BackColor = Color.FromArgb(28, 47, 70);
                imageBtnLeft.BackColor = Color.FromArgb(28, 47, 70);

            }
        }

        private void InitName()
        {
            name_lable.Text = $"Welcome back，{User_type.user_name}";
        }
        
        private void InitStyle()
        {
            if (User_type.user_theme == "light")
            {
                modelIcon.FillColor = Color.FromArgb(242, 243, 245);
                staffIcon.FillColor = Color.FromArgb(242, 243, 245);

                imageBtn1.FillColor = Color.FromArgb(252, 210, 80);
                imageBtnLeft.FillColor = Color.White;
                imageBtnRight.FillColor = Color.White;
            }
            Process.ProcessBackColor = Color.White;
            Process.ProcessColor = Color.FromArgb(0, 180, 42);

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

        }
        
        public void InitBtnEvent()
        {
            imageBtn1.Click += new EventHandler(Button_Click);
            imageBtn2.Click += new EventHandler(Button_Click);
            imageBtn3.Click += new EventHandler(Button_Click);
            imageBtnLeft.Click += new EventHandler(imageSwith);
            imageBtnRight.Click += new EventHandler(imageSwith);
        }
        
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
            if (SQLCursor.IfthereAnyOrder())
            {
                UC_Cus_OrderDetails uc = new UC_Cus_OrderDetails();
                addUserControl(uc);
            }
            else
            {
                MessageBox.Show("You haven't made any order");
            }
            
        }
        
        private void shortcutButton2_Click(object sender, EventArgs e)
        { 
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

        private void InitProcess()
        {
            if (SQLCursor.IfthereAnyOrder())
            {
                string sql = $"SELECT TOP 1 Schedule.Status,Orders.Model,Staff.Name " +
                $"FROM Schedule " +
                $"INNER JOIN Orders ON Orders.OrderID = Schedule.OrderID " +
                $"INNER JOIN Staff ON Staff.StaffID = Schedule.TechnicianID " +
                $"WHERE Orders.CustomerID = '{cusID}' " +
                $"ORDER BY Schedule.Time DESC; ";
                dynamic[] data = SQLCursor.Query(sql);

                //Console.WriteLine(sql);
                //MessageBox.Show(data[0]);

                if (data.Length == 0)
                {
                    Process.Text = "0";
                    Process.Value = 0;
                    orderStatus.Text = "Odered";
                    staffName.Text = "None";

                    sql = $"SELECT TOP 1 Orders.Model " +
                    $"FROM Schedule " +
                    $"INNER JOIN Orders ON Orders.OrderID = Schedule.OrderID " +
                    $"WHERE Orders.CustomerID = '{cusID}' " +
                    $"ORDER BY Schedule.Time DESC; ";
                    data = SQLCursor.Query(sql);
                    modelText.Text = data[0];
                }
                else
                {

                    Process.Value = int.Parse(prcessValue(data[0])[0]);
                    orderStatus.Text = prcessValue(data[0])[1];
                    modelText.Text = data[1];

                    if (data[2] != null)
                    {
                        staffName.Text = data[2];
                    }
                    else
                    {
                        staffName.Text = "None";
                    }
                }
            }
            else
            {
                Process.Text = "0";
                Process.Value = 100;
                Process.ShowProcess = false;
                modelText.Text = "None";
                orderStatus.Text = "None";
                staffName.Text = "None";
            }
            }

            /*Process.Text = */
        

        private string[] prcessValue(string str)
        {
            string[] valueText  = new string[2];
            if (str == "Order")
            {
                valueText[0] = "25";
                valueText[1] = "Ordered";
                return valueText;
            }
            else if (str == "Progress")
            {
                valueText[0] = "50";
                valueText[1] = "Repatring";
                return valueText;
            }
            else if (str == "Completed")
            {
                valueText[0] = "75";
                valueText[1] = "Complated";
                return valueText;
            }
            else if (str == "Finished")
            {
                valueText[0] = "100";
                valueText[1] = "Finished";
                return valueText;
            }
            return valueText;
        }

        private void InitNewsStyle()
        {
            newsTopBar.RectColor = Color.Transparent;
            newsTopBar.FillColor = Color.FromArgb(242, 243, 245);
            news1.MarkColor = Color.FromArgb(242, 243, 245);
            news2.MarkColor = Color.FromArgb(242, 243, 245);
            news3.MarkColor = Color.FromArgb(242, 243, 245);
            news4.MarkColor = Color.FromArgb(242, 243, 245);
            news5.MarkColor = Color.FromArgb(242, 243, 245);

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
        }
        
        private void InitNewsContent()
        {
            dynamic data = SQLCursor.Query("SELECT TOP  5 Title,Views,Url FROM Articles ORDER BY Views DESC;");
            UIMarkLabel[] uIMarkLabels = { news1 , news2 , news3 , news4 , news5 };
            Label[] lables = { newslabel1 , newslabel2 , newslabel3 , newslabel4 , newslabel5 };
            urls = new string[5];
            for (int i = 0; i < 5; i++)
            {
                uIMarkLabels[i].Text = (i+1).ToString()+ "     " + data[i][0];
                lables[i].Text = data[i][1];
                urls[i] = data[i][2];
            }
        }
        
        private void readerShow(int newsID)
        {
            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"))
                     + $"Html\\Articles\\{urls[newsID]}";
            Reader.reader.WebBrowser2.Load(path);


            add1ToViews(urls[newsID]);

            Thread.Sleep(100);
            Reader.reader.Show();


        }
        
        private void add1ToViews(string url)
        {
            Label[] lables = { newslabel1, newslabel2, newslabel3, newslabel4, newslabel5 };
            int index = urls.ToList().IndexOf(url);
            lables[index].Text = (int.Parse(lables[index].Text) + 1).ToString();
            string sql = $"update Articles set Views=Views+1 where Url='{url}';";
            SQLCursor.Execute(sql);
        }
        
        private void InitNewsEvents()
        {
            news1.Click  += new EventHandler(newsClick);
            news2.Click += new EventHandler(newsClick);
            news3.Click += new EventHandler(newsClick);
            news4.Click += new EventHandler(newsClick);
            news5.Click += new EventHandler(newsClick);

            news1.MouseHover += new EventHandler(newsHover);
            news2.MouseHover += new EventHandler(newsHover);
            news3.MouseHover += new EventHandler(newsHover);
            news4.MouseHover += new EventHandler(newsHover);
            news5.MouseHover += new EventHandler(newsHover);

            news1.MouseLeave += new EventHandler(newsLeave);
            news2.MouseLeave += new EventHandler(newsLeave);
            news3.MouseLeave += new EventHandler(newsLeave);
            news4.MouseLeave += new EventHandler(newsLeave);
            news5.MouseLeave += new EventHandler(newsLeave);
        }
        
        private void newsClick(object sender, EventArgs e)
        {
            if (sender.Equals(news1))
            {
                readerShow( 0);
            }
            else if(sender.Equals(news2))
            {
                readerShow( 1);
            }
            else if (sender.Equals(news3))
            {
                readerShow( 2);
            }
            else if (sender.Equals(news4))
            {
                readerShow( 3);
            }
            else if (sender.Equals(news5))
            {
                readerShow( 4);
            }
        }

        private void newsHover(object sender, EventArgs e)
        {
            if (sender.Equals(news1))
            {
                news1.ForeColor = Color.FromArgb(51, 112, 255);
                newslabel1.ForeColor = Color.FromArgb(51, 112, 255);
            }
            else if (sender.Equals(news2))
            {
                news2.ForeColor = Color.FromArgb(51, 112, 255);
                newslabel2.ForeColor = Color.FromArgb(51, 112, 255);
            }
            else if (sender.Equals(news3))
            {
                news3.ForeColor = Color.FromArgb(51, 112, 255);
                newslabel3.ForeColor = Color.FromArgb(51, 112, 255);
            }
            else if (sender.Equals(news4))
            {
                news4.ForeColor = Color.FromArgb(51, 112, 255);
                newslabel4.ForeColor = Color.FromArgb(51, 112, 255);
            }
            else if (sender.Equals(news5))
            {
                news5.ForeColor = Color.FromArgb(51, 112, 255);
                newslabel5.ForeColor = Color.FromArgb(51, 112, 255);
            }
        }

        private void newsLeave(object sender, EventArgs e)
        {
            if (sender.Equals(news1))
            {
                news1.ForeColor = newsForeColor;
                newslabel1.ForeColor = newsForeColor;
            }
            else if (sender.Equals(news2))
            {
                news2.ForeColor = newsForeColor;
                newslabel2.ForeColor = newsForeColor;
            }
            else if (sender.Equals(news3))
            {
                news3.ForeColor = newsForeColor;
                newslabel3.ForeColor = newsForeColor;
            }
            else if (sender.Equals(news4))
            {
                news4.ForeColor = newsForeColor;
                newslabel4.ForeColor = newsForeColor;
            }
            else if (sender.Equals(news5))
            {
                news5.ForeColor = newsForeColor;
                newslabel5.ForeColor = newsForeColor;
            }
        }

        private void docShow(string docFileName)
        {
            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin"))
                + $"Html\\Document\\{docFileName}.html";
            Reader.reader.WebBrowser2.Load(path);
            Thread.Sleep(100);
            Reader.reader.Show();
        }
        
        private void doc1_Click(object sender, EventArgs e)
        {
            docShow("Doc000001");
        }

        private void doc2_Click(object sender, EventArgs e)
        {
            docShow("Doc000002");
        }

        private void doc3_Click(object sender, EventArgs e)
        {
            docShow("Doc000003");
        }

        private void doc4_Click(object sender, EventArgs e)
        {
            docShow("Doc000004");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VideoPlayer videoPlayer = new VideoPlayer();
            videoPlayer.Show();
        }

        private void readMoreNews_Click(object sender, EventArgs e)
        {
            string path = AppSetting.path + "\\Html\\Articles\\newsMore.html";
            Reader.reader.WebBrowser2.Load(path);

            Thread.Sleep(100);
            Reader.reader.Show();
        }

        private void readMoreDoc_Click(object sender, EventArgs e)
        {
            string path = AppSetting.path + "\\Html\\Document\\docMore.html";
            Reader.reader.WebBrowser2.Load(path);

            Thread.Sleep(100);
            Reader.reader.Show();
        }

    }



}
