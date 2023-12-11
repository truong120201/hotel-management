using WinFormsApp;

namespace hotel_management
{
    public partial class Room_Type_Management : Form
    {

        string mode = "CREATE NEW";
        string currentSelectedRoomID = "";
        public Room_Type_Management()
        {
            InitializeComponent();
            init_grid_buttons();
            get_room_type();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void room_type_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (room_type_view.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < room_type_view.Rows.Count - 1)
                {
                    var room_id = room_type_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var room_type = room_type_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var room_price = room_type_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var room_add_on = room_type_view.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (room_type_view.Columns[e.ColumnIndex].Name.Equals("edit"))
                    {
                        this.mode = "EDIT";
                        room_type_info_label.Text = this.mode + " // (Room ID: " + room_id + ")";
                        button_save_room.Text = "Update";
                        textBox_room_type.Text = room_type;
                        textBox_room_price.Text = room_price;
                        textBox_room_add_on.Text = room_add_on;
                        this.currentSelectedRoomID = room_id;
                    }
                    else if (room_type_view.Columns[e.ColumnIndex].Name.Equals("remove"))
                    {
                        DialogResult dialogResult = MessageBox.Show("If you remove this room type (" + room_type + ") then every room with this room type will be set to Normal. Do you want to remove this entry?", "Remove Confirmation", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            MessageBox.Show("Clicked on OK remove for ID: " + room_id);
                        }
                        else if (dialogResult == DialogResult.Cancel)
                        {
                            MessageBox.Show("Clicked on Cancel remove for ID: " + room_id);
                        }
                    }
                }
            }
        }

        private void get_room_type()
        {
            try
            {
                string query = "SELECT * FROM room_type";
                var result = DB_Connection.ExecuteQuery(query);

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        room_type_view.Rows.Add(result["room_type_id"], result["type"], result["price"], result["add_on"]);
                    }
                    result.Close();
                }
                else
                {
                    result.Close();
                    MessageBox.Show("No data found in the room_type table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
            }
        }

        private void init_grid_buttons()
        {
            DataGridViewButtonColumn edit_button = new DataGridViewButtonColumn();
            {
                edit_button.Name = "edit";
                edit_button.HeaderText = "Edit";
                edit_button.Text = "Edit";
                edit_button.UseColumnTextForButtonValue = true;
                this.room_type_view.Columns.Add(edit_button);
            }

            DataGridViewButtonColumn remove_button = new DataGridViewButtonColumn();
            {
                remove_button.Name = "remove";
                remove_button.HeaderText = "Remove";
                remove_button.Text = "Remove";
                remove_button.UseColumnTextForButtonValue = true;
                this.room_type_view.Columns.Add(remove_button);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_room_type.Text) || !string.IsNullOrEmpty(textBox_room_price.Text) || !string.IsNullOrEmpty(textBox_room_add_on.Text))
            {
                string noti = this.mode == "EDIT" ? "You are in edit mode, cancel will clear all value you have inserted and change to CREATE NEW mode." : "You want to clear all value you have inserted?";
                DialogResult dialogResult = MessageBox.Show(noti, "Cancel Confirmation", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    if (this.mode == "EDIT")
                    {
                        this.mode = "CREATE NEW";
                        room_type_info_label.Text = this.mode;
                        button_save_room.Text = "Create";
                    }

                    textBox_room_type.Text = "";
                    textBox_room_price.Text = "";
                    textBox_room_add_on.Text = "";
                }
            }
        }

        private void textBox_room_price_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void back_to_room_management_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_Management_D room_management_d = new Room_Management_D();
            room_management_d.StartPosition = FormStartPosition.CenterScreen;
            room_management_d.ShowDialog();
            this.Close();
        }

        private void button_save_room_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_room_type.Text) || string.IsNullOrEmpty(textBox_room_price.Text))
            {
                return;
            }
            try
            {
                string query = "";
                if (this.mode == "CREATE NEW")
                {
                    query = "INSERT INTO room_type (type, price, add_on) VALUES ('" + textBox_room_type.Text + "', '" + textBox_room_price.Text + "', '" + textBox_room_add_on.Text + "')";
                }
                else if (this.mode == "EDIT")
                {
                    query = "UPDATE room_type SET type = '" + textBox_room_type.Text + "', price = '" + textBox_room_price.Text + "', add_on = '" + textBox_room_add_on.Text + "' WHERE room_type_id = " + this.currentSelectedRoomID;
                }
                var result = DB_Connection.ExecuteQuery(query);
                result.Close();
                room_type_view.Rows.Clear();
                get_room_type();
                MessageBox.Show("Room information saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
            }
        }

    }
}
