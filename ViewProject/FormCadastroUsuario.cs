using ControllerProject;
using CpfLibrary;
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
            ActiveControl = fmCPF;
        }

        UserController userController = new UserController();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string senhaHash = Criptografia.GerarHash(fmSenha.Text);
            User usuario = new User(fmCPF.Text,
                                    fmNome.Text,
                                    senhaHash,
                                    fmEmail.Text,
                                    fmTelefone.Text,
                                    false);
            if (userController.addUserToDB(usuario))
            {
                MessageBox.Show("Usuário cadastrado com sucesso."
                    + "\nSenha Criptografada: ",(senhaHash));
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

        private void button1_Click(object sender, EventArgs e)
        {
            fmCPF.Text = "";
            fmNome.Text = "";
            fmSenha.Text = "";
            fmEmail.Text = "";
            fmTelefone.Text = "";
            ActiveControl = fmCPF;
        }
        private void fmCPF_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void fmCPF_Leave(object sender, EventArgs e)
        {
            bool validaCPF = TesteCpf.IsCpf(fmCPF.Text);

            if (validaCPF == false)
            {
                MessageBox.Show("O CPF digitado está incorreto.\nPor favor, " +
                "verifique os dados inseridos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ActiveControl = fmCPF;
            }
        }

        private void fmCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fmSenha_Leave(object sender, EventArgs e)
        {
            int contaCaracteres = fmSenha.Text.Length;
            if ((contaCaracteres <= 7) || (contaCaracteres > 10))
            {
                MessageBox.Show("A senha deve ter o tamanho mínimo de 8 caracteres " +
                    "e máximo de 10 caracteres.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fmSenha.Text = "";
                fmConfirmaSenha.Text = "";
                ActiveControl = fmSenha;
            }
        }

        private void fmConfirmaSenha_Leave(object sender, EventArgs e)
        {
            if (fmSenha.Text != fmConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas digitadas são diferentes. " +
                    "\nPor favor, refaça o processo.", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                fmSenha.Text = "";
                fmConfirmaSenha.Text = "";
                ActiveControl = fmSenha;
            }
        }

        private void fmNome_Leave(object sender, EventArgs e)
        {
            int contaCaracteres = fmNome.Text.Length;
            if ((contaCaracteres <= 3) || (contaCaracteres > 100))
            {
                MessageBox.Show("O Nome deve ter o tamanho mínimo de 3 caracteres " +
                    "e máximo de 100 caracteres.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = fmNome;
            }
        }

        private void fmEmail_Leave(object sender, EventArgs e)
        {
            int contaCaracteres = fmEmail.Text.Length;
            if ((contaCaracteres <= 3) || (contaCaracteres > 100))
            {
                MessageBox.Show("O e-mail deve ter o tamanho mínimo de 3 caracteres " +
                    "e máximo de 100 caracteres.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = fmEmail;
            }
        }

        private void fmTelefone_Leave(object sender, EventArgs e)
        {
            int contaCaracteres = fmTelefone.Text.Length;
            if (contaCaracteres <10)
            {
                MessageBox.Show("O Telefone deve ter o tamanho mínimo de 10 caracteres.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = fmEmail;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
