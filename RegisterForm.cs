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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account created!");
            string name = txtname.Text.Trim();/* gathering user input*/
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if ((string.IsNullOrWhiteSpace(name)) || /* checking if or fields are filled by using OR */
               string.IsNullOrWhiteSpace(email)||
               string.IsNullOrWhiteSpace(password))
               {
                MessageBox.Show("Please fill all fields. Thank you!");
                return;
                }
            /*string validationMessage = password.Length < 6 ? "The password needs to be over 6 characters." : "The password is good enough!";
            MessageBox.Show(validationMessage);*/
            if (password.Length < 6) //cheking if password fulfills minimum condition
            {
                MessageBox.Show("The password needs to be over 6 characters.");
            }
            else 
            {
                MessageBox.Show("The password is good enough!");
            }
            try /*exception handling using try-catch method*/
                {
                    var repo = new UserRepo();
                    int rows = repo.CreateConcertGoer(name, email, password);
                    if (rows == 1)
                    {
                        MessageBox.Show("Registration is done!");
                        var lobby = new ConcertGoerForm();
                        lobby.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database error!");
                }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var lobby = new ConcertGoerForm();
            lobby.Show();
            this.Close();
        }
    }
}
