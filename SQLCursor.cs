﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniSys0._3
{
    public static class SQLCursor
    {
        // query
        public static dynamic[] Query(string SQL)
        {
            
            dynamic[] connTools = getDataReader(SQL);
            SqlDataReader dr = connTools[1];
            SqlConnection conn = connTools[0];

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
            string[] resultSingle = new string[colsNum];
            while (dr.Read())
            {
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
                    resultSingle[i] = dr[i].ToString();
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

            string connStr = Setting.DBString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
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
            string connStr = Setting.DBString;
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
            string connStr = Setting.DBString;

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

            int newValue = int.Parse(lastOneID.Substring(3, 6)) + 1;
            string newID = rowIDName.Substring(0,3) + newValue.ToString().PadLeft(6, '0');
            return newID;
        }
        public static dynamic getDataReader(string sql)
        {
            string DBString = Setting.DBString;

            SqlConnection conn = new SqlConnection(DBString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dynamic[] connTools = { conn, dr };
            return connTools;
        }
    }
}
