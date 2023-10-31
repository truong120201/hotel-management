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

        }

        private void booking_button_Click(object sender, EventArgs e)
        {

        }

        private void accountant_button_Click(object sender, EventArgs e)
        {

        }
    }
}
