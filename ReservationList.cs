using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            dataGridView1.CurrentCell = null;
        }

        private DataTable LoadDataFromDatabase()
        {
            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            OleDbConnection connection = new OleDbConnection(connectionString);


            try
            {
                connection.Open();
                Console.WriteLine("Connected");
                OleDbCommand command = new OleDbCommand("SELECT * FROM Reservations", connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resortReservationSystemDataSet7.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter1.Fill(this.resortReservationSystemDataSet7.Reservations);
            // This line of code loads data into the 'resortReservationSystemDataSet2.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.resortReservationSystemDataSet2.Reservations);

            // Allow user to edit cells
            dataGridView1.ReadOnly = false;

            // Set the data source for the DataGridView
            dataGridView1.DataSource = LoadDataFromDatabase();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ClearSelection();

            // Start a timer to update the DataGridView
            var timer = new Timer();
            timer.Interval = 5000; // 5 seconds
            timer.Tick += timer1_Tick;
            timer.Start();

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
         
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {         
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var addReservation = new AddReservation();
            addReservation.Show();
        }

        public void UpdateData()
        {
            dataGridView1.DataSource = LoadDataFromDatabase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Get the value of the ID column in the selected row
                int reservationId = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                // Create a connection to the database
                string fileName = "ResortReservationSystem.mdb";
                string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
                OleDbConnection connection = new OleDbConnection(connectionString);


                try
                {
                    connection.Open();
                    Console.WriteLine("Connected");

                    // Create a SQL DELETE command to remove the row from the Reservations table
                    OleDbCommand command = new OleDbCommand("DELETE FROM Reservations WHERE ID = @ID", connection);
                    command.Parameters.AddWithValue("@ID", reservationId);
                    command.ExecuteNonQuery();

                    // Refresh the DataGridView to show the updated data
                    dataGridView1.DataSource = LoadDataFromDatabase();

                    MessageBox.Show("Reservation deleted successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        dataGridView1.CurrentCell = cell;
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;        
            // Save the currently selected row (if any) to restore it later
            var selectedRow = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0] : null;

            // Update the DataGridView's data source here...

            // Restore the selected row (if any) without selecting the first row
            if (selectedRow != null)
            {
                dataGridView1.ClearSelection();
                if (selectedRow.Index < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[selectedRow.Index].Selected = true;
                    dataGridView1.DataSource = LoadDataFromDatabase();
                }
                else if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                }
            }
            else
            {
                dataGridView1.ClearSelection();
            }
        }
    }

}


