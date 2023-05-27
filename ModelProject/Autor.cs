using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Autor
    {
        public string ID_Autor;
        public string nome;

        public Autor(string ID_Autor, string nome)
        {
            this.ID_Autor = ID_Autor;
            this.nome = nome;
        }
    }
}
