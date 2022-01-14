using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RSDCharts.Domain
{
    public class ConnectionUtil
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            var con = new SqlConnection(ConnectionString);
            con.Open();
            return con;
        }
    }
}