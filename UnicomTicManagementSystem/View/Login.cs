using System.Net;
using System.Xml.Linq;

namespace UnicomTicManagementSystem
{
    public partial class Unicom : Form
    {
        public Unicom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void t_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(t_uname.Text) || string.IsNullOrWhiteSpace(t_password.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }
            MessageBox.Show("Student Added Successfully");
        }
    }
}
