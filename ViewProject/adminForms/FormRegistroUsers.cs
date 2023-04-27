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

        UserController userController = new UserController();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            addClienteToDB();
            fillDgv();
        }
        
        private void addClienteToDB()
        {
            User usuario = new User(fmCPF.Text, 
                                    fmNome.Text, 
                                    fmSenha.Text, 
                                    fmEmail.Text, 
                                    fmTelefone.Text);

            userController.addUserToDB(usuario);
            fillDgv();
            MessageBox.Show("Cliente registrado com sucesso");
        }
        


        private void btnDelete_Click(object sender, EventArgs e)
        {
            User usuario = new User(fmCPF.Text,
                                    fmNome.Text,
                                    fmSenha.Text,
                                    fmEmail.Text,
                                    fmTelefone.Text);
            userController.deleteUserFromDB(usuario);
            MessageBox.Show("Cliente excluído com sucesso");
            fillDgv();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                fmCPF.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                fmNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                fmSenha.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                fmEmail.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                fmTelefone.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            }
            
        }

        private void fillDgv()
        {
            var conn = DBCon.Conn();
            var command = conn.CreateCommand();
            command.CommandText = "select * from tbClientes";
            var table = DBCon.queryDataTable(command);
            dgvClientes.DataSource = table;

            conn.Close();
        }

        //IMPLEMENTAR VALIDAÇÃO DE CPF
    }
}
