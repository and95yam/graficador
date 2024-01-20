using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    class cVector3D: cVector
    {
        public double z0;
        double ax, ay;
        int sx, sy;

        public override void Encender(Bitmap pixel)
        {
            //int Sx, Sy;

            cVector v = new cVector();
            cFuncion f = new cFuncion();

            v.Axonometria(x0, y0, z0, out ax, out ay);
            f.Pantalla(ax, ay, out sx, out sy);

            if (sx >= 0 && sx < 600 && sy >= 0 && sy < 500)
            {
                pixel.SetPixel(sx, sy, color0);

            }

            
            

            

        }


    }
}
