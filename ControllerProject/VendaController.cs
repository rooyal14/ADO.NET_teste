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
    public class VendaController
    {
        public void confirmarCompra(Carrinho carrinho, string email)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command;

            //Inserção da compra
            command = conn.CreateCommand();
            command.CommandText = "SELECT ID_Cliente FROM Tb_Usuarios WHERE Email=@Email";
            command.Parameters.AddWithValue("@Email", email);
            string ID_Cliente = DBCon.queryDataTable(command).Rows[0].ItemArray[0].ToString();

            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Tb_Venda (total, ID_Cliente, data) VALUES (@total, @ID_Cliente, @date)";
            command.Parameters.AddWithValue("@total", carrinho.getTotal());
            command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
            command.Parameters.AddWithValue("@date", DateTime.Now);
            command.ExecuteNonQuery();

            //Inserção dos itens da compra
            command = conn.CreateCommand();
            command.CommandText = "SELECT MAX(ID_Venda) FROM Tb_Venda WHERE ID_Cliente=@ID_Cliente";
            command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
            string ID_Venda = DBCon.queryDataTable(command).Rows[0].ItemArray[0].ToString();

            foreach (ItemCarrinho item in carrinho.obterCarrinho())
            {
                command = conn.CreateCommand();
                command.CommandText = "INSERT INTO Tb_ItemVendido(ID_Venda, subtotal, ID_Livro, quantidade) VALUES " +
                    "(@ID_Venda, @subtotal, @ID_Livro, @quantidade)";
                
                command.Parameters.AddWithValue("@ID_Venda", ID_Venda);
                command.Parameters.AddWithValue("@subtotal", item.Subtotal);
                command.Parameters.AddWithValue("@ID_Livro", item.getLivro().ID_Livro);
                command.Parameters.AddWithValue("@quantidade", item.Qtd);
                command.ExecuteNonQuery();
            }
        }

        public void substituirPorClienteDeletado(User usuario)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Tb_Venda SET ID_Cliente=1 WHERE ID_Cliente=" +
                "(SELECT ID_Cliente FROM Tb_Usuarios WHERE CPF=@cpf)";
            command.Parameters.AddWithValue("@cpf", usuario.cpf);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void substituirPorLivroIndefinido(Livro livro)
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Tb_Venda SET ID_Livro=0 WHERE ID_Livro=@ID_Livro";
            command.Parameters.AddWithValue("@ID_Livro", livro.ID_Livro);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable getVendasFromDB()
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT tbv.ID_Venda, tbv.total, tbu.Nome, tbv.Data FROM Tb_Venda as tbv LEFT JOIN Tb_Usuarios as tbu on tbv.ID_Cliente = tbu.ID_Cliente";
            var table = DBCon.queryDataTable(command);
            conn.Close();
            return table;
        }

        public DataTable searchVendasByColumn(string tipoPesquisado, string pesquisa, DataTable tbVendasOriginal)
        {
            string colunaPesquisada;
            string filtro = "";
            try
            {
                switch (tipoPesquisado)
                {
                    case "Código":
                        colunaPesquisada = "ID_Venda";
                        filtro = String.Format("{0} = {1}", colunaPesquisada, pesquisa);
                        break;
                    case "Valor total":
                        colunaPesquisada = "total";
                        filtro = String.Format("{0} = {1}", colunaPesquisada, pesquisa);
                        break;
                    case "Nome":
                        colunaPesquisada = "Nome";
                        filtro = String.Format("{0} LIKE '%{1}%'", colunaPesquisada, pesquisa);
                        break;

                }


                var tbFiltrado = tbVendasOriginal.Select(filtro, "ID_Venda ASC").CopyToDataTable();
                return tbFiltrado;
            }
            catch
            {
                return null;
            }

        }
    }
}
