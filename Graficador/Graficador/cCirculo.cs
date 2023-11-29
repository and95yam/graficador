using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class cCirculo : cCurva
    {

        public override void Encender(Bitmap pixel)
        {
            double t = 0;
            float dt = 0.001f;

            cVector v = new cVector();
            do
            {
                v.x0 = x0 + rd * (Math.Cos(t));
                v.y0 = y0 + rd * (Math.Sin(t));
                v.color0 = color0;
                v.Encender(pixel);
                t += dt;
            } while (t <= 2 * PI);
        }

    }
}
