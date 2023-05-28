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
    public partial class FormLoginCompra : Form
    {
        
        public FormLoginCompra()
        {
            InitializeComponent();
        }

        private bool currentUserIsAdmin;
        private string currentUserEmail;
        public string CurrentUserEmail { get; set; }

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

            currentUserIsAdmin = false;
            if (validado)
            {
                CurrentUserEmail = fmEmail.Text;
                this.Close();
                
            }            
            else
            {
                CurrentUserEmail = "";
                MessageBox.Show("Email ou usuário incorretos, tente novamente");
            }
        }


    }
}

