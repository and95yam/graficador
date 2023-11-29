using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class Taylor1:cVector
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
                seg.y0 = Math.Pow(2, t);
                seg.Encender(pixel);
                t = t + dt;
            } while (t <= 6);

        }
    }
}
