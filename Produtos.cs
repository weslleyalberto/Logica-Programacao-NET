using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    public class Produtos
    {
        public string Nome { get; private set; }
        protected double Preco { get;  set; }
        public Produtos()
        {

        }

        public Produtos(string nome, double preco)
        {
            this.Nome = nome;
            Preco = preco;
        }
        public virtual String TagPreco()
        {
            return $"Preco do produto: {Preco}";
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - Preço Total: {Preco}";
        }
    }
}
