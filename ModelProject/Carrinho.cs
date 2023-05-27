using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Carrinho
    {
        private IList<ItemCarrinho> carrinhoDeLivros = new BindingList<ItemCarrinho>();

        private double total;

        public void adicionarItemAoCarrinho(ItemCarrinho itemCarrinho)
        {

            var itemExistente = carrinhoDeLivros.Where(x => x.getLivro().ID_Livro == itemCarrinho.getLivro().ID_Livro);
            if (itemExistente.Count() == 0)
            {
                carrinhoDeLivros.Add(itemCarrinho);
            } else
            {
                carrinhoDeLivros[carrinhoDeLivros.IndexOf(itemExistente.First())] = itemCarrinho;
            }
            calcularTotal();

        }
        
        public void removerItemDoCarrinho(Livro livro)
        {
            carrinhoDeLivros.Remove(carrinhoDeLivros.Where(x => x.getLivro().ID_Livro == livro.ID_Livro).FirstOrDefault());
        }
        
        private void calcularTotal()
        {
            total = 0;
            foreach (ItemCarrinho item in carrinhoDeLivros)
            {
                total += item.Subtotal;
            }
            
        }

        public IList<ItemCarrinho> obterCarrinho()
        {
            return this.carrinhoDeLivros;
        }

        public void limparCarrinho()
        {
            this.carrinhoDeLivros.Clear();
        }
        
        public double getTotal()
        {
            return this.total;
        }
    }
}
