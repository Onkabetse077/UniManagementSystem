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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lblX_Main_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Main_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void btnDashboard_Main_Click(object sender, EventArgs e)
        {
            dashboardForm_Main.Visible = true;
            addStudentsForm_Main.Visible = false;
            addTeachersForm_Main.Visible = false;
        }

        private void btnAddTeacher_Main_Click(object sender, EventArgs e)
        {
            dashboardForm_Main.Visible = false;
            addStudentsForm_Main.Visible = false;
            addTeachersForm_Main.Visible = true;
        }

        private void btnAddStudent_Main_Click(object sender, EventArgs e)
        {
            dashboardForm_Main.Visible = false;
            addStudentsForm_Main.Visible = true;
            addTeachersForm_Main.Visible = false;
        }
    }
}
