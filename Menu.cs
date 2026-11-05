namespace TicketBookingApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (DatabaseTest.TestConnection(out string msg))
                MessageBox.Show(msg, "Database is working.");
            else
                MessageBox.Show(msg, "Database error.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbConcertGoer.Checked)
            {
                new ConcertGoerForm().Show();
                this.Hide();
            }
            else if (rbEventOrganiser.Checked)
            {
                new EventOrganiserForm().Show();
                this.Hide();
            }
            else if (rbAdmin.Checked)
            {
                new AdminForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Select a role.");
            }

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
