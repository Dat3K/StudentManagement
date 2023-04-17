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
        public static void DelStudent(string id)
        {
            DAL_Student.DelStudent(id);
        }
        public static int AddStudent(DTO_Student student)
        {
            return DAL_Student.AddStudent(student);
        }
        public static string GetMaxId()
        {
            return DAL_Student.GetMaxId();
        }
        public static DataTable GetData()
        {
            return DAL_Student.GetData();
        }
    }
}
