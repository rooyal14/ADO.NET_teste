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

        }

        private void btnClientesCadastrados_Click(object sender, EventArgs e)
        {
            dgvTable = geradorDeRelatorios.gerarDataTableClientesCadastrados();
            dgv.DataSource = dgvTable;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            dgvTable = geradorDeRelatorios.gerarDataTableEstoqueLivros();
            dgv.DataSource = dgvTable;
        }

        private void btnFechamentoDeCaixa_Click(object sender, EventArgs e)
        {
            dgvTable = geradorDeRelatorios.gerarDataTableFechamentoDeCaixa();
            dgv.DataSource = dgvTable;
        }

        private void btnMaisVendidos_Click(object sender, EventArgs e)
        {
            dgvTable = geradorDeRelatorios.gerarDataTableLivrosMaisVendidos();
            dgv.DataSource = dgvTable;
        }

        private void btnPedidosRealizados_Click(object sender, EventArgs e)
        {
            dgvTable = geradorDeRelatorios.gerarDataTablePedidosRealizados();
            dgv.DataSource = dgvTable;
        }
    }
}
