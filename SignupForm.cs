using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniManagementSystem
{
    public partial class SignupForm : Form
    {
        private string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Project\Visual Studio\C#\UniManagementSystem\Resources\Database\Uni.mdf"";Integrated Security=True;Connect Timeout=30";
        public SignupForm()
        {
            InitializeComponent();
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
    }
}
