using ControllerProject;
using ModelProject;
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
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        UserController userController = new UserController();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            User usuario = new User(fmCPF.Text,
                                    fmNome.Text,
                                    fmSenha.Text,
                                    fmEmail.Text,
                                    fmTelefone.Text,
                                    false);
            if (userController.addUserToDB(usuario))
            {
                MessageBox.Show("Usuário cadastrado com sucesso");
                this.Close();
            } else
            {
                MessageBox.Show("Usuário já cadastrado");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
