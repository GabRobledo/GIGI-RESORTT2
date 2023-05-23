
using System;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    partial class Form1
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
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfGuestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resortReservationSystemDataSet9 = new GIGI_RESORTT.ResortReservationSystemDataSet9();
            this.guests_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resortReservationSystemDataSet = new GIGI_RESORTT.ResortReservationSystemDataSet();
            this.guests_tableTableAdapter = new GIGI_RESORTT.ResortReservationSystemDataSetTableAdapters.Guests_tableTableAdapter();
            this.tableAdapterManager = new GIGI_RESORTT.ResortReservationSystemDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.resortReservationSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guestTableAdapter = new GIGI_RESORTT.ResortReservationSystemDataSet9TableAdapters.GuestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guests_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guestNameDataGridViewTextBoxColumn,
            this.checkInDataGridViewTextBoxColumn,
            this.checkOutDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.numberOfGuestsDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.guestBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(-7, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(853, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "Guest Name";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "Guest Name";
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            this.checkInDataGridViewTextBoxColumn.DataPropertyName = "Check-In";
            this.checkInDataGridViewTextBoxColumn.HeaderText = "Check-In";
            this.checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            this.checkOutDataGridViewTextBoxColumn.DataPropertyName = "Check-Out";
            this.checkOutDataGridViewTextBoxColumn.HeaderText = "Check-Out";
            this.checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // numberOfGuestsDataGridViewTextBoxColumn
            // 
            this.numberOfGuestsDataGridViewTextBoxColumn.DataPropertyName = "Number of Guest/s";
            this.numberOfGuestsDataGridViewTextBoxColumn.HeaderText = "Number of Guest/s";
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
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.resortReservationSystemDataSet9;
            // 
            // resortReservationSystemDataSet9
            // 
            this.resortReservationSystemDataSet9.DataSetName = "ResortReservationSystemDataSet9";
            this.resortReservationSystemDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guests_tableBindingSource
            // 
            this.guests_tableBindingSource.DataMember = "Guests table";
            this.guests_tableBindingSource.DataSource = this.resortReservationSystemDataSet;
            // 
            // resortReservationSystemDataSet
            // 
            this.resortReservationSystemDataSet.DataSetName = "ResortReservationSystemDataSet";
            this.resortReservationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guests_tableTableAdapter
            // 
            this.guests_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Guests_tableTableAdapter = this.guests_tableTableAdapter;
            this.tableAdapterManager.Reservations_tableTableAdapter = null;
            this.tableAdapterManager.Rooms_tableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GIGI_RESORTT.ResortReservationSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Guest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resortReservationSystemDataSetBindingSource
            // 
            this.resortReservationSystemDataSetBindingSource.DataSource = this.resortReservationSystemDataSet;
            this.resortReservationSystemDataSetBindingSource.Position = 0;
            // 
            // guestsTableBindingSource
            // 
            this.guestsTableBindingSource.DataMember = "Guests table";
            this.guestsTableBindingSource.DataSource = this.resortReservationSystemDataSetBindingSource;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 348);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "GuestList";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guests_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Console.WriteLine("Works");
            System.Console.WriteLine(this.dataGridView1.SelectedCells);
            System.Console.WriteLine(e.ColumnIndex);
            System.Console.WriteLine(e.RowIndex);
            System.Console.WriteLine(e);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.RowIndex == 0 && dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                dataGridView1.CurrentCell = null;
            }
        }


        #endregion
        private ResortReservationSystemDataSet resortReservationSystemDataSet;
        private ResortReservationSystemDataSetTableAdapters.Guests_tableTableAdapter guests_tableTableAdapter;
        private ResortReservationSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource guests_tableBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource resortReservationSystemDataSetBindingSource;
        private System.Windows.Forms.BindingSource guestsTableBindingSource;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridView1;
        private Timer timer2;
        private Button button2;
        private TextBox textBox1;
        private ResortReservationSystemDataSet9 resortReservationSystemDataSet9;
        private BindingSource guestBindingSource;
        private ResortReservationSystemDataSet9TableAdapters.GuestTableAdapter guestTableAdapter;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfGuestsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
    }
}