using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public static class BUS_User
    {
        public static DTO_User GetUserById(string id)
        {
            DataTable dt = DAL_User.GetUserById(id);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DTO_User user = new DTO_User
                    (
                        row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].Equals(true)
                    );
                    return user;
                }
            }
            return null;
        }

        public static DataTable GetAUserData(string id)
        {
            return DAL_User.GetUserById(id);
        }

        public static void DelUser(string id)
        {
            DAL_User.DelUser(id);
        }

        public static bool AddUser(DTO_User User)
        {
            return DAL_User.AddUser(User) > 0;
        }

        public static string GetMaxId()
        {
            return DAL_User.GetMaxId();
        }

        public static DataTable GetData()
        {
            return DAL_User.GetData();
        }

        public static bool UpdateUser(DTO_User User)
        {
            return DAL_User.UpdateUser(User) > 0;
        }

        public static DTO_User GetUserByUserId(string id)
        {
            DataTable dt = DAL_User.GetUserByUserId(id);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DTO_User user = new DTO_User
                    (
                        row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].Equals(true)
                    );
                    return user;
                }
            }
            return null;
        }
    }
}
