using ControllerProject;
using ModelProject;
using System;
using System.CodeDom.Compiler;
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
            this.fmDinheiro.Text = "";
            this.fmTroco.Text = 0.ToString("C2");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fmDinheiro.Text) && Convert.ToDouble(fmDinheiro.Text) >= repositorioCarrinho.getTotal())
            {
                vendaController.confirmarCompra(repositorioCarrinho, currentUserEmail);
                repositorioCarrinho.limparCarrinho();
                CompraRealizada = true;
                this.Close();
                this.Hide();
                var FormLogin = new FormLogin();
                FormLogin.Closed += (s, args) => this.Close();
                FormLogin.Show();
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
            dgvCarrinho.Columns[3].DefaultCellStyle.Format = "C2";
            dgvCarrinho.Columns[4].HeaderText = "Subtotal";
            dgvCarrinho.Columns[4].DefaultCellStyle.Format = "C2";

            lblTotal.Text = repositorioCarrinho.getTotal().ToString("C2");
        }

        private void fmDinheiro_TextChanged(object sender, EventArgs e)
        {
            try
                {
                double total = Convert.ToDouble(lblTotal.Text.Substring(2));
                double troco = Convert.ToDouble(fmTroco.Text.Substring(2));
                double faltaPagar = Convert.ToDouble(fmTotalFaltaPagar.Text.Substring(2));
                double dinheiro = Convert.ToDouble(fmDinheiro.Text);
                if (dinheiro < total)
                {
                    fmTroco.Text = 0.ToString("C2");
                    fmTotalFaltaPagar.Text = (total - dinheiro).ToString("C2");
                } else if (dinheiro >= total)
                {
                    fmTotalFaltaPagar.Text = 0.ToString("C2");
                    fmTroco.Text = (dinheiro - total).ToString("C2");
                }
            }
            catch
            {

            }
        }
    }
}
