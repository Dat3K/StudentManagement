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
    public static class BUS_Staff
    {
        public static DTO_Staff GetStaffById(string id)
        {
            DataTable dt = DAL_Staff.GetStaffById(id);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DTO_Staff staff = new DTO_Staff
                    (
                        row[0].ToString(),
                        row[1].ToString(),
                        Convert.ToDateTime(row[2]),
                        row[3].ToString(),
                        row[4].ToString(),
                        row[5].ToString(),
                        row[6].ToString(),
                        row[7].ToString(),
                        row[8].ToString(),
                        row[9].ToString(),
                        row[10].ToString(),
                        row[11].ToString()
                    );
                    return staff;
                }
            }
            return null;
        }

        public static int GetStaffCount()
        {
            return DAL_Staff.GetData().Rows.Count;
        }

        public static DataTable GetAStaffData(string id)
        {
            return DAL_Staff.GetStaffById(id);
        }

        public static void DelStaff(string id)
        {
            DAL_Staff.DelStaff(id);
        }

        public static bool AddStaff(DTO_Staff staff)
        {
            return DAL_Staff.AddStaff(staff) > 0;
        }

        public static string GetMaxId()
        {
            return DAL_Staff.GetMaxId();
        }

        public static DataTable GetData()
        {
            return DAL_Staff.GetData();
        }

        public static bool UpdateStaff(DTO_Staff staff)
        {
            return DAL_Staff.UpdateStaff(staff) > 0;
        }

        
    }
}
