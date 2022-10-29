using miniSys0._3.Controls.MainArea;
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
    public partial class Price_Card : UserControl
    {
        public int numCache;
        public Price_Card()
        {
            InitializeComponent();
        }

        public void Init(int num)
        {
            InitServiceType(num);
            InitServiceData(num);
            numCache = num;
        }
        public void InitTheme()
        {
            normalFee.RectColor = Color.Gainsboro;
            urgentFee.RectColor = Color.Gainsboro;

            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(55, 55, 57);
                dynamic[] lable = { serviceType,normal,urgent };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.White;
                }
            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.White;


                dynamic[] lable = { serviceType, normal, urgent };
                foreach (var item in lable)
                {
                    item.ForeColor = Color.Black;
                }
            }
        }

        private void InitServiceType(int num)
        {
            string[] serviceList =
            {
                "Remove virus, malware or spyware",
                "Troubleshot and fix computer running slow",
                "Laptop screen replacement",
                "Laptop keyboard replacement",
                "Laptop battery replacement",
                "Operating System Format and Installation",
                "Data backup and recovery",
                "Internet connectivity issues"
            };

            if (num>=0 && num<8)
            {
                serviceType.Text = serviceList[num];
            }
           
        }

        private void InitServiceData(int num)
        {
            dynamic data = UC_PriceModify.Instance.data;
            if (data.Length > 0)
            {
                normalFee.Text = data[num][0];
                urgentFee.Text = data[num][1];
            }
            normalFee.Enabled = false;
            urgentFee.Enabled = false;
        }
        public int iconStatus = 0;
        private void editIcon_Click(object sender, EventArgs e)
        {
            if (iconStatus == 0)
            {
                editIcon.FillColor = Color.FromArgb(0, 180, 42);//green
                editIcon.Symbol = 61452;
                normalFee.Enabled = true;
                urgentFee.Enabled = true;
                iconStatus = 1;
            }
            else if (iconStatus == 1)
            {
                string sql = SQLStatement();
                if (sql == null)
                {
                    //pass
                }
                else
                {
                    editIcon.FillColor = Color.FromArgb(22, 93, 255); //blue
                    editIcon.Symbol = 61508;
                    normalFee.Enabled = false;
                    urgentFee.Enabled = false;
                    SQLCursor.Execute(sql);
                    iconStatus = 0;

                    NotificationForm messageBoxForm = new NotificationForm("success", "Modify successfully");
                    messageBoxForm.ShowDialog();
                }
                
            }
        }

        private string SQLStatement()
        {
            string normalFeeStr = normalFee.Text;
            string urgentFeeStr = urgentFee.Text;
            bool ifNormalFeeNum = RegexForInput.PhoneNumVerify(normalFee.Text);
            
            bool ifUrgentFeeNum = RegexForInput.PhoneNumVerify(urgentFee.Text);
            Console.WriteLine(ifUrgentFeeNum.ToString());
            //urgentFee
            if (ifNormalFeeNum && ifUrgentFeeNum)
            {
                string sql = $"UPDATE Service SET Normal_fee={normalFeeStr}, " +
                     $"Urgent_fee ={urgentFeeStr} WHERE ServiceID = 'Ser00{numCache +1}';";
                return sql;
            }
            else
            {
                NotificationForm messageBoxForm = new NotificationForm("warning", "Invalid input");
                messageBoxForm.ShowDialog();
                return null;
            }
        }
    }
}
