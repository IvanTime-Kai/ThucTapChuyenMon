using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys
{
    public class ConnectProvider
    {
        public static SqlConnection GetConnection()
        {
            string connectString = @"Data Source=.\SQLEXPRESS;Initial Catalog=thuctap;Integrated Security=True";
            return new SqlConnection(connectString);
        }
    }
}
