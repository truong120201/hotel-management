namespace hotel_management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void room_management_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_Management_D room_management_d = new Room_Management_D();
            room_management_d.StartPosition = FormStartPosition.CenterScreen;
            room_management_d.ShowDialog();
            this.Close();
        }

        private void user_management_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Management user_management = new User_Management();
            user_management.StartPosition = FormStartPosition.CenterScreen;
            user_management.ShowDialog();
            this.Close();
        }

        private void booking_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking_Management booking_management = new Booking_Management();
            booking_management.StartPosition = FormStartPosition.CenterScreen;
            booking_management.ShowDialog();
            this.Close();
        }

        private void accountant_button_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_Status room_status = new Room_Status();
            room_status.StartPosition = FormStartPosition.CenterScreen;
            room_status.ShowDialog();
            this.Close();
        }
    }
}
