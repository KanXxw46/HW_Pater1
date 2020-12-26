using System;
using System.Collections.Generic;
using System.Text;

namespace Paterns1.model
{
    public class MySqlConnection
    {
        public string Data{get; set;}

        private static MySqlConnection sqlConnection;

        private MySqlConnection() { }

        public static MySqlConnection CreateOrSqlConnection()
        {
            if(sqlConnection == null)
            {
                sqlConnection = new MySqlConnection();
            }
            return sqlConnection;
        }
    }
}
