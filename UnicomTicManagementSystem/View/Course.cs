using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UnicomTicManagementSystem.Method;
using UnicomTicManagementSystem.Controller;

namespace UnicomTicManagementSystem.View
{

    public partial class Course : Form
    {
        public event Action<CourseName> CourseAdded;

        protected virtual void OnCourseAdded(CourseName course)
        {
            CourseAdded?.Invoke(course);
        }



        private int selectedCourseId = -1;
        private CourseController coursec = new CourseController();

        public Course()
        {
            InitializeComponent();
            LoadCourse();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dgv_course_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_course.SelectedRows.Count > 0)
            {
                var row = dgv_course.SelectedRows[0];
                CourseName Courses = row.DataBoundItem as CourseName;
                if (Courses != null)
                {
                    selectedCourseId = Courses.Id;
                    t_course.Text = Courses.Course;
                    t_subject.Text = Courses.Subject ?? "";

                }
                else
                {
                    Clearinputs();
                    selectedCourseId = -1;
                }
            }
        }

        private void LoadCourse()
        {
            List<CourseName> users = coursec.GetAllCourse();
            dgv_course.DataSource = users;
            dgv_course.ClearSelection();
            Clearinputs();
            selectedCourseId = -1;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Clearinputs()
        {
            t_course.Text = "";
            t_subject.Text = "";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(t_course.Text) || string.IsNullOrWhiteSpace(t_subject.Text))
            {
                MessageBox.Show("Please enter both Course and Subject.");
                return;
            }

            // Create a CourseName object (adjust properties if needed)
            CourseName newCourse = new CourseName
            {
                Course = t_course.Text.Trim(),
                Subject = t_subject.Text.Trim()
            };

            // Save to DB via your controller
            bool success = coursec.AddCourse(newCourse);
            if (success)
            {
                MessageBox.Show("Course added successfully!");
                LoadCourse(); // Refresh DataGridView to show new data

                // Optionally clear input fields
                Clearinputs();

                // Notify other forms or refresh ComboBoxes (see next section)
                OnCourseAdded(newCourse);
            }
            else
            {
                MessageBox.Show("Failed to add course.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(t_course.Text) || string.IsNullOrEmpty(t_subject.Text))
            {
                MessageBox.Show("incomplete Input");
                return;
            }
            CourseName Course = new CourseName
            {
                Id = selectedCourseId,
                Subject = t_subject.Text.Trim(),    
                Course = t_course.Text.Trim()
            };
            bool success = coursec.AddSubjectToCourse(selectedCourseId, t_subject.Text.Trim() , t_course.Text.Trim());
            if (success)
            {
                MessageBox.Show("Update Successfull");
                LoadCourse();
            }
            else
            {
                MessageBox.Show("Failed Update");
            }
          
        }
    }
}
