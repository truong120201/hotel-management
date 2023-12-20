namespace hotel_management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            room_management_button = new Button();
            user_management_button = new Button();
            booking_button = new Button();
            accountant_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(385, 77);
            label1.Name = "label1";
            label1.Size = new Size(339, 50);
            label1.TabIndex = 0;
            label1.Text = "Hotel Management";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // room_management_button
            // 
            room_management_button.Image = (Image)resources.GetObject("room_management_button.Image");
            room_management_button.ImageAlign = ContentAlignment.MiddleLeft;
            room_management_button.Location = new Point(255, 162);
            room_management_button.Name = "room_management_button";
            room_management_button.Padding = new Padding(20, 0, 20, 0);
            room_management_button.Size = new Size(248, 68);
            room_management_button.TabIndex = 1;
            room_management_button.Text = "Room Management";
            room_management_button.TextAlign = ContentAlignment.MiddleRight;
            room_management_button.UseVisualStyleBackColor = true;
            room_management_button.Click += room_management_button_Click;
            // 
            // user_management_button
            // 
            user_management_button.Image = (Image)resources.GetObject("user_management_button.Image");
            user_management_button.ImageAlign = ContentAlignment.MiddleLeft;
            user_management_button.Location = new Point(593, 162);
            user_management_button.Name = "user_management_button";
            user_management_button.Padding = new Padding(20, 0, 20, 0);
            user_management_button.Size = new Size(248, 68);
            user_management_button.TabIndex = 1;
            user_management_button.Text = "User Management";
            user_management_button.TextAlign = ContentAlignment.MiddleRight;
            user_management_button.UseVisualStyleBackColor = true;
            user_management_button.Click += user_management_button_Click;
            // 
            // booking_button
            // 
            booking_button.Image = (Image)resources.GetObject("booking_button.Image");
            booking_button.ImageAlign = ContentAlignment.MiddleLeft;
            booking_button.Location = new Point(255, 252);
            booking_button.Name = "booking_button";
            booking_button.Padding = new Padding(20, 0, 20, 0);
            booking_button.Size = new Size(248, 68);
            booking_button.TabIndex = 1;
            booking_button.Text = "Booking Management";
            booking_button.TextAlign = ContentAlignment.MiddleRight;
            booking_button.UseVisualStyleBackColor = true;
            booking_button.Click += booking_button_Click;
            // 
            // accountant_button
            // 
            accountant_button.Image = (Image)resources.GetObject("accountant_button.Image");
            accountant_button.ImageAlign = ContentAlignment.MiddleLeft;
            accountant_button.Location = new Point(593, 252);
            accountant_button.Name = "accountant_button";
            accountant_button.Padding = new Padding(20, 0, 20, 0);
            accountant_button.Size = new Size(248, 68);
            accountant_button.TabIndex = 1;
            accountant_button.Text = "Accountant Management";
            accountant_button.TextAlign = ContentAlignment.MiddleRight;
            accountant_button.UseVisualStyleBackColor = true;
            accountant_button.Click += accountant_button_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(255, 343);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 20, 0);
            button1.Size = new Size(248, 68);
            button1.TabIndex = 1;
            button1.Text = "Room Status";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 552);
            Controls.Add(accountant_button);
            Controls.Add(booking_button);
            Controls.Add(user_management_button);
            Controls.Add(button1);
            Controls.Add(room_management_button);
            Controls.Add(label1);
            Name = "Dashboard";
            Padding = new Padding(20, 0, 20, 0);
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button room_management_button;
        private Button user_management_button;
        private Button booking_button;
        private Button accountant_button;
        private Button button1;
    }
}