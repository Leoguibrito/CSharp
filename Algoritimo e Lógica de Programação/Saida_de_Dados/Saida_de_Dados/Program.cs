using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Saida_de_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double x;
            x = 2.3241;
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.ToString(CI));    
        }
    }
}
