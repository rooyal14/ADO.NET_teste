using ControllerProject;
using ModelProject;
using System;
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
    public partial class FormPagamento : Form
    {
        VendaController vendaController;
        Carrinho repositorioCarrinho;
        private string currentUserEmail;
        public bool CompraRealizada { get; set; }

        public FormPagamento(VendaController vendaController, Carrinho repositorioCarrinho, 
            string currentUserEmail, string nome, string cpf)
        {
            this.vendaController = vendaController;
            this.repositorioCarrinho = repositorioCarrinho;
            this.currentUserEmail = currentUserEmail;
            InitializeComponent();
            fillDgvCarrinho();
            this.CompraRealizada = false;
            this.lblNome.Text = nome;
            this.lblCPF.Text = cpf;
            this.fmTotalFaltaPagar.Text = lblTotal.Text;
            this.fmDinheiro.Text = "0";
            this.fmTroco.Text = "0";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fmDinheiro.Text) && Convert.ToInt32(fmDinheiro.Text) >= repositorioCarrinho.getTotal())
            {
                vendaController.confirmarCompra(repositorioCarrinho, currentUserEmail);
                repositorioCarrinho.limparCarrinho();
                CompraRealizada = true;
                this.Close();
            } else
            {
                MessageBox.Show("Dinheiro insuficiente para compra");
            }
            
        }

        private void fillDgvCarrinho()
        {
            dgvCarrinho.DataSource = repositorioCarrinho.obterCarrinho();

            dgvCarrinho.Columns[0].HeaderText = "Código";
            dgvCarrinho.Columns[1].HeaderText = "Nome do Livro";
            dgvCarrinho.Columns[2].HeaderText = "Quantidade";
            dgvCarrinho.Columns[3].HeaderText = "Preço Unitário";
            dgvCarrinho.Columns[4].HeaderText = "Subtotal";

            lblTotal.Text = repositorioCarrinho.getTotal().ToString();
        }

        private void fmDinheiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(lblTotal.Text);
                double troco = Convert.ToDouble(fmTroco.Text);
                double faltaPagar = Convert.ToDouble(fmTotalFaltaPagar.Text);
                double dinheiro = Convert.ToDouble(fmDinheiro.Text);
                if (dinheiro < total)
                {
                    fmTroco.Text = "0";
                    fmTotalFaltaPagar.Text = (total - dinheiro).ToString();
                } else if (dinheiro >= total)
                {
                    fmTotalFaltaPagar.Text = "0";
                    fmTroco.Text = (dinheiro - total).ToString();
                }
            }
            catch
            {

            }
        }
    }
}
