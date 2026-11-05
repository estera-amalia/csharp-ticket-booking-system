using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketBookingApp
{
    public partial class ConcertGoerForm : Form
    {
        public ConcertGoerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var form = new LoginForm();
            form.Show();
            this.Close();
        }
    }

}
