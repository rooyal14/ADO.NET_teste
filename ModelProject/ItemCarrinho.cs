using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class ItemCarrinho
    {
        private Livro livro;
        public string Codigo
        {
            get
            {
                return this.livro.ID_Livro;
            }
        }
        public string NomeLivro
        {
            get
            {
                return this.livro.nome;
            }
        }
        public int Qtd { get; set; }
        //TODO: Passar o preço unitário para a classe Livro
        public double PrecoUnitario
        {
            get
            {
                return this.livro.precoUnitario;
            }
        }
        public double Subtotal { get; set; }

        
        
        public ItemCarrinho(Livro livro, int qtd)
        {
            this.livro = livro;
            this.Qtd = qtd;
            this.Subtotal = qtd * this.livro.precoUnitario;
        }

        public Livro getLivro()
        {
            return this.livro;
        }
    }
}
