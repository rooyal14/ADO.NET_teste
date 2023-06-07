using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject.adminForms
{
    public partial class FormRelatorioVenda : Form
    {
        public FormRelatorioVenda()
        {
            InitializeComponent();
            fillDgvVendas();
        }

        private void fillDgvVendas()
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT tbv.ID_Venda, tbv.total, tbu.Nome, tbv.Data FROM Tb_Venda as tbv LEFT JOIN Tb_Usuarios as tbu on tbv.ID_Cliente = tbu.ID_Cliente";
            var table = DBCon.queryDataTable(command);
            dgvVendas.DataSource = table;
            conn.Close();
        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVendas.CurrentRow != null)
            {
                SqlConnection conn = DBCon.Conn();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT tbiv.ID_ItemVendido, tbl.Nome as Livro, tbiv.quantidade, tbiv.subtotal FROM Tb_ItemVendido " +
                    "AS tbiv LEFT JOIN Tb_Venda AS tbv ON tbiv.ID_Venda = tbv.ID_Venda LEFT JOIN Tb_Livro AS tbl ON " +
                    "tbiv.ID_Livro = tbl.ID_Livro WHERE tbiv.ID_Venda = @ID_Venda";
                command.Parameters.AddWithValue("@ID_Venda", dgvVendas.CurrentRow.Cells[0].Value.ToString());
                var table = DBCon.queryDataTable(command);
                dgvItensVendidos.DataSource = table;
                command.CommandText = "SELECT CPF FROM Tb_Usuarios WHERE ID_Cliente = (SELECT ID_Cliente FROM Tb_Venda WHERE ID_Venda = @ID_Venda)";
                var cpf = DBCon.queryDataTable(command).Rows[0][0].ToString();
                conn.Close();
                lblTotal.Text = dgvVendas.CurrentRow.Cells[1].Value.ToString();
                lblNome.Text = dgvVendas.CurrentRow.Cells[2].Value.ToString();
                lblCPF.Text = cpf;
            }
            
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
