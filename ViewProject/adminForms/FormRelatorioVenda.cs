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
            command.CommandText = "SELECT * FROM Tb_Venda";
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
                command.CommandText = "SELECT tbiv.ID_ItemVendido, tbu.Nome, tbl.Nome as Livro, tbiv.quantidade, " +
                    "tbiv.subtotal FROM Tb_ItemVendido AS tbiv LEFT JOIN Tb_Venda AS tbv ON tbiv.ID_Venda = " +
                    "tbv.ID_Venda LEFT JOIN Tb_Usuarios AS tbu ON tbv.ID_Cliente = tbu.ID_Cliente LEFT JOIN " +
                    "Tb_Livro AS tbl ON tbiv.ID_Livro = tbl.ID_Livro WHERE tbiv.ID_Venda = @ID_Venda";
                command.Parameters.AddWithValue("@ID_Venda", dgvVendas.CurrentRow.Cells[0].Value.ToString());
                var table = DBCon.queryDataTable(command);
                dgvItensVendidos.DataSource = table;
                conn.Close();
            }
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
