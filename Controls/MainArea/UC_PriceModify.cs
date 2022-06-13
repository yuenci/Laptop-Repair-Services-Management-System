using miniSys0._3.Controls.Others;
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
    public partial class UC_PriceModify : UserControl
    {
        public dynamic[] data;
        public static UC_PriceModify Instance;
        public UC_PriceModify()
        {
            InitializeComponent();
            Instance = this;
            InitServiceData();
            Init();
            InitTheme();
        }

        private void InitTheme()
        {
            if (User_type.user_theme == "dark")
            {
                this.BackColor = Color.FromArgb(18, 31, 43);
                Container.FillColor = Color.FromArgb(28, 47, 70);
                Container.BackColor = Color.FromArgb(28, 47, 70);
                Container.RectColor = Color.Transparent;
                crumbsHome.ForeColor = Color.White;
                crumbText.ForeColor = Color.White;

                pageTitle.ForeColor = Color.White;
            }
            else if (User_type.user_theme == "light")
            {
                this.BackColor = Color.FromArgb(247, 248, 250);
                Container.FillColor = Color.White;
                Container.BackColor = Color.White;
                Container.RectColor = Color.Gainsboro;
                crumbsHome.ForeColor = Color.Black;
                crumbText.ForeColor = Color.Black;

                pageTitle.ForeColor = Color.Black;
            }

            Price_Card[] cards = {price_Card1, price_Card2,price_Card3,price_Card4,price_Card5,price_Card6,price_Card7,price_Card8};
            foreach (var card in cards)
            {
                card.InitTheme();
            }
        }



        private void InitServiceData()
        {
            string sql = "SELECT　Normal_fee, Urgent_fee FROM Service ORDER BY ServiceID;";
            data = SQLCursor.Query(sql);
        }

        private void Init()
        {
            price_Card1.Init(0);
            price_Card2.Init(1);
            price_Card3.Init(2);
            price_Card4.Init(3);
            price_Card5.Init(4);
            price_Card6.Init(5);
            price_Card7.Init(6);
            price_Card8.Init(7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(price_Card1.iconStatus);
        }
    }
}
