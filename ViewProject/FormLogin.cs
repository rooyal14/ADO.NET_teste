using ControllerProject;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }
        string currentUserCpf;
        ClienteController clienteController = new ClienteController();
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormCadastroUsuario().ShowDialog();
            MessageBox.Show("SS");
            this.Show();
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool validado = clienteController.loginUser(fmEmail.Text, fmSenha.Text, out currentUserCpf);
            if (validado)
            {
                this.Hide();
                var FormRegistroLivros = new FormRegistroLivros();
                FormRegistroLivros.Closed += (s, args) => this.Close();
                FormRegistroLivros.Show();
            } else
            {
                MessageBox.Show("Email ou usuário incorretos, tente novamente");
            }
        }

    }
}
