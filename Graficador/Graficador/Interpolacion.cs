using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class Interpolacion
    {
        public int sx;
        public int sy;

        public Interpolacion() { }

        public virtual void Encender(Bitmap pixel)
        {
            for (sx = 0; sx < 600; sx++)
            {
                for (sy = 0; sy < 500; sy++)
                {
                    pixel.SetPixel(sx, sy, Color.FromArgb(0, (int)(0.36 * sx), 128));


                }
            }


        }
    }
}
