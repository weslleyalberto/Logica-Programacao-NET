using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    public class ProdutoImportado : Produtos
    {
        public int TaxaImportacao { get; private set; }
        public ProdutoImportado() : base()
        {

        }

        public ProdutoImportado(string nome,double preco,int taxaImportacao)
            :base(nome,preco)
        {
            TaxaImportacao = taxaImportacao;
        }
        public double PrecoTotal()
        {
             Preco += Preco * TaxaImportacao / 100.0;
            return Preco;
        }
        public override string TagPreco()
        {
            return $" O preço total do produto é: {PrecoTotal()}";
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - Valor unitario: {Preco}  - Preco Total {TagPreco()}";
        }
    }
}
