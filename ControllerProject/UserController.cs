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
            if (!userIsDuplicated(user) && !emailIsDuplicated(user))
            {
                string senhaHash = Criptografia.GerarHash(user.senha);
                
                SqlConnection conn = DBCon.Conn();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "insert into Tb_Usuarios(cpf, nome, senha, email, telefone, trueAdmin) values " +
                    "(@cpf, @nome, @senha, @email, @telefone, @trueAdmin)";
                command.Parameters.AddWithValue("@cpf", user.cpf);
                command.Parameters.AddWithValue("@nome", user.nome);
                command.Parameters.AddWithValue("@senha", senhaHash);
                command.Parameters.AddWithValue("@email", user.email);
                command.Parameters.AddWithValue("@telefone", user.telefone);
                command.Parameters.AddWithValue("@trueAdmin", user.trueAdmin == true ? 1 : 0);
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
            command.CommandText = "delete from Tb_Usuarios where cpf = @cpf";
            command.Parameters.AddWithValue("@cpf", user.cpf);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updateUserFromDB(User user)
        {
            string senhaHash = Criptografia.GerarHash(user.senha);
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Tb_Usuarios SET nome=@nome, senha=@senha, " +
                                "email=@email, telefone=@telefone WHERE cpf=@cpf";
            command.Parameters.AddWithValue("@cpf", user.cpf);
            command.Parameters.AddWithValue("@nome", user.nome);
            command.Parameters.AddWithValue("@senha", senhaHash);
            command.Parameters.AddWithValue("@email", user.email);
            command.Parameters.AddWithValue("@telefone", user.telefone);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updatePasswordFromDB(User user)
        {
            string senhaHash = Criptografia.GerarHash(user.senha);
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Tb_Usuarios SET senha=@senha WHERE cpf=@cpf";
            command.Parameters.AddWithValue("@cpf", user.cpf);
            command.Parameters.AddWithValue("@senha", senhaHash);        
            command.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable getChangeableUsersFromDB()
        {
            var conn = DBCon.Conn();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Tb_Usuarios WHERE ID_Cliente > 1";
            var table = DBCon.queryDataTable(command);
            conn.Close();
            return table;
        }

        public bool loginUser(string email, string password, out string currentUserEmail, out bool currentUsertrueAdmin)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            string senhaHash = Criptografia.GerarHash(password);
            command.CommandText = "select Email, trueAdmin from Tb_Usuarios where Email = @email and Senha = @senha";
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", senhaHash);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();
            if (query.Rows.Count > 0)
            {
                currentUserEmail = query.Rows[0][0].ToString();
                currentUsertrueAdmin = Convert.ToBoolean(query.Rows[0][1].ToString());
                return true;
            }
            else
            {
                currentUserEmail = "";
                currentUsertrueAdmin = false;
                return false;
            }

        }

        public bool checkIfProtectedUser(User usuario)
        {
            if (usuario.email == "admin" || usuario.email == "cliente deletado" || usuario.cpf == "99999999999")
                return true;
            else
                return false;

        }

        public bool userIsDuplicated (User user)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select count(cpf) from Tb_Usuarios where cpf = @cpf";
            command.Parameters.AddWithValue("@cpf", user.cpf);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();
             
            var result = Convert.ToInt32(query.Rows[0][0].ToString()) == 0 ? false : true;
            return result;

        }

        public bool emailIsDuplicated(User user)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select count (Email) from Tb_Usuarios where Email = @Email";
            command.Parameters.AddWithValue("@Email", user.email);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();

            var result = Convert.ToInt32(query.Rows[0][0].ToString()) == 0 ? false : true;
            return result;

        }

        public bool userIsReferenced(User user)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT COUNT(ID_Venda) FROM Tb_Venda WHERE ID_Cliente = (SELECT ID_Cliente FROM Tb_Usuarios WHERE CPF=@cpf)";
            command.Parameters.AddWithValue("@cpf", user.cpf);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();
            var result = Convert.ToInt32(query.Rows[0][0].ToString()) == 0 ? false : true;
            return result;
        }

        public User getUser(string email)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT cpf, Nome, Senha, Email, Telefone, trueAdmin FROM Tb_Usuarios WHERE Email = @Email";
            command.Parameters.AddWithValue("@Email", email);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();
            User usuario = new User(query.Rows[0][0].ToString(),
                query.Rows[0][1].ToString(),
                query.Rows[0][2].ToString(),
                query.Rows[0][3].ToString(),
                query.Rows[0][4].ToString(),
                Convert.ToBoolean(query.Rows[0][5]));
            return usuario;
        }

        public DataTable searchUsersByColumn(string tipoPesquisado, string pesquisa, DataTable tbUsersOriginal)
        {
            string colunaPesquisada;
            string filtro = "";
            try
            {
                switch (tipoPesquisado)
                {
                    case "Código":
                        colunaPesquisada = "ID_Cliente";
                        filtro = String.Format("{0} = {1}", colunaPesquisada, pesquisa);
                        break;
                    case "Nome":
                        colunaPesquisada = "Nome";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                    case "CPF":
                        colunaPesquisada = "CPF";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                    case "Email":
                        colunaPesquisada = "Email";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                    case "Senha":
                        colunaPesquisada = "Senha";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                    case "Telefone":
                        colunaPesquisada = "Telefone";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                }

                var tbFiltrado = tbUsersOriginal.Select(filtro, "ID_Cliente ASC").CopyToDataTable();
                return tbFiltrado;
            }
            catch
            {
                return null;
            }

        }






    }
}
