using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    public class ProdutoUsado : Produtos
    {
        public DateTime DataFabricacao { get; private set; }
        public ProdutoUsado():base()
        {

        }

        public ProdutoUsado(string nome,double preco,DateTime dataFabricacao) : base(nome,preco)
        {
            DataFabricacao = dataFabricacao;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - Preco {Preco} - Data de fabricação:{DataFabricacao.ToShortDateString()}";
        }

    }
}
