using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controller;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Method;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UnicomTicManagementSystem.View
{
    public partial class Exam : Form
    {
        private ExamController Examc = new ExamController();
        private TimeTableController Timec = new TimeTableController();
        private int selectedexamId = -1;
        public Exam()
        {
            InitializeComponent();
            LoadExam();
        }


        private void LoadExam()
        {
            LoadSubjectsIntoComboBox();
            lord_time();
        }
        private void LoadSubjectsIntoComboBox()
        {
            // Call your controller method here
            List<string> subjects = Timec.GetAllSubjectNames(); // or SubjectController.GetAllSubjectNames();

            c_subject.Items.Clear();
            c_subject.Items.AddRange(subjects.ToArray());
        }

        private void lord_time()
        {

            List<ExamN> time = Examc.GetAllExam();
            dgv_exam.DataSource = time;
            dgv_exam.ClearSelection();
            Clearinputs();
            selectedexamId = -1;




        }

        private void dgv_time_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_exam.SelectedRows.Count > 0)
            {
                var row = dgv_exam.SelectedRows[0];
                ExamN users = row.DataBoundItem as ExamN;
                if (users != null)
                {
                    selectedexamId = users.Id;
                    t_date.Text = users.Date;
                    //t_time.Text = users.TimeSlot;
                    c_subject.Text = users.Subject;
                    t_hall.Text = users.Hall;
                    //c_course.Text = users.Course;
                    //c_lecturer.Text = users.Lecturer;
                    t_exam.Text = users.Name;
                }
            }
            else
            {
                Clearinputs();
                selectedexamId = -1;
            }
        }

        private void Clearinputs()
        {
            t_date.Text = "";
            t_hall.Text = "";
            c_subject.Text = "";
            t_exam.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exam_Load(object sender, EventArgs e)
        {

        }

        private void c_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubject = c_subject.SelectedItem.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var start = d_time.Value.ToString("hh:mm tt");
            var end = d_time2.Value.ToString("hh:mm tt");
            var timeRange = $"{start} - {end}";
            if (d_time2.Value <= d_time.Value)
            {
                MessageBox.Show("End time must be later than start time.");
                return;
            }
            ExamN time = new ExamN
            {
                TimeSlot = timeRange,
                Subject = c_subject.Text.Trim(),
                Date = t_date.Text.Trim(),
                Hall = t_exam.Text.Trim(),
                Name = t_hall.Text.Trim(),


            };

            bool success = Examc.AddExam(time);
            if (success)
            {

                lord_time();
                Clearinputs();
            }

            else
            {
                MessageBox.Show("Failed to add TimeTable.");
            }
        }

        private void t_hall_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedexamId == -1)
            {
                MessageBox.Show("Please select to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Examc.DeleteUser(selectedexamId);
                MessageBox.Show("User Deleted Successfully");
                LoadExam();
            }
        }

        private void d_time_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
