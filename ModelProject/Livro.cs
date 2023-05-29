using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Livro
    {
        public string ID_Livro;
        public string genero;
        public string nome;
        public int estoque;
        public double precoUnitario;

        public Livro(string nr, string genero, string nome, int estoque, double precoUnitario)
        {
            this.ID_Livro = nr;
            this.genero = genero;
            this.nome = nome;
            this.estoque = estoque;
            this.precoUnitario = precoUnitario;
        }
    }
}
