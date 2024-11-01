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
    public partial class AddStudentsForm : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Project\Visual Studio\C#\UniManagementSystem\Resources\Database\Uni.mdf"";Integrated Security=True;Connect Timeout=30");
        public AddStudentsForm()
        {
            InitializeComponent();
        }

        private void btnAdd_AddStudents_Click(object sender, EventArgs e)
        {

        }
    }
}
