
namespace GIGI_RESORTT
{
    partial class AddRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomNumber = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Pax = new System.Windows.Forms.TextBox();
            this.Inclusions = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RoomStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Roomtype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Room Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inclusions";
            // 
            // RoomNumber
            // 
            this.RoomNumber.Location = new System.Drawing.Point(163, 96);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Size = new System.Drawing.Size(100, 20);
            this.RoomNumber.TabIndex = 4;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(30, 141);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 6;
            // 
            // Pax
            // 
            this.Pax.Location = new System.Drawing.Point(163, 141);
            this.Pax.Name = "Pax";
            this.Pax.Size = new System.Drawing.Size(100, 20);
            this.Pax.TabIndex = 7;
            // 
            // Inclusions
            // 
            this.Inclusions.Location = new System.Drawing.Point(30, 226);
            this.Inclusions.Name = "Inclusions";
            this.Inclusions.Size = new System.Drawing.Size(422, 60);
            this.Inclusions.TabIndex = 9;
            this.Inclusions.Text = "";
            this.Inclusions.TextChanged += new System.EventHandler(this.Inclusions_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RoomStatus
            // 
            this.RoomStatus.FormattingEnabled = true;
            this.RoomStatus.Items.AddRange(new object[] {
            "Available ",
            "Unavailable"});
            this.RoomStatus.Location = new System.Drawing.Point(295, 141);
            this.RoomStatus.Name = "RoomStatus";
            this.RoomStatus.Size = new System.Drawing.Size(100, 21);
            this.RoomStatus.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Room Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Status";
            // 
            // Roomtype
            // 
            this.Roomtype.FormattingEnabled = true;
            this.Roomtype.Location = new System.Drawing.Point(30, 96);
            this.Roomtype.Name = "Roomtype";
            this.Roomtype.Size = new System.Drawing.Size(100, 21);
            this.Roomtype.TabIndex = 19;
            this.Roomtype.SelectedIndexChanged += new System.EventHandler(this.RoomType_SelectedIndexChanged);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Roomtype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RoomStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Inclusions);
            this.Controls.Add(this.Pax);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRoom";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoomNumber;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Pax;
        private System.Windows.Forms.RichTextBox Inclusions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox RoomStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Roomtype;
    }
}