using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    internal class Student_Manager
    {
        public static bool CheckUserExistence(string name, string password)
        {
            string sqlQuery = "declare @answer varchar (255)\r\n\r\nIF exists (SELECT * FROM Student where Name = @name and Password = @password)\r\n\tbegin\r\n\t\tselect @answer = 'true';\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tselect @answer = 'User does not exist, create a new user';\r\n\tend\r\n\tselect @answer";
            string[] parameters = {"@name", "@password"};
            string[] values = { name, password };
            string result = DBConnection.runSQLSingleResult(sqlQuery, parameters, values);

            if (result == "true")
            {
                return true;
            }
            else
            {
                MessageBox.Show(result);
                return false;
            }
        }

        public static List<string> GetCourses()
        {
            string sqlQuery = "select Name from course";
            List<string> Courses = new List<string>();
            SqlDataReader reader = DBConnection.runSQLAllResult(sqlQuery);

            for (int i = 0; reader.Read(); i++)
            {
                Courses.Add(reader.GetString(0));
            }
            reader.Close();
            return Courses;
        }

        public static List<string> GetCourseByString(string filter)
        {
            string sqlQuery = "select Name from course where Name like '%'+@filter+'%';\r\n";
            string[] parameters = { "@filter" };
            string[] values = { filter };
            List<string> Courses = new List<string>();
            SqlDataReader reader = DBConnection.runSQLAllResult(sqlQuery, parameters, values);

            for (int i = 0; reader.Read(); i++)
            {
                Courses.Add(reader.GetString(0));
            }
            reader.Close();
            return Courses;
        }

        public static DataTable GetSelectedCourses(string student)
        {
            string sqlQuery = "select Course.name as Name, Course.Price as Price, Course.StartDate as StartDate\r\nfrom College\r\njoin Course on Course.id = College.CourseId\r\njoin Student on Student.id = College.StudentId\r\nWHERE Student.Name = @student";
            string[] parameters = { "@student" };
            string[] values = { student };
            return DBConnection.runSQLTableResult(sqlQuery, parameters, values);
        }

        public static void AddCourseToStudent(string student, string course)
        {
            string sqlQuery = "INSERT INTO College (StudentId, CourseId)\r\nSELECT Student.id, Course.id\r\nFROM Student, Course\r\nWHERE Student.Name = @student AND Course.Name = @course";
            string[] parameters = { "@student", "@course" };
            string[] values = { student, course };
            DBConnection.runSQLNoAnswer(sqlQuery, parameters, values);
        }

        public static DataTable GetCourseDetails(string courseName)
        {
            string sqlQuery = "SELECT Price, StartDate, Day, Hour FROM Course WHERE Name = @courseName";
            string[] parameters = { "@courseName" };
            string[] values = { courseName };
            return DBConnection.runSQLTableResult(sqlQuery, parameters, values);
        }

        public static List<string> GetSubjectsByCourse(string coursenam)
        {
            string sqlQuery = "SELECT Student.Name \r\nFROM Subject Student\r\nJOIN Course c ON Student.CourseId = CourseId\r\nWHERE c.Name = @courseNam";
            string[] parameters = { "@courseNam" };
            string[] values = { coursenam };
            List<string> subjects = new List<string>();
            SqlDataReader reader = DBConnection.runSQLAllResult(sqlQuery, parameters, values);

            while (reader.Read())
            {
                subjects.Add(reader.GetString(0));
            }
            reader.Close();
            return subjects;
        }
    }
}
