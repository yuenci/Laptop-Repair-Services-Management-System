using miniSys0._3.Controls.MainArea;
using miniSys0._3.Controls.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Security;
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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            /*string a =  Membership.GeneratePassword(8, 1);*/

            string chars = "0123456789ABCDEFGHIJKLMNOPQSTUVWXYZabcdefghijklmnpqrstuvwxyz";
            Random randrom = new Random(getNewSeed());

            string str = "";
            for (int j = 0; j < 50; j++)
            {
                str = "";
                for (int i = 0; i < 8; i++)
                {
                    str += chars[randrom.Next(chars.Length)];//randrom.Next(int i)返回一个小于所指定最大值的非负随机数
                }
                //不符合正则，重新生成
                if (!Regex.IsMatch(str, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$"))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine(str);
        }
        private static int getNewSeed()
        {
            byte[] rndBytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(rndBytes);
            return BitConverter.ToInt32(rndBytes, 0);
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“csharpRepairerIncDataSet.Orders”中。您可以根据需要移动或移除它。
            this.ordersTableAdapter.Fill(this.csharpRepairerIncDataSet.Orders);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.FillBy(this.csharpRepairerIncDataSet.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            string connStr = AppSetting.DBString;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                string sql = "select * from Orders order by OrderID DESC;";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                //add set to dataview
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dynamic[] Data = SQLCursor.Query($"SELECT TOP 1 Status,Time FROM Schedule " +
                $"WHERE OrderID = 'Ord00000003' " +
                $"ORDER BY Time DESC;");
            MessageBox.Show(Data[1]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string data = SQLCursor.getName("sta000009");
            MessageBox.Show(data);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Title,Staff.Name,Time,Views,Likes FROM Articles  " +
                "INNER JOIN Staff ON Articles.PosterID = Staff.StaffID " +
                "WHERE  Type = 'News'  ORDER BY Views DESC ;";
            dynamic[] Data = SQLCursor.Query(sql);
            string json = "{";
            for (int i = 0; i < Data.Length; i++)
            {
                json += $"\"{i}\":{{";
                json += $"\"title\":\"{Data[i][0]}\",";
                json += $"\"publisher\":\"{Data[i][1]}\",";
                json += $"\"time\":\"{Data[i][2]}\",";
                json += $"\"views\":\"{Data[i][3]}\",";
                json += $"\"likes\":\"{Data[i][4]}\"";
                if (i == Data.Length - 1)
                {
                    json += "}";
                }
                else
                {
                    json += "},";
                }

            }
            json += "}";

            writeJsonToFile("newsIndex.json", json);
        }

        private void writeJsonToFile(string fileName, string content)
        {
            string path = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf("bin")) + $"Html\\Articles\\{fileName}";
            //empty old js file
            FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite);
            fs.Close();
            // add new 
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path, true, System.Text.Encoding.Default);
            sw.Write(content);
            sw.Close();

            MessageBox.Show("Done");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string sql =  OrderSearch.search(str);
            Console.WriteLine(sql);
            MessageBox.Show(sql);
        }
        private void InitSetting()
        {
            string UseIDRowName;

            if (User_type.user_ID.Substring(0, 3) == "Cus")
            {
                UseIDRowName = "UseID_cus";
            }
            else
            {
                UseIDRowName = "UseID_sta";
            }

            string[] typeList = {"theme","autoTheme","rejectAllMs","rejectAllSy","rejectAllCus",
                                "allowSearch", "allowShowProfile","privateMode"};

            string allSQL = "";
            for (int i = 0; i < typeList.Length; i++)
            {
                string sql = $"SELECT Value FROM Settings WHERE {UseIDRowName} = '{User_type.user_ID}' " +
                    $"AND Type = '{typeList[i]}';";
                allSQL += sql;
            }

            string[] valueCacheList = { UserSettings.theme, UserSettings.autoTheme, UserSettings.rejectAllMs,
                                        UserSettings.rejectAllSy,UserSettings.rejectAllCus,UserSettings.allowSearch,
                                        UserSettings.allowShowProfile,UserSettings.privateMode};


            dynamic[] allData = SQLCursor.QueryMany(allSQL);
            for (int i = 0; i < allData.Length; i++)
            {
                if (allData[i][0] != "")
                {
                    valueCacheList[i] = allData[i][0];
                    //Console.WriteLine($"{typeList[i]}:{allData[i][0]}");
                }
            }

        }


        private void button9_Click(object sender, EventArgs e)
        {
            InitSetting();
        }
    }
}
