using ModelProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class ClienteController
    {
        
        public bool loginUser(string email, string password, out string currentUserCpf)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select cpf from tbClientes where email = @email and senha = @senha";
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", password);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();
            if(query.Rows.Count > 0)
            {
                currentUserCpf = query.Rows[0][0].ToString();
                return true;
            } else
            {
                currentUserCpf = "";
                return false;
            }

        }

    }
}
