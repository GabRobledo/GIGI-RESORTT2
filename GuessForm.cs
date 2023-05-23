using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class GuessForm : Form
    {

        //public event EventHandler SubmitClicked;
        public GuessForm()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

            // Submit_Click(sender, e);
            // Raise the SubmitClicked event to notify the parent form that the submit button has been clicked
            //SubmitClicked?.Invoke(this, EventArgs.Empty);

            string id = this.IdText.Text;
            string name = this.NameText.Text;
            string address = this.AddressText.Text;
            string phone = this.PhoneText.Text;
            string email = this.EmailText.Text;

            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            OleDbConnection connection = new OleDbConnection(connectionString);

            try
            {
                connection.Open();

                System.Console.WriteLine("connected");

                OleDbCommand command = new OleDbCommand("INSERT INTO Guest (Name, Address, Phone, Email) VALUES (?, ?, ?, ?)", connection);


                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Email", email);

                // Execute the INSERT statement
                command.ExecuteNonQuery();

                // Display a success message
                MessageBox.Show("Data saved successfully!");








                // Connection opened successfully
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                // Handle exception here
            }
            finally
            {
                connection.Close();
            }

            System.Console.WriteLine(address);
            // Close the form
            this.Close();


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuessForm_Load(object sender, EventArgs e)
        {

        }

        private void PhoneText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
