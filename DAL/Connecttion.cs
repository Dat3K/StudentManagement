using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DAL
{
    public class Connection
    {
        public static SqlConnection cn;

        public static void Connect()
        {
            SqlConnectionStringBuilder builder;
            string serverName = "THANHDAT";
            string dbName = "StudentManagement";
            string userID = "myDomain\\myUser";

            builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = serverName;
            builder["Integrated Security"] = true;
            builder["Initial Catalog"] = dbName;
            builder["User ID"] = userID;

            builder["Password"] = "";

            string connectionString = builder.ConnectionString;
            cn = new SqlConnection(connectionString);
            cn.Open();
        }


        public static void AcctionQuery(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
        }

        public static DataTable SelectQuery(string sql)
        {
            Connect();
            SqlDataAdapter dta = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            return dt;
        }

    }
}
