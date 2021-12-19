using System;
using System.Collections.Generic;
using System.Globalization;

namespace Produto
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Entre com número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            List<Produtos> lista = new();
            Console.WriteLine("Produto, usado ou importado (p/u/i)?");
            char m = char.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
               if(m == 'p')
                {
                    Console.Write("Produto #" +i);
                    Console.WriteLine("Nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    

                    lista.Add(new Produtos(nome,preco));
                }
                else if(m == 'u')
                {
                    Console.Write("Produto #" + i);
                    Console.WriteLine("Nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.WriteLine("Data da fabricação?:(dd/mm/yyyy)");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoUsado(nome,preco,dataFabricacao)); // Polismorfismo
                }
               else if(m == 'i')
                {
                    Console.Write("Produto #" + i);
                    Console.WriteLine("Nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.WriteLine("Taxa de importação(%)" );
                    int taxa = int.Parse(Console.ReadLine());   
                    lista.Add(new ProdutoImportado(nome,preco,taxa));
                }
            }
            foreach(Produtos p in lista)
            {
                Console.WriteLine(p);
            }
            
        }
    }
}
