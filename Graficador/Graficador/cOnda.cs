using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Graficador
{
    class cOnda:cVector
    {
        public List<double> ListaX { get; private set; } = new List<double>();
        public List<double> ListaY { get; private set; } = new List<double>();
        public List<double> ListaZ { get; private set; } = new List<double>();

        int i, j;
        double x, y, z;
        public double w = 5;
        public double v = 9.3;
        public double t = 1;
        public double m = 0.3;
        Color[] paleta3 = new Color[16];
        Color[] paleta2 = new Color[16];
        Color[] paleta1 = new Color[16];
        Color[] paleta4 = new Color[16];

        public cVector3D vec3d = new cVector3D();

        public cOnda()
        {
            paleta1[0] = Color.Black;
            paleta1[1] = Color.Navy;
            paleta1[2] = Color.Green;
            paleta1[3] = Color.Aqua;
            paleta1[4] = Color.Red;
            paleta1[5] = Color.Purple;
            paleta1[6] = Color.Maroon;
            paleta1[7] = Color.LightGray;
            paleta1[8] = Color.DarkGray;
            paleta1[9] = Color.Blue;
            paleta1[10] = Color.Lime;
            paleta1[11] = Color.Silver;
            paleta1[12] = Color.Teal;
            paleta1[13] = Color.Fuchsia;
            paleta1[14] = Color.Yellow;
            paleta1[15] = Color.White;
            paleta2[0] = Color.Red;
            paleta2[1] = Color.White;
            paleta2[2] = Color.Yellow;
            paleta2[3] = Color.OrangeRed;
            paleta2[4] = Color.Red;
            paleta2[5] = Color.White;
            paleta2[6] = Color.Red;
            paleta2[7] = Color.White;
            paleta2[8] = Color.Red;
            paleta2[9] = Color.White;
            paleta2[10] = Color.Red;
            paleta2[11] = Color.White;
            paleta2[12] = Color.Red;
            paleta2[13] = Color.White;
            paleta2[14] = Color.Red;
            paleta2[15] = Color.White;

            for (int k = 0; k < 15; k++)
            {
                paleta3[k] = Color.FromArgb(0, (int)(-1.33) * (k - 15) + 17 * k, (int)(15) * k + 30);

            }

            for (int k = 0; k < 15; k++)
            {
                paleta4[k] = Color.FromArgb(255, (255 * k / 15), 0);

            }
        }

        public void GrafOnda(Bitmap pixel)
        {
            Color c;
            int cl;

            for (i = 0; i < 600; i++)
            {
                for (j = 0; j < 500; j++)
                {
                    VReal(i, j, out x, out y);

                    ListaX.Add(x);
                    ListaY.Add(y);
                    z = w * (Math.Sqrt((x + 5) * (x + 5) + y * y)) - v * t;
                    z = Math.Sin(z) + 1;

                    
                    ListaZ.Add(z);

                    cl = (int)(z * 7.5);
                    c = paleta1[cl];
                    pixel.SetPixel(i, j, c);
                }
            }
        }





        public void grafOnda3d(Bitmap vectorPixel)
        {

            cVector3D v3d = new cVector3D();
            double x, y, p, d, m, w, v, t;
            x = -7;
            m = 0.4;
            w = 3;
            v = 9.8;
            t = 0;
            do
            {
                y = -5;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    v3d.color0 = Color.Red;

                    ListaX.Add(x);
                    ListaY.Add(y);
                    
                    d = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 0), 2))));
                    p = w * (d - v * t);
                    v3d.z0 = m * Math.Sin(p);
                    v3d.Encender(vectorPixel);
                    ListaZ.Add(p);
                    y = y + 0.2;
                } while (y <= 5);
                x = x + 0.2;
            } while (x <= 7);


        }

        public void Onda3DAnimada(Bitmap vectorPixel)
        {
            cVector3D v3d = new cVector3D();
            double x, y, p, p2, z, z0;
            int color;
            x = -7;
            do
            {
                y = -6;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    p = w * (Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0))) - v * t;
                    z = 0.4 * Math.Sin(p);
            
                    v3d.z0 = z;

                    v3d.color0 = Color.Blue;
                    v3d.Encender(vectorPixel);
                    y = y + 0.2;
                } while (y <= 6);
                x = x + 0.2;
            } while (x <= 7);
        }



    }
}
