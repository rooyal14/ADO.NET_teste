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

        public bool addUserToDB(User user)
        {
            if (!userIsDuplicated(user))
            {
                SqlConnection conn = DBCon.Conn();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "insert into tbClientes(cpf, nome, senha, email, telefone, isAdmin) values " +
                    "(@cpf, @nome, @senha, @email, @telefone, @isAdmin)";
                command.Parameters.AddWithValue("@cpf", user.cpf);
                command.Parameters.AddWithValue("@nome", user.nome);
                command.Parameters.AddWithValue("@senha", user.senha);
                command.Parameters.AddWithValue("@email", user.email);
                command.Parameters.AddWithValue("@telefone", user.telefone);
                command.Parameters.AddWithValue("@isAdmin", user.isAdmin == true ? 1 : 0);
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            } else
            {
                return false;
            }
            
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


        public bool loginUser(string email, string password, out string currentUserCpf, out bool currentUserIsAdmin)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select cpf, isAdmin from tbClientes where email = @email and senha = @senha";
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", password);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();
            if(query.Rows.Count > 0)
            {
                currentUserCpf = query.Rows[0][0].ToString();
                currentUserIsAdmin = Convert.ToBoolean(query.Rows[0][1].ToString());
                return true;
            } else
            {
                currentUserCpf = "";
                currentUserIsAdmin = false;
                return false;
            }

        }

        public bool userIsDuplicated(User user)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select cpf from tbClientes where cpf = @cpf";
            command.Parameters.AddWithValue("@cpf", user.cpf);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();

            if (query.Rows.Count == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }






    }
}
