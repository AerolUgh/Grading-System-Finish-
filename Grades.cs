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
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void pcbHome_Click(object sender, EventArgs e)
        {
            HomePage HP = new HomePage();
            HP.Show();
            this.Hide();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
            this.Hide();
        }

        private void pcbAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            lstRecords.Items.Clear();
            txtAttendance.Clear();
            txtCourse.Clear();
            txtID.Clear();
            txtLab.Clear();
            txtLab2.Clear();
            txtLab3.Clear();
            txtName.Clear();
            txtPE.Clear();
            txtProject.Clear();
            txtQuiz.Clear();
            txtQuiz2.Clear();
            txtQuiz3.Clear();
            txtSeatwork.Clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
            double PQuiz = Convert.ToDouble(txtQuiz.Text);
            double PLab = Convert.ToDouble(txtLab.Text);
            double PSeatwork = Convert.ToDouble(txtSeatwork.Text);
            double PAttendance = Convert.ToDouble(txtAttendance.Text);
            double MQuiz = Convert.ToDouble(txtQuiz2.Text);
            double MLab = Convert.ToDouble(txtLab2.Text);
            double MPE = Convert.ToDouble(txtPE.Text);
            double FQuiz = Convert.ToDouble(txtQuiz3.Text);
            double FLab = Convert.ToDouble(txtLab3.Text);
            double FProject = Convert.ToDouble(txtProject.Text);

            if (PQuiz < 0 || PLab < 0 || PSeatwork < 0 || PAttendance < 0 || MQuiz < 0 || MLab < 0 || MPE < 0 || FQuiz < 0 || FLab < 0 || FProject < 0 || PQuiz > 100 || PLab > 100 || PSeatwork > 100 || PAttendance > 100 || MQuiz > 100 || MLab > 100 || MPE > 100 || FQuiz > 100 || FLab > 100 || FProject > 100)
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                //Prelim
                double Quiz = PQuiz / 100 * .40;
                double Lab = PLab / 100 * .50;
                double Seatwork = PSeatwork / 100 * .05;
                double Attendance = PAttendance / 100 * .05;

                double PrelimResult = (Quiz + Lab + Seatwork + Attendance) * 100;
                PrelimResult = Math.Round(PrelimResult, 2);
                

                //Midterm
                double Quiz2 = MQuiz / 100 * .20;
                double Lab2 = MLab / 100 * .50;
                double PracticalExam = MPE / 100 * .30;

                double MidtermResult = (Quiz2 + Lab2 + PracticalExam) * 100;
                MidtermResult = Math.Round(MidtermResult, 2);
                

                //Finals
                double Quiz3 = FQuiz / 100 * .30;
                double Lab3 = FLab / 100 * .50;
                double Project = FProject / 100 * .20;

                double FinalsResult = (Quiz3 + Lab3 + Project) * 100;
                FinalsResult = Math.Round(FinalsResult, 2);
               
                //FinalGrade
                double PrelimGrade = PrelimResult / 100 * .20;
                double MidtermGrade = MidtermResult / 100 * .40;
                double FinalsGrade = FinalsResult / 100 * .40;

                double FinalResult = (PrelimGrade + MidtermGrade + FinalsGrade) * 100;
                FinalResult = Math.Round(FinalResult, 2);
                if (FinalResult >= 100)
                {
                    FinalResult = 100;
                }
                else if (FinalResult <= 65)
                {
                    FinalResult = 65;
                }
                else
                {
                    FinalResult = FinalResult;
                }

                dataGridView1.Rows.Add(txtID.Text, txtName.Text, txtCourse.Text, txtQuiz.Text, txtLab.Text, txtSeatwork.Text, txtAttendance.Text, txtQuiz2.Text, txtLab2.Text, txtPE.Text, txtQuiz3.Text, txtLab3.Text, txtProject.Text, FinalResult + "%");

                txtID.Clear();
                txtLab.Clear();
                txtLab2.Clear();
                txtLab3.Clear();
                txtName.Clear();
                txtPE.Clear();
                txtProject.Clear();
                txtQuiz.Clear();
                txtQuiz2.Clear();
                txtQuiz3.Clear();
                txtSeatwork.Clear();
                txtAttendance.Clear();
                txtCourse.Clear();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstRecords.Items.Clear();
            string PResult, MResult, FResult, FGResult;

            int r = dataGridView1.CurrentCell.RowIndex;
            int c = dataGridView1.CurrentCell.ColumnIndex;

            if (dataGridView1.Rows[r].Cells[c].Selected)
            {
                double PQuiz = Convert.ToDouble(dataGridView1.Rows[r].Cells[3].Value.ToString());
                double PLab = Convert.ToDouble(dataGridView1.Rows[r].Cells[4].Value.ToString());
                double PSeatwork = Convert.ToDouble(dataGridView1.Rows[r].Cells[5].Value.ToString());
                double PAttendance = Convert.ToDouble(dataGridView1.Rows[r].Cells[6].Value.ToString());
                double MQuiz = Convert.ToDouble(dataGridView1.Rows[r].Cells[7].Value.ToString());
                double MLab = Convert.ToDouble(dataGridView1.Rows[r].Cells[8].Value.ToString());
                double MPE = Convert.ToDouble(dataGridView1.Rows[r].Cells[9].Value.ToString());
                double FQuiz = Convert.ToDouble(dataGridView1.Rows[r].Cells[10].Value.ToString());
                double FLab = Convert.ToDouble(dataGridView1.Rows[r].Cells[11].Value.ToString());
                double FProject = Convert.ToDouble(dataGridView1.Rows[r].Cells[12].Value.ToString());

                //Prelim
                double Quiz = PQuiz / 100 * .40;
                double Lab = PLab / 100 * .50;
                double Seatwork = PSeatwork / 100 * .05;
                double Attendance = PAttendance / 100 * .05;

                double PrelimResult = (Quiz + Lab + Seatwork + Attendance) * 100;
                PrelimResult = Math.Round(PrelimResult, 2);
                if (PrelimResult >= 100)
                {
                    PResult = "100";
                }
                else if (PrelimResult <= 65)
                {
                    PResult = "65";
                }
                else
                {
                    PResult = PrelimResult.ToString();
                }

                //Midterm
                double Quiz2 = MQuiz / 100 * .20;
                double Lab2 = MLab / 100 * .50;
                double PracticalExam = MPE / 100 * .30;

                double MidtermResult = (Quiz2 + Lab2 + PracticalExam) * 100;
                MidtermResult = Math.Round(MidtermResult, 2);
                if (MidtermResult >= 100)
                {
                    MResult = "100";
                }
                else if (MidtermResult <= 65)
                {
                    MResult = "65";
                }
                else
                {
                    MResult = MidtermResult.ToString();
                }

                //Finals
                double Quiz3 = FQuiz / 100 * .30;
                double Lab3 = FLab / 100 * .50;
                double Project = FProject / 100 * .20;

                double FinalsResult = (Quiz3 + Lab3 + Project) * 100;
                FinalsResult = Math.Round(FinalsResult, 2);
                if (FinalsResult >= 100)
                {
                    FResult = "100";
                }
                else if (FinalsResult <= 65)
                {
                    FResult = "65";
                }
                else
                {
                    FResult = FinalsResult.ToString();
                }

                //FinalGrade
                double PrelimGrade = PrelimResult / 100 * .20;
                double MidtermGrade = MidtermResult / 100 * .40;
                double FinalsGrade = FinalsResult / 100 * .40;

                double FinalResult = (PrelimGrade + MidtermGrade + FinalsGrade) * 100;
                FinalResult = Math.Round(FinalResult, 2);
                if (FinalResult >= 100)
                {
                    FGResult = "100";
                }
                else if (FinalResult <= 65)
                {
                    FGResult = "65";
                }
                else
                {
                    FGResult = FinalResult.ToString();
                }

                //ListBox
                lstRecords.Items.Add($"               Final Result");
                lstRecords.Items.Add($"\n");
                lstRecords.Items.Add($"\n");
                lstRecords.Items.Add($"Student ID: {dataGridView1.Rows[r].Cells[0].Value}");
                lstRecords.Items.Add($"Student Name: {dataGridView1.Rows[r].Cells[1].Value}");
                lstRecords.Items.Add($"Course: {dataGridView1.Rows[r].Cells[2].Value}");
                lstRecords.Items.Add($"\n");
                lstRecords.Items.Add($"\n");
                lstRecords.Items.Add($"Prelim Grade: {PResult}");
                lstRecords.Items.Add($"\n");
                lstRecords.Items.Add($"Midterm Grade: {MResult}");
                lstRecords.Items.Add($"\n");
                lstRecords.Items.Add($"Finals Grade: {FResult}");
                lstRecords.Items.Add($"\n");
                lstRecords.Items.Add($"Final Grade: {dataGridView1.Rows[r].Cells[13].Value}");
                lstRecords.Items.Add($"\n");
                lstRecords.Items.Add($"\n");
                lstRecords.Items.Add($"               KEEP IT UP!! ");
            }
        }

        private void btnUpdateCell_Click(object sender, EventArgs e)
        {
            
            int r = dataGridView1.CurrentCell.RowIndex;
            int c = dataGridView1.CurrentCell.ColumnIndex;

            if (dataGridView1.Rows[r].Cells[c].Selected)
            {
                double PQuiz = Convert.ToDouble(dataGridView1.Rows[r].Cells[3].Value.ToString());
                double PLab = Convert.ToDouble(dataGridView1.Rows[r].Cells[4].Value.ToString());
                double PSeatwork = Convert.ToDouble(dataGridView1.Rows[r].Cells[5].Value.ToString());
                double PAttendance = Convert.ToDouble(dataGridView1.Rows[r].Cells[6].Value.ToString());
                double MQuiz = Convert.ToDouble(dataGridView1.Rows[r].Cells[7].Value.ToString());
                double MLab = Convert.ToDouble(dataGridView1.Rows[r].Cells[8].Value.ToString());
                double MPE = Convert.ToDouble(dataGridView1.Rows[r].Cells[9].Value.ToString());
                double FQuiz = Convert.ToDouble(dataGridView1.Rows[r].Cells[10].Value.ToString());
                double FLab = Convert.ToDouble(dataGridView1.Rows[r].Cells[11].Value.ToString());
                double FProject = Convert.ToDouble(dataGridView1.Rows[r].Cells[12].Value.ToString());

                if (PQuiz < 0 || PLab < 0 || PSeatwork < 0 || PAttendance < 0 || MQuiz < 0 || MLab < 0 || MPE < 0 || FQuiz < 0 || FLab < 0 || FProject < 0 || PQuiz > 100 || PLab > 100 || PSeatwork > 100 || PAttendance > 100 || MQuiz > 100 || MLab > 100 || MPE > 100 || FQuiz > 100 || FLab > 100 || FProject > 100)
                {
                    MessageBox.Show("Invalid input");
                }
                else
                {
                    //Prelim
                    double Quiz = PQuiz / 100 * .40;
                    double Lab = PLab / 100 * .50;
                    double Seatwork = PSeatwork / 100 * .05;
                    double Attendance = PAttendance / 100 * .05;

                    double PrelimResult = (Quiz + Lab + Seatwork + Attendance) * 100;
                    PrelimResult = Math.Round(PrelimResult, 2);


                    //Midterm
                    double Quiz2 = MQuiz / 100 * .20;
                    double Lab2 = MLab / 100 * .50;
                    double PracticalExam = MPE / 100 * .30;

                    double MidtermResult = (Quiz2 + Lab2 + PracticalExam) * 100;
                    MidtermResult = Math.Round(MidtermResult, 2);


                    //Finals
                    double Quiz3 = FQuiz / 100 * .30;
                    double Lab3 = FLab / 100 * .50;
                    double Project = FProject / 100 * .20;

                    double FinalsResult = (Quiz3 + Lab3 + Project) * 100;
                    FinalsResult = Math.Round(FinalsResult, 2);

                    //FinalGrade
                    double PrelimGrade = PrelimResult / 100 * .20;
                    double MidtermGrade = MidtermResult / 100 * .40;
                    double FinalsGrade = FinalsResult / 100 * .40;

                    double FinalResult = (PrelimGrade + MidtermGrade + FinalsGrade) * 100;
                    FinalResult = Math.Round(FinalResult, 2);
                    if (FinalResult >= 100)
                    {
                        FinalResult = 100;
                    }
                    else if (FinalResult <= 65)
                    {
                        FinalResult = 65;
                    }
                    else
                    {
                        FinalResult = FinalResult;
                    }

                    dataGridView1.Rows.Add(dataGridView1.Rows[r].Cells[0].Value.ToString(), dataGridView1.Rows[r].Cells[1].Value.ToString(), dataGridView1.Rows[r].Cells[2].Value.ToString(), dataGridView1.Rows[r].Cells[3].Value.ToString(), dataGridView1.Rows[r].Cells[4].Value.ToString(), dataGridView1.Rows[r].Cells[5].Value.ToString(), dataGridView1.Rows[r].Cells[6].Value.ToString(), dataGridView1.Rows[r].Cells[7].Value.ToString(), dataGridView1.Rows[r].Cells[8].Value.ToString(), dataGridView1.Rows[r].Cells[9].Value.ToString(), dataGridView1.Rows[r].Cells[10].Value.ToString(), dataGridView1.Rows[r].Cells[11].Value.ToString(), dataGridView1.Rows[r].Cells[12].Value.ToString(), FinalResult + "%");

                    dataGridView1.Rows.RemoveAt(r);
                }
            }
        }

        private void btnRemoveCell_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows.RemoveAt(r);
        }
    }
}
