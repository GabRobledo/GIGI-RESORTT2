using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 ReservationList = new Form5();
            ReservationList.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 GuesList = new Form1();
            GuesList.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 ReservationList = new Form5();
            ReservationList.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 GuesList = new Form1();
            GuesList.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 AvailableRooms = new Form8();
            AvailableRooms.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 AvailableRooms = new Form8();
            AvailableRooms.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 ResortPackages = new Form6();
            ResortPackages.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 ResortPackages = new Form6();
            ResortPackages.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoomList RoomList = new RoomList();
            RoomList.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RoomList RoomList = new RoomList();
            RoomList.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reports form7 = new Reports();
            form7.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text += " " + DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = "" + DateTime.Now.ToLongTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
    }
}
