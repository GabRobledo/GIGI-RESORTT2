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
    public partial class Form8 : Form
    {       
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resortReservationSystemDataSet8.Available_Rooms' table. You can move, or remove it, as needed.
            this.available_RoomsTableAdapter1.Fill(this.resortReservationSystemDataSet8.Available_Rooms);
            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            OleDbConnection connection = new OleDbConnection(connectionString);

            string query = "SELECT * FROM Rooms WHERE [Room Status] = 'Available'";

            // Create the data adapter and fill the data table
            dataAdapter = new OleDbDataAdapter(query, connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Bind the data table to the DataGridView
            dataGridView1.DataSource = dataTable;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckIn CheckIn = new CheckIn();
            CheckIn.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
