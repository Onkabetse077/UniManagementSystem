using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace UniManagementSystem
{
    public partial class AddTeachersForm : UserControl
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Project\Visual Studio\C#\UniManagementSystem\Resources\Database\Uni.mdf"";Integrated Security=True;Connect Timeout=30");
        public AddTeachersForm()
        {
            InitializeComponent();
        }

        public void teacherDisplayData()
        {
            TeachersData teacherData = new TeachersData();
            List<TeachersData> teachersList = teacherData.teacherData();
            dgvTeacherData_AddTeachers.DataSource = teachersList;
        }

        private void btnAdd_AddTeachers_Click(object sender, EventArgs e)
        {
            if (tbTeacherID_AddTeachers.Text == ""|| tbFullName_AddTeachers.Text == ""||cbGender_AddTeachers.Text == ""||
                tbAddress_AddTeachers.Text == "" || cbStatus_AddTeachers.Text == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();

                        string checkTeachersID = "SELECT COUNT(*) FROM teachers WHERE employee_id = @teacher_id AND date_deleted IS NULL";

                        using (SqlCommand checkTeachersIDs = new SqlCommand(checkTeachersID,connection))
                        {
                            checkTeachersIDs.Parameters.AddWithValue("@teacher_id",
                                tbTeacherID_AddTeachers.Text.Trim()); 
                            int count = (int)checkTeachersIDs.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(tbTeacherID_AddTeachers.Text.Trim() + " Teacher ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Teachers(teacher_id,teacher_name,teacher_gender,teacher_address,teacher_image,teacher_status,date_inserterd) " +
                                                    "VALUES(@teacher_id,@teacher_name,@teacher_gender,@teacher_address,@teacher_image,@teacher_status,@date_inserterd)";
                                string path = Path.Combine(@"C:\Users\gosia\Documents\Project\Visual Studio\C#\UniManagementSystem\Resources\Pictures\"
                                                           + tbTeacherID_AddTeachers.Text.Trim() + ".jpg");

                                string picturePath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(picturePath))
                                {
                                    Directory.CreateDirectory(picturePath);
                                }

                                File.Copy(pbStudentImg_AddTeachers.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@teacher_id", tbTeacherID_AddTeachers.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_name", tbFullName_AddTeachers.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_gender", cbGender_AddTeachers.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_address", tbAddress_AddTeachers.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_image", path);
                                    cmd.Parameters.AddWithValue("@teacher_status", cbStatus_AddTeachers.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date_inserterd", DateTime.Today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Teacher added successfully", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error: " + exception.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
