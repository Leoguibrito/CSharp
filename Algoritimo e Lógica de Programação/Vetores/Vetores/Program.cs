using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N;
            Console.Write("Digite quantos numeros serao digitados: ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];
           
            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite o numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CI));
            }
        }
    }
}
