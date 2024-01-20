using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPractica1
{

    internal class Segmento:Vector
    {

        public double xf { get; set; }
        public double yf { get; set; }

        Color[] paleta4 = new Color[16];
        public override void encender(Bitmap pixelVector)
        {
            double t = 0;
            double dt=0.001;


            for (int k = 0; k < 15; k++)
            {
                paleta4[k] = Color.FromArgb(255*(k-15)/-15, 0, 255*k/15);

            }


            Vector v = new Vector(0,0,color0);
           
            do
            {

                int cl = ((int)(t / 100));
                color0 = paleta4[cl];
                v.X0 = X0 * (1-t)+xf*t;
                v.Y0 = Y0 * (1 - t) + yf * t;
                v.encender(pixelVector);
                t = t + dt;

            }
            while (t <= 1);
        }

    }
}
