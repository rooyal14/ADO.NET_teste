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


        private void btnInsert_Click(object sender, EventArgs e)
        {
            addClienteToDB();
            fillDgv();
        }
        
        private void addClienteToDB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into tbClientes(cpf, nome, senha, email, telefone) values " +
                "(@cpf, @nome, @senha, @email, @telefone)";
            command.Parameters.AddWithValue("@cpf", fmCPF.Text);
            command.Parameters.AddWithValue("@nome", fmNome.Text);
            command.Parameters.AddWithValue("@senha", fmSenha.Text);
            command.Parameters.AddWithValue("@email", fmEmail.Text);
            command.Parameters.AddWithValue("@telefone", fmTelefone.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Cliente registrado com sucesso");
        }
        


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            
            command.CommandText = "delete from tbClientes where cpf = @cpf";
            command.Parameters.AddWithValue("@cpf", fmCPF.Text);
            command.ExecuteNonQuery();
            connection.Close();
            fillDgv();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            fmCPF.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            fmNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            fmSenha.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            fmEmail.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            fmTelefone.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
        }

        private void fillDgv()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            var adapter = new SqlDataAdapter("select * from tbClientes", connectionString);
            var builder = new SqlCommandBuilder(adapter);
            var table = new DataTable();
            adapter.Fill(table);
            dgvClientes.DataSource = table;
            connection.Close();
        }

        //IMPLEMENTAR VALIDAÇÃO DE CPF
    }
}
