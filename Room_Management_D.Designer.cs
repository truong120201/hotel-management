namespace hotel_management
{
    partial class Room_Management_D
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
            room_type_management = new Button();
            label1 = new Label();
            filter_room_type = new ComboBox();
            label2 = new Label();
            back_to_dashboard = new Button();
            room_list = new DataGridView();
            room_id = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)room_list).BeginInit();
            SuspendLayout();
            // 
            // room_type_management
            // 
            room_type_management.Location = new Point(948, 93);
            room_type_management.Name = "room_type_management";
            room_type_management.Size = new Size(162, 35);
            room_type_management.TabIndex = 0;
            room_type_management.Text = "Room Type Management";
            room_type_management.UseVisualStyleBackColor = true;
            room_type_management.Click += room_type_management_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Filter";
            // 
            // filter_room_type
            // 
            filter_room_type.DropDownStyle = ComboBoxStyle.DropDownList;
            filter_room_type.FormattingEnabled = true;
            filter_room_type.Location = new Point(12, 121);
            filter_room_type.Name = "filter_room_type";
            filter_room_type.Size = new Size(149, 23);
            filter_room_type.TabIndex = 3;
            filter_room_type.SelectedIndexChanged += filter_room_type_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Type";
            // 
            // back_to_dashboard
            // 
            back_to_dashboard.Location = new Point(21, 12);
            back_to_dashboard.Name = "back_to_dashboard";
            back_to_dashboard.Size = new Size(181, 36);
            back_to_dashboard.TabIndex = 5;
            back_to_dashboard.Text = "Back to Dashboard";
            back_to_dashboard.UseVisualStyleBackColor = true;
            back_to_dashboard.Click += back_to_dashboard_Click;
            // 
            // room_list
            // 
            room_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            room_list.Columns.AddRange(new DataGridViewColumn[] { room_id, price, type });
            room_list.Location = new Point(12, 181);
            room_list.Name = "room_list";
            room_list.RowTemplate.Height = 25;
            room_list.Size = new Size(552, 359);
            room_list.TabIndex = 6;
            room_list.CellContentClick += room_list_CellContentClick;
            // 
            // room_id
            // 
            room_id.HeaderText = "RoomID";
            room_id.Name = "room_id";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            // 
            // type
            // 
            type.HeaderText = "Type";
            type.Name = "type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(729, 252);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 8;
            label4.Text = "CREATE NEW ROOM";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(729, 301);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 9;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(729, 283);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 8;
            label5.Text = "Room ID";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(729, 336);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 8;
            label6.Text = "Room Type";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(729, 354);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 23);
            comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(729, 398);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 10;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(921, 398);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 10;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Room_Management_D
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 552);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(room_list);
            Controls.Add(back_to_dashboard);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(filter_room_type);
            Controls.Add(label1);
            Controls.Add(room_type_management);
            Name = "Room_Management_D";
            Text = "Room Management D";
            Load += Room_Management_D_Load;
            ((System.ComponentModel.ISupportInitialize)room_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button room_type_management;
        private Label label1;
        private ComboBox filter_room_type;
        private Label label2;
        private Button back_to_dashboard;
        private DataGridView room_list;
        private DataGridViewTextBoxColumn room_id;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn type;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}