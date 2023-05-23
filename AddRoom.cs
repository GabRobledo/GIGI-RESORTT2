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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            RoomType[] roomTypes = new RoomType[]
            {
    new RoomType("Fan Room (6 pax)", 1750),
    new RoomType("Fan Room (8 pax)", 2500),
    new RoomType("Bahay Kubo (10 pax)", 3000),
    new RoomType("Kamalig (12 pax)", 3700),
    new RoomType("Aircon Room (2 pax)", 2500),
    new RoomType("Aircon Room (8 pax)", 3500),
    new RoomType("Aircon Room w/ CR (2 pax)", 3000)
            };
            Roomtype.DataSource = roomTypes;
        }

        public class RoomType
        {
            public string Name { get; set; }
            public double CostPerDay { get; set; }

            public RoomType(string name, double costPerDay)
            {
                Name = name;
                CostPerDay = costPerDay;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string roomId = this.RoomId.Text;
            string roomType = Roomtype.Text;
            string roomNumber = RoomNumber.Text;
            string pax = Pax.Text;
            string price = Price.Text;
            string inclusions = Inclusions.Text;
            string roomStatus = RoomStatus.SelectedItem != null ? RoomStatus.SelectedItem.ToString() : null;
            // Insert the values into the database
            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            OleDbConnection connection = new OleDbConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected");

                string query = "INSERT INTO Rooms ([Room Name], [Room Number], [Pax], [Price], [Inclusions], [Room Status]) VALUES (@RoomType, @RoomNumber, @Pax, @Price, @Inclusions, @RoomStatus)";
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@RoomType", roomType);
                command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                command.Parameters.AddWithValue("@Pax", pax);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Inclusions", inclusions);
                command.Parameters.AddWithValue("@RoomStatus", roomStatus);

                if (roomStatus == null)
                {
                    MessageBox.Show("Please Fill in Room Status", "Missing Room Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                command.ExecuteNonQuery();

                MessageBox.Show("Room added successfully!");
             


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error adding room: " + ex.Message);
            }
            finally
            {
                connection.Close();

            }

            // Close the form
            this.Close();

        }

        private void RoomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inclusions_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

