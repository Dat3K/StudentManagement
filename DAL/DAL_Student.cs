using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Student
    {
        private DTO_Student Student;
        public DAL_Student(string fullName, DateTime? dOB, string gen, string address, string phone, string email, string eduLv, string major, string workExp, string lang)
        {
            Student = new DTO_Student(fullName, dOB, gen, address, phone, email, eduLv, major, workExp, lang);
        }

        public DataTable GetData()
        {
            string query = "select * from Student";
            return Connection.SelectQuery(query);
        }
    }
}
