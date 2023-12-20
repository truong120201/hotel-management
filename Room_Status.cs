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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotel_management
{
    public partial class Room_Status : Form
    {
        string selected_booking_id = "";
        float total = 0;
        public Room_Status()
        {
            InitializeComponent();
            init_grid_buttons();
            get_booking();
            init_room_status();
            init_room_filter();
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

        private void get_booking()
        {
            try
            {
                string query = "SELECT * from booking inner join booking_status on booking.booking_status_id = booking_status.booking_status_id;";
                var result = DB_Connection.ExecuteQuery(query);


                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        dataGridView1.Rows.Add(result["room_id"], result["customer_id"], result["booking_id"], result["status"], result["checkin_date"], result["checkout_date"]);
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

        private void init_room_status()
        {
            try
            {
                comboBox2.Items.Clear();
                string query = "SELECT * FROM booking_status";
                var result = DB_Connection.ExecuteQuery(query);

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        string roomType = result["status"].ToString() + "-" + result["booking_status_id"].ToString();
                        comboBox2.Items.Add(roomType);
                    }
                    result.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
            }
        }

        private void init_room_filter()
        {
            try
            {
                comboBox1.Items.Clear();
                string query = "SELECT room_id FROM room";
                var result = DB_Connection.ExecuteQuery(query);

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        string roomType = result["room_id"].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < dataGridView1.Rows.Count - 1)
                {
                    var room_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var booking_id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var checkin_date = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    var checkout_date = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    DateTime checkinDate = DateTime.Parse(checkin_date);
                    DateTime checkoutDate = DateTime.Parse(checkout_date);

                    // Calculate the total days
                    TimeSpan totalDuration = checkoutDate - checkinDate;
                    int totalDays = (int)totalDuration.TotalDays;
                    var status = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string getPricePerDay = "SELECT room_type.price from room inner join room_type on room.room_type_id = room_type.room_type_id;";
                    var result1 = DB_Connection.ExecuteQuery(getPricePerDay);
                    this.selected_booking_id = booking_id;
                    if (result1.HasRows)
                    {
                        result1.Read();
                        var pricePerDay = result1["price"].ToString();
                        result1.Close();
                        if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("select"))
                        {
                            comboBox2.Text = status;
                            label5.Text = "total amount: " + (totalDays * Int32.Parse(pricePerDay)).ToString();
                            this.total = totalDays * Int32.Parse(pricePerDay);
                            label6.Text = checkin_date;
                            label7.Text = checkout_date;
                        }
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedValue = comboBox2.SelectedItem.ToString();

                string[] parts = selectedValue.Split('-');

                if (parts.Length == 2)
                {
                    string id = parts[1];

                    string query = "UPDATE booking SET booking_status_id = " + id + " WHERE booking_id = " + this.selected_booking_id;
                    var result = DB_Connection.ExecuteQuery(query);
                    result.Close();
                    dataGridView1.Rows.Clear();
                    get_booking();
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Invalid selection format.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            string query1 = "UPDATE booking SET booking_status_id = " + 4 + " WHERE booking_id = " + this.selected_booking_id;
            var result1 = DB_Connection.ExecuteQuery(query1);
            result1.Close();
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string query2 = "INSERT INTO bill(booking_id, amount, date) values("+this.selected_booking_id+", "+this.total+", "+ currentDate + ")";
            var result2 = DB_Connection.ExecuteQuery(query2);
            result2.Close();
            MessageBox.Show("CHECKOUT");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
