using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace TicketBookingApp.Data
{
    internal static class Db
    {
        public static string ConnStr =
            "server=localhost; port=3306;database=ticketbookingdb;user=root;password=MUSEtel1968.;";
        public static MySqlConnection GetConnection() => new MySqlConnection(ConnStr);
    }
}
