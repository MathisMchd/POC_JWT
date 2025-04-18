﻿using BasicApi.Entity;
using BasicApi.Services.Interfaces;
using MySql.Data.MySqlClient;

namespace BasicApi.Services
{
    /// <inheritdoc cref="IMySqlService"/>
    public class MySqlService : IMySqlService
    {
        private readonly IDataBaseConnectionService _dbconnectionService;
        public MySqlService(IDataBaseConnectionService dbconnectionService)
        {
            _dbconnectionService = dbconnectionService;
        }

        /// <inheritdoc />
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (var connection = _dbconnectionService.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, Name FROM USER";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var user = new User
                                {
                                    Id = reader.GetInt32("Id"),
                                    Name = reader.GetString("Name")
                                };
                                users.Add(user);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return users;
        }
    }
}
