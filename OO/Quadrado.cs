using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    public class Quadrado
    {
        public double AreaQuadrado { get; set; }
        public double PerimetroQuadrado { get; set; }

        public static double CalcularAreaQuadrado(double l1, double l2)
        {
            return l1 * l2;
        }

        public static double CalcularPerimetroQuadrado(double l1, double l2)
        {
            return 2 * l1 + 2 * l2;
        }

        public override string ToString()
        {
            return "Area total; " + AreaQuadrado.ToString("N2") + "\r\n" + "Perímetro total; " + PerimetroQuadrado.ToString("N2");
        }







    }
}
