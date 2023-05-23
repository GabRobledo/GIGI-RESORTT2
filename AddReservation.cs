using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values entered by the user
            string guestName = GuestName.Text;
            string roomType = Roomtype.Text;
            string NumberGuest = NumberGuests.Text;
            string emailAddress = EmailAddress.Text;
            string telephoneNumber = TelephoneNumber.Text;
            string cellphoneNumber = CellphoneNumber.Text;
            DateTime checkInDate = CheckInDate.Value;
            DateTime checkOutDate = CheckOutDate.Value;
            string paymentStatus = PaymentStatus.SelectedItem != null ? PaymentStatus.SelectedItem.ToString() : null;
            string totalcost = TotalCost.Text;

            // Insert the values into the database
            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            OleDbConnection connection = new OleDbConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected");

                string query = "INSERT INTO Reservations ([Guest Name], [E-mail Address], [Telephone#], [Cellphone#], [Check-In Date], [Check-Out Date], [Room Type], [Number of Guests], [Total Cost], [Payment Status]) VALUES (@GuestName, @EmailAddress, @TelephoneNumber, @CellphoneNumber, @CheckInDate, @CheckOutDate, @RoomType, @NumberGuests, @TotalCost, @PaymentStatus)";
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@GuestName", guestName);
                command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                command.Parameters.AddWithValue("@TelephoneNumber", telephoneNumber);
                command.Parameters.AddWithValue("@CellphoneNumber", cellphoneNumber);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                command.Parameters.AddWithValue("@RoomType", roomType);
                command.Parameters.AddWithValue("@NumberGuest", NumberGuest);
                command.Parameters.AddWithValue("@TotalCost", totalcost);
                command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);


                if (paymentStatus == null)
                {
                    MessageBox.Show("Please Fill in Payment Status", "Missing Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                command.ExecuteNonQuery();

                MessageBox.Show("Reservation saved successfully!");

                Form5 form = (Form5)Application.OpenForms["ReservationList"];
                if (form != null)
                {
                    form.UpdateData();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error adding reservation: " + ex.Message);
            }
            finally
            {
                connection.Close();

            }          

            // Close the form
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GuestName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void RoomType_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddReservation_Load(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumberGuests_TextChanged(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomType_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime checkInDate = CheckInDate.Value;
            DateTime checkOutDate = CheckOutDate.Value;

            // Calculate the number of days between the check-in and check-out dates
            TimeSpan span = checkOutDate - checkInDate;
            int days = span.Days;

            RoomType roomType = (RoomType)Roomtype.SelectedItem;
            double costPerDay = roomType.CostPerDay;

            double totalCost = days * costPerDay;
            TotalCost.Text = $"{totalCost:C}";
        }

        private void TotalCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
