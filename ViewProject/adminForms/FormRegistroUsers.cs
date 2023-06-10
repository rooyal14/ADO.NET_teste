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

namespace ViewProject
{
    public partial class FormRegistroClientes : Form
    {
        UserController userController = new UserController();
        VendaController vendaController = new VendaController();
        DataTable tbUsers;
        public FormRegistroClientes()
        {
            tbUsers = userController.getChangeableUsersFromDB();
            InitializeComponent();
            fillDgv();
            cbxPesquisa.SelectedIndex = 0;
        }

        bool stateAdicionando = false;

        

         private void btnNew_Click(object sender, EventArgs e)
        {
            stateAdicionando = true;
            btnChange.Enabled = false;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmCPF.Text = "";
            fmNome.Text = "";
            fmSenha.Text = "";
            fmConfirmaSenha.Text = "";
            fmEmail.Text = "";
            fmTelefone.Text = "";
            cbxIsAdmin.Checked = false;
            changeFormularioEnabled(true);
            ActiveControl = fmCPF;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //fmSenha.Text = " ";
            
            string senhaHash = Criptografia.GerarHash(fmSenha.Text);
            string senhaHash1 = Criptografia.GerarHash(fmConfirmaSenha.Text);
            User usuario = new User(fmCPF.Text,
                        fmNome.Text,
                        senhaHash,
                        fmEmail.Text,
                        fmTelefone.Text,
                        cbxIsAdmin.Checked);
            //Comando apenas habilita a edição do registro
            //Implementação feita na função btnInsert_Click

            if (userController.checkIfProtectedUser(usuario))
            {
                MessageBox.Show("Não é possível mudar o valor do administrador padrão");
            }
            else
            {
                btnNew.Enabled = false;
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
                btnInsert.Enabled = true;
                btnVoltar.Enabled = true;
                changeFormularioEnabled(true);
                cbxIsAdmin.Enabled = false;
                fmCPF.Enabled = false;
            }
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string senhaHash = Criptografia.GerarHash(fmSenha.Text);
            User usuario = new User(fmCPF.Text,
                        fmNome.Text,
                        senhaHash,
                        fmEmail.Text,
                        fmTelefone.Text,
                        cbxIsAdmin.Checked);

            if (userController.checkIfProtectedUser(usuario))
            {
                MessageBox.Show("Não é possível deletar um usuário protegido");
            }
            else if (userController.userIsReferenced(usuario))
            {
                MessageBox.Show("Usuário cadastrado em vendas, deseja substituí-lo deletar mesmo assim?");
                //TODO: perguntar se o usuário quer mesmo deletar
                if (true)
                {
                    vendaController.substituirPorClienteDeletado(usuario);
                    userController.deleteUserFromDB(usuario);
                }
            } 
            else
            {
                userController.deleteUserFromDB(usuario);
                MessageBox.Show("Usuário excluído com sucesso");
            }
            fillDgv();

        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (fmCPF.Text == "")
            {
                MessageBox.Show("Preencha os dados solicitados ou clique em Voltar",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fmCPF.Text = "";
                
            }
            
            
            else
            {
                string senhaHash = Criptografia.GerarHash(fmSenha.Text);
                string senhaHash1 = Criptografia.GerarHash(fmConfirmaSenha.Text);
                User usuario = new User(fmCPF.Text,
                                            fmNome.Text,
                                            senhaHash,
                                            fmEmail.Text,
                                            fmTelefone.Text,
                                            cbxIsAdmin.Checked);

                if (stateAdicionando)
                {
                    //TODO: Alerta caso haja repetição de nomes
                    userController.addUserToDB(usuario);
                }
                else
                {
                    userController.updateUserFromDB(usuario);
                }
            }
            fillDgv();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            stateAdicionando = false;

            btnNew.Enabled = true;
            btnChange.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = false;
            changeFormularioEnabled(false);

            if (dgvClientes.CurrentRow != null)
            {
                fmCPF.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                fmNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                fmSenha.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                fmConfirmaSenha.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                fmEmail.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                fmTelefone.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            }
            
        }

        private void fillDgv()
        {
            dgvClientes.DataSource = tbUsers;

        }

        private void changeFormularioEnabled(bool arg)
        {
            fmCPF.Enabled = arg;
            fmNome.Enabled = arg;
            fmSenha.Enabled = arg;
            fmConfirmaSenha.Enabled = arg;
            fmEmail.Enabled = arg;
            fmTelefone.Enabled = arg;
            cbxIsAdmin.Enabled = arg;
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

        private void fmCPF_Leave(object sender, EventArgs e)
        {
            bool validaCPF = TesteCpf.IsCpf(fmCPF.Text);
            User usuario = new User(fmCPF.Text, null, null, null, null, true);
            bool cpfCadastrado = userController.userIsDuplicated(usuario);

            if (fmCPF.Text == "") 
               {
                    MessageBox.Show("Preencha os dados solicitados ou clique em Voltar",
                        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                    fmCPF.Text = "";
                    
                }

            else if ((fmCPF.Text != "") && (!validaCPF))
            {
                MessageBox.Show("O CPF digitado está incorreto.\nPor favor, " +
                "verifique os dados inseridos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fmCPF.Text = "";
                
            }

            else if (cpfCadastrado)
            {
                MessageBox.Show("O Usuário já está Cadastrado.\n\nSelecione o usuário para alterar.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

            else if (userController.checkIfProtectedUser(usuario))
            {
                MessageBox.Show("Não é possível mudar o valor do administrador padrão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        private void fmNome_Leave(object sender, EventArgs e)
        {
            int contaCaracteres = fmNome.Text.Length;
            if ((contaCaracteres < 3) || (contaCaracteres > 100))
            {
                MessageBox.Show("O Nome deve ter o tamanho mínimo de 3 caracteres " +
                    "e máximo de 100 caracteres.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = fmNome;
            }
        }

        private void fmEmail_Leave(object sender, EventArgs e)
        {
            int contaCaracteres = fmEmail.Text.Length;
            if ((contaCaracteres < 3) || (contaCaracteres > 100))
            {
                MessageBox.Show("O e-mail deve ter o tamanho mínimo de 3 caracteres " +
                    "e máximo de 100 caracteres.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = fmEmail;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fmPesquisa.Text))
            {
                dgvClientes.DataSource = tbUsers;
                return;
            }
            else
            {
                dgvClientes.DataSource = userController.searchUsersByColumn(cbxPesquisa.SelectedItem.ToString(), fmPesquisa.Text, tbUsers);
            }



        }

    }
}
