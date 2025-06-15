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
    public partial class student : Form

    {
        private List<string> GetSubjectsByCourse(string course)
        {
            return subject
                .Where(kvp => kvp.Value.Any(c => c.Trim() == course.Trim()))  // trim to handle spaces
                .Select(kvp => kvp.Key)
                .ToList();
        }


        private Dictionary<string, List<string>> subject = new Dictionary<string, List<string>>()
    {
        { "Commerce", new List<string> { "Accounting" , "Economics","BusinessStudies", "Finance" , " Marketing" ,"Taxation" , "Auditing" , "Entrepreneurship" , "Statistics" , "Commercial Law" } },
        { "Mathematic", new List<string> { "Mathematics", "Chemistry", "Physics" } },
        { "Biology", new List<string> { "Biology", "Chemistry", "Physics" } },
        { "Arts", new List<string> { "History" ,"Geography" ,"Political Science","Sociology", "Psychology","Philosophy"," English Literature" , "Economics", "Arts" , "Anthropology" } },
        { "Bio-system technology", new List<string> { "Biology", "Chemistry", "Physics" } },
        { "Engineering Technology", new List<string> { "Biology", "Chemistry", "Physics" } }

    };


        private int selectedStudentId = -1;
        private adminController adminc = new adminController();
        public student()
        {
            InitializeComponent();
            LoadStudents();

            Course.DataSource = new BindingSource(subject.Keys.ToList(), null);
            Course.SelectedIndexChanged += Course_SelectedIndexChanged;
            Subject1.SelectedIndexChanged += Subject1_SelectedIndexChanged;

            // Initialize Course based on first selection
            if (Subject1.Items.Count > 0)
            {
                string selected = Subject1.SelectedItem as string;
                if (selected != null && subject.ContainsKey(selected))
                {
                    Course.DataSource = new BindingSource(subject[selected], null);
                }
            }

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
                    Course.Text = users.Course;
                    subject2.Text = users.subject2;
                    Subject1.Text = users.subject1;
                    subject3.Text = users.Subject3;

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
            User_dgv.Columns["subject2"].Visible = false;
            User_dgv.Columns["subject3"].Visible = false;
            User_dgv.Columns["Subject1"].Visible = false;

        }
        private void ClearInputs()
        {
            T_uname.Text = "";
            T_password.Text = "";
            textBox1.Text = "";
            comboBox4.Text = "";
            role.Text = "";
            Course.Text = "";
            subject2.Text = "";
            Subject1.Text = "";
            subject3.Text = "";

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
            if (string.IsNullOrWhiteSpace(T_uname.Text) || string.IsNullOrWhiteSpace(T_password.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox4.Text) || string.IsNullOrWhiteSpace(role.Text) )
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }
            Users users = new Users
            {
                username = T_uname.Text, password = T_password.Text,
                Role = role.Text,address = textBox1.Text, Gender =comboBox4.Text
            };
            adminc.AddUser(users);
            MessageBox.Show("Registation Successfull");
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
                username = T_uname.Text,
                password = T_password.Text,
                Role = role.Text,
                address = textBox1.Text,
                Gender = comboBox4.Text
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

            bool isStaff = selectedRole.Equals("Staff", StringComparison.OrdinalIgnoreCase);

            Course.Visible = !isStaff;
            Subject1.Visible = !isStaff;
            subject2.Visible = !isStaff;
            subject3.Visible = !isStaff;
            label7.Visible = !isStaff;
            label8.Visible = !isStaff;
            label6.Visible = !isStaff;
            label3.Visible = !isStaff;
        }
        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = Course.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCourse) && subject.ContainsKey(selectedCourse))
            {
                List<string> availableSubjects = subject[selectedCourse];

                // Optional: You can choose how to distribute them across 3 subject boxes
                Subject1.DataSource = new BindingSource(availableSubjects.ToList(), null);
                subject2.DataSource = new BindingSource(availableSubjects.ToList(), null);
                subject3.DataSource = new BindingSource(availableSubjects.ToList(), null);
            }
            else
            {
                Subject1.DataSource = null;
                subject2.DataSource = null;
                subject3.DataSource = null;
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
    }
}
