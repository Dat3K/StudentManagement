using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Student
    {
        DAL_Student Student;

        public BUS_Student(string fullName, DateTime? dOB, string gen, string address, string phone, string email, string eduLv, string major, string workExp, string lang)
        {
            Student = new DAL_Student(fullName, dOB, gen, address, phone, email, eduLv, major, workExp, lang);
        }

        public DataTable GetData()
        {
            return Student.GetData();
        }
    }
}
