using WinFormsApp;
using System.Data.SqlClient;

namespace hotel_management
{
    public partial class Room_Management_D : Form
    {
        string mode = "CREATE NEW ROOM";
        string currentSelectedRoomID = "";
        public Room_Management_D()
        {
            InitializeComponent();
            init_room_type_filter();
            init_grid_buttons();
            init_room_list();
        }

        private void room_type_management_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_Type_Management room_Type_management = new Room_Type_Management();
            room_Type_management.StartPosition = FormStartPosition.CenterScreen;
            room_Type_management.ShowDialog();
            this.Close();
        }

        private void back_to_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.ShowDialog();
            this.Close();
        }
        private void init_room_type_filter()
        {
            try
            {
                filter_room_type.Items.Clear();
                filter_room_type.Items.Add("All");
                filter_room_type.Text = "All";
                string query = "SELECT type FROM room_type";
                var result = DB_Connection.ExecuteQuery(query);

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        string roomType = result["type"].ToString();
                        filter_room_type.Items.Add(roomType);
                        comboBox1.Items.Add(roomType);
                    }
                    result.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
            }
        }
        private void init_room_list(string specificRoomType = "")
        {
            room_list.Rows.Clear();
            try
            {
                string query = "SELECT room.room_id, room_type.price, room_type.type " +
                               "FROM room INNER JOIN room_type ON room.room_type_id = room_type.room_type_id";

                // Check if a specific room type is provided and it's not "All"
                if (!string.IsNullOrEmpty(specificRoomType) && specificRoomType != "All")
                {
                    query += " WHERE room_type.type = '" + specificRoomType + "'";
                }
                Console.WriteLine(query);

                // Assuming DB_Connection is your database connection and ExecuteQuery is a method to execute the SQL query
                var result = DB_Connection.ExecuteQuery(query);


                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        room_list.Rows.Add(result["room_id"], result["price"], result["type"]);
                    }
                    result.Close();
                }
                else
                {
                    result.Close();
                    MessageBox.Show("No data found for the specified room type.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving room data: " + ex.Message);
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
                this.room_list.Columns.Add(edit_button);
            }

            DataGridViewButtonColumn remove_button = new DataGridViewButtonColumn();
            {
                remove_button.Name = "remove";
                remove_button.HeaderText = "Remove";
                remove_button.Text = "Remove";
                remove_button.UseColumnTextForButtonValue = true;
                this.room_list.Columns.Add(remove_button);
            }
        }

        private void room_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (room_list.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < room_list.Rows.Count - 1)
                {
                    var room_id = room_list.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var room_type = room_list.Rows[e.RowIndex].Cells[2].Value.ToString();
                    if (room_list.Columns[e.ColumnIndex].Name.Equals("edit"))
                    {
                        this.mode = "EDIT";
                        label4.Text = this.mode + " // (Room ID: " + room_id + ")";
                        button2.Text = "Update";
                        textBox1.Visible = true;
                        textBox1.Text = room_id;
                        comboBox1.Text = room_type;
                        this.currentSelectedRoomID = room_id;
                    }
                    else if (room_list.Columns[e.ColumnIndex].Name.Equals("remove"))
                    {
                        DialogResult dialogResult = MessageBox.Show("You are going to remove room id (" + room_id + ")", "Remove Confirmation", MessageBoxButtons.OKCancel);
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

        private void filter_room_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedValue = comboBox.SelectedItem.ToString();
            Console.WriteLine(selectedValue);
            init_room_list(selectedValue);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Room_Management_D_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                Console.WriteLine("run");
                return;
            }
            try
            {
                string query = "";
                if (this.mode == "CREATE NEW ROOM")
                {
                    query = "INSERT INTO room(room_type_id) SELECT room_type_id FROM room_type WHERE type = '" + comboBox1.Text + "'";
                    Console.WriteLine(query);
                }
                else if (this.mode == "EDIT")
                {

                    query = "UPDATE room SET room_type_id = (SELECT room_type_id FROM room_type WHERE room_type.type = '" + comboBox1.Text + "') WHERE room.room_id = " + this.currentSelectedRoomID;
                }
                var result = DB_Connection.ExecuteQuery(query);
                result.Close();
                room_list.Rows.Clear();
                init_room_list();
                MessageBox.Show("Room information saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.mode == "EDIT")
            {
                string noti = this.mode == "EDIT" ? "You are in edit mode, cancel will clear all value you have inserted and change to CREATE NEW ROOM mode." : "You want to clear all value you have inserted?";
                DialogResult dialogResult = MessageBox.Show(noti, "Cancel Confirmation", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    if (this.mode == "EDIT")
                    {
                        this.mode = "CREATE NEW ROOM";
                        label4.Text = this.mode;
                        button2.Text= "Create";
                        comboBox1.Text = "";
                    }

                    textBox1.Visible = false;
                    textBox1.Text = "";
                    comboBox1.Text = "";
                    this.currentSelectedRoomID = "";
                }
            }
        }
    }
}
