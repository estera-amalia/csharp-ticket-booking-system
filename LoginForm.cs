using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TicketBookingApp.Data;

namespace TicketBookingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var lobby = new ConcertGoerForm();
            lobby.Show();
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(email)||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email AND password. Thank you.");
                return;
            }
            try
            {
                var repo = new UserRepo();
                var result = repo.Authenticate(email, password);
                if (!result.ok)
                {
                    MessageBox.Show("Invalid details.");
                    return;
                }
                MessageBox.Show($"Welcome, {result.name}!");
                var lobby = new ConcertGoerForm();
                lobby.Show();
                this.Close();
            }
            catch (Exception ex)
            { 
            }
        }

    }
}
