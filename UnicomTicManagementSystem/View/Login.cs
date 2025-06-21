using System.Data.SQLite;
using System.Net;
using System.Xml.Linq;
using UnicomTicManagementSystem.Controller;
using UnicomTicManagementSystem.Data;
using UnicomTicManagementSystem.Method;
using UnicomTicManagementSystem.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

            //string validUserCode = "AT010776";
            //string validPassword = "1234";
            //string validRole = "Admin";

            //if (UserCode == validUserCode && password == validPassword)
            //{
            //    new Select().Show();
            //    this.Hide();
            //    return;
            //}

            Credentials credentials = new Credentials
            {
                userName = UserCode,
                password = password
            };

            bool isLoggedIn = adminController.Login(credentials);
            if (isLoggedIn && Session.LoggedInUser != null)
            {
                if (string.IsNullOrEmpty(Session.LoggedInUser.Role))
                {
                    MessageBox.Show("User role is missing. Cannot continue.");
                    return;
                }

                switch (Session.LoggedInUser.Role.ToLower())
                {
                    case "admin":
                       
                        new DashBoard().Show();
                        this.Hide();
                        break;
                    case "staff":
                      
                        new DashBoard().Show();
                        this.Hide();
                        break;
                    case "student":
                       
                        new DashBoard().Show();
                      
                        this.Hide();
                        break;
                    case "lecture":    
                        new DashBoard().Show();
                       
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Unknown role.");
                        return;
                }


                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserCode or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t_uname.Clear();
                t_uname.Focus();
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
