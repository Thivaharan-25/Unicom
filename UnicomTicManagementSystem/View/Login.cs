using System.Net;
using System.Xml.Linq;
using UnicomTicManagementSystem.Controller;
using UnicomTicManagementSystem.View;
using static UnicomTicManagementSystem.Method.Users;

namespace UnicomTicManagementSystem
{
    public partial class Unicom : Form
    {
        
        private readonly adminController adminController;
        public Unicom()
        {
            InitializeComponent();
            adminController = new adminController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void t_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = t_uname.Text.Trim();
            string password = t_password.Text;

            string validUsername = "UT010776";
            string validPassword = "1234";

            if (username == validUsername && password == validPassword)
            {

                student maintenance = new student();
                maintenance.Show();
                this.Hide();
            }
            //if (string.IsNullOrWhiteSpace(t_uname.Text) || string.IsNullOrWhiteSpace(t_password.Text))
            //{
            //    MessageBox.Show("Please enter both Name and Address.");
            //    return;
            //}
            else
            {
                Credentials credentials = new Credentials();
                credentials.userName = username;
                credentials.password = password;
                var result = adminController.Login(credentials);
                if (result)
                {
                    student maintenance = new student();
                    maintenance.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Optionally clear fields
                    t_uname.Clear();
                    t_uname.Focus();
                }

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
