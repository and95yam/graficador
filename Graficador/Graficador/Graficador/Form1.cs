using Microsoft.VisualBasic.Devices;
using System;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Graficador
{
    public partial class Form1 : Form
    {

        public Bitmap pixel;
        
        public Form1()
        {
            InitializeComponent();
            // a=0; b=0;

            pixel = new Bitmap(700, 500);
            paleta0 = new Color[16];
            paleta1M = new Color[16];
            paletaC = new Color[4];
            paletaP = new Color[6];

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



            for (int i = 0; i < 15; i++)
            {
                paleta1M[i] = Color.FromArgb((int)2.46 * i + 133, (int)2 * i + 100, 0);
            }




            paletaC[0] = Color.FromArgb(0, 255, 0);
            paletaC[1] = Color.FromArgb(189, 255, 153);
            paletaC[2] = Color.FromArgb(0, 140, 0);
            paletaC[3] = Color.FromArgb(0, 168, 0);


            paletaP[0] = Color.FromArgb(224, 244, 244);
            paletaP[1] = Color.FromArgb(136, 134, 134);
            paletaP[2] = Color.FromArgb(255, 255, 255);
            paletaP[3] = Color.FromArgb(136, 136, 136);
            paletaP[4] = Color.White;
            paletaP[5] = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Color color0;// variable tipo color 

            color0 = paleta0[4];

            int x = 100, y = 100;

            pixel.SetPixel(x, y, color0);



            fondo.Image = pixel;

        }



        private void btnTrazo_Click(object sender, EventArgs e)
        {
            Segmento seg = new Segmento();
            int x = -10;
            int x2 = 2;
            seg.x0 = x;
            seg.xf = 6;
            seg.y0 = 2;
            seg.yf = 4;
            seg.color0 = Color.Black;
            seg.Encender(pixel);
            fondo.Image = pixel;

            seg.x0 = 6;
            seg.xf = 6;
            seg.y0 = 4;
            seg.yf = -5;
            seg.color0 = Color.Red;
            seg.Encender(pixel);
            fondo.Image = pixel;

            seg.x0 = 6;
            seg.xf = 10;
            seg.y0 = -5;
            seg.yf = 8.33;
            seg.color0 = Color.Blue;
            seg.Encender(pixel);
            fondo.Image = pixel;

        }

        private void btncircunf_Click(object sender, EventArgs e)
        {
            circulo c = new circulo();

            c.x0 = -2;
            c.y0 = 3;
            c.rd = 3;
            c.color0 = Color.DarkGreen;
            c.Encender(pixel);

            fondo.Image = pixel;

            c.x0 = -2;
            c.y0 = 4;
            c.rd = 0.5;
            c.color0 = Color.Brown;
            c.Encender(pixel);

            fondo.Image = pixel;

            c.x0 = 6;
            c.y0 = 4;
            c.rd = 0.5;
            c.color0 = Color.Violet;
            c.Encender(pixel);

            fondo.Image = pixel;
        }

        private void lazo_Click(object sender, EventArgs e)
        {
            lazo l = new lazo();


            l.x0 = 2;
            l.y0 = 3;
            l.rd = 3;
            l.color0 = Color.Purple;
            l.Encender(pixel);
            fondo.Image = pixel;
        }

        private void concentrico_Click(object sender, EventArgs e)
        {
            circulo c = new circulo();

            for (c.rd = 1; c.rd <= 5; c.rd++)
            {
                c.x0 = 0;
                c.y0 = 0;

                c.color0 = paleta0[((int)c.rd)];
                c.Encender(pixel);
                fondo.Image = pixel;
            }
        }

        private void ejes_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento();

            s.x0 = -10;
            s.xf = 10;
            s.y0 = 0;
            s.yf = 0;
            s.color0 = Color.Red;
            s.Encender(pixel);
            fondo.Image = pixel;

            s.x0 = 0;
            s.xf = 0;
            s.y0 = -8.32;
            s.yf = 8.32;
            s.color0 = Color.Red;
            s.Encender(pixel);
            fondo.Image = pixel;
        }

        private void taylor1_Click(object sender, EventArgs e)
        {
            Taylor t = new Taylor();

            t.Encender(pixel);

            fondo.Image = pixel;
        }

        private void Taylor2_Click(object sender, EventArgs e)
        {
            Taylor2 t = new Taylor2();

            t.Encender(pixel);

            fondo.Image = pixel;
        }

        private void Taylor3_Click(object sender, EventArgs e)
        {
            Taylor3 t = new Taylor3();

            t.Encender(pixel);

            fondo.Image = pixel;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            Color c = Color.White;
            for (int sx = 0; sx < 700; sx++)
            {
                for (int sy = 0; sy < 500; sy++)
                {
                    pixel.SetPixel(sx, sy, c);
                }
            }

            fondo.Image = pixel;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interpolacion2 i = new Interpolacion2();
            i.Encender(pixel);
            fondo.Image = pixel;
        }

        private void barrido1_Click(object sender, EventArgs e)
        {
            Color c = Color.Yellow;
            for (int sx = 0; sx < 700; sx++)
            {
                for (int sy = 0; sy < 500; sy++)
                {
                    pixel.SetPixel(sx, sy, c);
                }
            }

            fondo.Image = pixel;
        }

        private void barrido2_Click(object sender, EventArgs e)
        {
            Color c = Color.Yellow;

            for (int sx = 0; sx < 700; sx++)
            {
                for (int sy = 0; sy < 500; sy++)
                {
                    if (sx > 350 && sy > 250) { c = Color.Red; }
                    pixel.SetPixel(sx, sy, c);
                }
            }

            fondo.Image = pixel;

        }

        private void interpolacion1_Click(object sender, EventArgs e)
        {
            interpolacion1 i = new interpolacion1();
            i.Encender(pixel);
            fondo.Image = pixel;
        }

        private void interpolacion3_Click(object sender, EventArgs e)
        {

            int i, j;
            int colorT;
            Color c;

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 500; j++)
                {

                    colorT = ((i * i) + (j * j)) % 15;
                    c = paleta0[colorT];
                    pixel.SetPixel(i, j, c);


                }
            }

            fondo.Image = pixel;

        }

        private void textura1_Click(object sender, EventArgs e)
        {
            int i, j;
            int colorT;
            Color c;

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 500; j++)
                {

                    colorT = ((i * j) + (j * i)) % 15;
                    c = paleta0[colorT];
                    pixel.SetPixel(i, j, c);


                }
            }

            fondo.Image = pixel;

        }

        private void cbTapetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i, j;
            int colorT;
            Color c;
            int cont = 0;

            if (cbTapetes.SelectedIndex == 0)
            {

                for (i = 0; i < 700; i++)
                {
                    for (j = 0; j < 500; j++)
                    {

                        colorT = (((j * i) * (j) / (i + 1))) % 15;
                        c = paleta0[colorT];
                        pixel.SetPixel(i, j, c);


                    }
                }

                fondo.Image = pixel;

            }


            if (cbTapetes.SelectedIndex == 1)
            {

                for (i = 0; i < 700; i++)
                {
                    for (j = 0; j < 500; j++)
                    {

                        colorT = (((int)(Math.Sin(i) + 1) + (int)(Math.Cos(j) + 1)) + (j + j + 1)) % 15;
                        c = paleta0[colorT];
                        pixel.SetPixel(i, j, c);


                    }
                }

                fondo.Image = pixel;

            }


            if (cbTapetes.SelectedIndex == 2)
            {

                for (i = 0; i < 700; i++)
                {
                    for (j = 0; j < 500; j++)
                    {

                        colorT = (((int)(Math.Sin(j) + 1)) * (int)Math.PI * (int)(Math.Cos(i) + 1)) % 15;
                        c = paleta0[colorT];
                        pixel.SetPixel(i, j, c);


                    }
                }

                fondo.Image = pixel;

            }


            if (cbTapetes.SelectedIndex == 3)
            {

                for (i = 0; i < 700; i++)
                {
                    for (j = 0; j < 500; j++)
                    {

                        colorT = (int)Math.Sqrt(((j * i) * (j + i) / (i + 1))) % 15;
                        c = paleta0[colorT];
                        pixel.SetPixel(i, j, c);


                    }
                }

                fondo.Image = pixel;

            }


            if (cbTapetes.SelectedIndex == 4)
            {

                for (i = 0; i < 700; i++)
                {
                    for (j = 0; j < 500; j++)
                    {
                        cont = cont + 10;
                        colorT = (int)(((j + cont)) / Math.Log(cont) % 15);
                        c = paleta1M[colorT];
                        pixel.SetPixel(i, j, c);


                    }
                }

                fondo.Image = pixel;

            }


            if (cbTapetes.SelectedIndex == 5)
            {


                for (i = 0; i < 700; i++)
                {
                    for (j = 0; j < 500; j++)
                    {
                        colorT = (int)((Math.Pow(i * (j + 70), 7) + Math.Pow(j * i * 2 / 2.5, 2)) % 5 + 1);
                        c = paletaP[colorT];
                        pixel.SetPixel(i, j, c);


                    }
                }

                fondo.Image = pixel;

            }

            if (cbTapetes.SelectedIndex == 6)
            {


                for (i = 0; i < 700; i++)
                {
                    for (j = 0; j < 500; j++)
                    {
                        colorT = (int)(Math.E * (i / 2) + Math.PI * (Math.Pow(j, 2)) + j * i) % 4;
                        c = paletaC[colorT];
                        pixel.SetPixel(i, j, c);


                    }
                }

                fondo.Image = pixel;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cVector v = new cVector();
            float t = -8;
            float dt = 0.0001f;

            do
            {
                v.x0 = t;
                v.y0 = -1 * (-50 + Math.Pow(t, 2)) / 15;
                v.color0 = Color.Blue;
                v.Encender(pixel);

                t += dt;
            } while (t <= 8);

            /*v.x0 = 6;
            v.y0 = 48.75 / 15;
            v.color0 = Color.Red;
            v.Encender(pixel);*/







            fondo.Image = pixel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();
            double x = 0.1;
            v.x0 = 0;
            v.y0 = -0.48;

            do
            {
                x += +0.1;

                v.color0 = Color.Black;
                v.Encender(pixel);

            } while (x < 0.5);

            fondo.Image = pixel;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            /*
            Segmento seg = new Segmento();
            lazo l = new lazo();
            circulo c = new circulo();

            seg.x0 = 2;
            seg.xf = -5;
            seg.y0 = 2;
            seg.yf = 0;
            seg.color0 = Color.Black;
            seg.Encender(pixel);

            // lazo 
            l.x0 = -2;
            l.y0 = 3;
            l.rd = 1;
            l.color0 = Color.Purple;
            l.Encender(pixel);


            // circulo
            c.x0 = 1;
            c.y0 = -2;
            c.rd = 2;
            c.color0 = Color.DarkGreen;

            c.Encender(pixel);

            fondo.Refresh();
            Thread.Sleep(2000);
            c.Apagar(pixel);

            fondo.Image = pixel;*/


            circulo c = new circulo();

            double x = -8;
            c.rd = 1;
            do
            {
                c.x0 = x;
                c.y0 = (Math.Pow(x, 2)) / 15;
                c.color0 = Color.Blue;
                c.Encender(pixel);
                fondo.Image = pixel;
                fondo.Refresh();
                Thread.Sleep(10);
                c.Apagar(pixel);
                fondo.Image = pixel;
                x += 0.4;

            } while (x <= 8);


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Segmento seg = new Segmento();
            seg.x0 = -3;
            seg.y0 = -16;//-4
            seg.xf = -3;
            seg.color0 = Color.Black;
            seg.yf = (float)(49 - Math.Pow(-3, 2)) / 15;
            seg.Encender(pixel);

            fondo.Image = pixel;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Segmento seg = new Segmento();
            seg.x0 = -3;
            seg.y0 = (float)(49 - Math.Pow(-3, 2)) / 15;
            seg.color0 = Color.Black;
            //seg.Encender(pixel) ;

            seg.color0 = Color.Purple;

            seg.xf = 8;
            seg.yf = Math.Round((float)((-1.0467 * 8) - 0.48));
            seg.Encender(pixel);
            fondo.Image = pixel;
        }



        private void fondo_Click(object sender, EventArgs e)
        {

            circulo c = new circulo();
            cFuncion funcion = new cFuncion();
            Segmento seg = new Segmento();

            float dt = 0.0001f;

            funcion.Carta(p, q, out a, out b);
            c.x0 = a;
            c.y0 = b;
            c.rd = 0.5;
            c.color0 = Color.DarkGreen;
            c.Encender(pixel);

            //fondo.Image = pixel;

            label1.Text = c.x0.ToString();
            label2.Text = c.y0.ToString();



            seg.x0 = c.x0;
            seg.y0 = c.y0;
            seg.xf = 3;
            seg.color0 = Color.Black;
            seg.yf = (float)(49 - Math.Pow(-3, 2)) / 15;

            seg.Encender(pixel);

            fondo.Image = pixel;



        }

        private void fondo_MouseMove(object sender, MouseEventArgs e)
        {
            p = e.X;
            q = e.Y;

            //label1.Text = p.ToString();
            //label2.Text = q.ToString();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            circulo c = new circulo();

            double x = -8;
            c.rd = 0.5;
            do
            {
                c.x0 = x;
                c.y0 = -(x + 5) * (x + 1);//-Math.Abs(x - 1) + 5;
                c.color0 = Color.Blue;
                c.Encender(pixel);
                fondo.Image = pixel;
                fondo.Refresh();
                Thread.Sleep(10);
                c.Apagar(pixel);
                fondo.Image = pixel;
                x += 0.4;

            } while (x <= 8);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();
            float t = -7;
            float dt = 0.0001f;

            do
            {
                v.x0 = t;
                v.y0 = (-10 + Math.Pow(t, 2)) / 20;
                v.color0 = Color.Red;
                v.Encender(pixel);

                t += dt;
            } while (t <= 2);

            fondo.Image = pixel;


        }

        private void Z(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            double t = 0;

            cVector3D v3d = new cVector3D();

            do
            {
                v3d.x0 = 3 * Math.Cos(t);
                v3d.y0 = 3 * Math.Sin(t);
                v3d.z0 = 2 + 3 * Math.Cos(t);
                v3d.Encender(pixel);
                t += 0.005;


            } while (t <= 9.8);

            fondo.Image = pixel;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();
            circulo c = new circulo();
            float t = -8;
            c.rd = 0.5;


            float dt = 0.01f;
            v.color0 = Color.Black;
            do
            {
                c.x0 = t;
                c.y0 = -(t + 5) * (t + 1);
                c.color0 = Color.Red;
                v.x0 = t;
                v.y0 = -(t + 5) * (t + 1);
                if (v.y0 >= 0)
                {

                    v.Encender(pixel);

                }

                if (c.y0 >= 0)
                {

                    c.Encender(pixel);
                    fondo.Image = pixel;

                    Thread.Sleep(1);
                    fondo.Refresh();
                    c.Apagar(pixel);
                    fondo.Image = pixel;
                }

                t += dt;
            } while (t <= 8);



            t = -8;
            do
            {
                c.x0 = t;
                c.y0 = -(t + 1) * (t - 2);
                c.color0 = Color.Red;
                v.x0 = t;
                v.y0 = -(t + 1) * (t - 2);
                if (v.y0 >= 0)
                {

                    v.Encender(pixel);

                }

                if (c.y0 >= 0)
                {

                    c.Encender(pixel);
                    fondo.Image = pixel;

                    Thread.Sleep(1);
                    fondo.Refresh();
                    c.Apagar(pixel);
                    fondo.Image = pixel;
                }
                t += dt;
            } while (t <= 8);

            t = -8;

            do
            {
                c.x0 = t;
                c.y0 = -(t - 2) * (t - 4);
                c.color0 = Color.Red;
                v.x0 = t;
                v.y0 = -(t - 2) * (t - 4);
                if (v.y0 >= 0)
                {
                    v.Encender(pixel);

                }

                if (c.y0 >= 0)
                {

                    c.Encender(pixel);
                    fondo.Image = pixel;

                    Thread.Sleep(1);
                    fondo.Refresh();
                    c.Apagar(pixel);
                    fondo.Image = pixel;
                }
                t += dt;
            } while (t <= 8);

            fondo.Image = pixel;
        }

        private void Onda_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            o.Encender(pixel);
            fondo.Image = pixel;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            cCurvaV cv = new cCurvaV();



            cv.x0 = 3;
            cv.y0 = -1;
            cv.rd = 2;
            cv.color0 = Color.Purple;
            cv.Encender(pixel);



            fondo.Image = pixel;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cSenoTaylor st = new cSenoTaylor();
            st.Encender(pixel);
            fondo.Image = pixel;

            cCosenoTaylor ct = new cCosenoTaylor();
            ct.Encender(pixel);
            fondo.Image = pixel;

            cTangenteTaylor tt = new cTangenteTaylor();
            tt.Encender(pixel);
            fondo.Image = pixel;

            funcioncubo fc = new funcioncubo();
            fc.Encender(pixel);
            fondo.Image = pixel;

            funcionE fe = new funcionE();
            fe.Encender(pixel);
            fondo.Image = pixel;
        }
    }
}