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
    public static class BUS_Student
    {
        public static DTO_Student GetStudentById(string id)
        {
            DataTable dt = DAL_Student.GetStudentById(id);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DTO_Student student = new DTO_Student
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
                        row[10].ToString()
                    );
                    return student;
                }
            }
            return null;
        }

        public static void DelStudent(string id)
        {
            DAL_Student.DelStudent(id);
        }

        public static bool AddStudent(DTO_Student student)
        {
            return DAL_Student.AddStudent(student) > 0;
        }

        public static string GetMaxId()
        {
            return DAL_Student.GetMaxId();
        }

        public static DataTable GetData()
        {
            return DAL_Student.GetData();
        }

        public static bool UpdateStudent(DTO_Student student)
        {
            if(DAL_Student.UpdateStudent(student) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
