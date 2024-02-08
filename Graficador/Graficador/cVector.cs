using System;
using System.Collections.Generic;
using System.Drawing;
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


        public double sx1 = 0;
        public double sx2 = 600;
        public double sy1 = 0;
        public double sy2 = 500;


        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -8.33;
        public static double y2 = 8.33;

        public cVector() { }

        public cVector(double x0, double y0, Color color0)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color0 = color0;
        }

        public virtual void Encender(Bitmap pixel)
        {
            cFuncion funcion = new cFuncion();


            funcion.Pantalla(x0, y0, out int sx, out int sy);

            if (sx >= 0 && sx < 600 && sy >= 0 && sy < 500)
            {

                pixel.SetPixel(sx, sy, color0);

            }

        }

        public virtual void Apagar(Bitmap pixel)
        {
            cFuncion funcion = new cFuncion();
            funcion.Pantalla(x0, y0, out int sx, out int sy);

            if (sx >= 0 && sx < 600 && sy >= 0 && sy < 500)
            {
                color0 = Color.Black;
                Encender(pixel);

            }

        }

        public void Axonometria(double x, double y, double z, out double ax, out double ay)
        {
            ax = (x + (0.5) * y * Math.Cos(0.8));
            ay = ((0.5) * y * Math.Sin(0.8) + z);
        }

        public void VReal(int sx, int sy, out double x, out double y)
        {
            x = (((sx - sx1) / (sx1 - sx2)) * (x1 - x2)) + x1;
            y = (((sy - sy1) / (sy1 - sy2)) * (y2 - y1)) + y2;

        }

    }
}
