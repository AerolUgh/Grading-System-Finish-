using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem
{
    
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }

        private void pcbGrades_Click(object sender, EventArgs e)
        {
            Grades grade = new Grades();
            grade.Show();
            this.Hide();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            Grades grade = new Grades();
            grade.Show();
            this.Hide();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();

                login.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();

                login.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }
    }
}
