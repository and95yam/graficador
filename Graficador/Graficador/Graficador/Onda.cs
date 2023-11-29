using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class Onda:cVector
    {

        public override void Encender(Bitmap pixel)
        {

            cFuncion fun = new cFuncion();
            int i, j, color2;
            double x, y, z;
            
            double w = 1.5;
            double v1 = 9.3;
            double t = 2.00;
            Color c;

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 500; j++)
                {

                    fun.Transforma(i + 250, j + 250, out x, out y);
                    z = (w * (Math.Sqrt(x * x + y * y)) - (v1 * 1));
                   // z = Math.Sin(z) + 1;
                    color2 = (int)(z * 7.5) % 15;
                    c = cPaleta.Paleta0[color2];
                    pixel.SetPixel(i, j,c);
                    
                }
            }



        }
    }
}
