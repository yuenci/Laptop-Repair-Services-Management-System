using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace miniSys0._3
{
    public static class SQLCursor
    {
        // query
        public static dynamic[] Query(string SQL)
        {
            //Console.WriteLine(SQL);
            dynamic[] connTools = getDataReader(SQL);
            SqlDataReader dr = null;
            SqlConnection conn = null;
            try
            {
                dr = connTools[1];
                conn = connTools[0];
            }
            catch
            {
                string[] resultEmpty = new String[0];
                return resultEmpty;
            }
            

            //if has result
            if (dr.HasRows.ToString() == "false")
            {
                string[] resultEmpty = new String[0];
                // return point 1:string[]
                return resultEmpty;
            }

            //if there was result,how many cols in the result
            int colsNum = int.Parse(dr.FieldCount.ToString());
            List<dynamic> result = new List<dynamic>();
            
            while (dr.Read())
            {
                string[] resultSingle = new string[colsNum];
                for (int i = 0; i < colsNum; i++)
                {
                    resultSingle[i] = dr[i].ToString();
                }
                result.Add(resultSingle);
                
            }
            dr.Close();
            conn.Close();

            if (result.Count == 1)
            {
                //return point2 string[]
                return result[0];
            }
            else
            {
                //return point2 string[[]]
                return result.ToArray();
            }

            


        }

        public static dynamic QueryMany(string SQL)
        {
            dynamic[] connTools = getDataReader(SQL);
            SqlDataReader dr = connTools[1];
            SqlConnection conn = connTools[0];

            List<dynamic> result = new List<dynamic>();
            
            do
            {
                int colsNum = int.Parse(dr.FieldCount.ToString());
                string[] resultSingle = new string[colsNum];
                dr.Read();
                for (int i = 0; i < colsNum; i++)
                {
                    try
                    {
                        resultSingle[i] = dr[i].ToString();
                    }
                    catch
                    {
                        resultSingle[i] = "";
                    }
                    
                }
                result.Add(resultSingle);
            }
            while (dr.NextResult()); //next method

            dr.Close();
            conn.Close();

            if (result.Count == 1)
            {
                return result[0];
            }
            else
            {
                return result.ToArray();
            }

            
        }

        //execute
        public static void Execute(string sql)
        {

            string connStr = AppSetting.DBString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(sql);
                MessageBox.Show("SQL:" + sql + ex.Message);
            }
            
            conn.Close();
        }
       

        public static void ExecuteMany(string sql,dynamic list)
        {
            // how to use 
            /*
             string sql = "select      %para%  , %para%,%para%  from   table1  where name = %para%";
             string[[]] list = {{ "a", "b", "c", "d", "tabbbb"},
                                {"a1", "b1", "c1", "d1", "tabbbb1"},
                                {"a2", "b2", "c2", "d2", "tabbbb2" }}

             */
            // if sql write like  [ "select      %para%  , %para%,%para%  from   table1  where name = %para%";]
            // will cause eror, because before and after comma must have space.
            string connStr = AppSetting.DBString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            List<dynamic> parament = new List<dynamic>();
            var array = sql.Split(new char[] { ' ', ',' });

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != String.Empty)
                {
                    parament.Add(array[i]);
                }
            }
            string[] composeSQL = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                string[] args = list[i];
                string sqlAddUp = "";
                int num = 0;
                for (int ii = 0; ii < parament.Count; ii++)
                {
                    if (parament[ii] != "%para%")
                    {
                        sqlAddUp += parament[ii] + " ";
                    }
                    else
                    {
                        sqlAddUp += "," + args[num] + " ";
                        num++;
                    }
                }
                sqlAddUp += ";";
                sqlAddUp = sqlAddUp.Replace($",{args[num - 1]} ;", $"{args[num - 1]};");
                composeSQL[i] = sqlAddUp;
            }

            foreach (var item in composeSQL)
            {
                Console.WriteLine(item);
            }

            conn.Close();    
            
        }
        

        public static void AddOne(string rowIDName, string IDvalue, string colname, string tableName )
        {
            //args = {rowIDName,IDvalue,colname, tableName}
            string atrID = ArticlesInfo.currentArticlelD;
            string connStr = AppSetting.DBString;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string targetValue = Query($"select {colname} from {tableName} where {rowIDName} = '{IDvalue}';")[0];
            //select Name from Customer where CustomerID = 'Cus000000';

            string sql = "";

            int oldValue;
            if (int.TryParse(targetValue,out oldValue))
            {
                sql = $"update {tableName} set  {colname} = {oldValue + 1} where {rowIDName}='{IDvalue}';";
                //sql = $"update Articles set Views=Views+1 where ArticlelD='{atrID}';";
                Execute(sql);
            }
            else
            {
                Console.WriteLine("Wrong happed in the SQLCursor in line 187");
            }

            
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public static string AddOneToLastID(string rowIDName ,string tableName)
        {
            string lastOneID = Query($"SELECT TOP 1 {rowIDName} FROM {tableName} ORDER BY  {rowIDName} DESC;")[0];
            //sql = "SELECT TOP 1 ArticlelD FROM Articles ORDER BY  ArticlelD DESC;"
            int newValue;
            string newID;
            if (tableName == "Orders" || tableName == "Schedule")
            {
                newValue = int.Parse(lastOneID.Substring(3, 8)) + 1;
                newID = rowIDName.Substring(0, 3) + newValue.ToString().PadLeft(8, '0');
                return newID;
            }

            newValue = int.Parse(lastOneID.Substring(3, 6)) + 1;
            newID = rowIDName.Substring(0, 3) + newValue.ToString().PadLeft(6, '0');
            return newID;
        }
       

        public static dynamic getDataReader(string sql)
        {
            string DBString = AppSetting.DBString;

            SqlConnection conn = new SqlConnection(DBString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dynamic[] connTools = { conn, dr };
                return connTools;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred in database.{ex}");
                return null;
            }
            
        }


        public static string getName(string useID)
        {
            if (useID =="")
            {
                return null;
            }
            string first = useID.Substring(0, 3).ToLower();
            if (first == "cus")
            {
                dynamic res =  Query($"SELECT Name FROM  Customer WHERE CustomerID = '{useID}';");
                if (res.Length == 1)
                {
                    return res[0];
                }
                else
                {
                    return null;
                }
            }
            else if(first == "sta")
            {
                dynamic res =  Query($"SELECT Name FROM  Staff WHERE StaffID = '{useID}';");
                if (res.Length ==1)
                {
                    return res[0];
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public static string getGender(string useID)
        {
            string first = useID.Substring(0, 3).ToLower();
            if (first == "cus")
            {
                dynamic res = Query($"SELECT Gender FROM  Customer WHERE CustomerID = '{useID}';");
                if (res.Length == 1)
                {
                    return res[0];
                }
                else
                {
                    return null;
                }
            }
            else if (first == "sta")
            {
                dynamic res = Query($"SELECT Gender FROM  Staff WHERE StaffID = '{useID}';");
                if (res.Length == 1)
                {
                    return res[0];
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public static string ifStaOrCus(string userName)
        {
            dynamic[] staffInfo  = Query($"SELECT StaffID FROM　Staff　WHERE Name = '{userName}';");
            if (staffInfo.Length > 0)
            {
                return staffInfo[0];
            }

            dynamic[] customerInfo = Query($"SELECT CustomerID FROM　Customer　WHERE Name = '{userName}';");
            if (customerInfo.Length > 0)
            {
                return customerInfo[0];
            }

            return null;


        }

        public static bool PasswordVerification(string nameOrID, string password)
        {
            //must exist then use this function
            if (nameOrID.Length == 9 && 
                (nameOrID.Substring(0,3) =="Cus" || nameOrID.Substring(0, 3) == "Sta"))
            {
                nameOrID = nameOrID;
            }
            else
            {
                nameOrID = ifStaOrCus(nameOrID);
            }

            if (nameOrID.Contains("Cus"))
            {
                string sql = $"SELECT Password FROM Customer WHERE CustomerID = '{nameOrID}';";
                if (password == Query(sql)[0])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (nameOrID.Contains("Sta"))
            {
                string sql = $"SELECT Password FROM Staff WHERE StaffID = '{nameOrID}';";
                if (password == Query(sql)[0])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    
        public static bool IfthereAnyOrder()
        {
            string sql = $"SELECT OrderID FROM Orders WHERE CustomerID = '{User_type.user_ID}';";     
            dynamic[] data= Query(sql);
            if (data.Length>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ifCurrentOrderNotStart()
        {
            string sql = "Select Status from Schedule Where OrderID " +
                $"= (Select top 1 OrderID from Orders Where CustomerID = '{User_type.user_ID}' " +
                $"ORDER BY OrderID DESC);";
            Console.WriteLine(sql);
            dynamic[] data= Query(sql);
            if (data.Length == 1)
            {
                return true;
            }
            else if(data.Length > 1)
            {
                return false;
            }
            else
            {
                MessageBox.Show("SQLCursor Line425 ifCurrentOrderNotStart() Error");
            }
            return false;
        }

        public static bool ifCurrentOrderNotStart(string orderID)
        {
            string sql = $"Select Status from Schedule Where OrderID = '{orderID}'";
            Console.WriteLine(sql);
            dynamic[] data = Query(sql);
            if (data.Length ==1 )
            {
                return true;
            }
            else if (data.Length > 1)
            {
                return false;
            }
            else
            {
                MessageBox.Show("SQLCursor Line460 ifCurrentOrderNotStart() Error");
            }
            return false;
        }
    }
}
