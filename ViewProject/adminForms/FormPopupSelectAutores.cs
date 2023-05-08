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

namespace ViewProject.adminForms
{
    public partial class FormPopupSelectAutores : Form
    {
        public FormPopupSelectAutores()
        {
            InitializeComponent();
            popupAutorController.setAllAutores();
            fillLbx();
        }
        AutorController.PopupInsertLivro popupAutorController = new AutorController.PopupInsertLivro();
        

        private void fillLbx()
        {
            popupAutorController.setDisplayAutores();
            lbxAutores.DataSource = popupAutorController.getDisplayAutores();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //implementar pergunta pro usuário
            this.Close();
        }



        private void lbxAutores_Click(object sender, EventArgs e)
        {
            var itensSelecionados = new List<string>();
            foreach(var item in lbxAutores.SelectedItems)
            {

                itensSelecionados.Add(item.ToString());
            }
            popupAutorController.atualizarSelecao(itensSelecionados);

            lbxAutores.DataSource = popupAutorController.getAllAutores();
            lbxAutores.DataSource = popupAutorController.getDisplayAutores();
            for (int i = 0; i < popupAutorController.getSelectedAutores().Count; i++)
                lbxAutores.SetSelected(i, true);
            
            fmAutor.Text = "";
        }

        private void fmAutor_TextChanged(object sender, EventArgs e)
        {
            popupAutorController.pesquisarAutor(fmAutor.Text);

            lbxAutores.ClearSelected();
            lbxAutores.DataSource = popupAutorController.getAllAutores();
            lbxAutores.DataSource = popupAutorController.getDisplayAutores();
            for (int i = 0; i < popupAutorController.getSelectedAutores().Count; i++)
                lbxAutores.SetSelected(i, true);
        }
    }
}
