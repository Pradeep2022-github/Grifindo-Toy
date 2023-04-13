using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grifindo_Toy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool IsValidUser(string username, string password)
        { // Create a database connection
            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kithm\Documents\Griffindo_Payroll.mdf; Integrated Security = True; Connect Timeout = 30"))
            {
                // Open the connection
                connection.Open();
                // Create a SQL command to retrieve the user with the given username and password
                SqlCommand command = new SqlCommand("SELECT * FROM UserTB WHERE[User Name] = @Username AND Password = @Password", connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                // Execute the SQL command and retrieve the results
                SqlDataReader reader = command.ExecuteReader();
                // Check if a row was returned
                bool result = reader.HasRows;
                // Close the reader and return the result
                reader.Close();
                return result;
            }
        }
        private void Logbtn_Click(object sender, EventArgs e)
        {
            string Username = User.Text;
            string Password = PasswWd.Text;
            // Check the entered credentials against the database
            if (IsValidUser(Username, Password))
            {
                // Hide the login form
                this.Hide();
                // Show the home page form
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.Please try again.");
            }
        }

    }
}
