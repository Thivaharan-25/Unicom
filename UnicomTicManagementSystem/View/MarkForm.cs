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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnicomTicManagementSystem.View
{
    public partial class MarkForm : Form
    {
        MarkController Markc = new MarkController();
        private int selectedResultId = -1;
        public MarkForm()
        {
            InitializeComponent();
            LoadCourse();
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoadCourse()
        {
            List<Mark> users = Markc.GetAllMark();
            dgv_result.DataSource = users;
            dgv_result.ClearSelection();
            Clearinputs();
            selectedResultId = -1;

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
                    selectedResultId = users.Id;
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
    }
}
