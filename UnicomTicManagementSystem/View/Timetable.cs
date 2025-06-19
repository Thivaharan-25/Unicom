using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controller;
using UnicomTicManagementSystem.Method;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static UnicomTicManagementSystem.Method.Users;

namespace UnicomTicManagementSystem.View
{
    public partial class Timetable : Form
    {
        private int selectedTimeId = -1;
        TimeTableController Timec = new TimeTableController();
        public Timetable()
        {
            InitializeComponent();
            Timetable_load();
        }
        private void Timetable_load()
        {
            LoadCoursesIntoComboBox();
            LoadSubjectsIntoComboBox();
            LoadLecturerIntoComboBox();
            lord_time();
        }
        private void Timetable_Load(object sender, EventArgs e)
        {
           

        }

        private void LoadLecturerIntoComboBox()
        {
            // Call your controller method here
            List<string> lecturer = Timec.GetAllLecturerNames(); // or SubjectController.GetAllSubjectNames();

            c_lecturer.Items.Clear();
            c_lecturer.Items.AddRange(lecturer.ToArray());
        }
        private void LoadCoursesIntoComboBox()
        {

            List<string> Course = Timec.GetAllCourseNames();

            c_course.Items.Clear();
            c_course.Items.AddRange(Course.ToArray());
        }
        private void LoadSubjectsIntoComboBox()
        {
            // Call your controller method here
            List<string> subjects = Timec.GetAllSubjectNames(); // or SubjectController.GetAllSubjectNames();

            c_subject.Items.Clear();
            c_subject.Items.AddRange(subjects.ToArray());
        }

        private void dgv_time_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_time.SelectedRows.Count > 0)
            {
                var row = dgv_time.SelectedRows[0];
                TimeTable users = row.DataBoundItem as TimeTable;
                if (users != null)
                {
                    selectedTimeId = users.Id;
                    t_date.Text = users.DateOfWeek;
                    d_time.Text = users.TimeSlot;
                    c_subject.Text = users.Subject;
                    t_hall.Text = users.Hall;
                    c_course.Text = users.Course;
                    c_lecturer.Text = users.Lecturer;
                    c_roomtype.Text = users.RoomType;
                }
            }
            else
            {
                Clearinputs();
                selectedTimeId = -1;
            }
        }

        private void lord_time()
        {

            List<TimeTable> time = Timec.GetTimeTable();
            dgv_time.DataSource = time;
            dgv_time.ClearSelection();
            Clearinputs();
            selectedTimeId = -1;
            dgv_time.Columns["RoomType"].Visible = false;
            dgv_time.Columns["HallNo"].Visible = false;


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clearinputs()
        {
            c_lecturer.Text = "";
            c_subject.Text = "";
            t_hall.Text = "";
            t_date.Text = "";
            d_time.Text = "";
            c_roomtype.Text = "";
            c_course.Text = "";


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void c_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubject = c_subject.SelectedItem.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            TimeTable time = new TimeTable
            {
                TimeSlot = timeRange,
                Subject = c_subject.Text.Trim(),
                DateOfWeek = t_date.Text.Trim(),
                Hall = t_hall.Text.Trim(),
                Lecturer = c_lecturer.Text.Trim(),
                RoomType = c_roomtype.Text.Trim(),
                Course = c_course.Text.Trim()

            };

            bool success = Timec.AddTime(time);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedTimeId == -1)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(d_time.Text) || string.IsNullOrWhiteSpace(c_subject.Text) || string.IsNullOrWhiteSpace(t_date.Text) || string.IsNullOrWhiteSpace(c_course.Text) || string.IsNullOrWhiteSpace(c_roomtype.Text) || string.IsNullOrWhiteSpace(t_hall.Text) || string.IsNullOrWhiteSpace(c_lecturer.Text))
            {
                MessageBox.Show("incomplete Input");
                return;
            }

            var start = d_time.Value.ToString("hh:mm tt");
            var end = d_time2.Value.ToString("hh:mm tt");
            var timeRange = $"{start} - {end}";
            if (d_time2.Value <= d_time.Value)
            {
                MessageBox.Show("End time must be later than start time.");
                return;
            }

            TimeTable time = new TimeTable
            {
                Id = selectedTimeId,
                TimeSlot = timeRange,
                Subject = c_subject.Text.Trim(),
                DateOfWeek = t_date.Text.Trim(),
                Hall = t_hall.Text.Trim(),
                Lecturer = c_lecturer.Text.Trim(),
                RoomType = c_roomtype.Text.Trim(),
                Course = c_course.Text.Trim()
            };
            bool success = Timec.UpdateTime(time);
            if (success)
            {
                MessageBox.Show("Update Successfull");
                lord_time();
                Clearinputs();
            }

            else
            {
                MessageBox.Show("Failed Update");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedTimeId == -1)
            {
                MessageBox.Show("Please select to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Timec.DeleteTime(selectedTimeId);
                MessageBox.Show("User Deleted Successfully");
                lord_time();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void c_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubject = c_course.SelectedItem.ToString();
        }
    }
}
