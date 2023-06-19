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
    public class AutorController
    {
        public void addAutorToDB(Autor autor)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "insert into Tb_Autor(nome) values (@nome)";
            command.Parameters.AddWithValue("@nome", autor.nome);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteAutorFromDB(Autor autor)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from Tb_Autor where ID_Autor = @ID_Autor";
            command.Parameters.AddWithValue("@ID_Autor", autor.ID_Autor);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void updateAutorFromDB(Autor autor)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Tb_Autor SET nome=@nome WHERE ID_Autor=@ID_Autor";
            command.Parameters.AddWithValue("@ID_Autor", autor.ID_Autor);
            command.Parameters.AddWithValue("@nome", autor.nome);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable getChangeableAutoresFromDB()
        {
            var conn = DBCon.Conn();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Tb_Autor WHERE ID_Autor > 1";
            var table = DBCon.queryDataTable(command);
            conn.Close();
            return table;
        }

        public bool autorIsDuplicated(Autor autor)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT COUNT(Nome) FROM Tb_Autor WHERE Nome = @Nome";
            command.Parameters.AddWithValue("@Nome", autor.nome);
            DataTable query = DBCon.queryDataTable(command);
            conn.Close();

            var result = Convert.ToInt32(query.Rows[0][0].ToString()) == 0 ? false : true;
            return result;

        }

        public void substituirPorAutorIndefinido(Autor autor)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Tb_AutorEscreve SET ID_Autor=0 WHERE ID_Autor=@ID_Autor";
            command.Parameters.AddWithValue("@ID_Autor", autor.ID_Autor);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public bool checkIfProtectedAutor(Autor autor)
        {
            if (autor.ID_Autor== "0")
                return true;
            else
                return false;

        }

        public bool autorIsReferenced(Autor autor)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT COUNT(ID_AutorEscreve) FROM Tb_AutorEscreve WHERE ID_Autor=@ID_Autor";
            command.Parameters.AddWithValue("@ID_Autor", autor.ID_Autor);
            var query = DBCon.queryDataTable(command);
            conn.Close();
            var result = Convert.ToInt32(query.Rows[0][0].ToString()) == 0 ? false : true;
            return result;
        }

        public DataTable searchAutoresByColumn(string tipoPesquisado, string pesquisa, DataTable tbAutoresOriginal)
        {
            string colunaPesquisada;
            string filtro = "";
            try
            {
                switch (tipoPesquisado)
                {
                    case "Código":
                        colunaPesquisada = "ID_Autor";
                        filtro = String.Format("{0} = {1}", colunaPesquisada, pesquisa);
                        break;
                    case "Nome":
                        colunaPesquisada = "Nome";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;
                }

                var tbFiltrado = tbAutoresOriginal.Select(filtro, "ID_Autor ASC").CopyToDataTable();
                return tbFiltrado;
            }
            catch
            {
                return null;
            }

        }


        public class PopupInsertLivro
        {
            private List<string> allAutores = new List<string>();
            private List<string> selectedAutores = new List<string>();
            private List<string> containsAutores = new List<string>();
            private List<string> displayAutores = new List<string>();

            public void setAllAutores()
            {
                var comm = DBCon.Conn().CreateCommand();
                comm.CommandText = "select nome from Tb_Autor";
                var dt = DBCon.queryDataTable(comm);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    allAutores.Add(dt.Rows[i].ItemArray[0].ToString());
                }
            }

            public void setContainsAutores()
            {
                allAutores.ForEach(x => containsAutores.Add(x));
            }

            public void setDisplayAutores()
            {
                this.setContainsAutores();
                selectedAutores.ForEach(item => displayAutores.Add(item));
                containsAutores.ForEach(item => displayAutores.Add(item));

            }

            public void atualizarSelecao(List<string> itensSelecionados)
            {
                /*
                Função responsável por atualizar seleção do autor, deixando 
                no topo da lista os autores selecionados e abaixo os pesquisados
                pelo usuário da aplicação
                */
                displayAutores.Clear();
                selectedAutores.Clear();
                containsAutores.Clear();
                this.setContainsAutores();

                foreach (var item in itensSelecionados)
                {
                    selectedAutores.Add(item);
                    containsAutores.Remove(item);
                }

                selectedAutores.ForEach(item => displayAutores.Add(item));
                containsAutores.ForEach(item => displayAutores.Add(item));

            }

            public void pesquisarAutor(string pesquisa)
            {
                /*
                Função responsável por mostrar resultados de acordo com o texto
                pesquisado pelo usuário da aplicação
                */
                displayAutores.Clear();
                containsAutores.Clear();
                foreach (var autor in allAutores)
                {
                    if (autor.Contains(pesquisa) && !selectedAutores.Contains(autor))
                        containsAutores.Add(autor);
                }

                selectedAutores.ForEach(item => displayAutores.Add(item));
                containsAutores.ForEach(item => displayAutores.Add(item));
            }



            public List<string> getDisplayAutores()
            {
                return this.displayAutores;
            }

            public List<string> getAllAutores()
            {
                return this.allAutores;
            }

            public List<string> getSelectedAutores()
            {
                return this.selectedAutores;
            }

        }

        
    }
}
