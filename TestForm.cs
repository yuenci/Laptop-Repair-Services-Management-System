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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // return empty
            /*
            dynamic[] result = SQLCursor.Query("select Name from Customer where CustomerID = 'Cus00';");
            Console.WriteLine(result.Length);
            */
            //out put 0

            //---------------
            // retun array
            /*
            dynamic[] result1 = SQLCursor.Query("select Name from Customer where CustomerID = 'Cus000000';");
            Console.WriteLine(result1.Length);
            Console.WriteLine(result1[0]);
            */


            //---------------
            // return 2D arrry
            dynamic[] result1 = SQLCursor.Query("select Name ,Email,Birthday,Gender from Customer where CustomerID = 'Cus000000';");
            Console.WriteLine(result1.Length);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            // return 2D arrry
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select Name ,Email,Birthday,Gender from Customer where CustomerID = 'Cus000000';" +
                "select Name ,Email,Birthday,Gender from Customer where CustomerID = 'Cus000001';";
            dynamic[] result = SQLCursor.QueryMany(sql);

            Console.WriteLine(result.Length);
            foreach (var item in result)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //int 
            /*
            SQLCursor.AddOne("ArticlelD", "Art000001", "Likes", "Articles");
            Console.WriteLine("done");
            */
            //update Articles set Likes=Likes+1 where ArticlelD='Art000001';



            //string
            SQLCursor.AddOne("ArticlelD", "Art000001", "ArticlelD", "Articles");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine(SQLCursor.AddOneToLastID("ArticlelD", "Articles"));
        }
    }
}
