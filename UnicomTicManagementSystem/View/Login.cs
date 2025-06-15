using System.Data.SQLite;
using System.Net;
using System.Xml.Linq;
using UnicomTicManagementSystem.Controller;
using UnicomTicManagementSystem.Data;
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

            DatabaseInitializer.CreateTable();  // <== Add this!
            adminController = new adminController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='Users';", conn);
                var result = cmd.ExecuteScalar();
                if (result == null) ;
            }
        }
        private void t_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string UserCode = t_uname.Text.Trim();
            string password = t_password.Text;

            string validUserCode = "AT010776";
            string validPassword = "1234";

            if (UserCode == validUserCode && password == validPassword)
            {

                //student maintenance = new student();
                //maintenance.Show();
                //this.Hide();
                Select dashboard = new Select();
                dashboard.Show();
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
                credentials.userName = UserCode;
                credentials.password = password;
                var result = adminController.Login(credentials);
                if (result)
                {
                    student maintenance = new student();
                    maintenance.Show();
                    this.Hide();

                    Select dashboard = new Select();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid UserCode or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Optionally clear fields
                    t_uname.Clear();
                    t_uname.Focus();
                }

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
