using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTicManagementSystem.Controller;
using UnicomTicManagementSystem.Method;

namespace UnicomTicManagementSystem.View
{
    public partial class AddUsersForm : Form

    {
        CourseController coursec = new CourseController();



        private Dictionary<string, List<string>> subject = new Dictionary<string, List<string>>()
        {


        };


        private int selectedStudentId = -1;
        private adminController adminc = new adminController();
        public AddUsersForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadCourses();


            // Assuming you open the Course form somewhere like this:
            Course course = new Course();
            course.CourseAdded += CourseForm_CourseAdded;

            // Setup ComboBoxes, events, etc...
        }

        private void CourseForm_CourseAdded(CourseName newCourse)
        {
            // Reload courses from DB, or just add the new course directly:
            LoadCourses();

            // Optionally, also update subjects dictionary if needed
            if (!subject.ContainsKey(newCourse.Course))
            {
                subject[newCourse.Course] = new List<string> { newCourse.Subject };
            }
            else if (!subject[newCourse.Course].Contains(newCourse.Subject))
            {
                subject[newCourse.Course].Add(newCourse.Subject);
            }
        }
        private void LoadCourses()
        {
            var courses = coursec.GetAllCourse().Select(c => c.Course).Distinct().ToList();
            Course.DataSource = null;
            Course.DataSource = new BindingSource(courses, null);
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (User_dgv.SelectedRows.Count > 0)
            {
                var row = User_dgv.SelectedRows[0];
                Users users = row.DataBoundItem as Users;
                if (users != null)
                {
                    selectedStudentId = users.Id;
                    T_uname.Text = users.username;
                    T_password.Text = users.password;
                    textBox1.Text = users.address;
                    comboBox4.Text = users.Gender;
                    role.Text = users.Role;

                    // Set course
                    int courseIndex = Course.FindStringExact(users.Course);
                    if (courseIndex != -1)
                        Course.SelectedIndex = courseIndex;

                    // Trigger population of subjects
                    Course_SelectedIndexChanged(null, null);



                    UpdateRoleComboBoxState();
                }
            }

            else
            {
                ClearInputs();
                selectedStudentId = -1;
                UpdateRoleComboBoxState();
            }
        }

        private void LoadStudents()
        {
            List<Users> users = adminc.GetAllUsers();
            User_dgv.DataSource = users;
            User_dgv.ClearSelection();
            ClearInputs();
            selectedStudentId = -1;
            User_dgv.Columns["password"].Visible = false;
            User_dgv.Columns["Course"].Visible = false;


        }
        private void ClearInputs()
        {
            T_uname.Text = "";
            T_password.Text = "";
            textBox1.Text = "";
            comboBox4.Text = "";
            role.Text = "";
            Course.Text = "";


            role.Enabled = true;
        }
        private void AddUsers_Load(object sender, EventArgs e)
        {

        }
        private void T_uname_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(T_uname.Text) || string.IsNullOrWhiteSpace(T_password.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox4.Text) ||
                string.IsNullOrWhiteSpace(role.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Construct the user object
            Users users = new Users
            {
                username = T_uname.Text,
                password = T_password.Text,
                Role = role.Text,
                address = textBox1.Text,
                Gender = comboBox4.Text,
                Course = (role.Text.ToLower() == "student") ? Course.SelectedItem?.ToString() ?? "" : ""
            };

            // Add the user through the controller (which will now handle role-specific inserts)
            adminc.AddUser(users);

            MessageBox.Show("Registration Successful");
            LoadStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {

                return;
            }
            if (string.IsNullOrWhiteSpace(T_uname.Text) || string.IsNullOrWhiteSpace(T_password.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox4.Text) || string.IsNullOrWhiteSpace(role.Text))
            {
                MessageBox.Show("Incomplete Input.");
                return;
            }
            Users users = new Users
            {
                Id = selectedStudentId,
                username = T_uname.Text,
                password = T_password.Text,
                Role = role.Text,
                address = textBox1.Text,
                Gender = comboBox4.Text,
                Course = Course.SelectedItem?.ToString() ?? "",


            };
            adminc.UpdateUser(users);

            MessageBox.Show("Update Successfull");
            LoadStudents();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                adminc.DeleteUser(selectedStudentId);
                MessageBox.Show("User Deleted Successfully");
                LoadStudents();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void T_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void rolebox_selectedindexchanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = role.SelectedItem?.ToString() ?? "";

            if (selectedRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                Course.Visible = false;

                label3.Visible = false;

            }
            else if (selectedRole.Equals("Staff", StringComparison.OrdinalIgnoreCase))
            {
                Course.Visible = false;

                label3.Visible = false;

            }
            else
            {
                // Show all for students or other roles
                Course.Visible = true;

                label3.Visible = true;

            }
        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = Course.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCourse) && subject.ContainsKey(selectedCourse))
            {
                List<string> availableSubjects = subject[selectedCourse];


            }
        }

        private void UpdateRoleComboBoxState()
        {
            if (selectedStudentId == -1) // Adding new user
            {
                role.Enabled = true;  // Allow selecting role
            }
            else // Editing existing user
            {
                role.Enabled = false; // Disable changing role
            }
        }

        private void Subject1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subject2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subject3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Subject1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
