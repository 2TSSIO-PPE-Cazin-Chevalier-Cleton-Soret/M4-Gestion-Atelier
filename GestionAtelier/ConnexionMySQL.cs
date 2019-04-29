using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionActivitePlanificateur
{
    class ConnexionMySQL
    {
        public static SqlConnection
             GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
