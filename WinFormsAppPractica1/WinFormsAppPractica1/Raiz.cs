using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPractica1
{
    internal class Raiz:Circunferencia
    {
        public override void encender(Bitmap pixelVector)
        {
            double t = 0;
            double dt = 0.001;
            Vector v = new Vector(0,0,color0);
            v.color0 = Color.Black;
            do
            {
                v.X0 = X0 + Rd * Math.Sin(2*t);
                v.Y0 = Y0 + Rd * Math.Cos(3*t);
                v.encender(pixelVector);
                t = t + dt;
            } while (t <= 2 * (Math.PI));

        }
    }
}
