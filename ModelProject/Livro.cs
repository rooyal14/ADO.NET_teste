using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Livro
    {
        public string nr;
        public string nome;
        public int estoque;
        public string autor;

        public Livro(string nr, string nome, int estoque, string autor)
        {
            this.nr = nr;
            this.nome = nome;
            this.estoque = estoque;
            this.autor = autor;
        }
    }
}
