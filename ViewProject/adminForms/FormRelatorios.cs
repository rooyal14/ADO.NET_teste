using System;
using ControllerProject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormRelatorios : Form
    {
        GerarRelatorioPDF geradorDeRelatorios = new GerarRelatorioPDF();
        DataTable dgvTable;
        string currentRelatorio;
        public FormRelatorios()
        {
            InitializeComponent();
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (currentRelatorio)
                {
                    case "Clientes cadastrados":
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Lista de Clientes Cadastrados");
                        break;
                    case "Estoque":
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Lista de Estoque");
                        break;
                    case "Fechamento de caixa":
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Fechamento de Caixa do dia "+ DateTime.Today.ToString("dd/MM/yyyy"));
                        break;
                    case "Livros mais vendidos":
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Lista dos 5 Livros mais vendidos");
                        break;
                    case "Pedidos realizados":
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Lista de Itens Pedidos");
                        break;

                }
                
            }
        }

        private void btnClientesCadastrados_Click(object sender, EventArgs e)
        {
            currentRelatorio = "Clientes cadastrados";
            sfd.FileName = "relatorioClientesCadastrados.pdf";
            dgvTable = geradorDeRelatorios.gerarDataTableClientesCadastrados();
            dgv.DataSource = dgvTable;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            currentRelatorio = "Estoque";
            sfd.FileName = "relatorioEstoqueDisponivel.pdf";
            dgvTable = geradorDeRelatorios.gerarDataTableEstoqueLivros();
            dgv.DataSource = dgvTable;
            
        }

        private void btnFechamentoDeCaixa_Click(object sender, EventArgs e)
        {
            currentRelatorio = "Fechamento de caixa";
            sfd.FileName = "relatorioFechamentoDeCaixa.pdf";
            dgvTable = geradorDeRelatorios.gerarDataTableFechamentoDeCaixa();
            dgv.DataSource = dgvTable;
            
        }

        private void btnMaisVendidos_Click(object sender, EventArgs e)
        {
            currentRelatorio = "Livros mais vendidos";
            sfd.FileName = "relatorioLivrosMaisVendidos.pdf";
            dgvTable = geradorDeRelatorios.gerarDataTableLivrosMaisVendidos();
            dgv.DataSource = dgvTable;
        }

        private void btnPedidosRealizados_Click(object sender, EventArgs e)
        {
            currentRelatorio = "Pedidos realizados";
            sfd.FileName = "relatorioPedidosRealizados.pdf";
            dgvTable = geradorDeRelatorios.gerarDataTablePedidosRealizados();
            dgv.DataSource = dgvTable;
        }
    }
}
