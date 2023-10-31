namespace hotel_management
{
    public partial class Room_Management_D : Form
    {
        public Room_Management_D()
        {
            InitializeComponent();
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
    }
}
