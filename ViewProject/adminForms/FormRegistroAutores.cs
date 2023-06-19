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

namespace ViewProject.adminForms
{
    public partial class FormRegistroAutores : Form
    {
        AutorController autorController = new AutorController();
        DataTable tbAutores;

        public FormRegistroAutores()
        {
            InitializeComponent();
            fillDgv();
            cbxPesquisa.SelectedIndex = 0;
        }

        

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnChange.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = false;
            fmNome.Enabled = false;

            if (dgvAutores.CurrentRow != null)
            {
                fmIdAutor.Text = dgvAutores.CurrentRow.Cells[0].Value.ToString();
                fmNome.Text = dgvAutores.CurrentRow.Cells[1].Value.ToString();

            }

        }

        private void fillDgv()
        {
            tbAutores = autorController.getChangeableAutoresFromDB();
            dgvAutores.DataSource = tbAutores;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmIdAutor.Text = "";
            fmNome.Text = "";
            fmNome.Enabled = true;

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //Comando apenas habilita a edição do registro
            //Implementação feita na função btnInsert_Click
            btnNew.Enabled = true;
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmNome.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor(fmIdAutor.Text, fmNome.Text);
            if (autorController.checkIfProtectedAutor(autor))
            {
                MessageBox.Show("Não é possível deletar o autor padrão");
            }
            else if (autorController.autorIsReferenced(autor))
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Autor cadastrado em livros, deseja substituí-lo e deletar mesmo assim?",
                    "", 
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    autorController.substituirPorAutorIndefinido(autor);
                    autorController.deleteAutorFromDB(autor);
                }
            }
            else
            {
                autorController.deleteAutorFromDB(autor);
                MessageBox.Show("Autor excluído com sucesso");
            }
            
            fillDgv();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor(fmIdAutor.Text, fmNome.Text);

            if (String.IsNullOrEmpty(fmIdAutor.Text))
            {
                if (autorController.autorIsDuplicated(autor))
                {
                    MessageBox.Show("Autor já cadastrado");
                }
                else
                {
                    autorController.addAutorToDB(autor);
                }
            }
            else
            {
                autorController.updateAutorFromDB(autor);
            }
            fillDgv();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fmPesquisa.Text))
            {
                dgvAutores.DataSource = tbAutores;
                return;
            }
            else
            {
                dgvAutores.DataSource = autorController.searchAutoresByColumn(cbxPesquisa.SelectedItem.ToString(), fmPesquisa.Text, tbAutores);
            }



        }

        private void cbxPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
