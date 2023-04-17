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
        public static void AddStudent(DTO_Student student)
        {
            DAL_Student.AddStudent(student);
        }

        public static DataTable GetData()
        {
            return DAL_Student.GetData();
        }
    }
}
