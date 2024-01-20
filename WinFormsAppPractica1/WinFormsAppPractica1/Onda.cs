using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPractica1
{
    internal class Onda : Vector
    {
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

        public Vector3D vec3d = new Vector3D();

        public Onda()
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
                paleta4[k] = Color.FromArgb(255, (255*k/15), 0);

            }
        }

        public void GrafOnda(Bitmap pixel)
        {
          

            Color c;
            int cl;

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 420; j++)
                {
                    VReal(i, j, out x, out y);
                    z = w * (Math.Sqrt(x * x + y * y)) - v * t;
                    z = Math.Sin(z) + 1;
                    z = (Math.Sin(z) + 1) ;//*m
                    cl = (int)(z * 7.5);
                    c = paleta1[cl];
                    pixel.SetPixel(i, j, c);

                }
            }


        }

        public void grafOnda3d(Bitmap vectorPixel)
        {

            Vector3D v3d = new Vector3D();
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
                    v3d.X0 = x;
                    v3d.Y0 = y;
                    v3d.color0 = Color.Red;
                    d = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 0), 2))));
                    p = w * (d - v * t);
                    v3d.Z0 = m * Math.Sin(p);
                    v3d.encender(vectorPixel);

                    y = y + 0.2;
                } while (y <= 5);
                x = x + 0.2;
            } while (x <= 7);


        }

        public void interferenciaOnda3d(Bitmap vectorPixel)
        {
            vec3d.color0 = color0;
            double y, dy, h, dh;
            double z1, z2, aux;
            y = -8;
            dy = 0.2;

            do
            {
                h = -4.5;
                dh = 0.2;
                do
                {
                    vec3d.X0 = y;
                    vec3d.Y0 = h;
                    vec3d.color0 = Color.DarkBlue;
                    z1 = w * (Math.Sqrt((Math.Pow((y - 0), 2)) + (Math.Pow((h + 0), 2)))) - t * v;
                    z2 = w * (Math.Sqrt((Math.Pow((y + 5), 2)) + (Math.Pow((h + 0), 2)))) - t * v;
                    z1 = Math.Sin(z1) * m;
                    z2 = Math.Sin(z2) * m;
                    aux = z1+ z2;
                    aux = Math.Sin(aux);
                    vec3d.Z0 = aux;
                    vec3d.encender(vectorPixel);
                    h = h + dh;
                } while (h <= 4.5);
                y = y + dy;
            } while (y <= 8);

        }


        public void Interferencia(Bitmap pixel)
        {           
            int cl;
            double x; double y; double z, z1, z2, z3, z4,z5,z6,z7;
            Color c;

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    VReal(i, j, out double X, out double Y);
                    z1 = w * (Math.Sqrt((X +3) * (X +3) + (Y - 0) * (Y - 0))) - v * t;
                    z2 = w * (Math.Sqrt((X  +2) * (X +2) + (Y + 0) * (Y + 0))) - v * t;
                  /* z3 = w * (Math.Sqrt((X +1) * (X +1) + (Y + 0) * (Y + 0))) - v * t;
                    z4 = w * (Math.Sqrt((X - 0) * (X - 0) + (Y + 0) * (Y + 0))) - v * t;
                    z5 = w * (Math.Sqrt((X - 1) * (X - 1) + (Y + 0) * (Y + 0))) - v * t;
                    z6 = w * (Math.Sqrt((X - 2) * (X - 2) + (Y + 0) * (Y + 0))) - v * t;
                    z7 = w * (Math.Sqrt((X - 3) * (X - 3) + (Y + 0) * (Y + 0))) - v * t;*/


                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                   /* z3 = Math.Sin(z3) + 1;
                     z4 = Math.Sin(z4) + 1;
                     z5 = Math.Sin(z5) + 1;
                     z6 = Math.Sin(z6) + 1;
                     z7 = Math.Sin(z7) + 1;*/

                    z = z1 + z2;
                     cl =  ((int)(z * 3.75));
                    c = paleta1[cl];
                    pixel.SetPixel(i, j, c);
                }

            }

        }

        public void Interferencia2Ondas(Bitmap pixel)
        {


            int cl;

            double x; double y; double z, z1, z2,z3;
            Color c;



            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    VReal(i, j, out double X, out double Y);
                    z1 = w * (Math.Sqrt((X - 0) * (X - 0) + (Y - (-2)) * (Y - (-2)))) - v * t;
                    z2 = w * (Math.Sqrt((X - 8) * (X - 8) + (Y + (-2)) * (Y + (-2)))) - v * t;
                    z3 = w * (Math.Sqrt((X - 8) * (X - 8) + (Y + (-2)) * (Y + (-2)))) - v * t;

                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    z3 = Math.Sin(z3) + 1;



                    z = z1  + z2;
                    cl = ((int)(z * 3.75));
                    c = paleta1[cl];
                    pixel.SetPixel(i, j, c);
                }

            }

        }

        public void Onda2(Bitmap pixel)
        {
            int cl;

            double x; double y; double z2;
            Color c;



            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    VReal(i, j, out double X, out double Y);
                    z2 = w * (Math.Sqrt((X - 8) * (X - 8) + (Y + 0) * (Y + 0))) - v * t;             
                    z2 = Math.Sin(z2) + 1;
                   
                    cl = ((int)(z2 * 2.5));
                    c = paleta1[cl];
                    pixel.SetPixel(i, j, c);
                }

            }

        }

        public void principioHuygens(Bitmap pixel)
        {
            Color[] paleta1 = new Color[16];
            paleta1 = new Color[16];
            paleta1[0] = Color.FromArgb(0, 0, 100);
            paleta1[1] = Color.FromArgb(0, 0, 110);
            paleta1[2] = Color.FromArgb(0, 0, 120);
            paleta1[3] = Color.FromArgb(0, 0, 140);
            paleta1[4] = Color.FromArgb(0, 0, 160);
            paleta1[5] = Color.FromArgb(0, 0, 180);
            paleta1[6] = Color.FromArgb(0, 0, 200);
            paleta1[7] = Color.FromArgb(0, 0, 220);
            paleta1[8] = Color.FromArgb(0, 0, 240);
            paleta1[9] = Color.FromArgb(0, 100, 255);
            paleta1[10] = Color.FromArgb(0, 140, 255);
            paleta1[11] = Color.FromArgb(0, 180, 255);
            paleta1[12] = Color.FromArgb(0, 200, 255);
            paleta1[13] = Color.FromArgb(0, 220, 255);
            paleta1[14] = Color.FromArgb(0, 240, 255);
            paleta1[15] = Color.FromArgb(0, 255, 255);



            Color[] paleta0 = new Color[16];

            paleta0 = new Color[16];
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.Maroon;
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            int color;
            double x, y, z, z1;
            Color c;
            z = 0;

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    double z0 = 0;
                    VReal(i, j, out x, out y);
                    for (int l = 0; l < 4; l++)
                    {
                        z1 = w * (Math.Sqrt(Math.Pow((x + 0 + l), 2) + Math.Pow(y + 0, 2)) - v * t);
                        z1 = Math.Sin(z1) + 1;
                        z0 += z1;
                    }
                    color = (int)((13 + z0) %15);
                    c = paleta3[(color)];
                    pixel.SetPixel(i, j, c);
                }
            }
        }

        public void Interferencia3D2(Bitmap vectorPixel)
        {

            Vector3D v3d = new Vector3D();
            double x, y, p, d, m, w, v;
            double d1, p1;
            x = -8;
            m = 0.4;
            w = 3;
            v = 9.8;
            do
            {
                y = -6;
                do
                {
                    v3d.X0 = x;
                    v3d.Y0 = y;
                    v3d.color0 = Color.Green;
                    d = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y - 3), 2))));
                    d1 = (Math.Sqrt((Math.Pow((x + 0), 2)) + (Math.Pow((y + 3), 2))));
                    p = w * (d - v * t);
                    p1 = w * (d1 - v * t);
                    v3d.Z0 = m * Math.Sin(p) + m * Math.Sin(p1);
                    v3d.encender(vectorPixel);

                    y = y + 0.05;
                } while (y <= 6);
                x = x + 0.05;
            } while (x <= 8);
        }

        public void Interferencia3D(Bitmap vectorPixel)
        {
            Vector3D v3d = new Vector3D();
            double x, y, p, p2, z, z0;
            int color;
            x = -7;
            do
            {
                y = -6;
                do
                {
                    v3d.X0 = x;
                    v3d.Y0 = y;
                    p = w * (Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0))) - v * t;
                    z = 0.4 * Math.Sin(p);
                    //v3d.color = Color.Red;
                    //v3d.Z0 = z;
                    //v3d.encender(lienzo);

                    // p2 = w * (Math.Sqrt((x - 0) * (x - 0) + (y + 3) * (y + 3))) - v * t;
                    //z0 = 0.35 * Math.Sin(p2);
                    v3d.Z0 = z;

                    v3d.color0 = Color.Blue;
                    v3d.encender(vectorPixel);
                    y = y + 0.2;
                } while (y <= 6);
                x = x + 0.2;
            } while (x <= 7);
        }

    }



   
}
