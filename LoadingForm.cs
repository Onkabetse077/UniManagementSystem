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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void timer_Loading_Tick(object sender, EventArgs e)
        {
            pnlLoadingBar.Width += 5;

            if (pnlLoadingBar.Width >= 800)
            {
                timer_Loading.Stop();

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

    }
}
