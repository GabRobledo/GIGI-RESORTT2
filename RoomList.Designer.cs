
namespace GIGI_RESORTT
{
    partial class RoomList
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resortReservationSystemDataSet3 = new GIGI_RESORTT.ResortReservationSystemDataSet3();
            this.button2 = new System.Windows.Forms.Button();
            this.resortReservationSystemDataSet1 = new GIGI_RESORTT.ResortReservationSystemDataSet1();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new GIGI_RESORTT.ResortReservationSystemDataSet1TableAdapters.RoomsTableAdapter();
            this.roomsTableAdapter1 = new GIGI_RESORTT.ResortReservationSystemDataSet3TableAdapters.RoomsTableAdapter();
            this.resortReservationSystemDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inclusionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room/Cottage List";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.resortReservationSystemDataSet3;
            // 
            // resortReservationSystemDataSet3
            // 
            this.resortReservationSystemDataSet3.DataSetName = "ResortReservationSystemDataSet3";
            this.resortReservationSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Room";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resortReservationSystemDataSet1
            // 
            this.resortReservationSystemDataSet1.DataSetName = "ResortReservationSystemDataSet1";
            this.resortReservationSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.resortReservationSystemDataSet1;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter1
            // 
            this.roomsTableAdapter1.ClearBeforeFill = true;
            // 
            // resortReservationSystemDataSet3BindingSource
            // 
            this.resortReservationSystemDataSet3BindingSource.DataSource = this.resortReservationSystemDataSet3;
            this.resortReservationSystemDataSet3BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.paxDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.inclusionsDataGridViewTextBoxColumn,
            this.roomStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 268);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "Room Name";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "Room Name";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // paxDataGridViewTextBoxColumn
            // 
            this.paxDataGridViewTextBoxColumn.DataPropertyName = "Pax";
            this.paxDataGridViewTextBoxColumn.HeaderText = "Pax";
            this.paxDataGridViewTextBoxColumn.Name = "paxDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // inclusionsDataGridViewTextBoxColumn
            // 
            this.inclusionsDataGridViewTextBoxColumn.DataPropertyName = "Inclusions";
            this.inclusionsDataGridViewTextBoxColumn.HeaderText = "Inclusions";
            this.inclusionsDataGridViewTextBoxColumn.Name = "inclusionsDataGridViewTextBoxColumn";
            // 
            // roomStatusDataGridViewTextBoxColumn
            // 
            this.roomStatusDataGridViewTextBoxColumn.DataPropertyName = "Room Status";
            this.roomStatusDataGridViewTextBoxColumn.HeaderText = "Room Status";
            this.roomStatusDataGridViewTextBoxColumn.Name = "roomStatusDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Search Room List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "RoomList";
            this.Text = "Room List";
            this.Load += new System.EventHandler(this.RoomList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private ResortReservationSystemDataSet1 resortReservationSystemDataSet1;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private ResortReservationSystemDataSet1TableAdapters.RoomsTableAdapter roomsTableAdapter;
        private ResortReservationSystemDataSet3 resortReservationSystemDataSet3;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private ResortReservationSystemDataSet3TableAdapters.RoomsTableAdapter roomsTableAdapter1;
        private System.Windows.Forms.BindingSource resortReservationSystemDataSet3BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inclusionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}