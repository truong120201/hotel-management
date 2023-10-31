namespace hotel_management
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            login_button = new Button();
            exit_button = new Button();
            username_text_box = new TextBox();
            password_text_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            error_label = new Label();
            checkBoxShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.BackColor = SystemColors.ControlLight;
            login_button.Location = new Point(412, 275);
            login_button.Name = "login_button";
            login_button.RightToLeft = RightToLeft.Yes;
            login_button.Size = new Size(151, 26);
            login_button.TabIndex = 0;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += Login_Button;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(255, 275);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(151, 26);
            exit_button.TabIndex = 0;
            exit_button.Text = "Exit";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += Exit_Button;
            // 
            // username_text_box
            // 
            username_text_box.Location = new Point(255, 161);
            username_text_box.Name = "username_text_box";
            username_text_box.Size = new Size(308, 23);
            username_text_box.TabIndex = 1;
            username_text_box.TextChanged += username_text_box_change;
            // 
            // password_text_box
            // 
            password_text_box.Location = new Point(255, 205);
            password_text_box.Name = "password_text_box";
            password_text_box.PasswordChar = '*';
            password_text_box.Size = new Size(308, 23);
            password_text_box.TabIndex = 1;
            password_text_box.TextChanged += password_text_box_change;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 143);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 187);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(255, 257);
            error_label.Name = "error_label";
            error_label.Size = new Size(248, 15);
            error_label.TabIndex = 3;
            error_label.Text = "You must fill in both username and password!";
            error_label.Visible = false;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(255, 234);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(113, 19);
            checkBoxShowPassword.TabIndex = 4;
            checkBoxShowPassword.Text = "Show password?";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(error_label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_text_box);
            Controls.Add(username_text_box);
            Controls.Add(exit_button);
            Controls.Add(login_button);
            Name = "Login";
            RightToLeftLayout = true;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_button;
        private Button exit_button;
        private TextBox username_text_box;
        private TextBox password_text_box;
        private Label label1;
        private Label label2;
        private Label error_label;
        private CheckBox checkBoxShowPassword;
    }
}