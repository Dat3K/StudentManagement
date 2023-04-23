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
            string queryString = "INSERT INTO Staffs (ID, Name, DOB, Gender, Job, Address, Phone, Email, Qualification, Major, Experience, Language) VALUES (@ID,@Name, @DOB, @Gender,@Job, @Address, @Phone, @Email, @Qualification, @Major, @Experience, @Language)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID",staff.Id),
                new SqlParameter("@Name", staff.Name),
                new SqlParameter("@DOB", staff.DOB),
                new SqlParameter("@Gender", staff.Gender),
                new SqlParameter("@Job", staff.Job),
                new SqlParameter("@Address", staff.Address),
                new SqlParameter("@Phone",staff.Phone),
                new SqlParameter("@Email",staff.Email),
                new SqlParameter("@Qualification",staff.Qualification),
                new SqlParameter("@Major",staff.Major),
                new SqlParameter("@Experience",staff.Experience),
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
            DataTable dt = Connection.SelectQuery(queryString);
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
            string queryString = "UPDATE Staffs SET Name = @Name, DOB = @DOB, Gender = @Gender,Job = @Job, Address = @Address, Phone = @Phone, Email = @Email, Qualification = @Qualification, Major = @Major, Experience = @Experience, Language = @Language WHERE Id = @Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID",staff.Id),
                new SqlParameter("@Name", staff.Name),
                new SqlParameter("@DOB", staff.DOB),
                new SqlParameter("@Gender", staff.Gender),
                new SqlParameter("@Job", staff.Job),
                new SqlParameter("@Address", staff.Address),
                new SqlParameter("@Phone",staff.Phone),
                new SqlParameter("@Email",staff.Email),
                new SqlParameter("@Qualification",staff.Qualification),
                new SqlParameter("@Major",staff.Major),
                new SqlParameter("@Experience",staff.Experience),
                new SqlParameter("@Language",staff.Language)
            };
            return Connection.ActionParamQuery(queryString, parameters);
        }
    }
}
