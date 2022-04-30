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
    public partial class UC_TaskCards : UserControl
    {
        public static UC_TaskCards uc_TaskCards;
        public UC_TaskCards()
        {
            InitializeComponent();
            InitCurmbs();
            InitCard();
            uc_TaskCards = this;
        }

        private void InitCurmbs()
        {
            urC_Crumbs1.crumbText.Text = "Table";
            urC_Crumbs1.crumbsHome.Text = " / Table / Card list";
        }
        private void InitCard()
        {
            string sql = "WITH A AS(SELECT DISTINCT OrderID,Time from Schedule WhERE Status = 'Finished'),";
            sql += "B AS(SELECT DISTINCT OrderID,Time from Schedule)";
            sql += "select * from B where (select count(1) as num from A where A.OrderID = B.OrderID) = 0  Order by Time";

            dynamic[]  data = SQLCursor.Query(sql);

            dynamic[] card = { uC_Task_Card1, uC_Task_Card2, uC_Task_Card3, uC_Task_Card4,
            uC_Task_Card5,uC_Task_Card6,uC_Task_Card7,uC_Task_Card8,uC_Task_Card9};

            for (int i = 0; i < card.Length; i++)
            {
                card[i].Init(data[i][0]);
            }

            pagination.Init(data.Length,9);
            pagination.ComboBox.Text = "9 / page";
            pagination.ComboBox.Enabled = false;
            pagination.type = "card";
        }


        private void reset_Click(object sender, EventArgs e)
        {
            serviceType.Text = "";
            name.Text = "";
            date1.Text = DateTime.Now.ToString("yyyy-MM-dd"); 
            date2.Text = DateTime.Now.ToString("yyyy-MM-dd"); 
            status.Text = "";
            orderID.Text = "";
        }

        private void query_Click(object sender, EventArgs e)
        {

        }
    }
}
