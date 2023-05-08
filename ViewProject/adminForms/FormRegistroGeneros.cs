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
    public partial class FormRegistroGeneros : Form
    {
        public FormRegistroGeneros()
        {
            InitializeComponent();
            fillDgv();
        }

        GeneroController generoController = new GeneroController();

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
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from tbGeneros";
            var table = DBCon.queryDataTable(command);
            dgvGeneros.DataSource = table;
            conn.Close();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmIdGenero.Text = "";
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
            Genero genero = new Genero(fmIdGenero.Text, fmNome.Text);
            
            generoController.deleteGeneroFromDB(genero);
            fillDgv();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero(fmIdGenero.Text, fmNome.Text);

            if (String.IsNullOrEmpty(fmIdGenero.Text))
            {
                //TODO: Alerta caso haja repetição de nomes
                generoController.addGeneroToDB(genero);
            }
            else
            {
                generoController.updateGeneroFromDB(genero);
            }
            fillDgv();
        }
    }
}
