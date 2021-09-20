using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    class Triangulo
    {
        public double AreaTriangulo { get; set; }
        public double PerimetroTriangulo { get; set; }
        public double AlturaTriangulo { get; set; }

        public static double CalcularArea(double l1, double l2, double l3)
        {
            double semiPerimetro = l1 + l2 + l3 / 2;
            return Math.Sqrt(semiPerimetro * (semiPerimetro - l1) * (semiPerimetro - l2) * (semiPerimetro - l3));
        }

        public static double CalcularPerimetro(double l1, double l2, double l3)
        {
            return l1 + l2 + l3;
        }

        public static double CalcularAltura( double areaTriangulo, double @base)
        {
            return 2 * areaTriangulo / @base;
        }

        public override string ToString()
        {
            return "Area: " + AreaTriangulo.ToString("N2") + "\r\n" +
                "Perímetro: " + PerimetroTriangulo.ToString("N2") + "\r\n" + "Altura: " + AlturaTriangulo.ToString("N2");

        }
    }
}
