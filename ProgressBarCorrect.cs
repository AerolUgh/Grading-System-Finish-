using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GradingSystem
{
    public partial class ProgressBarCorrect : Form
    {
        public ProgressBarCorrect()
        {
            InitializeComponent();
            ProgressBar1.Value = 0;
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString() + "%";

            if (ProgressBar1.Value == 0)
            {
                lblLogging.Text = "Logging in";
            }
            if (ProgressBar1.Value == 25)
            {
                lblLogging.Text = "Logging in.";
            }
            if (ProgressBar1.Value == 50)
            {
                lblLogging.Text = "Logging in..";
            }
            if (ProgressBar1.Value == 75)
            {
                lblLogging.Text = "Logging in...";
            }
            if (ProgressBar1.Value == 90)
            {
                lblLogging.Text = "Logging in...";
                lblSL.Text = "Successfully Log in";
            }
            if (ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
        }
    }
}
