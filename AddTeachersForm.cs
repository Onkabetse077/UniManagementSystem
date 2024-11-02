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
            displayTeachersData();
        }

        private int getID = 0;
        public void displayTeachersData()
        {
            TeachersData teacherData = new TeachersData();
            List<TeachersData> teachersList = teacherData.teacherData();
            dgvTeacherData_AddTeachers.DataSource = teachersList;
        }

        public void clearFields()
        {
            tbTeacherID_AddTeachers.Text = "";
            tbFullName_AddTeachers.Text = "";
            cbGender_AddTeachers.SelectedIndex = -1;
            tbAddress_AddTeachers.Text = "";
            cbStatus_AddTeachers.SelectedIndex = -1;
            pbTeacherImg_AddTeachers.Image = null;
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

                        string checkTeachersID = "SELECT COUNT(*) FROM teachers WHERE teacher_id = @teacher_id AND date_deleted IS NULL";

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

                                File.Copy(pbTeacherImg_AddTeachers.ImageLocation, path, true);

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

                                    displayTeachersData();

                                    MessageBox.Show("Teacher added successfully", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
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

        private void btnUpdate_AddTeachers_Click(object sender, EventArgs e)
        {
            if (tbTeacherID_AddTeachers.Text == "" || tbFullName_AddTeachers.Text == "" || cbGender_AddTeachers.Text == "" ||
                tbAddress_AddTeachers.Text == "" || cbStatus_AddTeachers.Text == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to update this Teacher?", "Teacher ID: " +
                    tbTeacherID_AddTeachers.Text.Trim(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();

                        string updateData = "UPDATE teacher SET teacher_id = @teacher_id,teacher_name = @teacher_name,teacher_gender = @teacher_gender," +
                            "teacher_address = @teacher_address,teacher_image = @teacher_image,teacher_status = @teacher_status,date_updated = @date_updated";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@teacher_id", tbTeacherID_AddTeachers.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacher_name", tbFullName_AddTeachers.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacher_gender", cbGender_AddTeachers.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacher_address", tbAddress_AddTeachers.Text.Trim());
                            cmd.Parameters.AddWithValue("@teacher_image", pbTeacherImg_AddTeachers.Location);
                            cmd.Parameters.AddWithValue("@teacher_status", cbStatus_AddTeachers.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_updated", DateTime.Today);

                            cmd.ExecuteNonQuery();

                            displayTeachersData();

                            MessageBox.Show("Teacher updated successfully", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception exception) 
                    {
                        MessageBox.Show("Error: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
        }

        private void btnClear_AddTeachers_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnDelete_AddTeachers_Click(object sender, EventArgs e)
        {
            if (tbTeacherID_AddTeachers.Text == "" || tbFullName_AddTeachers.Text == "" || cbGender_AddTeachers.Text == "" ||
                tbAddress_AddTeachers.Text == "" || cbStatus_AddTeachers.Text == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this Teacher?", "Teacher ID: " +
                    tbTeacherID_AddTeachers.Text.Trim(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();

                        string updateData = "UPDATE teachers SET date_deleted = @date_deleted WHERE teacher_id = @teacher_id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {

                            cmd.Parameters.AddWithValue("@date_deleted", DateTime.Today);
                            cmd.Parameters.AddWithValue("@teacher_id", tbTeacherID_AddTeachers.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayTeachersData();

                            MessageBox.Show("Employee removed successfully", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch(Exception exception) {
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Employee not removed", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnImport_AddTeachers_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbTeacherImg_AddTeachers.Image = Image.FromFile(dialog.FileName);
                    pbTeacherImg_AddTeachers.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTeacherData_AddTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {
                DataGridViewRow row = dgvTeacherData_AddTeachers.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                tbTeacherID_AddTeachers.Text = row.Cells[1].Value.ToString();
                tbFullName_AddTeachers.Text = row.Cells[2].Value.ToString();
                cbGender_AddTeachers.Text = row.Cells[3].Value.ToString();
                tbAddress_AddTeachers.Text = row.Cells[4].Value.ToString();
                pbTeacherImg_AddTeachers.ImageLocation = row.Cells[5].Value.ToString();
                cbStatus_AddTeachers.Text = row.Cells[6].Value.ToString();

                if (pbTeacherImg_AddTeachers.ImageLocation != null) {
                    pbTeacherImg_AddTeachers.Image = Image.FromFile(pbTeacherImg_AddTeachers.ImageLocation);
                }
                else
                {
                    pbTeacherImg_AddTeachers.Image = null;
                }
            }
        }
    }
}
