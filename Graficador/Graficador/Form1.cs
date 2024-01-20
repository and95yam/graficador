using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Threading;




namespace Graficador
{
    public partial class Form1 : Form
    {
        public Bitmap pixel;
        public Color[] paleta;
        public Color[] paleta2;

        Color[] paletaFuego = new Color[16];

        public Form1()
        {
            InitializeComponent();
            pixel = new Bitmap(600, 500);
            paleta = new Color[16];
            paleta2 = new Color[16];

            paleta[0] = Color.Black;
            paleta[1] = Color.Navy;
            paleta[2] = Color.Green;
            paleta[3] = Color.Aqua;
            paleta[4] = Color.Red;
            paleta[5] = Color.Purple;
            paleta[6] = Color.Maroon;
            paleta[7] = Color.LightGray;
            paleta[8] = Color.DarkGray;
            paleta[9] = Color.Blue;
            paleta[10] = Color.Lime;
            paleta[11] = Color.Silver;
            paleta[12] = Color.Teal;
            paleta[13] = Color.Fuchsia;
            paleta[14] = Color.Yellow;
            paleta[15] = Color.White;


            paleta2[0] = Color.Black;
            paleta2[1] = Color.DarkBlue;
            paleta2[2] = Color.DarkGreen;
            paleta2[3] = Color.DarkCyan;
            paleta2[4] = Color.DarkRed;
            paleta2[5] = Color.DarkMagenta;
            paleta2[6] = Color.Brown;
            paleta2[7] = Color.LightGray;
            paleta2[8] = Color.Gray;
            paleta2[9] = Color.Blue;
            paleta2[10] = Color.Green;
            paleta2[11] = Color.Silver;
            paleta2[12] = Color.Teal;
            paleta2[13] = Color.Magenta;
            paleta2[14] = Color.Gold;
            paleta2[15] = Color.White;





            /*paletaFuego[0] = Color.FromArgb(255, 0, 0);      // Rojo
             paletaFuego[1] = Color.FromArgb(255, 165, 0);    // Naranja
             paletaFuego[2] = Color.FromArgb(255, 255, 0);    // Amarillo
             paletaFuego[3] = Color.FromArgb(255, 69, 0);    */ //Naranja fuerte



            paletaFuego[0] = Color.FromArgb(255, 0, 0);       // Rojo
            paletaFuego[1] = Color.FromArgb(255, 69, 0);      // Rojo anaranjado
            paletaFuego[2] = Color.FromArgb(255, 140, 0);     // Anaranjado
            paletaFuego[3] = Color.FromArgb(255, 165, 0);     // Naranja
            paletaFuego[4] = Color.FromArgb(255, 215, 0);     // Amarillo anaranjado
            paletaFuego[5] = Color.FromArgb(255, 255, 0);     // Amarillo
            paletaFuego[6] = Color.FromArgb(255, 255, 69);    // Amarillo claro
            paletaFuego[7] = Color.FromArgb(255, 255, 140);   // Amarillo pálido
            paletaFuego[8] = Color.FromArgb(255, 255, 165);   // Amarillo suave
            paletaFuego[9] = Color.FromArgb(255, 255, 215);   // Amarillo muy suave
            paletaFuego[10] = Color.FromArgb(255, 255, 255);  // Blanco
            paletaFuego[11] = Color.FromArgb(255, 192, 203);  // Rosa
            paletaFuego[12] = Color.FromArgb(255, 127, 80);   // Coral
            paletaFuego[13] = Color.FromArgb(255, 99, 71);    // Tomate
            paletaFuego[14] = Color.FromArgb(178, 34, 34);    // Fuego oscuro
            paletaFuego[15] = Color.FromArgb(128, 0, 0);      // Fuego profundo


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Segmento seg = new Segmento();
            seg.color0 = Color.White;
            int x = int.Parse(x0.Text);
            int y = int.Parse(y0.Text);
            int xf = int.Parse(x1.Text);
            int yf = int.Parse(y1.Text);


            seg.x0 = x;
            seg.y0 = y;
            seg.xf = xf;
            seg.yf = yf;

            
            seg.Encender(pixel);
            fondo.Image = pixel;
           
        }

        private void button2_Click(object sender, EventArgs e)
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
            s.y0 = -8.33;
            s.yf = 8.33;
            s.color0 = Color.Red;
            s.Encender(pixel);
            fondo.Image = pixel;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fondo.Image = null;
            Color c = Color.Black;
            for (int sx = 0; sx < 600; sx++)
            {
                for (int sy = 0; sy < 500; sy++)
                {
                    pixel.SetPixel(sx, sy, c);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lazo l = new lazo();


            l.x0 = 2;
            l.y0 = 3;
            l.rd = 3;
            l.color0 = Color.Purple;
            l.Encender(pixel);
            fondo.Image = pixel;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cCirculo c = new cCirculo();

            c.x0 = -2;
            c.y0 = 3;
            c.rd = 3;
            c.color0 = Color.DarkGreen;
            c.Encender(pixel);

            fondo.Image = pixel;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cCurva cv = new cCurva();

            cv.x0 = 3;
            cv.y0 = -1;
            cv.rd = 2;
            cv.color0 = Color.Purple;
            cv.Encender(pixel);
            fondo.Image = pixel;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cCurva2 cv = new cCurva2();

            cv.x0 = 3;
            cv.y0 = -1;
            cv.rd = 2;
            cv.color0 = Color.Yellow;
            cv.Encender(pixel);
            fondo.Image = pixel;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cCurva3 cv = new cCurva3();

            cv.x0 = 3;
            cv.y0 = -1;
            cv.rd = 2;
            cv.color0 = Color.Blue;
            cv.Encender(pixel);
            fondo.Image = pixel;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Interpolacion i = new Interpolacion();
            i.Encender(pixel);
            fondo.Image = pixel;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Taylor1 t = new Taylor1();

            t.Encender(pixel);

            fondo.Image = pixel;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Taylor2 t = new Taylor2();

            t.Encender(pixel);

            fondo.Image = pixel;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Taylor3 t = new Taylor3();

            t.Encender(pixel);

            fondo.Image = pixel;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int i, j;
            int colorT;
            Color c;

            for (i = 0; i < 600; i++)
            {
                for (j = 0; j < 500; j++)
                {

                    colorT = ((i * j) + (j * i)) % 15;
                    c = paleta[colorT];
                    pixel.SetPixel(i, j, c);


                }
            }

            fondo.Image = pixel;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int i, j;
            int colorT;
            Color c;

            for (i = 0; i < 600; i++)
            {
                for (j = 0; j < 500; j++)
                {

                    colorT = ((i+j+j+j)*(i*i)) % 15;
                    c = paleta[colorT];
                    pixel.SetPixel(i, j, c);


                }
            }

            fondo.Image = pixel;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int i, j;
            int colorT;
            Color c;

            for (i = 0; i < 600; i++)
            {
                for (j = 0; j < 500; j++)
                {

                    colorT = ((i * j) + (j * i)) % 15;
                    c = paleta2[colorT];
                    pixel.SetPixel(i, j, c);


                }
            }

            fondo.Image = pixel;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int i, j;
            int colorT;
            Color c;

            for (i = 0; i < 600; i++)
            {
                for (j = 0; j < 500; j++)
                {

                    colorT = ((i + j + j + j) * (i * i)) % 15;
                    c = paleta2[colorT];
                    pixel.SetPixel(i, j, c);


                }
            }

            fondo.Image = pixel;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int colorT;
            Color c;
            int cont = 0;

            if(comboBox2.SelectedIndex == 0)
            {
                for (int i = 0; i < 600; i++)
                {
                    for (int j = 0; j < 500; j++)
                    {
                        // Ajusta la ecuación para simular la llama
                        colorT = (int)(Math.Sin(i / 10.0) + Math.Sin(j / 10.0) + Math.Sin((i + j) / 10.0)+Math.Cos(i+j) * 3);
                        colorT = (colorT + 16) % 16; // Asegura que el resultado esté en el rango [0, 15]
                        c = paletaFuego[colorT];
                       pixel.SetPixel(i, j, c);
                    }

                }
                fondo.Image = pixel;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    
                    colorT = (int)(Math.Sin(i / 10.0) + Math.Sin(j*2 / 1000.0) + Math.Sin((i + j*2) / 1000.0) * 2);
                    colorT = (colorT +15) % 15; 
                    c = paletaFuego[colorT];
                    pixel.SetPixel(i, j, c);
                }

            }
            fondo.Image = pixel;

        }

        private async void button20_Click(object sender, EventArgs e)
        {
            // Primera parte
            cCurva cv = new cCurva();
            cv.x0 = 3;
            cv.y0 = -1;
            cv.rd = 2;
            cv.color0 = Color.Purple;
            cv.Encender(pixel);
            fondo.Image = pixel;

            // Esperar 2 segundos
            await Task.Delay(2000);

            // Segunda parte
            cCurva2 cv2 = new cCurva2();
            cv2.x0 = -5;
            cv2.y0 = -4;
            cv2.rd = 2;
            cv2.color0 = Color.Yellow;
            cv2.Encender(pixel);
            fondo.Image = pixel;

            await Task.Delay(3000);
            //limpiar
            fondo.Image = null;
            Color c = Color.Black;
            for (int sx = 0; sx < 600; sx++)
            {
                for (int sy = 0; sy < 500; sy++)
                {
                    pixel.SetPixel(sx, sy, c);
                }
            }
            //grafico 1
            
            cv.x0 = 3;
            cv.y0 = -1;
            cv.rd = 2;
            cv.color0 = Color.Purple;
            cv.Encender(pixel);
            fondo.Image = pixel;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();
            cCirculo c = new cCirculo();
            float t = -8;
            c.rd = 0.25;


            float dt = 0.01f;
            v.color0 = Color.Black;
            do
            {
                c.x0 = t;
                c.y0 = -(t + 8) * (t + 2)/2.25;
                c.color0 = Color.Red;
                v.x0 = t;
                v.y0 = -(t + 8) * (t + 2);
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
                c.y0 = -(t + 2) * (t - 2);
                c.color0 = Color.Red;
                v.x0 = t;
                v.y0 = -(t + 2) * (t - 2);
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

        private void button22_Click(object sender, EventArgs e)
        {
            cVector cv = new cVector();
            double x, dx;
            x = -8;
            dx= 0.002;
            cv.color0 = Color.White;
            do
            {
                cv.x0 = x;
                cv.y0 = 3 * (Math.Exp(-4 * x));
                cv.Encender(pixel);
                x = x + dx;

            } while (x <= 8);

            fondo.Image = pixel;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            cVector cv = new cVector();
            double x, dx;
            x = -8;
            dx = 0.002;
            cv.color0 = Color.Blue;
            do
            {
                cv.x0 = x;
                cv.y0 = 6 * (Math.Exp(-4 * x));
                cv.Encender(pixel);
                x = x + dx;

            } while (x <= 8);

            fondo.Image = pixel;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            cVector cv = new cVector();
            double x, dx;
            x = -8;
            dx = 0.002;
            cv.color0 = Color.Gold;
            do
            {
                cv.x0 = x;
                cv.y0 = 8 * (Math.Exp(-4 * x));
                cv.Encender(pixel);
                x = x + dx;

            } while (x <= 8);

            fondo.Image = pixel;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            cVector cv = new cVector();
            double x, dx;
            x = -8;
            dx = 0.002;
            cv.color0 = Color.Violet;
            do
            {
                cv.x0 = x;
                cv.y0 = -4 * (Math.Exp(-4 * x));
                cv.Encender(pixel);
                x = x + dx;

            } while (x <= 8);

            fondo.Image = pixel;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            cVector cv = new cVector();
            double x, dx;
            x = -8;
            dx = 0.002;
            cv.color0 = Color.Green;
            do
            {
                cv.x0 = x;
                cv.y0 = -7 * (Math.Exp(-4 * x));
                cv.Encender(pixel);
                x = x + dx;

            } while (x <= 8);

            fondo.Image = pixel;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            cVector cv = new cVector();
            double x, dx;
            x = -8;
            dx = 0.002;
            cv.color0 = Color.BurlyWood;
            do
            {
                cv.x0 = x;
                cv.y0 = 9 * (Math.Exp(-4 * x));
                cv.Encender(pixel);
                x = x + dx;

            } while (x <= 8);

            fondo.Image = pixel;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            cVector cv = new cVector();
            double x, dx;
            x = -8;
            dx = 0.002;
            cv.color0 = Color.MistyRose;
            do
            {
                cv.x0 = x;
                cv.y0 = -3 * (Math.Exp(-4 * x));
                cv.Encender(pixel);
                x = x + dx;

            } while (x <= 8);

            fondo.Image = pixel;
        }

        private void button29_Click(object sender, EventArgs e)
        {

            cVector3D vd = new cVector3D();
            double t = 0;
            vd.color0 = Color.White;
            do
            {
                vd.x0 = ((t / 3) - 2);
                vd.y0 = (1 + 3) * Math.Sin(t);
                vd.z0 = ((2 + 3) * Math.Cos(t));
                vd.Encender(pixel);
                t = t + 0.001;

            } while (t <= 15);

            fondo.Image = pixel;



        }

        private void button30_Click(object sender, EventArgs e)
        {
            

        }

        private void button31_Click(object sender, EventArgs e)
        {
            cVector3D vd = new cVector3D();
            double dt = 0.1;
            double dh = 0.2;
            vd.color0 = Color.Yellow;

            for (double t = 0; t <= 6.3; t += dt)
            {
                for (double h = 0; h <= 9; h += dh)
                {
                    vd.x0 = -4 + 2 * Math.Cos(t);
                    vd.y0 = 1 + 3 * Math.Sin(t);
                    vd.z0 = 1 + h / 3;
                    vd.Encender(pixel);
                }
            }

            fondo.Image = pixel;



        }

        private void button32_Click(object sender, EventArgs e)
        {
            cVector3D vd = new cVector3D();
            double dt = 0.1;
            double dh = 0.2;
            double radio = 2;
            vd.color0 = Color.Red;

            for (double t = -1.75; t <= 1.75; t += dt)
            {
                for (double h = 0; h <= 6.3; h += dh)
                {
                    vd.x0 = radio * Math.Cos(t) * Math.Cos(h);
                    vd.y0 = radio * Math.Cos(t) * Math.Sin(h);
                    vd.z0 = radio * Math.Sin(t);
                    vd.Encender(pixel);
                }
            }

            fondo.Image = pixel;




        }

        private void button33_Click(object sender, EventArgs e)
        {
            cVector3D vd = new cVector3D();
            double R = 4.0;  // Radio mayor
            double r = 1.0;  // Radio menor
            double dTheta = 0.05;  // Incremento en el ángulo polar
            double dPhi = 0.05;    // Incremento en el ángulo azimutal

            vd.color0 = Color.Blue;

            for (double theta = 0; theta <= 2 * Math.PI; theta += dTheta)
            {
                for (double phi = 0; phi <= 2 * Math.PI; phi += dPhi)
                {
                    double x = (R + r * Math.Cos(theta)) * Math.Cos(phi);
                    double y = (R + r * Math.Cos(theta)) * Math.Sin(phi);
                    double z = r * Math.Sin(theta);

                    vd.x0 = x;
                    vd.y0 = y;
                    vd.z0 = z;
                    vd.Encender(pixel);
                }
            }

            fondo.Image = pixel;

        }

        private void button34_Click(object sender, EventArgs e)
        {
            Bitmap pixel = new Bitmap(600, 500);
            cOnda onda = new cOnda();

            onda.GrafOnda(pixel);

            // Muestra la lista de valores de z en el ListBox
            listBox1.DataSource = onda.ListaX;
            listBox2.DataSource = onda.ListaY;
            listBox3.DataSource = onda.ListaZ;

            fondo.Image = pixel;


        }

        private void button35_Click(object sender, EventArgs e)
        {
            Bitmap pixel = new Bitmap(700, 420);

            cOnda onda = new cOnda();

            onda.grafOnda3d(pixel);
            listBox1.DataSource = onda.ListaX;
            listBox2.DataSource = onda.ListaY;
            listBox3.DataSource = onda.ListaZ;
            fondo.Image = pixel;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            cOnda o = new cOnda();
            double t = 0;
            do
            {
                o.v = 9.3;
                o.w = 2.25;
                o.t = t;
                o.Onda3DAnimada(pixel);
                fondo.Image = pixel;
                Refresh();
                pixel = null;
                pixel = new Bitmap(600, 500);
                Thread.Sleep(5);
                t = t + 0.01;
            } while (t <= 4);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
