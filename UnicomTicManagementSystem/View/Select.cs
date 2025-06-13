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
        public Select()
        {
            InitializeComponent();
            LoadForm(new student());
        }
        public void LoadForm(object formObj)
        {
            if (this.admin_panel.Controls.Count > 0)
            {
                this.admin_panel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.admin_panel.Controls.Add(form);
            this.admin_panel.Tag = form;
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
    }
}
