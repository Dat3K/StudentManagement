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
    public static class BUS_Course
    {
        public static DTO_Course GetCourseById(string id)
        {
            DataTable dt = DAL_Course.GetCourseById(id);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DTO_Course Course = new DTO_Course
                    (
                        row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString(),
                        row[5].ToString()
                    );
                    return Course;
                }
            }
            return null;
        }

        public static DataTable GetACourseData(string id)
        {
            return DAL_Course.GetCourseById(id);
        }

        public static void DelCourse(string id)
        {
            DAL_Course.DelCourse(id);
        }

        public static bool AddCourse(DTO_Course Course)
        {
            return DAL_Course.AddCourse(Course) > 0;
        }

        public static string GetMaxId()
        {
            return DAL_Course.GetMaxId();
        }

        public static DataTable GetData()
        {
            return DAL_Course.GetData();
        }

        public static bool UpdateCourse(DTO_Course Course)
        {
            return DAL_Course.UpdateCourse(Course) > 0;
        }
    }
}
