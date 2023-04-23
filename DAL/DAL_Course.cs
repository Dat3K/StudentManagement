using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Course
    {
        public static int AddCourse(DTO_Course Course)
        {
            string queryString = "INSERT INTO Courses (id, name, description, teacher_id, start_date, end_date) VALUES (@id, @name, @description, @teacher_id, @start_date, @end_date)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@id",Course.Id),
                new SqlParameter("@name",Course.Name),
                new SqlParameter("@description",Course.Description),
                new SqlParameter("@teacher_id",Course.Teacher_id),
                new SqlParameter("@start_date",Course.Start_date),
                new SqlParameter("@end_date",Course.End_date)
            };
            return Connection.ActionParamQuery(queryString, parameters);
        }

        public static void DelCourse(string id)
        {
            string queryString = "DELETE FROM Courses WHERE Id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            Connection.ActionParamQuery(queryString, parameters);
        }

        public static DataTable GetData()
        {
            string query = "select * from Courses";
            return Connection.SelectQuery(query);
        }

        public static int UpdateCourse(DTO_Course Course)
        {
            string queryString = "UPDATE Courses SET ID = @ID, Name = @Name, Description = @Description, Teacher_id = @Teacher_id, Start_date = @Start_date ,End_date = @End_date WHERE Id = @Id";
            SqlParameter[] parameters =
            {
                 new SqlParameter("@ID",Course.Id),
                new SqlParameter("@Name",Course.Name),
                new SqlParameter("@Description",Course.Description),
                new SqlParameter("@Teacher_id",Course.Teacher_id),
                new SqlParameter("@Start_date",Course.Start_date),
                new SqlParameter("@End_date",Course.End_date)
            };
            return Connection.ActionParamQuery(queryString, parameters);
        }

        public static DataTable GetCourseById(string id)
        {
            string queryString = "select * from Courses where Id = @Id;";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            return Connection.SelectParamQuery(queryString, parameters);
        }

        public static DataTable GetCourseByCourseId(string id)
        {
            string queryString = "select * from Courses where ID = @ID;";
            SqlParameter[] parameters = { new SqlParameter("@ID", id) };
            return Connection.SelectParamQuery(queryString, parameters);
        }
        public static string GetMaxId()
        {
            string queryString = "SELECT TOP 1 Id FROM Courses WHERE Id LIKE 'C%' ORDER BY CONVERT(INT, SUBSTRING(Id, 2, LEN(Id) - 1)) DESC";
            DataTable dt = Connection.SelectQuery(queryString);
            DataRow row = dt.Rows[0];
            string id = row.Field<string>("ID");
            return id;
        }
    }
}
