using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Genero
    {
        public string ID_Genero;
        public string Nome;

        public Genero(string idGenero, string generoDesc)
        {
            this.ID_Genero = idGenero;
            this.Nome = generoDesc;
        }
    }
}
