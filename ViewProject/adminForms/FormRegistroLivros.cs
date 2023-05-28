﻿using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewProject.adminForms;

namespace ViewProject
{
    public partial class FormRegistroLivros : Form
    {
        public FormRegistroLivros()
        {
            InitializeComponent();
            fillDgv();
            fillCbx();

        }

        LivroController livroController = new LivroController();
        VendaController vendaController = new VendaController();

        private void fillCbx()
        {
            var comm = DBCon.Conn().CreateCommand();
            comm.CommandText = "SELECT Nome, ID_Genero FROM Tb_Genero";
            var d = DBCon.queryDataTable(comm);
            cbxGenero.ValueMember = d.Columns[1].ToString();
            cbxGenero.DisplayMember = d.Columns[0].ToString();
            cbxGenero.DataSource = d;
        }

        private void fillDgv()
        {
            dgv.DataSource = livroController.getDisplayLivros();

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnChange.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = false;
            changeFormularioEnabled(false);
            if (dgv.CurrentRow != null)
            {
                fmNr.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                fmNome.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                fmPrecoUnitario.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                fmEstoque.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                cbxGenero.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                fmAutor.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                
            }
        }

        private void changeFormularioEnabled(bool arg)
        {

            fmNome.Enabled = arg;
            fmEstoque.Enabled = arg;
            btnAutorPopup.Enabled = arg;
            fmPrecoUnitario.Enabled = arg;
            cbxGenero.Enabled = arg;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmNr.Text = "";
            fmNome.Text = "";
            fmEstoque.Text = "";
            fmAutor.Text = "";
            cbxGenero.SelectedIndex = -1;
            fmPrecoUnitario.Text = "";
            changeFormularioEnabled(true);

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //Comando apenas habilita a edição do registro
            //Implementação feita na função btnInsert_Click
            btnNew.Enabled = true;
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            changeFormularioEnabled(true);
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(fmNr.Text,
                    fmNome.Text,
                    Convert.ToInt32(fmEstoque.Text),
                    Convert.ToDouble(fmPrecoUnitario.Text));

            if (livroController.checkIfProtectedLivro(livro))
            {
                MessageBox.Show("Não é possível deletar o gênero padrão");
            }
            else if (livroController.livroIsReferenced(livro))
            {
                MessageBox.Show("livro cadastrado em livros, deseja substituí-lo e deletar mesmo assim?");
                //TODO: perguntar se o usuário quer mesmo deletar
                if (true)
                {
                    vendaController.substituirPorLivroIndefinido(livro);
                    livroController.deleteLivroFromDB(livro);
                }
            }
            else
            {
                livroController.deleteLivroFromDB(livro);
                MessageBox.Show("Usuário excluído com sucesso");
            }
            fillDgv();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(fmNr.Text,
                    fmNome.Text,
                    Convert.ToInt32(fmEstoque.Text),
                    Convert.ToDouble(fmPrecoUnitario.Text));

            if (String.IsNullOrEmpty(fmNr.Text))
            {
                //TODO: Alerta caso haja repetição de nomes
                livroController.addLivroToDB(livro);                
            } else
            {
                livroController.updateLivroFromDB(livro);
            }

            fillDgv();




        }

        private void btnAutorPopup_Click(object sender, EventArgs e)
        {
            new FormPopupSelectAutores().ShowDialog();
        }
    }
}