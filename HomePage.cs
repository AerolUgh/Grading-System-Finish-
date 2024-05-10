using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void btnGrades_Click(object sender, EventArgs e)
        {
            Grades grade = new Grades();

            grade.Show();
            this.Hide();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();

            aboutUs.Show();
            this.Hide();
        }

        private void pcbGrades_Click_1(object sender, EventArgs e)
        {
            Grades grade = new Grades();

            grade.Show();
            this.Hide();
        }

        private void pcbAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();

            aboutUs.Show();
            this.Hide();
        }

        private void lblLogOut_Click_1(object sender, EventArgs e)
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
