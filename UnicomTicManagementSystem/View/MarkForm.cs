using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controller;
using UnicomTicManagementSystem.Method;


namespace UnicomTicManagementSystem.View
{
    public partial class MarkForm : Form
    {
        MarkController Markc = new MarkController();
        private int selectedResultId = -1;
        public MarkForm()
        {
            InitializeComponent();
            lord_Result();
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {

        }

        private void dvg_result_SelectionChanged(object sender, EventArgs e)
        {
           selectedResultId = -1; // Reset selected ID
            if (dgv_result.SelectedRows.Count > 0)
            {
                var row = dgv_result.SelectedRows[0];
                Mark mark = row.DataBoundItem as Mark;
                if (mark != null)
                {
                    selectedResultId = mark.Id;
                    t_code.Text = mark.StudentCode;
                    c_subject.Text = mark.Subject;
                    t_mark.Text = mark.Score.ToString();
                }
            }
            else
            {
                Clearinputs();
            }
        }

        private void lord_Result()
        {

            List<Mark> time = Markc.GetAllMark();
            dgv_result.DataSource = time;
            dgv_result.ClearSelection();
            Clearinputs();
            selectedResultId = -1;
            LoadSubjectsIntoComboBox();
            //dgv_result.Columns["RoomType"].Visible = false;
            //dgv_result.Columns["HallNo"].Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedResultId == -1)
            {
                MessageBox.Show("Please select to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Markc.DeleteMark(selectedResultId);
                MessageBox.Show(" Deleted Successfully");
                lord_Result();
            }
        }


        private void LoadSubjectsIntoComboBox()
        {
            // Call your controller method here
            List<string> subjects = Markc.GetAllSubjectNames(); // or SubjectController.GetAllSubjectNames();

            c_subject.Items.Clear();
            c_subject.Items.AddRange(subjects.ToArray());
        }

        private void dgv_time_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_result.SelectedRows.Count > 0)
            {
                var row = dgv_result.SelectedRows[0];
                ExamN users = row.DataBoundItem as ExamN;
                if (users != null)
                {
                   
                    t_code.Text = users.Date;
                    c_subject.Text = users.Subject;
                    t_mark.Text = users.Hall;

                }
            }
            else
            {
                Clearinputs();
                selectedResultId = -1;
            }
        }

        private void Clearinputs()
        {
            t_code.Text = "";
            c_subject.Text = "";
            t_mark.Text = "";

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedResultId == -1)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(t_mark.Text) || string.IsNullOrEmpty(c_subject.Text) || string.IsNullOrEmpty(t_code.Text))
            {
                MessageBox.Show("incomplete Input");
                return;
            }
            Mark mark = new Mark
            {
                Id = selectedResultId,
                Subject = c_subject.Text.Trim(),
                StudentCode = t_code.Text.Trim(),
                Score = int.Parse(t_mark.Text.Trim())
            };
            bool success = Markc.UpdateMark(mark);
            if (success)
            {
                MessageBox.Show("Update Successfull");
                lord_Result();
            }
            else
            {
                MessageBox.Show("Failed Update");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(t_mark.Text) || string.IsNullOrWhiteSpace(c_subject.Text) || string.IsNullOrEmpty(t_code.Text))
            {
                MessageBox.Show("Please enter Score,StudentCode and Subject.");
                return;
            }

            // Create a CourseName object (adjust properties if needed)
            Mark mark = new Mark
            {
                Id = selectedResultId,
                Subject = c_subject.Text.Trim(),
                StudentCode = t_code.Text.Trim(),
                Score = int.Parse(t_mark.Text.Trim())

            };

            // Save to DB via your controller
            bool success = Markc.AddMark(mark);
            if (success)
            {
                MessageBox.Show("Mark added successfully!");
                lord_Result(); // Refresh DataGridView to show new data

                // Optionally clear input fields
                Clearinputs();

              
            }
            else
            {
                MessageBox.Show("Failed to add Mark.");
            }
        }
    }
}
