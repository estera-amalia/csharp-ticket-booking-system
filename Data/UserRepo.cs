using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace TicketBookingApp.Data
{
    internal class UserRepo
    {
        public int CreateConcertGoer(string name, string email, string password)
        {
            using var conn = Db.GetConnection();
            conn.Open();
            /* making changes to the database to match forms*/
            var sql = @"INSERT INTO users(name, email, password, role)
                        VALUES (@name, @email, @password, @role)";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", "ConcertGoer");
            return cmd.ExecuteNonQuery();
        }

        public (bool ok, int userId, string name, string role) Authenticate (string email, string password)
            {
            using var conn = Db.GetConnection();
            conn.Open();
            string sql = @"SELECT userId, name, role
                            FROM users
                            WHERE email=@email AND password=@password LIMIT 1";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@password",password);
            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return (false, 0, "", "");
            int userId = reader.GetInt32("userId");
            string name = reader.GetString("name");
            string role = reader.GetString("role");
            return (true, userId, name, role);                
        }
    }
}
