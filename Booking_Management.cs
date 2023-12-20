using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp;

namespace hotel_management
{
    public partial class Booking_Management : Form
    {
        string selected_room = "";
        public Booking_Management()
        {
            InitializeComponent();
            init_grid_buttons();
            init_room_type_filter();
        }

        private void init_grid_buttons()
        {
            DataGridViewButtonColumn select_button = new DataGridViewButtonColumn();
            {
                select_button.Name = "select";
                select_button.HeaderText = "Select";
                select_button.Text = "Select";
                select_button.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Add(select_button);
            }
        }

        private void get_rooms()
        {
            try
            {
                string query = "SELECT room.room_id, room_type.type\r\nFROM room\r\nJOIN room_type ON room.room_type_id = room_type.room_type_id\r\nWHERE room.room_id NOT IN (\r\n    SELECT booking.room_id\r\n    FROM booking\r\n    JOIN room ON booking.room_id = room.room_id\r\n    JOIN room_type ON room.room_type_id = room_type.room_type_id\r\n    WHERE room_type.type = '" + comboBox1.Text + "'\r\n    AND (\r\n        ('" + dateTimePicker1.Text.ToString() + "' BETWEEN booking.checkin_date AND booking.checkout_date)\r\n        OR ('" + dateTimePicker2.Text.ToString() + "' BETWEEN booking.checkin_date AND booking.checkout_date)\r\n        OR (booking.checkin_date BETWEEN '" + dateTimePicker1.Text.ToString() + "' AND '" + dateTimePicker2.Text.ToString() + "')\r\n        OR (booking.checkout_date BETWEEN '" + dateTimePicker1.Text.ToString() + "' AND '" + dateTimePicker2.Text.ToString() + "')\r\n    )\r\n)\r\nAND room_type.type = '" + comboBox1.Text + "';";
                var result = DB_Connection.ExecuteQuery(query);


                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        dataGridView1.Rows.Add(result["room_id"]);
                    }
                    result.Close();
                }
                else
                {
                    result.Close();
                    MessageBox.Show("No matched data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            get_rooms();
        }

        private void init_room_type_filter()
        {
            try
            {
                string query = "SELECT type FROM room_type";
                var result = DB_Connection.ExecuteQuery(query);

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        string roomType = result["type"].ToString();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < dataGridView1.Rows.Count - 1)
                {
                    var room_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("select"))
                    {
                        this.selected_room = room_id;
                        label6.Text = " // (Selected Room ID: " + room_id + ")";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.selected_room))
            {
                return;
            }
            try
            {
                var name = textBox1.Text;
                var contact = textBox2.Text;
                string queryUser = "SELECT * from customer WHERE name = '"+name+"' AND contact = '"+ contact +"' LIMIT 1";

                var result = DB_Connection.ExecuteQuery(queryUser);

                if (result.HasRows)
                {
                   result.Read();
                   var customer_id = result["customer_id"].ToString();
                   result.Close();
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    string queryBook = "insert into booking(customer_id, room_id, booking_date, checkin_date, checkout_date, booking_status_id ) \r\nvalues(" + customer_id + ", " + this.selected_room + ", '" + currentDate + "', '" + dateTimePicker1.Text.ToString() + "', '" + dateTimePicker2.Text.ToString() + "', 2)";
                    var resultBook = DB_Connection.ExecuteQuery(queryBook);
                    MessageBox.Show("Customer booked successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
            }
        }
    }
}
