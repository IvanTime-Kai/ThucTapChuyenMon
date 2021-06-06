using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace dental_sys
{
    class Connect
    {
        private static Connect instace;

        private string connSTr = @"Data Source=IVANTIME\SQLEXPRESS;Initial Catalog=thuctap;Integrated Security=True";
        public static Connect Instace
        {
            get
            {
                if (instace == null)
                    instace = new Connect();
                return Connect.instace;
            }
            private set
            {
                Connect.instace = value;

            }

        }
        public DataTable excutequery(string Query)
        {
            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(connSTr);
            conn.Open();
            SqlCommand command = new SqlCommand(Query, conn);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            conn.Close();
            return data;
        }
        public int updateTaikhoan(string query)
        {
            SqlConnection conn = new SqlConnection(connSTr);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            int a = command.ExecuteNonQuery();
            return a;
        }
    }
}
