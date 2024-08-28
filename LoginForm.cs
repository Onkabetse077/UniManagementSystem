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
    public partial class LoginForm : Form
    {
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

        private void lblRegisterLink_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
