using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture; 

            string nome = Console.ReadLine();
            Console.WriteLine("Nome: " + nome);

            double salario;
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Salario: " + salario);

            int idade;
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Idade: " + idade);

            Console.Write("What is your name: ");
            string name = Console.ReadLine();
        }
    }
}
