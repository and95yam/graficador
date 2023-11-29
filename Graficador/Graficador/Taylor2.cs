using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class Taylor2 : cVector
    {
        double t = -10;
        double dt = 0.001;
        double xa = 3, ya, m;




        public override void Encender(Bitmap pixel)
        {
            ya = -0.03 * Math.Pow(t, 2) + 3;
            m = -0.06 * xa;
            x0 = t;
            cVector seg = new cVector();

            do
            {
                seg.color0 = Color.Green;
                seg.x0 = t;
                seg.y0 = m * (seg.x0 - xa) + ya;

                seg.Encender(pixel);

                // seg.y0 = 1 + (0.69 * t) + (0.24 * Math.Pow(t, 2) + (0.05 * Math.Pow(t, 3)));
                //seg.y0 = ((1.206) * (Math.Pow((t - 0), 2) / 2));
                // seg.Encender(pixel);

                // seg.y0 = Math.Pow(3,t);
                //seg.Encender(pixel);

                //seg.y0 = 1 + 1.098 * t + 0.603 * Math.Pow(t, 2) + 0.22 * Math.Pow(t, 3) + 0.06 * Math.Pow(t, 4);
                //seg.Encender(pixel);

                // seg.y0 = (Math.Pow((Math.Log(3)), 4)) * 3 * t;
                seg.y0 = -0.03 * Math.Pow(t, 2) + 3;

                seg.Encender(pixel);

                t = t + dt;
            } while (t <= 10);
        }
    }
}
