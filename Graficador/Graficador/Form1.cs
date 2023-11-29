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



namespace Graficador
{
    public partial class Form1 : Form
    {
        public Bitmap pixel;
        

        public Form1()
        {
            InitializeComponent();
            pixel = new Bitmap(600, 500);
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
    }
}
