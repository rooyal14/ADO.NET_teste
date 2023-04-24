using ControllerProject;
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

namespace ADO.NET_teste
{
    public partial class FormRegistroLivros : Form
    {
        public FormRegistroLivros()
        {
            InitializeComponent();
            fillDgv();
        }

        LivroController livroController = new LivroController();

        private void fillDgv()
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from tbLivros";
            var table = DBCon.queryDataTable(command);
            dgv.DataSource = table;
            conn.Close();

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
                fmEstoque.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                fmAutor.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void changeFormularioEnabled(bool arg)
        {

            fmNome.Enabled = arg;
            fmEstoque.Enabled = arg;
            fmAutor.Enabled = arg;

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
                    fmAutor.Text);

            livroController.deleteLivroFromDB(livro);
            fillDgv();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(fmNr.Text,
                    fmNome.Text,
                    Convert.ToInt32(fmEstoque.Text),
                    fmAutor.Text);
            
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
    }
}
