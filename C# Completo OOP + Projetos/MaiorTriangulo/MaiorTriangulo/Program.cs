using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do Triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = 0;
            double areaY = 0;

            if (x.Verificar())
            {
                areaX = x.Area();
            }

            if (y.Verificar())
            {
                areaY = y.Area();
            }

            if (areaX > areaY)
            {
                Console.WriteLine("A maior area é a do triangulo X");
            } else
            {
                Console.WriteLine("A maior area é a do triangulo Y");
            }
        }
    }
}
