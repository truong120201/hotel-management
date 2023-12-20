namespace hotel_management
{
    partial class Room_Status
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            room_id = new DataGridViewTextBoxColumn();
            customer_id = new DataGridViewTextBoxColumn();
            booking_id = new DataGridViewTextBoxColumn();
            booking_status = new DataGridViewTextBoxColumn();
            checkin_date = new DataGridViewTextBoxColumn();
            checkout_date = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 37);
            button1.Name = "button1";
            button1.Size = new Size(228, 41);
            button1.TabIndex = 0;
            button1.Text = "Back to HomePage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { room_id, customer_id, booking_id, booking_status, checkin_date, checkout_date });
            dataGridView1.Location = new Point(22, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(757, 390);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // room_id
            // 
            room_id.HeaderText = "Room ID";
            room_id.Name = "room_id";
            // 
            // customer_id
            // 
            customer_id.HeaderText = "Customer id";
            customer_id.Name = "customer_id";
            // 
            // booking_id
            // 
            booking_id.HeaderText = "Booking ID";
            booking_id.Name = "booking_id";
            // 
            // booking_status
            // 
            booking_status.HeaderText = "Status";
            booking_status.Name = "booking_status";
            // 
            // checkin_date
            // 
            checkin_date.HeaderText = "Check In Date";
            checkin_date.Name = "checkin_date";
            // 
            // checkout_date
            // 
            checkout_date.HeaderText = "Check Out Date";
            checkout_date.Name = "checkout_date";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 143);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Room ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(981, 196);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(851, 273);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 4;
            label3.Text = "Selected Booking ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(851, 302);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(851, 320);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(187, 23);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(851, 365);
            button2.Name = "button2";
            button2.Size = new Size(187, 29);
            button2.TabIndex = 6;
            button2.Text = "Checkout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(851, 415);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 7;
            label5.Text = "total amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(851, 439);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 7;
            label6.Text = "check in date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(851, 466);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 7;
            label7.Text = "check out date";
            // 
            // Room_Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 627);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Room_Status";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn room_id;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn booking_id;
        private DataGridViewTextBoxColumn booking_status;
        private DataGridViewTextBoxColumn checkin_date;
        private DataGridViewTextBoxColumn checkout_date;
    }
}