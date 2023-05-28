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
using ViewProject.adminForms;

namespace ViewProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }
        string currentUserEmail;
        bool currentUserIsAdmin;

        UserController clienteController = new UserController();
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormCadastroUsuario().ShowDialog();
            this.Show();
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senhaHash = Criptografia.GerarHash(fmSenha.Text);
            bool validado = clienteController.loginUser(fmEmail.Text, senhaHash, out currentUserEmail, out currentUserIsAdmin);

            if (validado && currentUserIsAdmin)
            {
                this.Hide();
                var FormMenuAdmin = new FormMenuAdmin();
                FormMenuAdmin.Closed += (s, args) => this.Close();
                FormMenuAdmin.Show();
            } 
            else if (validado && !currentUserIsAdmin)
            {
                this.Hide();
                var FormLojaCliente= new FormLojaCliente(currentUserEmail);
                FormLojaCliente.Closed += (s, args) => this.Close();
                FormLojaCliente.Show();
            } 
            else
            {
                MessageBox.Show("Email ou usuário incorretos, tente novamente");
            }
        }

        private void btnEntrarAnonimo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormLojaCliente = new FormLojaCliente(currentUserEmail);
            FormLojaCliente.Closed += (s, args) => this.Close();
            FormLojaCliente.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seja bem-vindo ao Sistema Livraria " +
                "ADO.NET. \n\nProjeto desenvolvido por: \nAlice Bentes, " +
                "Rodrigo Zwirtes, Victor Hugo e Wellington Amaral.",
                "Sobre os Autores", MessageBoxButtons.OK);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
