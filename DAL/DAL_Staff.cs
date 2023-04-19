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
    public static class DAL_Staff
    {

        public static int AddStaff(DTO_Staff staff)
        {
            string queryString = "INSERT INTO Staffs (ID, FullName, DateOfBirth, Gender, Job, Address, PhoneNumber, Email, EducationLevel, Major, WorkExperience, Language) VALUES (@ID,@FullName, @DateOfBirth, @Gender,@Job, @Address, @PhoneNumber, @Email, @EducationLevel, @Major, @WorkExperience, @Language)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID",staff.Id),
                new SqlParameter("@FullName", staff.FullName),
                new SqlParameter("@DateOfBirth", staff.DateOfBirth),
                new SqlParameter("@Gender", staff.Gender),
                new SqlParameter("@Job", staff.Job),
                new SqlParameter("@Address", staff.Address),
                new SqlParameter("@PhoneNumber",staff.PhoneNumber),
                new SqlParameter("@Email",staff.Email),
                new SqlParameter("@EducationLevel",staff.Qualification),
                new SqlParameter("@Major",staff.Major),
                new SqlParameter("@WorkExperience",staff.WorkExperience),
                new SqlParameter("@Language",staff.Language)
            };
            return Connection.ActionParamQuery(queryString, parameters);
        }

        public static void DelStaff(string id)
        {
            string queryString = "DELETE FROM Staffs WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            Connection.ActionParamQuery(queryString, parameters);
        }

        public static string GetMaxId()
        {
            string queryString = "SELECT TOP 1 Id FROM Staffs WHERE Id LIKE 'S%' ORDER BY CONVERT(INT, SUBSTRING(Id, 3, LEN(Id) - 1)) DESC";
            DataTable dt = Connection.GetMaxIdRow(queryString);
            DataRow row = dt.Rows[0];
            string id = row.Field<string>("ID");
            return id;
        }
        public static DataTable GetData()
        {
            string query = "select * from Staffs";
            return Connection.SelectQuery(query);
        }

        public static DataTable GetStaffById(string id)
        {
            string queryString = "select * from Staffs where Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            return Connection.SelectParamQuery(queryString, parameters);
        }

        public static int UpdateStaff(DTO_Staff staff)
        {
            string queryString = "UPDATE Staffs SET FullName = @FullName, DateOfBirth = @DateOfBirth, Gender = @Gender,Job = @Job, Address = @Address, PhoneNumber = @PhoneNumber, Email = @Email, EducationLevel = @EducationLevel, Major = @Major, WorkExperience = @WorkExperience, Language = @Language WHERE Id = @Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID",staff.Id),
                new SqlParameter("@FullName", staff.FullName),
                new SqlParameter("@DateOfBirth", staff.DateOfBirth),
                new SqlParameter("@Gender", staff.Gender),
                new SqlParameter("@Job", staff.Job),
                new SqlParameter("@Address", staff.Address),
                new SqlParameter("@PhoneNumber",staff.PhoneNumber),
                new SqlParameter("@Email",staff.Email),
                new SqlParameter("@EducationLevel",staff.Qualification),
                new SqlParameter("@Major",staff.Major),
                new SqlParameter("@WorkExperience",staff.WorkExperience),
                new SqlParameter("@Language",staff.Language)
            };
            return Connection.ActionParamQuery(queryString, parameters);
        }
    }
}
