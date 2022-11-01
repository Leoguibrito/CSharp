using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorTriangulo
{
    internal class Triangulo
    {
        public double A, B, C;

        public bool Verificar()
        {
            bool triangulo_ = false;

            if (A < B + C && B < A + C && C < B + A)
            {
                triangulo_ = true;
            }

            return triangulo_;
        }
        public double Area ()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
