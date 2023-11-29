using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class cSenoTaylor:cVector
    {

        double t = -8;
        double dt = 0.001;




        public override void Encender(Bitmap pixel)
        {

            cVector seg = new cVector();

            do
            {
                seg.color0 = Color.Yellow;
                seg.x0 = t;
                seg.y0 = Math.Sin(t);
                seg.Encender(pixel);
                t = t + dt;
            } while (t <= 8);

        }
    }
}
