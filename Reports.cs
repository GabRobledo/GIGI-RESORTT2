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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //Create a connection to your Microsoft Access database using ADO.NET
            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            OleDbConnection connection = new OleDbConnection(connectionString);


            //Write a query to retrieve the data you want to display in the chart
            string query = "SELECT [Check-In], ID FROM Guest";

            //Use a DataAdapter to fill a DataTable with the results of your query
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            //Set the chart's DataSource property to the DataTable you created
            chart1.DataSource = dataTable;
            //chart2.DataSource = dataTable;

            //Set the chart's X and Y values to the appropriate columns in the DataTable
            chart1.Series[0].XValueMember = "Check-In";
            chart1.Series[0].YValueMembers = "ID";

            //chart2.Series[0].XValueMember = "Day";
            //chart2.Series[0].YValueMembers = "Costumers";


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
