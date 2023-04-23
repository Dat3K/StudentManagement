using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_User
    {
        public static int AddUser(DTO_User User)
        {
            string queryString = "INSERT INTO Users (ID,user_id,password) VALUES (@ID,@user_id,@password)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID",User.Id),
                new SqlParameter("@user_id",User.UserId),
                new SqlParameter("@password",User.Password)
            };
            return Connection.ActionParamQuery(queryString, parameters);
        }

        public static void DelUser(string id)
        {
            string queryString = "DELETE FROM users WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            Connection.ActionParamQuery(queryString, parameters);
        }

        public static DataTable GetData()
        {
            string query = "select * from users";
            return Connection.SelectQuery(query);
        }

        public static int UpdateUser(DTO_User User)
        {
            string queryString = "UPDATE users SET user_id = @user_id, password = @password,  WHERE Id = @Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID",User.Id),
                new SqlParameter("@user_id",User.UserId),
                new SqlParameter("@password",User.Password),
                new SqlParameter("@locked",User.locked)
            };
            return Connection.ActionParamQuery(queryString, parameters);
        }

        public static DataTable GetUserById(string id)
        {
            string queryString = "select * from users where Id = @Id;";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            return Connection.SelectParamQuery(queryString, parameters);
        }

        public static DataTable GetUserByUserId(string id)
        {
            string queryString = "select * from users where user_id = @user_id;";
            SqlParameter[] parameters = { new SqlParameter("@user_id", id) };
            return Connection.SelectParamQuery(queryString, parameters);
        }
        public static string GetMaxId()
        {
            string queryString = "SELECT TOP 1 Id FROM users WHERE Id LIKE 'U%' ORDER BY CONVERT(INT, SUBSTRING(Id, 2, LEN(Id) - 1)) DESC";
            DataTable dt = Connection.SelectQuery(queryString);
            DataRow row = dt.Rows[0];
            string id = row.Field<string>("ID");
            return id;
        }
    }
}
