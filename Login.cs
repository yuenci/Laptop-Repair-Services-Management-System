using CefSharp;
using miniSys0._3.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniSys0._3
{
    public partial class Login : Form
    {
        public static Login login;
        private Point mPoint;

        public Login()
        {
            InitializeComponent();
            login = this;
            this.StartPosition = FormStartPosition.CenterScreen;

            UC_Login uc = new UC_Login();
            addUserControl(uc);

            //delete this 
            DBdateCorrection();
        }

        private void DBdateCorrection()
        {
            String date = SQLCursor.Query("SELECT Time FROM　Schedule　ORDER BY TIME DESC")[0][0];
            DateTime laststDate = Convert.ToDateTime(date);
            DateTime currentDate = DateTime.Now.ToLocalTime();

            double diff = DiffDays(laststDate, currentDate);
            int diffentDays = Convert.ToInt32(diff) -1;
            
            if (diffentDays >7)
            {   
                SQLCursor.Execute($"update Schedule set Time =DATEADD(DAY,{diffentDays},Time);");
                SQLCursor.Execute($"update Orders set Time =DATEADD(DAY,{diffentDays},Time);");
                
            }
        }

        private double DiffDays(DateTime startTime, DateTime endTime)
        {
            TimeSpan daysSpan = new TimeSpan(endTime.Ticks - startTime.Ticks);
            return daysSpan.TotalDays;
        }



        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //FormFloating.profileFloating.Dispose();
            //Main.main.Dispose();
            /*UC_main.WebBrowser.Dispose();
            UC_main.WebBrowser1.Dispose();
            Reader.reader.Dispose();*/
            Cef.Shutdown();
            Environment.Exit(0);
        }
        

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
        

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


    }
}
