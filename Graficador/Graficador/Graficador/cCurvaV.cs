using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class cCurvaV:cVector
    {
        public double rd;
        public const double PI = 3.1415926535897931;
        int tipo;
        public override void Encender(Bitmap pixel)
        {
            

            double t = 0;
            float dt = 0.001f;

            cVector v = new cVector();
            do
            {
                v.x0 = x0 + rd * (Math.Sin(8*t/5)*Math.Cos(t));
                v.y0 = y0 + rd * (Math.Sin(8*t/5)*Math.Sin(t));
                v.color0 = color0;
                v.Encender(pixel);
                t += dt;
            } while (t <= 10*PI);
        }
    }
}
