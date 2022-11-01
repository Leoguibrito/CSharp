using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CI));
            Console.WriteLine("Circunferencia: " + Calculadora.Circunferencia(raio).ToString("F2", CI));
            Console.WriteLine("Volume: " + Calculadora.Volume(raio).ToString("F2", CI));
        }
    }
}
