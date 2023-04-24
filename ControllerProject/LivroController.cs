using ADO.NET_teste;
using ModelProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class LivroController
    {
        public void addLivroToDB(Livro livro)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "insert into tbLivros(nome, estoque, autor) values(@nome, @estoque, @autor)";
            command.Parameters.AddWithValue("@nome", livro.nome);
            command.Parameters.AddWithValue("@estoque", livro.estoque);
            command.Parameters.AddWithValue("@autor", livro.autor);
            command.ExecuteNonQuery();
            conn.Close();

        }

        public void deleteLivroFromDB(Livro livro)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from tbLivros where nr = @nr";
            command.Parameters.AddWithValue("@nr", livro.nr);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updateLivroFromDB(Livro livro)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE tbLivros SET nome=@nome, estoque=@estoque, " +
                                "autor=@autor WHERE nr=@nr";
            command.Parameters.AddWithValue("@nr", livro.nr);
            command.Parameters.AddWithValue("@nome", livro.nome);
            command.Parameters.AddWithValue("@estoque", livro.estoque);
            command.Parameters.AddWithValue("@autor", livro.autor);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
