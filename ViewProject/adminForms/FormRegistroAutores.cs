﻿using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject.adminForms
{
    public partial class FormRegistroAutores : Form
    {
        public FormRegistroAutores()
        {
            InitializeComponent();
            fillDgv();
        }

        AutorController autorController = new AutorController();

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnChange.Enabled = true;
            btnDelete.Enabled = true;
            btnInsert.Enabled = false;
            fmNome.Enabled = false;

            if (dgvAutores.CurrentRow != null)
            {
                fmIdAutor.Text = dgvAutores.CurrentRow.Cells[0].Value.ToString();
                fmNome.Text = dgvAutores.CurrentRow.Cells[1].Value.ToString();

            }

        }

        private void fillDgv()
        {
            SqlConnection conn = DBCon.Conn();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from tbAutores";
            var table = DBCon.queryDataTable(command);
            dgvAutores.DataSource = table;
            conn.Close();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmIdAutor.Text = "";
            fmNome.Text = "";
            fmNome.Enabled = true;

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //Comando apenas habilita a edição do registro
            //Implementação feita na função btnInsert_Click
            btnNew.Enabled = true;
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            btnInsert.Enabled = true;
            fmNome.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor(fmIdAutor.Text, fmNome.Text);

            autorController.deleteAutorFromDB(autor);
            fillDgv();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor(fmIdAutor.Text, fmNome.Text);

            if (String.IsNullOrEmpty(fmIdAutor.Text))
            {
                //TODO: Alerta caso haja repetição de nomes
                autorController.addAutorToDB(autor);
            }
            else
            {
                autorController.updateAutorFromDB(autor);
            }
            fillDgv();
        }

    }
}