﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Hotel
{
     class DB_Connection
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel");

        public MySqlConnection GetConnection() { 
           return connection;  }

        public void OpenCon()
        {
            if(connection.State ==System.Data.ConnectionState.Closed) {
            connection.Open();
            }
        }
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
