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
using static UnicomTicManagementSystem.Method.Users;

namespace UnicomTicManagementSystem.View
{
    public partial class StudentResultForm : Form
    {
        private readonly MarkController Markc = new MarkController();
        adminController adminc = new adminController();
        public StudentResultForm()
        {
            InitializeComponent();
            //this.Load += StudentResultForm_Load;
        }

        private void StudentResultForm_Load(object sender, EventArgs e)
        {
            //string userCode = Session.LoggedInUser?.UserCode; // assuming it's stored after login
            //if (!string.IsNullOrEmpty(userCode))
            //{
            //    var studentMarks = Markc.GetMarksByStudentCode(userCode);
            //    dgv_student.DataSource = studentMarks;
            //    dgv_student.Columns["Password"].Visible = false;
            //    dgv_student.Columns["Id"].Visible = false;
            //}
            //else
            //{
            //    MessageBox.Show("No student is currently logged in.");
            //}
        }

        private void StudentResultForm_Load()
        {
            LoadStudentResults();
        }
        private void LoadStudentResults()
        {
            //string userCode = Session.LoggedInUser?.UserCode;
            //if (!string.IsNullOrEmpty(userCode))
            //{
            //    var studentMarks = Markc.GetMarksByStudentCode(userCode);
            //    dgv_student.DataSource = studentMarks;
            //    dgv_student.Columns["Id"].Visible = false;
            //}
            //else
            //{
            //    MessageBox.Show("No student is currently logged in.");
            //}
        }

    }
}
