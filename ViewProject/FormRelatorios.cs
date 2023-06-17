using System;
using ControllerProject;
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
    public partial class FormRelatorios : Form
    {
        GerarRelatorioPDF geradorDeRelatorios = new GerarRelatorioPDF();
        public FormRelatorios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            geradorDeRelatorios.geralRelatorioClientesCadastrados();
        }
    }
}
