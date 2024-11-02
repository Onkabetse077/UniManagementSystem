using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UniManagementSystem
{
    internal class StudentsData
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Project\Visual Studio\C#\UniManagementSystem\Resources\Database\Uni.mdf"";Integrated Security=True;Connect Timeout=30");
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public string StudentAddress { get; set; }
        public string Grade{ get; set; }
        public string Section { get; set; }
        public string StudentImage { get; set; }
        public string Status{ get; set; }

        public List<StudentsData> studentData()
        {
            List<StudentsData> studentsList = new List<StudentsData>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {

                    connection.Open();

                    string selectData = "SELECT * FROM teachers WHERE date_deleted IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            StudentsData studentsData = new StudentsData();

                            studentsData.ID = (int)reader["id"];
                            studentsData.StudentID = reader["student_id"].ToString();
                            studentsData.StudentName = reader["student_name"].ToString();
                            studentsData.StudentGender = reader["student_gender"].ToString();
                            studentsData.StudentAddress = reader["student_address"].ToString();
                            studentsData.Grade = reader["student_grade"].ToString();
                            studentsData.Section = reader["student_section"].ToString();
                            studentsData.StudentImage = reader["student_image"].ToString();
                            studentsData.Status = reader["student_status"].ToString();

                            studentsList.Add(studentsData);

                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);

                }
                finally
                {
                    connection.Close();
                }
            }
            return studentsList;
        }
    }
}
