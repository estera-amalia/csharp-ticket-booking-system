using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace TicketBookingApp
{
    internal class DatabaseTest
    {
        private const string ConnStr =
            "server=localhost;port=3306;database=ticketbookingdb;user=root;password=MUSEtel1968.;";

        public static bool TestConnection(out string message)
        {
            try
            {
                using var conn = new MySqlConnection(ConnStr);
                conn.Open();
                message = "Database connection successful.";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
