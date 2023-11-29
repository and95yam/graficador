using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class Taylor3:cVector
    {
        double t = -8;
        double dt = 0.001;




        public override void Encender(Bitmap pixel)
        {

            cVector seg = new cVector();

            do
            {
                seg.color0 = Color.HotPink;
                seg.x0 = t;
                seg.y0 = ((Math.Pow(t, 2) / 5) - 3);
                //  seg.y0 = 1 + (0.69 * t) + (0.24 * Math.Pow(t, 2));
                seg.Encender(pixel);
                t = t + dt;
            } while (t <= 8);

        }
    }
}
