using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GradingSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            btnLogIn.Focus();
            string name = "allopita@gmail.com";
            string pass = "123456";
            string Changed = name.ToLower();

            if (txtEmail.Text.ToLower() == Changed || txtPassword.Text == pass)
            {
                if (txtPassword.Text == pass && txtEmail.Text.ToLower() == Changed)
                {
                    txtEmail.Clear();
                    txtPassword.Clear();
                    ProgressBarCorrect PBC = new ProgressBarCorrect();
                    PBC.Show();
                    this.Hide();
                }
                else if (txtPassword.Text == pass && txtEmail.Text.ToLower() != Changed)
                {
                    txtEmail.ForeColor = Color.Red;
                    txtEmail.Text = "Incorrect Email";
                }
                else
                {
                    txtPassword.ForeColor = Color.Red;
                    txtPassword.Text = "Incorrect Password";
                    if (txtPassword.Text == "Incorrect Password")
                    {
                        txtPassword.PasswordChar = '\0';
                    }
                }
            }
            else
            {
               
                if (txtEmail.Text == "Enter email here..." || txtPassword.Text == "Enter password here...")
                {
                    if (txtPassword.Text == "Enter password here..." && txtEmail.Text == "Enter email here...")
                    {
                        txtPassword.ForeColor = Color.Red;
                        txtPassword.Text = "Input Password";
                        txtEmail.ForeColor = Color.Red;
                        txtEmail.Text = "Input Email";
                    }
                    else if (txtPassword.Text == "Enter password here..." && txtEmail.Text != "Enter email here...")
                    {
                        txtEmail.ForeColor = Color.Red;
                        txtEmail.Text = "Input Email";
                    }
                    else
                    {
                        txtPassword.ForeColor = Color.Red;
                        txtPassword.Text = "Input Password";
                        if (txtPassword.Text == "Input Password")
                        {
                            txtPassword.PasswordChar = '\0';
                        }
                    }
                }
                else
                {
                    if (txtEmail.Text == "Input Email")
                    {
                        txtEmail.Text = "Input Email";
                        txtEmail.ForeColor = Color.Red;
                    }
                    else
                    {
                        txtEmail.ForeColor = Color.Red;
                        txtEmail.Text = "Incorrect Email";
                    }

                    if (txtPassword.Text == "Input Password")
                    {
                        txtPassword.Text = "Input Password";
                        txtPassword.ForeColor = Color.Red;
                    }
                    else
                    {
                        txtPassword.ForeColor = Color.Red;
                        txtPassword.Text = "Incorrect Password";
                    }
                    
                    if (txtPassword.Text == "Incorrect Password")
                    {
                        txtPassword.PasswordChar = '\0';
                    }
                }
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            //if the focus is in the txtEmail the placeholder remove
            if (txtEmail.Text == "Enter email here...")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
            if (txtEmail.Text == "Incorrect Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
            if (txtEmail.Text == "Input Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //if i move the focus to other control the placeholder show up
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Enter email here...";
                txtEmail.ForeColor = Color.DarkGray;
            }
            if (txtEmail.Text == "Incorrect Email")
            {
                txtEmail.ForeColor = Color.Red;
            }
            if (txtEmail.Text == "Input Email")
            {
                txtEmail.ForeColor = Color.Red;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //if the focus is in the txtPassword the placeholder remove
            if (txtPassword.Text == "Enter password here...")
            {
                txtPassword.Text = "";
                if (chkShowPassword.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '•';
                }
                txtPassword.ForeColor = Color.Black;
            }
            if (txtPassword.Text == "Incorrect Password")
            {
                txtPassword.Text = "";
                if (chkShowPassword.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '•';
                }
                txtPassword.ForeColor = Color.Black;
            }
            if (txtPassword.Text == "Input Password")
            {
                txtPassword.Text = "";
                if (chkShowPassword.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '•';
                }
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            //if i move the focus to other control the placeholder show up
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter password here...";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.DarkGray;
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowPassword.Checked)
            {
                if (chkShowPassword.Checked && txtEmail.Text != "Enter email here...")
                {
                    txtEmail.ForeColor = Color.Black;
                }
                else if (txtEmail.Text == "Incorrect Email")
                {
                    txtEmail.ForeColor = Color.Red;
                }
                else
                {
                    txtEmail.ForeColor = Color.DarkGray;
                }
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Black;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtPassword.ForeColor = Color.Black;
            }
            
            if (txtPassword.Text == "Enter password here...")
            {
                txtPassword.Text = "Enter password here...";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.DarkGray;
            }
            
            if (txtPassword.Text == "Incorrect Password" && txtEmail.Text == "Incorrect Email")
            {
                txtPassword.ForeColor = Color.Red;
                txtEmail.ForeColor = Color.Red;
                if (txtPassword.Text == "Incorrect Password")
                {
                    txtPassword.PasswordChar = '\0';
                }
            }
            if (txtPassword.Text == "Input Password" && txtEmail.Text == "Input Email")
            {
                txtPassword.ForeColor = Color.Red;
                txtEmail.ForeColor = Color.Red;
                if (txtPassword.Text == "Input Password")
                {
                    txtPassword.PasswordChar = '\0';
                }
            }
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Show();
            }
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            btnLogIn.Focus();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPassword.Text = "Enter password here...";
            txtPassword.PasswordChar = '\0';
            txtPassword.ForeColor = Color.DarkGray;
            txtEmail.Text = "Enter email here...";
            txtEmail.ForeColor = Color.DarkGray;
        }
    }
}