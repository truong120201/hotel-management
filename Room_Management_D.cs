using WinFormsApp;
using System.Data.SqlClient;

namespace hotel_management
{
    public partial class Room_Management_D : Form
    {
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
                    }
                    result.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
            }
        }
        //private void init_room_list()
        //{
        //    try
        //    {
        //        string query = "SELECT room.room_id, room_type.price, room_type.type FROM room INNER JOIN room_type ON room.room_type_id = room_type.room_type_id;";
        //        var result = DB_Connection.ExecuteQuery(query);

        //        if (result.HasRows)
        //        {
        //            while (result.Read())
        //            {
        //                room_list.Rows.Add(result["room_id"], result["price"], result["price"], result["type"]);
        //            }
        //            result.Close();
        //        }
        //        else
        //        {
        //            result.Close();
        //            MessageBox.Show("No data found in the room_type table.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while authenticating: " + ex.Message);
        //    }
        //}
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
                    query += " WHERE room_type.type = '" + specificRoomType +"'";
                }
                Console.WriteLine(query);

                // Assuming DB_Connection is your database connection and ExecuteQuery is a method to execute the SQL query
                var result = DB_Connection.ExecuteQuery(query);


                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        room_list.Rows.Add(result["room_id"], result["price"], result["price"], result["type"]);
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

        }

        private void filter_room_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedValue = comboBox.SelectedItem.ToString();
            Console.WriteLine(selectedValue);
            init_room_list(selectedValue);
        }
    }
}
