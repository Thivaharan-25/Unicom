using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTicManagementSystem.View
{
    public partial class Select : Form
    {
        private Course courseForm;
        private student studentForm = new student();
        public Select()
        {
            InitializeComponent();
            LoadForm(new student());

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
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_usermain_Click(object sender, EventArgs e)
        {
            LoadForm(new student());
        }

        private void btn_timetable_Click(object sender, EventArgs e)
        {
            LoadForm(new Timetable());
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
            LoadForm(new student());
        }

        private void btn_timetable_Click_1(object sender, EventArgs e)
        {
            LoadForm(new Timetable());
        }

        private void btn_exammain_Click(object sender, EventArgs e)
        {
            LoadForm(new Exam());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LoadForm(new MarkForm());
        }
    }
}
