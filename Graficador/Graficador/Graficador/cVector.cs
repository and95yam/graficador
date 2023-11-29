using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class cVector
    {
        public double x0 = 0;
        public double y0 = 0;
        public Color color0;

        public cVector() { }

        public virtual void Encender(Bitmap pixel)
        {
            cFuncion funcion = new cFuncion();
          

            funcion.Pantalla(x0, y0, out int sx, out int sy);

            if (sx >= 0 && sx < 700 && sy >= 0 && sy < 500)
            {

                pixel.SetPixel(sx, sy, color0);

            }

        }

        public virtual void Apagar(Bitmap pixel)
        {
            cFuncion funcion = new cFuncion();
            funcion.Pantalla(x0, y0, out int sx, out int sy);

            if (sx >= 0 && sx < 700 && sy >= 0 && sy < 500)
            {
                color0 = Color.White;
                Encender(pixel);

            }

        }
    }
}
