using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security.Cryptography;
using System.Collections;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection conn = GetConnection();
        private static string GetConnectionString()
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

            return builder.ConnectionString;
        }
        // Hàm kết nối đến cơ sở dữ liệu
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            return connection;
        }

        // Hàm ngắt kết nối đến cơ sở dữ liệu
        public static void CloseConnection()
        {
            conn.Close();
        }

        public static DataTable GetMaxIdRow(string queryString)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        public static int ActionParamQuery(string queryString, SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(queryString, conn))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                return command.ExecuteNonQuery();
            }
        }

        public static DataTable SelectQuery(string sql)
        {
            SqlDataAdapter dta = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            return dt;
        }

        public static DataTable SelectParamQuery(string queryString, SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(queryString, conn))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
