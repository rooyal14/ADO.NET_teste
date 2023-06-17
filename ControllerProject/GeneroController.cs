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
    public class GeneroController
    {
        public bool addGeneroToDB(Genero genero)
        {
            if (!generoIsDuplicated(genero))
            {
                SqlConnection conn = DBCon.Conn();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "insert into Tb_Genero(Nome) values (@Nome)";
                command.Parameters.AddWithValue("@Nome", genero.Nome);
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }



        public void deleteGeneroFromDB(Genero genero)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from Tb_Genero where ID_Genero = @idGenero";
            command.Parameters.AddWithValue("@idGenero", genero.ID_Genero);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updateGeneroFromDB(Genero genero)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Tb_Genero SET Nome=@Nome WHERE ID_Genero=@idGenero";
            command.Parameters.AddWithValue("@idGenero", genero.ID_Genero);
            command.Parameters.AddWithValue("@Nome", genero.Nome);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable getGenerosFromDB()
        {
            var conn = DBCon.Conn();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT Nome, ID_Genero FROM Tb_Genero";
            var query = DBCon.queryDataTable(command);
            return query;
        }

        public DataTable getChangeableGenerosFromDB()
        {
            var conn = DBCon.Conn();
            var command = conn.CreateCommand();
            //command.CommandText = "SELECT * FROM Tb_Genero WHERE ID_Genero > 0";
            command.CommandText = "EXEC RelatorioEstoqueLivros";
            var table = DBCon.queryDataTable(command);
            conn.Close();
            return table;
        }

        public bool checkIfProtectedGenero(Genero genero)
        {
            if (genero.ID_Genero == "0")
                return true;
            else
                return false;

        }

        public bool generoIsReferenced(Genero genero)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT COUNT(ID_Livro) FROM Tb_Livro WHERE ID_Genero=@ID_Genero";
            command.Parameters.AddWithValue("@ID_Genero", genero.ID_Genero);
            var query = DBCon.queryDataTable(command);
            conn.Close();
            var result = Convert.ToInt32(query.Rows[0][0].ToString()) == 0 ? false : true;
            return result;
        }

        public bool generoIsDuplicated(Genero genero)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select count(nome) from Tb_Genero where nome = @nome";
            command.Parameters.AddWithValue("@nome", genero.Nome);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();

            var result = Convert.ToInt32(query.Rows[0][0].ToString()) == 0 ? false : true;
            return result;

        }

        public DataTable searchGenerosByColumn(string tipoPesquisado, string pesquisa, DataTable tbGenerosOriginal)
        {
            string colunaPesquisada;
            string filtro = "";
            try
            {
                switch (tipoPesquisado)
                {
                    case "Código":
                        colunaPesquisada = "ID_Genero";
                        filtro = String.Format("{0} = {1}", colunaPesquisada, pesquisa);
                        break;
                    case "Nome":
                        colunaPesquisada = "Nome";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                }

                var tbFiltrado = tbGenerosOriginal.Select(filtro, "ID_Genero ASC").CopyToDataTable();
                return tbFiltrado;
            }
            catch
            {
                return null;
            }

        }


    }
}
