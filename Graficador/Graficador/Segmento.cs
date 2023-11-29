using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class Segmento : cVector
    {
        public double xf, yf;

        public override void Encender(Bitmap pixel)
        {
            float t = 0;
            float dt = 0.001f;
            cVector v = new cVector();
            do
            {
                v.x0 = (x0 * (1 - t)) + (xf * t);
                v.y0 = (y0 * (1 - t)) + (yf * t);
                v.color0 = color0;
                v.Encender(pixel);
                t += dt;
            } while (t <= 1);
        }
    }
}
