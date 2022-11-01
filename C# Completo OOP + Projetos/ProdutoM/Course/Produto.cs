using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoM
{
    internal class Produto
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double Preco;
        public int Estoque;

        public Produto() {}

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Estoque = 10;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Estoque;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Estoque += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Estoque -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CI) + ", " + Estoque 
            + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CI);

        }
    }
}
