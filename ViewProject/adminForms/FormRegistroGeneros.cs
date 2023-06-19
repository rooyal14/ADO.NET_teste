using ControllerProject;
using CpfLibrary;
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
    public partial class FormRegistroGeneros : Form
    {
        GeneroController generoController = new GeneroController();
        LivroController livroController = new LivroController();
        DataTable tbGeneros;
        public FormRegistroGeneros()
        {
            InitializeComponent();
            fillDgv();
            if (dgvGeneros.CurrentRow != null)
            {
                fmIdGenero.Text = dgvGeneros.CurrentRow.Cells[0].Value.ToString();
                fmNome.Text = dgvGeneros.CurrentRow.Cells[1].Value.ToString();

            }
            cbxPesquisa.SelectedIndex = 0;
        }

        
        

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnChange.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = false;
            fmNome.Enabled = false;

            if (dgvGeneros.CurrentRow != null)
            {
                fmIdGenero.Text = dgvGeneros.CurrentRow.Cells[0].Value.ToString();
                fmNome.Text = dgvGeneros.CurrentRow.Cells[1].Value.ToString();

            }

        }

        private void fillDgv()
        {
            tbGeneros = generoController.getChangeableGenerosFromDB();
            dgvGeneros.DataSource = tbGeneros;   

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmIdGenero.Text = "";
            fmNome.Text = "";
            fmNome.Enabled = true;
            ActiveControl = fmNome;
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            //Comando apenas habilita a edição do registro
            //Implementação feita na função btnInsert_Click
            btnNew.Enabled = true;
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmNome.Enabled = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Genero genero = new Genero(fmIdGenero.Text, fmNome.Text);

            if (generoController.checkIfProtectedGenero(genero))
            {
                MessageBox.Show("Não é possível deletar o gênero padrão");
            }
            else if (generoController.generoIsReferenced(genero))
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Genero cadastrado em livros, deseja substituí-lo e deletar mesmo assim?",
                    "",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    livroController.substituirPorGeneroIndefinido(genero);
                    generoController.deleteGeneroFromDB(genero);
                }

            }
            else
            {
                generoController.deleteGeneroFromDB(genero);
                MessageBox.Show("Gênero excluído com sucesso");
            }
            fillDgv();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            Genero genero = new Genero(fmIdGenero.Text, fmNome.Text);
            int contaCaracteres = fmNome.Text.Length;
            bool generoCadastrado = generoController.generoIsDuplicated(genero);

            if (fmNome.Text == "")
            {
                MessageBox.Show("Informe o Gênero.",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveControl = fmNome;

            }

            else if (contaCaracteres < 3)
            {
                MessageBox.Show("O Gênero deve ter o tamanho mínimo de 3 caracteres."
                    , "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = fmNome;
            }

            else if (generoCadastrado == true)
            {
                MessageBox.Show("O Gênero já está Cadastrado.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (String.IsNullOrEmpty(fmIdGenero.Text))
            
                //TODO: Alerta caso haja repetição de nomes
                generoController.addGeneroToDB(genero);

            else generoController.updateGeneroFromDB(genero);
                
             
            
            fillDgv();
        }

        private void fmPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fmPesquisa.Text))
            {
                dgvGeneros.DataSource = tbGeneros;
                return;
            }
            else
            {
                dgvGeneros.DataSource = generoController.searchGenerosByColumn(cbxPesquisa.SelectedItem.ToString(), fmPesquisa.Text, tbGeneros);
            }



        }

        private void FormRegistroGeneros_Load(object sender, EventArgs e)
        {

        }
    }
}
