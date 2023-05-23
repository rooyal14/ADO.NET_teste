﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject.adminForms
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistroClientes().ShowDialog();
            this.Show();
        } 

        private void btnRegistroLivros_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistroLivros().ShowDialog();
            this.Show();
        }

        private void btnRegistroAutores_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistroAutores().ShowDialog();
            this.Show();
        }

        private void btnRegistroGeneros_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegistroGeneros().ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
