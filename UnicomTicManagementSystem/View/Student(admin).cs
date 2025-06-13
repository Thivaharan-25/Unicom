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
        private int selectedStudentId = -1;
        private adminController adminc = new adminController();
        public student()
        {
            InitializeComponent();
            LoadStudents();

        }
        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (User_dgv.SelectedRows.Count > 0)
            {
                var row = User_dgv.SelectedRows[0];
                Student student = row.DataBoundItem as Student;
                if (student != null)
                {
                    selectedStudentId = student.StudentId;
                    T_uname.Text = student.Name;
                    T_password.Text = student.Password;
                }
            }
            else
            {
                ClearInputs();
                selectedStudentId = -1;
            }
        }
        private void LoadStudents()
        {
            List<Student> students = adminc.GetAllStudents();
            User_dgv.DataSource = students;
            User_dgv.ClearSelection();
            ClearInputs();
            selectedStudentId = -1;
            User_dgv.Columns["Password"].Visible = false;
        }
        private void ClearInputs()
        {
            T_uname.Text = "";
            T_password.Text = "";

        }
        private void AddUsers_Load(object sender, EventArgs e)
        {

        }
        private void T_uname_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_register_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Registation Successfull");
        }
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Update Successfull");
        }
        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Delete Successfull");
        }
        private void button3_Click(object sender, EventArgs e)
        {


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show($"Cell clicked at row {e.RowIndex}, column {e.ColumnIndex}");
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show($"You selected: {comboBox4.SelectedItem}");
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show($"You selected: {comboBox4.SelectedItem}");
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show($"You selected: {comboBox4.SelectedItem}");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show($"You selected: {comboBox4.SelectedItem}");
        }

        private void T_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
