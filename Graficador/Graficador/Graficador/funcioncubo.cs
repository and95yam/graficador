using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class funcioncubo:cVector
    {
        double t = -8;
        double dt = 0.001;




        public override void Encender(Bitmap pixel)
        {

            cVector seg = new cVector();

            do
            {
                seg.color0 = Color.Blue;
                seg.x0 = t;
                seg.y0 = Math.Pow(t+5, 3);
                seg.Encender(pixel);
                t = t + dt;
            } while (t <= 8);

        }
    }
}
