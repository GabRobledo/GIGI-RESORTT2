using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class RoomList : Form
    {
        public RoomList()
        {
            InitializeComponent();
        }

        private void RoomList_Load(object sender, EventArgs e)
        {
            DataTable dataTable = LoadDataFromDatabase();
            dataGridView1.DataSource = dataTable;
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
                OleDbCommand command = new OleDbCommand("SELECT * FROM Rooms", connection);
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

        private void button2_Click(object sender, EventArgs e)
        {
            AddRoom AddRoom = new AddRoom();
            AddRoom.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false; // Disable the timer temporarily to prevent re-entry

            // Save the currently selected row (if any) to restore it later
            int selectedRowIndex = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Index : -1;

            // Update the DataGridView's data source here...
            dataGridView1.DataSource = LoadDataFromDatabase();

            // Restore the selected row (if any) without selecting the first row
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
            {
                dataGridView1.Rows[selectedRowIndex].Selected = true;
            }
            else
            {
                dataGridView1.ClearSelection();
            }

            timer1.Enabled = true; // Re-enable the timer
        }
        }
    }
