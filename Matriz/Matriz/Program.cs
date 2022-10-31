using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int I, J;
            Console.Write("Digite quantas linhas terá a matriz: ");
            I = int.Parse(Console.ReadLine());
            Console.Write("Digite quantas colunas terá a matriz: ");
            J = int.Parse(Console.ReadLine());

            int[,] mat = new int[I, J];

            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    Console.Write("Digite o elemento " + i + ',' + j + " da Matriz: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIZ DIGITADA: ");

            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
