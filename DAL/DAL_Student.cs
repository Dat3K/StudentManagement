using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public static class DAL_Student
    {
        private static DTO_Student Student;
        //public DAL_Student(string fullName, DateTime? dOB, string gen, string address, string phone, string email, string eduLv, string major, string workExp, string lang)
        //{
        //    Student = new DTO_Student(fullName, dOB, gen, address, phone, email, eduLv, major, workExp, lang);
        //}

        public static void AddStudent(DTO_Student student)
        {
            string queryString = "INSERT INTO Students (FullName, DOB, Gen, Address, Phone, Email, EduLv, Major, WorkExp, Lang) VALUES (@FullName, @DOB, @Gen, @Address, @Phone, @Email, @EduLv, @Major, @WorkExp, @Lang)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@FullName", student.FullName),
                new SqlParameter("@DOB", student.DateOfBirth),
                new SqlParameter("@Gen", student.Gender),
                new SqlParameter("@Address", student.Address),
                new SqlParameter("@Phone",student.PhoneNumber),
                new SqlParameter("@Email",student.Email),
                new SqlParameter("@Edulv",student.EducationLevel),
                new SqlParameter("@Major",student.Major),
                new SqlParameter("@WorkExp",student.WorkExperience),
                new SqlParameter("@Lang",student.Language)
            };
            Connection.AcctionParamQuery(queryString, parameters);
        }
        public static DataTable GetData()
        {
            string query = "select * from Students";
            return Connection.SelectQuery(query);
        }
    }
}
