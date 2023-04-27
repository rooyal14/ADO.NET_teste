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
    public class UserController
    {

        public void addUserToDB(User user)
        {
            SqlConnection conn = DBCon.Conn();
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "insert into tbClientes(cpf, nome, senha, email, telefone) values " +
                "(@cpf, @nome, @senha, @email, @telefone)";
            command.Parameters.AddWithValue("@cpf", user.cpf);
            command.Parameters.AddWithValue("@nome", user.nome);
            command.Parameters.AddWithValue("@senha", user.senha);
            command.Parameters.AddWithValue("@email", user.email);
            command.Parameters.AddWithValue("@telefone", user.telefone);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteUserFromDB(User user)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from tbClientes where cpf = @cpf";
            command.Parameters.AddWithValue("@cpf", user.cpf);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updateUserFromDB(User user)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE tbClientes SET nome=@nome, senha=@senha, " +
                                "email=@email, telefone=@telefone WHERE cpf=@cpf";
            command.Parameters.AddWithValue("@cpf", user.cpf);
            command.Parameters.AddWithValue("@nome", user.nome);
            command.Parameters.AddWithValue("@senha", user.senha);
            command.Parameters.AddWithValue("@email", user.email);
            command.Parameters.AddWithValue("@telefone", user.telefone);
            command.ExecuteNonQuery();
            conn.Close();
        }


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
