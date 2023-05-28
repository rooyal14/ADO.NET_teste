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
            string senhaHash = Criptografia.GerarHash(fmSenha.Text);

            bool validaCPF = TesteCpf.IsCpf(fmCPF.Text);

            if (validaCPF == true) MessageBox.Show("CPF Valido");
            else MessageBox.Show("CPF INvalido");


            User usuario = new User(fmCPF.Text,
                                    fmNome.Text,
                                    senhaHash,
                                    fmEmail.Text,
                                    fmTelefone.Text,
                                    false);
            if (userController.addUserToDB(usuario))
            {
                MessageBox.Show("Usuário cadastrado com sucesso."
                    + "\nSenha Criptofada: ",(senhaHash));
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
