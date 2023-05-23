
namespace GIGI_RESORTT
{
    partial class AddReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GuestName = new System.Windows.Forms.TextBox();
            this.NumberGuests = new System.Windows.Forms.TextBox();
            this.TotalCost = new System.Windows.Forms.TextBox();
            this.CheckInDate = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.PaymentStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.TelephoneNumber = new System.Windows.Forms.TextBox();
            this.CellphoneNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Roomtype = new System.Windows.Forms.ComboBox();
            this.roomTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resortReservationSystemDataSet6 = new GIGI_RESORTT.ResortReservationSystemDataSet6();
            this.resortReservationSystemDataSet5 = new GIGI_RESORTT.ResortReservationSystemDataSet5();
            this.roomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_TypeTableAdapter = new GIGI_RESORTT.ResortReservationSystemDataSet5TableAdapters.Room_TypeTableAdapter();
            this.room_TypeTableAdapter1 = new GIGI_RESORTT.ResortReservationSystemDataSet6TableAdapters.Room_TypeTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Reservation Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Check-Out Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Room Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of Guests";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(717, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Costs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(705, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Payment Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 69);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuestName
            // 
            this.GuestName.Location = new System.Drawing.Point(27, 87);
            this.GuestName.Name = "GuestName";
            this.GuestName.Size = new System.Drawing.Size(192, 20);
            this.GuestName.TabIndex = 17;
            this.GuestName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NumberGuests
            // 
            this.NumberGuests.Location = new System.Drawing.Point(446, 324);
            this.NumberGuests.Name = "NumberGuests";
            this.NumberGuests.Size = new System.Drawing.Size(100, 20);
            this.NumberGuests.TabIndex = 20;
            this.NumberGuests.TextChanged += new System.EventHandler(this.NumberGuests_TextChanged);
            // 
            // TotalCost
            // 
            this.TotalCost.Location = new System.Drawing.Point(699, 291);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(100, 20);
            this.TotalCost.TabIndex = 23;
            this.TotalCost.TextChanged += new System.EventHandler(this.TotalCost_TextChanged);
            // 
            // CheckInDate
            // 
            this.CheckInDate.Location = new System.Drawing.Point(101, 288);
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.Size = new System.Drawing.Size(200, 20);
            this.CheckInDate.TabIndex = 24;
            this.CheckInDate.ValueChanged += new System.EventHandler(this.CheckInDate_ValueChanged);
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.Location = new System.Drawing.Point(101, 321);
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Size = new System.Drawing.Size(200, 20);
            this.CheckOutDate.TabIndex = 25;
            this.CheckOutDate.ValueChanged += new System.EventHandler(this.CheckOutDate_ValueChanged);
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.FormattingEnabled = true;
            this.PaymentStatus.Items.AddRange(new object[] {
            "Paid ",
            "Unpaid ",
            "Partially Paid"});
            this.PaymentStatus.Location = new System.Drawing.Point(701, 361);
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.Size = new System.Drawing.Size(98, 21);
            this.PaymentStatus.TabIndex = 27;
            this.PaymentStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "1. Personal Information";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(542, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Middle Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(607, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "2. Contact Information";
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(27, 187);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(192, 20);
            this.EmailAddress.TabIndex = 34;
            this.EmailAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.Location = new System.Drawing.Point(288, 187);
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.Size = new System.Drawing.Size(194, 20);
            this.TelephoneNumber.TabIndex = 35;
            // 
            // CellphoneNumber
            // 
            this.CellphoneNumber.Location = new System.Drawing.Point(542, 187);
            this.CellphoneNumber.Name = "CellphoneNumber";
            this.CellphoneNumber.Size = new System.Drawing.Size(177, 20);
            this.CellphoneNumber.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "E-mail Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(353, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Tel. No.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(607, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Phone No.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "3. Accommodation Information";
            // 
            // Roomtype
            // 
            this.Roomtype.DataSource = this.roomTypeBindingSource1;
            this.Roomtype.DisplayMember = "Rooms";
            this.Roomtype.FormattingEnabled = true;
            this.Roomtype.Location = new System.Drawing.Point(446, 291);
            this.Roomtype.Name = "Roomtype";
            this.Roomtype.Size = new System.Drawing.Size(146, 21);
            this.Roomtype.TabIndex = 41;
            this.Roomtype.ValueMember = "Rooms";
            this.Roomtype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // roomTypeBindingSource1
            // 
            this.roomTypeBindingSource1.DataMember = "Room Type";
            this.roomTypeBindingSource1.DataSource = this.resortReservationSystemDataSet6;
            // 
            // resortReservationSystemDataSet6
            // 
            this.resortReservationSystemDataSet6.DataSetName = "ResortReservationSystemDataSet6";
            this.resortReservationSystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resortReservationSystemDataSet5
            // 
            this.resortReservationSystemDataSet5.DataSetName = "ResortReservationSystemDataSet5";
            this.resortReservationSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTypeBindingSource
            // 
            this.roomTypeBindingSource.DataMember = "Room Type";
            this.roomTypeBindingSource.DataSource = this.resortReservationSystemDataSet5;
            // 
            // room_TypeTableAdapter
            // 
            this.room_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // room_TypeTableAdapter1
            // 
            this.room_TypeTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(805, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Roomtype);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CellphoneNumber);
            this.Controls.Add(this.TelephoneNumber);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PaymentStatus);
            this.Controls.Add(this.CheckOutDate);
            this.Controls.Add(this.CheckInDate);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.NumberGuests);
            this.Controls.Add(this.GuestName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddReservation";
            this.Text = "Add Reservation";
            this.Load += new System.EventHandler(this.AddReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GuestName;
        private System.Windows.Forms.TextBox NumberGuests;
        private System.Windows.Forms.TextBox TotalCost;
        private System.Windows.Forms.DateTimePicker CheckInDate;
        private System.Windows.Forms.DateTimePicker CheckOutDate;
        private System.Windows.Forms.ComboBox PaymentStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.TextBox TelephoneNumber;
        private System.Windows.Forms.TextBox CellphoneNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox Roomtype;
        private ResortReservationSystemDataSet5 resortReservationSystemDataSet5;
        private System.Windows.Forms.BindingSource roomTypeBindingSource;
        private ResortReservationSystemDataSet5TableAdapters.Room_TypeTableAdapter room_TypeTableAdapter;
        private ResortReservationSystemDataSet6 resortReservationSystemDataSet6;
        private System.Windows.Forms.BindingSource roomTypeBindingSource1;
        private ResortReservationSystemDataSet6TableAdapters.Room_TypeTableAdapter room_TypeTableAdapter1;
        private System.Windows.Forms.Button button2;
    }
}