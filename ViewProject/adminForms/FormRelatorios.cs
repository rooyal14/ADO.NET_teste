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
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Valor De Compras De Cada Cliente");
                        break;
                    case "Estoque":
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Lista De Estoque");
                        break;
                    case "Fechamento de caixa":
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Fechamento De Caixa Do dia "+ DateTime.Today.ToString("dd/MM/yyyy"));
                        break;
                    case "Livros mais vendidos":
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Lista Dos 5 Livros Mais Vendidos");
                        break;
                    case "Pedidos realizados":
                        geradorDeRelatorios.geralRelatorios(dgvTable, sfd.FileName, "Lista De Itens Pedidos");
                        break;

                }
                
            }
        }

        private void btnClientesCadastrados_Click(object sender, EventArgs e)
        {
            currentRelatorio = "Clientes cadastrados";
            sfd.FileName = "relatorioTotalPorCliente.pdf";
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
