using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UniManagementSystem
{
    internal class TeachersData
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Project\Visual Studio\C#\UniManagementSystem\Resources\Database\Uni.mdf"";Integrated Security=True;Connect Timeout=30");
        public int ID { get; set; }
        public string TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherGender { get; set; }
        public string TeacherAddress { get; set; }
        public string TeacherImage { get; set; }
        public string Status { get; set; }

        public List<TeachersData> teacherData()
        {
            List<TeachersData> teachersList = new List<TeachersData>();

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
                            TeachersData teachersData = new TeachersData();

                            teachersData.ID = (int)reader["id"];
                            teachersData.TeacherID = reader["teacher_id"].ToString();
                            teachersData.TeacherName = reader["teacher_name"].ToString();
                            teachersData.TeacherGender = reader["teacher_gender"].ToString();
                            teachersData.TeacherAddress = reader["teacher_address"].ToString();
                            teachersData.TeacherImage = reader["teacher_image"].ToString();
                            teachersData.Status = reader["teacher_status"].ToString();
                            
                            teachersList.Add(teachersData);

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
            return teachersList;
        }
    }
}
