﻿using Npgsql;


namespace PetShop.Repository.Util
{
    public class ConnectionFactory  
    {
        private NpgsqlConnection _conn;
        public NpgsqlConnection GetConnection(string sqlConnection)
        {
            _conn = new NpgsqlConnection(sqlConnection);
            _conn.Open();
            return _conn;
        }

        public void Dispose()
        {
            _conn.Dispose();
        }
    }
}
