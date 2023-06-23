using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject.adminForms
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistroClientes().ShowDialog();
            this.Show();
        } 

        private void btnRegistroLivros_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistroLivros().ShowDialog();
            this.Show();
        }

        private void btnRegistroAutores_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistroAutores().ShowDialog();
            this.Show();
        }

        private void btnRegistroGeneros_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistroGeneros().ShowDialog();
            this.Show();
        }

        private void btnRegistroVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRelatorioVenda().ShowDialog();
            this.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRelatorios().ShowDialog();
            this.Show();
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
      
        }

        private void FormMenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormMenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
