﻿using ControllerProject;
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

        LivroController livroController = new LivroController();

        VendaController vendaController = new VendaController();

        private Carrinho repositorioCarrinho = new Carrinho();

        private BindingSource binding = new BindingSource();

        private string currentUserEmail;
        public FormLojaCliente(string currentUserEmail)
        {
            this.currentUserEmail = currentUserEmail;
            InitializeComponent();
            fillDgvLivros();
            fillDgvCarrinho();
        }
 

        private void fillDgvLivros()
        {
            dgv.DataSource = livroController.getDisplayLivros(); ;

            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "Genero";
            dgv.Columns[2].HeaderText = "Quantidade em Estoque";
            dgv.Columns[3].HeaderText = "Valor Unitário";
            dgv.Columns[4].HeaderText = "Nome";

        }

        private void fillDgvCarrinho()
        {
            binding.DataSource = repositorioCarrinho.obterCarrinho();
            dgvCarrinho.DataSource = binding;

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
                //fmAutor.Text = livro.autor;
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
            if (String.IsNullOrEmpty(currentUserEmail))
            {
                MessageBox.Show("Necessário logar para confirmar compra");
                this.Hide();
                var a = new FormLoginCompra();
                a.ShowDialog();
                currentUserEmail = a.CurrentUserEmail;
                this.Show();
                if (String.IsNullOrEmpty(currentUserEmail))
                    MessageBox.Show("Usuário Logado com sucesso, confirme sua compra");
                else
                {
                    MessageBox.Show("Necessário logar para confirmar compra");
                }
                return;
            }
            
            
            vendaController.confirmarCompra(repositorioCarrinho, currentUserEmail);
            repositorioCarrinho.limparCarrinho();
            fillDgvLivros();
            this.Hide();
            new FormPagamento().Show() ;
            //FormPagamento.Show();
            //MessageBox.Show("Você comprou!");
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormLojaCliente_Load(object sender, EventArgs e)
        {

        }

        private void numQtd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
