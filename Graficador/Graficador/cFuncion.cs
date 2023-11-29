using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class cFuncion
    {
        public static int sx1 = 0;
        public static int sx2 = 600;
        public static int sy1 = 0;
        public static int sy2 = 500;
        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -8.33;
        public static double y2 = 8.33;

        public cFuncion() { }

        public double Getx1() { return x1; }
        public double Getx2() { return x2; }
        public double Gety1() { return y1; }
        public double Gety2() { return y2; }

        
        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }

        
    }
}
