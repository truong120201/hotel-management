using WinFormsApp;

namespace hotel_management
{
    public partial class Login : Form
    {
        private string username;
        private string password;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void Login_Button(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                error_label.Visible = true;
                return;
            }
            else
            {
                var isValid = this.login_database();
                if (isValid)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.StartPosition = FormStartPosition.CenterScreen;
                    dashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!");
                }
            }
        }

        private void Exit_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_text_box_change(object sender, EventArgs e)
        {
            this.username = username_text_box.Text;
            if (error_label.Visible == true)
            {
                error_label.Visible = false;
            }
        }

        private void password_text_box_change(object sender, EventArgs e)
        {
            this.password = password_text_box.Text;
            if (error_label.Visible == true)
            {
                error_label.Visible = false;
            }
        }

        private bool login_database()
        {
            try
            {
                string query = "SELECT * FROM admin WHERE user_name = @username AND password = @password";
                var result = DB_Connection.ExecuteParameterizedQuery(query, new Dictionary<string, string> { { "@username", username }, { "@password", password } });

                if (result.HasRows)
                {
                    result.Close();
                    return true;
                }
                else
                {
                    result.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
                return false;
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            password_text_box.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }
    }
}