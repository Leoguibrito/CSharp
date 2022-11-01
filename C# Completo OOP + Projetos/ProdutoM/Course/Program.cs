using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;



            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Quantidade no estoque: ");
            int estoque = int.Parse(Console.ReadLine());
            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, estoque);
            Produto q = new Produto(nome, preco);
            Produto w = new Produto
            {
                Nome = nome,
                Preco = preco,
                Estoque = estoque
            };

            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine("Dados do Produto: " + q);
            Console.WriteLine();

            int qtde;
            Console.Write("Digite quantos produtos serão adicionados: ");
            qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);
            Console.WriteLine();

            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine();

            Console.Write("Digite quantos produtos serão removidos: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);
            Console.WriteLine();

            Console.WriteLine("Dados do Produto: " + p);
        }
    }
}
