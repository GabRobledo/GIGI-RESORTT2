
namespace GIGI_RESORTT
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfGuestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resortReservationSystemDataSet7 = new GIGI_RESORTT.ResortReservationSystemDataSet7();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resortReservationSystemDataSet2 = new GIGI_RESORTT.ResortReservationSystemDataSet2();
            this.reservationsTableAdapter = new GIGI_RESORTT.ResortReservationSystemDataSet2TableAdapters.ReservationsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.reservationsTableAdapter1 = new GIGI_RESORTT.ResortReservationSystemDataSet7TableAdapters.ReservationsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.guestNameDataGridViewTextBoxColumn,
            this.checkinDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.numberOfGuestsDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.cellphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "Guest Name";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "Guest Name";
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            // 
            // checkinDateDataGridViewTextBoxColumn
            // 
            this.checkinDateDataGridViewTextBoxColumn.DataPropertyName = "Check-in Date";
            this.checkinDateDataGridViewTextBoxColumn.HeaderText = "Check-in Date";
            this.checkinDateDataGridViewTextBoxColumn.Name = "checkinDateDataGridViewTextBoxColumn";
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "Check-Out Date";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "Check-Out Date";
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // numberOfGuestsDataGridViewTextBoxColumn
            // 
            this.numberOfGuestsDataGridViewTextBoxColumn.DataPropertyName = "Number of Guests";
            this.numberOfGuestsDataGridViewTextBoxColumn.HeaderText = "Number of Guests";
            this.numberOfGuestsDataGridViewTextBoxColumn.Name = "numberOfGuestsDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "Payment Status";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "Payment Status";
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "E-mail Address";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "E-mail Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone#";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone#";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // cellphoneDataGridViewTextBoxColumn
            // 
            this.cellphoneDataGridViewTextBoxColumn.DataPropertyName = "Cellphone#";
            this.cellphoneDataGridViewTextBoxColumn.HeaderText = "Cellphone#";
            this.cellphoneDataGridViewTextBoxColumn.Name = "cellphoneDataGridViewTextBoxColumn";
            // 
            // reservationsBindingSource1
            // 
            this.reservationsBindingSource1.DataMember = "Reservations";
            this.reservationsBindingSource1.DataSource = this.resortReservationSystemDataSet7;
            // 
            // resortReservationSystemDataSet7
            // 
            this.resortReservationSystemDataSet7.DataSetName = "ResortReservationSystemDataSet7";
            this.resortReservationSystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.resortReservationSystemDataSet2;
            // 
            // resortReservationSystemDataSet2
            // 
            this.resortReservationSystemDataSet2.DataSetName = "ResortReservationSystemDataSet2";
            this.resortReservationSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1181, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1074, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reservationsTableAdapter1
            // 
            this.reservationsTableAdapter1.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 573);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "ReservationList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ResortReservationSystemDataSet2 resortReservationSystemDataSet2;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private ResortReservationSystemDataSet2TableAdapters.ReservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private ResortReservationSystemDataSet7 resortReservationSystemDataSet7;
        private System.Windows.Forms.BindingSource reservationsBindingSource1;
        private ResortReservationSystemDataSet7TableAdapters.ReservationsTableAdapter reservationsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfGuestsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}