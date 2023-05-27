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
        public FormRegistroClientes()
        {
            InitializeComponent();
            fillDgv();
        }

        bool stateAdicionando = false;

        UserController userController = new UserController();
        VendaController vendaController = new VendaController();

         private void btnNew_Click(object sender, EventArgs e)
        {
            stateAdicionando = true;
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmCPF.Text = "";
            fmNome.Text = "";
            fmSenha.Text = "";
            fmEmail.Text = "";
            fmTelefone.Text = "";
            cbxIsAdmin.Checked = false;
            changeFormularioEnabled(true);

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            User usuario = new User(fmCPF.Text,
                        fmNome.Text,
                        fmSenha.Text,
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
                btnNew.Enabled = true;
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
                btnInsert.Enabled = true;
                changeFormularioEnabled(true);
                fmCPF.Enabled = false;
            }
            
            
            
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            User usuario = new User(fmCPF.Text,
                        fmNome.Text,
                        fmSenha.Text,
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
            User usuario = new User(fmCPF.Text,
                                    fmNome.Text,
                                    fmSenha.Text,
                                    fmEmail.Text,
                                    fmTelefone.Text,
                                    cbxIsAdmin.Checked);

            if (stateAdicionando)
            {
                //TODO: Alerta caso haja repetição de nomes
                userController.addUserToDB(usuario);
            } else
            {
                userController.updateUserFromDB(usuario);
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
                fmEmail.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                fmTelefone.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            }
            
        }

        private void fillDgv()
        {
            var conn = DBCon.Conn();
            var command = conn.CreateCommand();
            command.CommandText = "select * from Tb_Usuarios";
            var table = DBCon.queryDataTable(command);
            dgvClientes.DataSource = table;

            conn.Close();
        }

        private void changeFormularioEnabled(bool arg)
        {
            fmCPF.Enabled = arg;
            fmNome.Enabled = arg;
            fmSenha.Enabled = arg;
            fmEmail.Enabled = arg;
            fmTelefone.Enabled = arg;
            cbxIsAdmin.Enabled = arg;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormRegistroClientes_Load(object sender, EventArgs e)
        {

        }

        private void fmCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //TESTE///////////////DELETAR DEPOIS
            MessageBox.Show(fmCPF.Text);
            MessageBox.Show(fmTelefone.Text);
            MessageBox.Show(fmSenha.Text);
        }
        //IMPLEMENTAR VALIDAÇÃO DE CPF
    }
}
