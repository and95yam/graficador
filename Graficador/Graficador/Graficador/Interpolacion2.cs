using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class Interpolacion2
    {
        public int sx;
        public int sy;

        public Interpolacion2() { }

        public virtual void Encender(Bitmap pixel)
        {
            for (sx = 0; sx < 700; sx++)
            {
                for (sy = 0; sy < 500; sy++)
                {
                    pixel.SetPixel(sx, sy, Color.FromArgb(0, (int)(0.36 * sx), 128));


                }
            }


        }
    }
}
