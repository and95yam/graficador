using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    internal class interpolacion1
    {
        public int sx;
        public int sy;

        public interpolacion1() { }

        public virtual void Encender(Bitmap pixel)
        {
            for (sx = 0; sx < 700; sx++)
            {
                for (sy = 0; sy < 500; sy++)
                {

                    pixel.SetPixel(sx, sy, Color.FromArgb(255, (int)(-0.36 * sx + 255), 0));


                }
            }


        }
    }
}
