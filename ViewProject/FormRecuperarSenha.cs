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
    public partial class FormRecuperarSenha : Form
    {
        public FormRecuperarSenha()
        {
            InitializeComponent();
            ActiveControl = fmCPF;
            fmConfirmaSenha.Enabled = false;
            fmSenha.Enabled = false;

        }
        
        UserController userController = new UserController();
        private void FormRecuperarSenha_Load(object sender, EventArgs e)
        {
            
        }

        private void fmSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void fmCPF_Leave(object sender, EventArgs e)
        {
            bool validaCPF = TesteCpf.IsCpf(fmCPF.Text);
            User usuario = new User(fmCPF.Text, null, null, null, null, true);
            bool cpfCadastrado = userController.userIsDuplicated(usuario);

            if ((fmCPF.Text != "") && (!validaCPF))
            {
                fmCPF.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("O CPF digitado está incorreto.\nPor favor, " +
               "verifique os dados inseridos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //fmCPF.Text = "";
                // ActiveControl = fmCPF;
            }

            else if (!cpfCadastrado)
            {
                fmCPF.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("Usuário Não Cadastrado.\n\nVerifique os Dados Cadastrados" +
                    " ou Clique em 'VOLTAR' e Cadastre-se.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // ActiveControl = fmCPF;
            }

            else if (userController.checkIfProtectedUser(usuario))
            {
                fmCPF.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("Não é possível mudar o valor do administrador padrão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //   ActiveControl = fmCPF;
            }
            else if (cpfCadastrado)
            {   
                fmCPF.BackColor = System.Drawing.Color.Green;
                fmConfirmaSenha.Enabled = true;
                fmSenha.Enabled = true;
                ActiveControl = fmSenha;
                fmSenha.BackColor = System.Drawing.Color.White;
                fmConfirmaSenha.BackColor = System.Drawing.Color.White;
            }
        }

        private void fmSenha_Leave(object sender, EventArgs e)
        {
            int contaCaracteres = fmSenha.Text.Length;
            if (fmCPF.Text != "")
            {

                //fmCPF.BackColor = System.Drawing.Color.MediumVioletRed;
                if ((contaCaracteres <= 7) || (contaCaracteres > 10))
                {
                    /*
                    MessageBox.Show("A senha deve ter o tamanho mínimo de 8 caracteres " +
                        "e máximo de 10 caracteres.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fmSenha.Text = "";
                    fmConfirmaSenha.Text = "";*/
                    fmSenha.BackColor = System.Drawing.Color.Red;
                    // ActiveControl = fmSenha;
                }
                else
                {
                    fmSenha.BackColor = System.Drawing.Color.Green;
                    ActiveControl = fmConfirmaSenha;
                }
            }
            else fmSenha.BackColor = System.Drawing.Color.White;

        }

        private void fmConfirmaSenha_Leave(object sender, EventArgs e)
        {

            if ((fmCPF.Text != "") && (fmSenha.Text != ""))
            {
                if (fmSenha.Text != fmConfirmaSenha.Text)
                {
                    /*
                    MessageBox.Show("As senhas digitadas são diferentes. " +
                        "\nPor favor, refaça o processo.", "Atenção!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                    fmSenha.Text = "";
                    fmConfirmaSenha.Text = "";
                    fmSenha.BackColor = System.Drawing.Color.Red;
                    fmConfirmaSenha.BackColor = System.Drawing.Color.Red;

                    //ActiveControl = fmSenha;
                }
            }
            else if (((fmCPF.Text != "") && (fmSenha.Text != "")) && (fmSenha.Text == fmConfirmaSenha.Text))
            {
                fmSenha.BackColor = System.Drawing.Color.Green;
                fmConfirmaSenha.BackColor = System.Drawing.Color.Green;
                ActiveControl = btnConfirmar;

            }
            else if ((fmCPF.Text == "") && (fmSenha.Text == ""))
            {
                fmSenha.BackColor = System.Drawing.Color.White;
                fmConfirmaSenha.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fmCPF.Text = "";
            fmSenha.Text = "";
            fmConfirmaSenha.Text = "";
            fmConfirmaSenha.Enabled = false;
            fmSenha.Enabled = false;
            //ActiveControl = fmCPF;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            string senhaHash = Criptografia.GerarHash(fmSenha.Text);
            User usuario = new User(fmCPF.Text, null, senhaHash, null, null, true);

            bool validaCPF = TesteCpf.IsCpf(fmCPF.Text);
                bool cpfCadastrado = userController.userIsDuplicated(usuario);

            if ((fmCPF.Text != "") && (!validaCPF))
            {
                MessageBox.Show("O CPF digitado está incorreto.\nPor favor, " +
                "verifique os dados inseridos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fmCPF.Text = "";
                // ActiveControl = fmCPF;
            }

            else if (!cpfCadastrado)
            {
                MessageBox.Show("Usuário Não Cadastrado.\n\nVerifique os Dados Cadastrados" +
                    " ou Clique em 'VOLTAR' e Cadastre-se.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // ActiveControl = fmCPF;
            }

            else if (userController.checkIfProtectedUser(usuario))
            {
                MessageBox.Show("Não é possível mudar o valor do administrador padrão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //   ActiveControl = fmCPF;
            }

            else if ((fmSenha.Text == fmConfirmaSenha.Text) && ((fmCPF.Text != "") && (fmSenha.Text != "")))
            {
                userController.updatePasswordFromDB(usuario);
                MessageBox.Show("Senha Redefinida com Sucesso!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                                    
            }
            else
            {
                
                MessageBox.Show("O Processo de redefinir senha não foi concluído!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fmConfirmaSenha.Enabled = false;
                fmSenha.Enabled = false;
                fmSenha.BackColor = System.Drawing.Color.White;
                fmConfirmaSenha.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
