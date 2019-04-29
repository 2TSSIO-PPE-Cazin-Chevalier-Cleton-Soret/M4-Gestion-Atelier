using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.SqlConn;

namespace GestionAtelier
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "172.29.102.22";
            int port = 3306;
            string database = "ram";
            string username = "root";
            string password = "root";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}
