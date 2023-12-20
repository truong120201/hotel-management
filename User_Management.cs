using System;
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
    public partial class User_Management : Form
    {
        string mode = "CREATE NEW CUSTOMER";
        string currentSelectedCustomerID = "";
        public User_Management()
        {
            InitializeComponent();
            init_grid_buttons();
            get_customer();
        }

        private void User_Management_Load(object sender, EventArgs e)
        {

        }

        private void get_customer()
        {
            try
            {
                string query = "SELECT * FROM customer";
                var result = DB_Connection.ExecuteQuery(query);

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        dataGridView1.Rows.Add(result["customer_id"], result["name"], result["contact"]);
                    }
                    result.Close();
                }
                else
                {
                    result.Close();
                    MessageBox.Show("No data found in the customer table.");
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
                this.dataGridView1.Columns.Add(edit_button);
            }

            DataGridViewButtonColumn remove_button = new DataGridViewButtonColumn();
            {
                remove_button.Name = "remove";
                remove_button.HeaderText = "Remove";
                remove_button.Text = "Remove";
                remove_button.UseColumnTextForButtonValue = true;
                this.dataGridView1.Columns.Add(remove_button);
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
                    var customer_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var contact = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("edit"))
                    {
                        this.mode = "EDIT";
                        label1.Text = this.mode + " // (Customer ID: " + customer_id + ")";
                        button3.Text = "Update";
                        textBox1.Text = name;
                        textBox2.Text = contact;
                        this.currentSelectedCustomerID = customer_id;
                    }
                    else if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("remove"))
                    {
                        DialogResult dialogResult = MessageBox.Show("Your are going to remove customer (" + name + ")?", "Remove Confirmation", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            MessageBox.Show("Clicked on OK remove for ID: " + customer_id);
                        }
                        else if (dialogResult == DialogResult.Cancel)
                        {
                            MessageBox.Show("Clicked on Cancel remove for ID: " + customer_id);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(textBox2.Text))
            {
                string noti = this.mode == "EDIT" ? "You are in edit mode, cancel will clear all value you have inserted and change to CREATE NEW CUSTOMER mode." : "You want to clear all value you have inserted?";
                DialogResult dialogResult = MessageBox.Show(noti, "Cancel Confirmation", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    if (this.mode == "EDIT")
                    {
                        this.mode = "CREATE NEW CUSTOMER";
                        label1.Text = this.mode;
                        button3.Text = "Create";
                    }

                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }
            try
            {
                string query = "";
                if (this.mode == "CREATE NEW CUSTOMER")
                {
                    query = "INSERT INTO customer (name, contact) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')";
                }
                else if (this.mode == "EDIT")
                {
                    query = "UPDATE customer SET name = '" + textBox1.Text + "', contact = '" + textBox2.Text + "' WHERE customer_id = " + this.currentSelectedCustomerID;
                }
                var result = DB_Connection.ExecuteQuery(query);
                result.Close();
                dataGridView1.Rows.Clear();
                get_customer();
                MessageBox.Show("Customer information saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while authenticating: " + ex.Message);
            }
        }
    }
}
