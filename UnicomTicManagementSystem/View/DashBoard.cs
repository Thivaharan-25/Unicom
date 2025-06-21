using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UnicomTicManagementSystem.Method.Users;

namespace UnicomTicManagementSystem.View
{
    public partial class DashBoard : Form
    {
        private Course courseForm;
        private AddUsersForm studentForm = new AddUsersForm();
        public DashBoard()
        {
            InitializeComponent();
            LoadForm(new AddUsersForm());

        }
        public void LoadForm(object formObj)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(form);
            this.mainpanel.Tag = form;
            form.Show();
            string role = Session.LoggedInUser?.Role?.ToLower();

            //if (role == "admin")
            //{
            //    LoadForm(new AddUsersForm());
            //}
            //else if (role == "student")
            //{
            //    LoadForm(new StudentResultForm());
            //}
            //else
            //{
            //    LoadForm(new TimetableForm());

            //}
        }
        public void LoadForm()
        {
            //if (this.mainpanel.Controls.Count > 0)
            //{
            //    this.mainpanel.Controls.RemoveAt(0);
            //}

            //Form form = new Form();
            //form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            //this.mainpanel.Controls.Add(form);
            //this.mainpanel.Tag = form;
            //form.Show();
            //string role = Session.LoggedInUser?.Role?.ToLower();

            //if (role == "admin")
            //{
            //    LoadForm(new AddUsersForm());
            //}
            //else if (role == "student")
            //{
            //    LoadForm(new StudentResultForm());
            //}
            //else
            //{
            //    LoadForm(new TimetableForm());

            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_usermain_Click(object sender, EventArgs e)
        {

           
                LoadForm(new AddUsersForm());
           
            
            
        }

        private void btn_timetable_Click(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void btn_course_Click_1(object sender, EventArgs e)
        {
            LoadForm(new Course());
        }

        private void Select_Load(object sender, EventArgs e)
        {
            string role = Session.LoggedInUser?.Role?.ToLower();

            if (role == "admin")
            {
                btn_usermain.Visible = true;
                btn_course.Visible = true;

            }
            else
            {
                btn_usermain.Visible = false;
                btn_course.Visible = false;

            }
            if (role == "student")
            {
                btn_result.Visible = true;
            }
            else
            {
                btn_result.Visible = false;
            }
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_course_Click(object sender, EventArgs e)
        {




            LoadForm(new Course());

        }

        private void btn_usermain_Click_1(object sender, EventArgs e)
        {
            LoadForm(new AddUsersForm());
        }

        private void btn_timetable_Click_1(object sender, EventArgs e)
        {
            LoadForm(new TimetableForm());
        }

        private void btn_exammain_Click(object sender, EventArgs e)
        {
            LoadForm(new Exam());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LoadForm(new MarkForm());
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentResultForm());
        }
    }
}
