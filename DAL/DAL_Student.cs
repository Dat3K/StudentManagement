using System;
using System.Collections;
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

        public static int AddStudent(DTO_Student student)
        {
            string queryString = "INSERT INTO Students (ID, FullName, DateOfBirth, Gender, Address, PhoneNumber, Email, EducationLevel, Major, WorkExperience, Language) VALUES (@ID,@FullName, @DateOfBirth, @Gender, @Address, @PhoneNumber, @Email, @EducationLevel, @Major, @WorkExperience, @Language)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID",student.Id),
                new SqlParameter("@FullName", student.FullName),
                new SqlParameter("@DateOfBirth", student.DateOfBirth),
                new SqlParameter("@Gender", student.Gender),
                new SqlParameter("@Address", student.Address),
                new SqlParameter("@PhoneNumber",student.PhoneNumber),
                new SqlParameter("@Email",student.Email),
                new SqlParameter("@EducationLevel",student.EducationLevel),
                new SqlParameter("@Major",student.Major),
                new SqlParameter("@WorkExperience",student.WorkExperience),
                new SqlParameter("@Language",student.Language)
            };
            return Connection.ActionParamQuery(queryString, parameters);
        }

        public static void DelStudent(string id)
        {
            string queryString = "DELETE FROM students WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            Connection.ActionParamQuery(queryString, parameters);
        }

        public static string GetMaxId()
        {
            string queryString = "SELECT TOP 1 Id FROM students WHERE Id LIKE 'S%' ORDER BY CONVERT(INT, SUBSTRING(Id, 2, LEN(Id) - 1)) DESC";
            DataTable dt = Connection.GetMaxIdRow(queryString);
            DataRow row = dt.Rows[0];
            string id = row.Field<string>("ID");
            return id;
        }
        public static DataTable GetData()
        {
            string query = "select * from Students";
            return Connection.SelectQuery(query);
        }

        public static DataTable GetStudentById(string id) {
            string queryString = "select * from Students where Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            return Connection.SelectParamQuery(queryString,parameters);
        }

        public static int UpdateStudent(DTO_Student student)
        {
            string queryString = "UPDATE Students SET FullName = @FullName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address, PhoneNumber = @PhoneNumber, Email = @Email, EducationLevel = @EducationLevel, Major = @Major, WorkExperience = @WorkExperience, Language = @Language WHERE Id = @Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID",student.Id),
                new SqlParameter("@FullName", student.FullName),
                new SqlParameter("@DateOfBirth", student.DateOfBirth),
                new SqlParameter("@Gender", student.Gender),
                new SqlParameter("@Address", student.Address),
                new SqlParameter("@PhoneNumber",student.PhoneNumber),
                new SqlParameter("@Email",student.Email),
                new SqlParameter("@EducationLevel",student.EducationLevel),
                new SqlParameter("@Major",student.Major),
                new SqlParameter("@WorkExperience",student.WorkExperience),
                new SqlParameter("@Language",student.Language)
            };
            return Connection.ActionParamQuery(queryString, parameters);
        }
    }
}
