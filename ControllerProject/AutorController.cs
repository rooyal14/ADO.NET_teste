using ModelProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class AutorController
    {
        public void addAutorToDB(Autor autor)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "insert into tbAutores(nome) values (@nome)";
            command.Parameters.AddWithValue("@nome", autor.nome);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteAutorFromDB(Autor autor)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from tbAutores where idAutor = @idAutor";
            command.Parameters.AddWithValue("@idAutor", autor.idAutor);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updateAutorFromDB(Autor autor)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE tbAutores SET nome=@nome WHERE idAutor=@idAutor";
            command.Parameters.AddWithValue("@idAutor", autor.idAutor);
            command.Parameters.AddWithValue("@nome", autor.nome);
            command.ExecuteNonQuery();
            conn.Close();
        }

        
    }
}
