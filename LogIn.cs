using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GIGI_RESORTT
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            // Create a new OleDbConnection object using the connection string
            OleDbConnection connection = new OleDbConnection(connectionString);

            // Open the connection
            connection.Open();

            // Declare a SQL query to check if the username and password are correct
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

            // Create a new OleDbCommand object using the query and the connection
            OleDbCommand command = new OleDbCommand(query, connection);

            // Add parameters to the command to replace the @Username and @Password placeholders with the actual values
            command.Parameters.AddWithValue("@Username", Username.Text);
            command.Parameters.AddWithValue("@Password", Password.Text);

            // Execute the query and store the result in a variable
            int count = (int)command.ExecuteScalar();

            // Close the connection
            connection.Close();

            // Check if the count is greater than zero, which means the username and password are correct
            if (count > 0)
            {
                // Open a new form to represent the user's session
                Dashboard form7 = new Dashboard();
                form7.Show();


                // Close the login form
                //this.Close();
            }
            else
            {
                // Display an error message to the user
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
