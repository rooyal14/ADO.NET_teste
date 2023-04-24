using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public abstract class DBCon
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
        //SqlConnection connection = new SqlConnection(connectionString);

        static public SqlConnection Conn()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        static public DataTable queryDataTable(SqlCommand sqlCommand)
        {
            var adapter = new SqlDataAdapter(sqlCommand);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
