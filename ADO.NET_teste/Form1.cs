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

namespace ADO.NET_teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro(Convert.ToInt32(fmNr.Text),
                                fmNome.Text,
                                Convert.ToInt32(fmEstoque.Text),
                                fmAutor.Text);

            
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into tbLivros(nome, estoque, autor) values(@nome, @estoque, @autor)";
            //command.Parameters.AddWithValue("@nr", livro.nr);
            command.Parameters.AddWithValue("@nome", livro.nome);
            command.Parameters.AddWithValue("@estoque", livro.estoque);
            command.Parameters.AddWithValue("@autor", livro.autor);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Fornecedor registrado com sucesso");
        }
    }
}
