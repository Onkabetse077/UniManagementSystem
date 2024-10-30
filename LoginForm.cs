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

namespace UniManagementSystem
{
    public partial class LoginForm : Form
    {
        private string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Project\Visual Studio\C#\UniManagementSystem\Resources\Database\Uni.mdf"";Integrated Security=True;Connect Timeout=30";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblX_Login_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbShowPassword_Login_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword_Login.PasswordChar = (cbShowPassword_Login.Checked) ? '\0' : '*'; ;
        }

        public static string Username;

        private void lblRegisterLink_Login_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void btnLogin_Login_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@username", tbUsername_Login.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", tbPassword_Login.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        Username = tbUsername_Login.Text;
                        MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        MainForm mainPage = new MainForm();
                        mainPage.Show(); 
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (tbUsername_Login.Text == "" || tbPassword_Login.Text == "")
            {
                MessageBox.Show("Please fill in all the details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
         }
    }

}

