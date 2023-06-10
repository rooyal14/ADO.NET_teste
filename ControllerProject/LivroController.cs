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
    public class LivroController
    {
        public void addLivroToDB(Livro livro)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Tb_Livro(ID_Genero, Nome, estoque, precoUnitario) VALUES ((SELECT ID_Genero FROM Tb_Genero WHERE Nome=@genero), @Nome, @estoque, @precoUnitario)";
            command.Parameters.AddWithValue("@genero", livro.genero);
            command.Parameters.AddWithValue("@Nome", livro.nome);
            command.Parameters.AddWithValue("@estoque", livro.estoque);
            command.Parameters.AddWithValue("@precoUnitario", livro.precoUnitario);
            command.ExecuteNonQuery();

            command = conn.CreateCommand();
            command.CommandText = "SELECT ID_Livro FROM Tb_Livro WHERE Nome=@Nome";
            command.Parameters.AddWithValue("@Nome", livro.nome);
            livro.ID_Livro = DBCon.queryDataTable(command).Rows[0].ItemArray[0].ToString();

            foreach(string autor in AutorList.listaDeAutoresSelecionados)
            {
                command = conn.CreateCommand();
                command.CommandText = "INSERT INTO Tb_AutorEscreve(ID_Autor, ID_Livro) VALUES " +
                    "((SELECT ID_Autor FROM Tb_Autor WHERE Nome = @NomeAutor), @ID_Livro)";
                command.Parameters.AddWithValue("@NomeAutor", autor);
                command.Parameters.AddWithValue("@ID_Livro", livro.ID_Livro);
                command.ExecuteNonQuery();
            }
            conn.Close();

        }

        public void deleteLivroFromDB(Livro livro)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Tb_AutorEscreve WHERE ID_Livro = @ID_Livro";
            command.Parameters.AddWithValue("@ID_Livro", livro.ID_Livro);
            command.ExecuteNonQuery();

            command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Tb_Livro WHERE ID_Livro = @ID_Livro";
            command.Parameters.AddWithValue("@ID_Livro", livro.ID_Livro);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updateLivroFromDB(Livro livro)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Tb_Livro SET ID_GENERO=(SELECT ID_Genero FROM Tb_Genero WHERE Nome=@genero), " +
                "Nome=@Nome, " +
                "estoque=@estoque, " +
                "precoUnitario=@precoUnitario " +
                "WHERE ID_Livro=@ID_Livro";
            command.Parameters.AddWithValue("@ID_Livro", livro.ID_Livro);
            command.Parameters.AddWithValue("@genero", livro.genero);
            command.Parameters.AddWithValue("@Nome", livro.nome);
            command.Parameters.AddWithValue("@estoque", livro.estoque);
            command.Parameters.AddWithValue("@precoUnitario", livro.precoUnitario);
            command.ExecuteNonQuery();

            command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Tb_AutorEscreve WHERE ID_Livro = @ID_Livro";
            command.Parameters.AddWithValue("@ID_Livro", livro.ID_Livro);
            command.ExecuteNonQuery();

            foreach (string autor in AutorList.listaDeAutoresSelecionados)
            {
                command = conn.CreateCommand();
                command.CommandText = "INSERT INTO Tb_AutorEscreve(ID_Autor, ID_Livro) VALUES " +
                    "((SELECT ID_Autor FROM Tb_Autor WHERE Nome = @NomeAutor), @ID_Livro)";
                command.Parameters.AddWithValue("@NomeAutor", autor);
                command.Parameters.AddWithValue("@ID_Livro", livro.ID_Livro);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        public DataTable getDisplayLivros()
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT ID_Livro, Nome, precoUnitario, estoque, Genero, STRING_AGG(autor,', ') as Autores " +
                "FROM (SELECT tbL.ID_Livro, tbL.Nome, tbL.precoUnitario, tbL.estoque, Tb_Genero.Nome as Genero, " +
                "Tb_Autor.Nome AS autor FROM Tb_Livro AS tbL FULL JOIN Tb_AutorEscreve " +
                "ON tbL.ID_Livro = Tb_AutorEscreve.ID_Livro FULL JOIN Tb_Autor " +
                "ON Tb_AutorEscreve.ID_Autor = Tb_Autor.ID_Autor INNER JOIN Tb_Genero " +
                "ON tbL.ID_Genero = Tb_Genero.ID_Genero) AS query GROUP BY ID_Livro, Nome, precoUnitario, estoque, Genero";
            var tb = DBCon.queryDataTable(command);
            tb.Rows[0].Delete();
            conn.Close();
            return tb;
        }

        public void substituirPorGeneroIndefinido(Genero genero)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Tb_Livro SET ID_Genero=0 WHERE ID_Genero=@ID_Genero";
            command.Parameters.AddWithValue("@ID_Genero", genero.ID_Genero);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public bool checkIfProtectedLivro(Livro livro)
        {
            if (livro.ID_Livro== "0")
                return true;
            else
                return false;

        }

        public bool livroIsReferenced(Livro livro)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT COUNT(ID_ItemVendido) FROM Tb_ItemVendido WHERE ID_Livro=@ID_Livro";
            command.Parameters.AddWithValue("@ID_Livro", livro.ID_Livro);
            var query = DBCon.queryDataTable(command);
            conn.Close();
            var result = Convert.ToInt32(query.Rows[0][0].ToString()) == 0 ? false : true;
            return result;
        }

        public DataTable searchLivrosByColumn(string tipoPesquisado, string pesquisa, DataTable tbLivrosOriginal)
        {
            string colunaPesquisada;
            string filtro = "";
            try
            {
                switch (tipoPesquisado)
                {
                    case "Código":
                        colunaPesquisada = "ID_Livro";
                        filtro = String.Format("{0} = {1}", colunaPesquisada, pesquisa);
                        break;
                    case "Nome":
                        colunaPesquisada = "Nome";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                    case "Valor Unitário":
                        colunaPesquisada = "precoUnitario";
                        filtro = String.Format("{0} = {1}", colunaPesquisada, pesquisa);
                        break;
                    case "Quantidade em Estoque":
                        colunaPesquisada = "estoque";
                        filtro = String.Format("{0} = {1}", colunaPesquisada, pesquisa);
                        break;
                    case "Gênero":
                        colunaPesquisada = "Genero";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                    case "Autor":
                        colunaPesquisada = "Autores";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                }

                var tbFiltrado = tbLivrosOriginal.Select(filtro, "ID_Livro ASC").CopyToDataTable();
                return tbFiltrado;
            }
            catch
            {
                return null;
            }
            
        }

    }
}
