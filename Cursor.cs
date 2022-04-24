using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniSys0._3
{
    public static class Cursor
    {
        public static string[] Execute(string SQL)
        {
            dynamic[] connTools = getDataReader(SQL);


        }

        public static dynamic ExecuteMany(string SQL)
        {

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
