using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniManagementSystem
{
    public partial class SignupForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Project\Visual Studio\C#\UniManagementSystem\Resources\Database\Uni.mdf"";Integrated Security=True;Connect Timeout=30");
        public SignupForm()
        {
            InitializeComponent();
        }

        public bool checkConnectonStatus()
        {
            return (connection.State == ConnectionState.Closed) ? true : false;
        }

        private void cbShowPassword_Signup_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword_Signup.PasswordChar = (cbShowPassword_Signup.Checked) ? '\0' : '*';
            tbConfirmPassword_Signup.PasswordChar = (cbShowPassword_Signup.Checked) ? '\0' : '*';
        }

        private void lblLoginLink_Signup_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lblX_Signup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Signup_Click(object sender, EventArgs e)
        {
            if (tbUsername_Signup.Text == "" || tbPassword_Signup.Text == "" || tbConfirmPassword_Signup.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPassword_Signup.Text != tbConfirmPassword_Signup.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnectonStatus())
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT * FROM users WHERE username = @username";

                        using (SqlCommand checkUser = new SqlCommand(query, connection))
                        {
                            checkUser.Parameters.AddWithValue("@username", tbUsername_Signup.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                string tempUsername = tbUsername_Signup.Text.Substring(0, 1).ToUpper() + tbUsername_Signup.Text.Substring(1);
                                MessageBox.Show(tempUsername + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (tbConfirmPassword_Signup.Text.Length < 8)
                            {
                                MessageBox.Show("password is too short", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username ,password,date_created) VALUES (@username,@password,@date)";

                                using (SqlCommand insertUser = new SqlCommand(insertData, connection))
                                {
                                    insertUser.Parameters.AddWithValue("@username", tbUsername_Signup.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@password", tbPassword_Signup.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@date", DateTime.Today);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("User Registered Successfully", "Informaton Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm loginform = new LoginForm();

                                    loginform.Show();
                                    this.Hide();

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
