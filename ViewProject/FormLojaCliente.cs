using ControllerProject;
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

namespace ViewProject
{
    public partial class FormLojaCliente : Form
    {
        //Separar classe do controller carrinho
        UserController userController = new UserController();

        LivroController livroController = new LivroController();

        VendaController vendaController = new VendaController();

        private Carrinho repositorioCarrinho = new Carrinho();

        User user;

        DataTable livrosTable;
        
        public FormLojaCliente(User user)
        {
            InitializeComponent();
            livrosTable = livroController.getDisplayLivros();
            this.user = user;
            fillDgvLivros();
            fillDgvCarrinho();
            if (user != null)
            {
                fillUserInfo();
            }
            cbxPesquisa.SelectedIndex = 0;
            
        }

        private void fillUserInfo()
        {
            lblCPF.Text = user.cpf;
            lblNome.Text = user.nome;
        }

        private void fillDgvLivros()
        {

            dgv.DataSource = livrosTable;

            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "Nome";
            dgv.Columns[2].HeaderText = "Valor Unitário";
            dgv.Columns[3].HeaderText = "Quantidade em Estoque";
            dgv.Columns[4].HeaderText = "Gênero";
            dgv.Columns[5].HeaderText = "Autores";

        }

        private void fillDgvCarrinho()
        {
            //binding.DataSource = repositorioCarrinho.obterCarrinho();
            //dgvCarrinho.DataSource = binding;
            dgvCarrinho.DataSource = repositorioCarrinho.obterCarrinho();

            dgvCarrinho.Columns[0].HeaderText = "Código";
            dgvCarrinho.Columns[1].HeaderText = "Nome do Livro";
            dgvCarrinho.Columns[2].HeaderText = "Quantidade";
            dgvCarrinho.Columns[3].HeaderText = "Preço Unitário";
            dgvCarrinho.Columns[4].HeaderText = "Subtotal";

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                fmNr.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                fmNome.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                fmPrecoUnitario.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                fmEstoque.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                fmGenero.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                fmAutores.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                numQtd.Value = 1;
                btnRemoveFromCart.Enabled = false;
            }
        }

        private void changeFormularioEnabled(bool arg)
        {

            fmNome.Enabled = arg;
            fmEstoque.Enabled = arg;
            fmGenero.Enabled = arg;

        }

        private void dgvCarrinho_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCarrinho.CurrentRow != null)
            {
                ItemCarrinho item = repositorioCarrinho.obterCarrinho().Where(x => x.Codigo == dgvCarrinho.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault();
                Livro livro = item.getLivro();
                fmNr.Text = livro.ID_Livro;
                fmNome.Text = livro.nome;
                fmEstoque.Text = livro.estoque.ToString();
                fmPrecoUnitario.Text = livro.precoUnitario.ToString();
                numQtd.Enabled = true;
                numQtd.Value = item.Qtd;
                btnRemoveFromCart.Enabled = true;
            }

        }

        private void btnAddToCarrinho_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(fmNr.Text,
                    fmGenero.Text,
                    fmNome.Text,
                    Convert.ToInt32(fmEstoque.Text),
                    Convert.ToDouble(fmPrecoUnitario.Text));
            ItemCarrinho item = new ItemCarrinho(livro, Convert.ToInt32(numQtd.Value));
            if (item.Qtd > livro.estoque)
            {
                MessageBox.Show("Estoque indisponível");
                return;
            }
            else
            {
                repositorioCarrinho.adicionarItemAoCarrinho(item);
                lblTotal.Text = repositorioCarrinho.getTotal().ToString();
            }

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(fmNr.Text,
                    fmGenero.Text,
                    fmNome.Text,
                    Convert.ToInt32(fmEstoque.Text),
                    Convert.ToDouble(fmPrecoUnitario.Text));
            repositorioCarrinho.removerItemDoCarrinho(livro);
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("Necessário logar para confirmar compra");
                this.Hide();
                var a = new FormLoginCompra();
                a.ShowDialog();
                if (String.IsNullOrEmpty(a.CurrentUserEmail))
                {
                    this.Show();
                    MessageBox.Show("Necessário logar para confirmar compra");
                    return;
                }   
                else
                {
                    user = userController.getUser(a.CurrentUserEmail);
                    fillUserInfo();
                    this.Show();
                    MessageBox.Show("Usuário Logado com sucesso, confirme sua compra");
                }
                    
            }
            
            this.Hide();
            var telaDePagamento = new FormPagamento(vendaController, repositorioCarrinho, user.email, 
                lblNome.Text, lblCPF.Text);
            telaDePagamento.ShowDialog();
            this.Show();
            if (telaDePagamento.CompraRealizada)
            {
                MessageBox.Show("Compra efetuada com sucesso");
                repositorioCarrinho.limparCarrinho();
            }
            else
            {
                MessageBox.Show("Erro na compra");
            }
            fillDgvLivros();
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fmPesquisa.Text))
            {
                dgv.DataSource = livrosTable;
                return;
            } 
            else
            {
                dgv.DataSource = livroController.searchLivrosByColumn(cbxPesquisa.SelectedItem.ToString(), fmPesquisa.Text, livrosTable);
            }
            
            

        }
    }
}
