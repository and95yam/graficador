using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    class cVector3D : cVector
    {
        public double z0 = 0;

        public cVector3D() { }


        public override void Encender(Bitmap pixel)
        {
            cFuncion funcion = new cFuncion();
            funcion.Axonometria(x0, y0, z0, out double ax, out double ay);
            funcion.Pantalla(ax, ay, out int sx, out int sy);

            if (sx >= 0 && sx < 700 && sy >= 0 && sy < 500)
            {
                pixel.SetPixel(sx, sy, color0);

            }

        }
            
    }
}
