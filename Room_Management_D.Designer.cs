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
            listView1 = new ListView();
            label1 = new Label();
            filter_room_type = new ComboBox();
            label2 = new Label();
            filter_room_status = new ComboBox();
            label3 = new Label();
            back_to_dashboard = new Button();
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
            // listView1
            // 
            listView1.Location = new Point(12, 181);
            listView1.Name = "listView1";
            listView1.Size = new Size(1098, 359);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
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
            filter_room_type.Items.AddRange(new object[] { "All", "Normal", "Advance", "VIP" });
            filter_room_type.Location = new Point(12, 121);
            filter_room_type.Name = "filter_room_type";
            filter_room_type.Size = new Size(149, 23);
            filter_room_type.TabIndex = 3;
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
            // filter_room_status
            // 
            filter_room_status.DropDownStyle = ComboBoxStyle.DropDownList;
            filter_room_status.FormattingEnabled = true;
            filter_room_status.Items.AddRange(new object[] { "All", "Available", "Booked" });
            filter_room_status.Location = new Point(236, 121);
            filter_room_status.Name = "filter_room_status";
            filter_room_status.Size = new Size(149, 23);
            filter_room_status.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 103);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Status";
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
            // Room_Management_D
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 552);
            Controls.Add(back_to_dashboard);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(filter_room_status);
            Controls.Add(filter_room_type);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(room_type_management);
            Name = "Room_Management_D";
            Text = "Room Management D";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button room_type_management;
        private ListView listView1;
        private Label label1;
        private ComboBox filter_room_type;
        private Label label2;
        private ComboBox filter_room_status;
        private Label label3;
        private Button back_to_dashboard;
    }
}