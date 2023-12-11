using System.Diagnostics;

namespace hotel_management
{
    partial class Room_Type_Management
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
            room_type_view = new DataGridView();
            room_type_id = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            add_on = new DataGridViewTextBoxColumn();
            room_type_info_label = new Label();
            textBox_room_type = new TextBox();
            label_room_type = new Label();
            textBox_room_price = new TextBox();
            label1 = new Label();
            textBox_room_add_on = new TextBox();
            label2 = new Label();
            button_cancel = new Button();
            button_save_room = new Button();
            back_to_room_management = new Button();
            create_room_type_noti = new Label();
            ((System.ComponentModel.ISupportInitialize)room_type_view).BeginInit();
            SuspendLayout();
            // 
            // room_type_view
            // 
            room_type_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            room_type_view.Columns.AddRange(new DataGridViewColumn[] { room_type_id, type, price, add_on });
            room_type_view.Location = new Point(38, 139);
            room_type_view.Name = "room_type_view";
            room_type_view.RowTemplate.Height = 25;
            room_type_view.Size = new Size(647, 378);
            room_type_view.TabIndex = 0;
            room_type_view.CellContentClick += room_type_view_CellContentClick;
            // 
            // room_type_id
            // 
            room_type_id.HeaderText = "Room ID";
            room_type_id.Name = "room_type_id";
            // 
            // type
            // 
            type.HeaderText = "Type";
            type.Name = "type";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            // 
            // add_on
            // 
            add_on.HeaderText = "Add on";
            add_on.Name = "add_on";
            // 
            // room_type_info_label
            // 
            room_type_info_label.AutoSize = true;
            room_type_info_label.Location = new Point(800, 157);
            room_type_info_label.Name = "room_type_info_label";
            room_type_info_label.Size = new Size(76, 15);
            room_type_info_label.TabIndex = 1;
            room_type_info_label.Text = "CREATE NEW";
            // 
            // textBox_room_type
            // 
            textBox_room_type.Location = new Point(800, 210);
            textBox_room_type.Name = "textBox_room_type";
            textBox_room_type.Size = new Size(261, 23);
            textBox_room_type.TabIndex = 2;
            // 
            // label_room_type
            // 
            label_room_type.AutoSize = true;
            label_room_type.Location = new Point(800, 192);
            label_room_type.Name = "label_room_type";
            label_room_type.Size = new Size(74, 15);
            label_room_type.TabIndex = 3;
            label_room_type.Text = "Room Type *";
            // 
            // textBox_room_price
            // 
            textBox_room_price.Location = new Point(800, 260);
            textBox_room_price.Name = "textBox_room_price";
            textBox_room_price.Size = new Size(261, 23);
            textBox_room_price.TabIndex = 2;
            textBox_room_price.KeyPress += textBox_room_price_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(800, 242);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Room Price *";
            // 
            // textBox_room_add_on
            // 
            textBox_room_add_on.Location = new Point(800, 313);
            textBox_room_add_on.Name = "textBox_room_add_on";
            textBox_room_add_on.Size = new Size(261, 23);
            textBox_room_add_on.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(800, 295);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Add on";
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(800, 368);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 23);
            button_cancel.TabIndex = 4;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_save_room
            // 
            button_save_room.Location = new Point(961, 368);
            button_save_room.Name = "button_save_room";
            button_save_room.Size = new Size(100, 23);
            button_save_room.TabIndex = 4;
            button_save_room.Text = "Create";
            button_save_room.UseVisualStyleBackColor = true;
            button_save_room.Click += button_save_room_Click;
            // 
            // back_to_room_management
            // 
            back_to_room_management.Location = new Point(38, 21);
            back_to_room_management.Name = "back_to_room_management";
            back_to_room_management.Size = new Size(181, 36);
            back_to_room_management.TabIndex = 5;
            back_to_room_management.Text = "Back to Room Management";
            back_to_room_management.UseVisualStyleBackColor = true;
            back_to_room_management.Click += back_to_room_management_Click;
            // 
            // create_room_type_noti
            // 
            create_room_type_noti.AutoSize = true;
            create_room_type_noti.ForeColor = Color.Red;
            create_room_type_noti.Location = new Point(800, 340);
            create_room_type_noti.Name = "create_room_type_noti";
            create_room_type_noti.Size = new Size(98, 15);
            create_room_type_noti.TabIndex = 6;
            create_room_type_noti.Text = "Please fill * fields!";
            create_room_type_noti.Visible = false;
            // 
            // Room_Type_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 552);
            Controls.Add(create_room_type_noti);
            Controls.Add(back_to_room_management);
            Controls.Add(button_save_room);
            Controls.Add(button_cancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_room_type);
            Controls.Add(textBox_room_add_on);
            Controls.Add(textBox_room_price);
            Controls.Add(textBox_room_type);
            Controls.Add(room_type_info_label);
            Controls.Add(room_type_view);
            Name = "Room_Type_Management";
            Text = "Room Type Management";
            ((System.ComponentModel.ISupportInitialize)room_type_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView room_type_view;
        private DataGridViewTextBoxColumn room_type_id;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn add_on;
        private Label room_type_info_label;
        private TextBox textBox_room_type;
        private Label label_room_type;
        private TextBox textBox_room_price;
        private Label label1;
        private TextBox textBox_room_add_on;
        private Label label2;
        private Button button_cancel;
        private Button button_save_room;
        private Button back_to_room_management;
        private Label create_room_type_noti;
    }
}