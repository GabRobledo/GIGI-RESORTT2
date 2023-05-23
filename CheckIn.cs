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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void CheckIn_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string guestName = GuestName.Text;
            string roomType = Roomtype.Text;
            string numberGuests = NumberGuests.Text;
            string emailAddress = EmailAddress.Text;
            string telephoneNumber = TelephoneNumber.Text;
            string cellphoneNumber = CellphoneNumber.Text;
            DateTime checkInDate = CheckInDate.Value;
            DateTime checkOutDate = CheckOutDate.Value;
            string paymentStatus = PaymentStatus.SelectedItem != null ? PaymentStatus.SelectedItem.ToString() : null;
            string totalCost = TotalCost.Text;

            // Insert the values into the database
            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            OleDbConnection connection = new OleDbConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected");

                string query = "INSERT INTO Guest ([Guest Name], [Check-in], [Check-Out], [Room Type], [Number of Guest/s], [Total Cost], [Payment Status], [Telephone Number], [Cellphone Number], [E-mail Address]) " +
                    "VALUES (@GuestName, @CheckInDate, @CheckOutDate, @RoomType, @NumberGuests, @TotalCost, @PaymentStatus, @Telephone, @Cellphone, @EmailAddress)";
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@GuestName", guestName);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                command.Parameters.AddWithValue("@RoomType", roomType);
                command.Parameters.AddWithValue("@NumberGuests", numberGuests);
                command.Parameters.AddWithValue("@TotalCost", totalCost);
                command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                command.Parameters.AddWithValue("@Telephone", telephoneNumber);
                command.Parameters.AddWithValue("@Cellphone", cellphoneNumber);
                command.Parameters.AddWithValue("@EmailAddress", emailAddress);


                if (paymentStatus == null)
                {
                    MessageBox.Show("Please Fill in Payment Status", "Missing Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                command.ExecuteNonQuery();

                MessageBox.Show("Guest added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error adding Guest: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CheckInDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("yyyy-MM-dd");
            Console.WriteLine(formattedDateTime);
        }

        private void CheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("yyyy-MM-dd");
            Console.WriteLine(formattedDateTime);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime checkInDate = CheckInDate.Value;
            DateTime checkOutDate = CheckOutDate.Value;

            // Calculate the number of days between the check-in and check-out dates
            TimeSpan span = checkOutDate - checkInDate;
            int totalHours = (int)Math.Ceiling(span.TotalHours);
            int days = (int)Math.Ceiling(span.TotalDays);

            RoomType roomType = (RoomType)Roomtype.SelectedItem;
            double costPerDay = roomType.CostPerDay;

            // Calculate the total cost based on the number of days and the cost per day
            double totalCost = days * costPerDay;

            // Check if there are additional hours beyond the whole days
            if (totalHours > (days * 24))
            {
                // Add 300 for each additional hour
                int extraHours = totalHours - (days * 24);
                totalCost += extraHours * 300;
            }

            TotalCost.Text = $"{totalCost:C}";


        }

        private void CellphoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
