using System.Windows.Forms;

namespace WinFormsAppPractica1
{
    public partial class Form1 : Form
    {

        Bitmap pixel = new Bitmap(700, 420);


        public Form1()
        {

            InitializeComponent();





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

        private void VectorBtn_Click(object sender, EventArgs e)
        {

            //Ejes
            Bitmap pixelVector = new Bitmap(700, 420);
            Vector vec = new Vector();

            vec.X0 = 0;
            vec.Y0 = 1;
            //int a, b;


            // vec.Pantalla(0, 1, out a, out b);

            // label1.Text = a.ToString();
            //label2.Text = b.ToString();
            vec.color0 = Color.Red;
            vec.encender(pixelVector);
            //pixelVector.SetPixel(500,300, Color.Red);
            // PBox.Image = pixelVector;


            ///////////////////////////////////////7
            vec.X0 = -1;
            vec.Y0 = 0;
            vec.encender(pixelVector);
            //PBox.Image = pixelVector;


            vec.X0 = -1;
            vec.Y0 = 0;
            vec.encender(pixelVector);
            //PBox.Image = pixelVector;



            vec.X0 = 1;
            vec.Y0 = 0;
            vec.encender(pixelVector);
            //PBox.Image = pixelVector;



            vec.X0 = 0;
            vec.Y0 = 0;
            vec.encender(pixelVector);
            //PBox.Image = pixelVector;


            vec.X0 = 0;
            vec.Y0 = 3;
            vec.encender(pixelVector);
            //PBox.Image = pixelVector;

            vec.X0 = 5;
            vec.Y0 = 0;
            vec.encender(pixelVector);
            PBox.Image = pixelVector;

            PBox.BackColor = Color.White;



        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSegmento_Click(object sender, EventArgs e)
        {

            Bitmap pixelVector = new Bitmap(700, 420);
            Segmento seg = new Segmento();

            seg.color0 = Color.Yellow;
            seg.X0 = -10;
            seg.Y0 = 0;
            seg.xf = 10;
            seg.yf = 0;
            seg.encender(pixelVector);

            seg.X0 = 0;
            seg.Y0 = -5.98;
            seg.xf = 0;
            seg.yf = 5.98;
            seg.encender(pixelVector);


            PBox.Image = pixelVector;




            PBox.BackColor = Color.White;
        }

        private void BtnCircunferencia_Click(object sender, EventArgs e)
        {
            Bitmap pixelVector = new Bitmap(700, 420);
            Circunferencia c = new Circunferencia();
            c.color0 = Color.Yellow;

            c.X0 = 6;
            c.Y0 = 1;
            c.Rd = 3;
            c.encender(pixelVector);

            PBox.Image = pixelVector;

            //c.X0 = 6;
            //c.Y0 = 1;
            //c.Rd = 3;


        }

        private void BtnLinea_Click(object sender, EventArgs e)
        {
            Bitmap pixelVector = new Bitmap(700, 420);
            Vector v = new Vector();

            Segmento seg = new Segmento();
            seg.color0 = Color.DarkGoldenrod;

            seg.X0 = -7;
            seg.Y0 = -2;
            seg.xf = 3;
            seg.yf = 4;
            seg.encender(pixelVector);

            PBox.Image = pixelVector;
            v.color0 = Color.Black;

            PBox.BackColor = Color.White;



            /*
             
             x0=-5;
            yo=3;
            rd=2;
            encender
             
             */

        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            Bitmap pixelVector = new Bitmap(700, 420);
            Segmento seg = new Segmento();

            seg.color0 = Color.Blue;
            seg.X0 = -9;
            seg.Y0 = 5;
            seg.xf = 8;
            seg.yf = 0;
            seg.encender(pixelVector);

            seg.X0 = -6;
            seg.Y0 = -5;
            seg.xf = 8;
            seg.yf = 0;
            seg.encender(pixelVector);





            Circunferencia c = new Circunferencia();
            c.color0 = Color.Black;
            c.X0 = 8;
            c.Y0 = 0;
            c.Rd = 1.2;
            c.encender(pixelVector);

            c.X0 = -6;
            c.Y0 = 0;
            c.Rd = 1.8;
            c.encender(pixelVector);




            Raiz r = new Raiz();
            r.color0 = Color.Blue;
            r.X0 = 2;
            r.Y0 = 4;
            r.Rd = 1;
            r.encender(pixelVector);


            Laso l = new Laso();
            l.color0 = Color.DarkOrange;
            l.X0 = -5.5;
            l.Y0 = 1;
            l.Rd = 0.6;
            l.encender(pixelVector);

            l.X0 = 6.5;
            l.Y0 = -3;
            l.Rd = 0.8;
            l.encender(pixelVector);


            Segmento ses = new Segmento();

            ses.color0 = Color.Red;
            ses.X0 = -10;
            ses.Y0 = 0;
            ses.xf = 10;
            ses.yf = 0;
            ses.encender(pixelVector);


            ses.X0 = 0;
            ses.Y0 = -5.98;
            ses.xf = 0;
            ses.yf = 5.98;
            ses.encender(pixelVector);


            PBox.Image = pixelVector;


            PBox.BackColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h = 0;
            Bitmap pixelVector = new Bitmap(700, 420);
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Red;

            do
            {
                v3d.X0 = 2 + 2 * Math.Cos(h);
                v3d.Y0 = 1 + 2 * Math.Sin(h);
                v3d.Z0 = -2 + h / 5;
                v3d.encender(pixelVector);
                h = h + 0.002;

            } while (h <= 15);
            PBox.Image = pixelVector;


            PBox.BackColor = Color.White;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap pixelVector = new Bitmap(700, 420);
            Segmento3d seg3d = new Segmento3d();
            seg3d.color0 = Color.Black;
            seg3d.X0 = 0;
            seg3d.Y0 = 0;
            seg3d.Z0 = 0;
            seg3d.Xf = 0;
            seg3d.Yf = 0;
            seg3d.Zf = 5;
            seg3d.encender(pixelVector);

            seg3d.X0 = 0;
            seg3d.Y0 = 0;
            seg3d.Z0 = 0;
            seg3d.Xf = 0;
            seg3d.Yf = 5;
            seg3d.Zf = 0;
            seg3d.encender(pixelVector);


            seg3d.X0 = 0;
            seg3d.Y0 = 0;
            seg3d.Z0 = 0;
            seg3d.Xf = 8;
            seg3d.Yf = 0;
            seg3d.Zf = 0;
            seg3d.encender(pixelVector);


            // punto 8
            seg3d.X0 = 0;
            seg3d.Y0 = 0;
            seg3d.Z0 = 5;
            seg3d.Xf = 8;
            seg3d.Yf = 0;
            seg3d.Zf = 5;
            seg3d.encender(pixelVector);


            //punto 9

            seg3d.X0 = 8;
            seg3d.Y0 = 0;
            seg3d.Z0 = 0;
            seg3d.Xf = 8;
            seg3d.Yf = 0;
            seg3d.Zf = 5;
            seg3d.encender(pixelVector);

            //punto 9

            seg3d.X0 = 0;
            seg3d.Y0 = 0;
            seg3d.Z0 = 0;
            seg3d.Xf = 8;
            seg3d.Yf = 0;
            seg3d.Zf = 5;
            seg3d.encender(pixelVector);


            //punto 7

            seg3d.X0 = 0;
            seg3d.Y0 = 0;
            seg3d.Z0 = 5;
            seg3d.Xf = 0;
            seg3d.Yf = 7;
            seg3d.Zf = 5;
            seg3d.encender(pixelVector);

            //punto 6
            seg3d.X0 = 0;
            seg3d.Y0 = 7;
            seg3d.Z0 = 5;
            seg3d.Xf = 0;
            seg3d.Yf = 7;
            seg3d.Zf = 0;
            seg3d.encender(pixelVector);


            //punto 6
            seg3d.X0 = 0;
            seg3d.Y0 = 7;
            seg3d.Z0 = 0;
            seg3d.Xf = 5;
            seg3d.Yf = 7;
            seg3d.Zf = 0;
            seg3d.encender(pixelVector);



            PBox.Image = pixelVector;



            PBox.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Bitmap pixelVector = new Bitmap(700, 420);

            Vector3D v3d = new Vector3D();

            double h = 0;
            v3d.color0 = Color.Bisque;
            do
            {
                v3d.X0 = 2 + 2 * Math.Cos(h);
                v3d.Y0 = 2 + 2 * Math.Sin(h);
                v3d.Z0 = -2 + h / 5;
                v3d.encender(pixelVector);
                h = h + 0.002;
            } while (h <= 25);





            h = 0;
            v3d.color0 = Color.Black;
            do
            {
                v3d.X0 = 3 + 2 * Math.Cos(h);
                v3d.Y0 = -2 + 2 * Math.Sin(h);
                v3d.Z0 = -2 + h / 5;
                v3d.encender(pixelVector);
                h = h + 0.002;
            } while (h <= 18);



            h = 0;
            v3d.color0 = Color.Chartreuse;
            do
            {
                v3d.X0 = -3 + 2 * Math.Cos(h);
                v3d.Y0 = 3 + 2 * Math.Sin(h);
                v3d.Z0 = -2 + h / 7;
                v3d.encender(pixelVector);
                h = h + 0.002;
            } while (h <= 15);

            PBox.Image = pixelVector;

            PBox.BackColor = Color.White;





        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Vector V = new Vector();

            Bitmap pixelVector = new Bitmap(700, 420);

            // rgb azul 0.0.255     verde  0.255.0
            for (int i = 0; i < 700; i++)
            {

                for (int j = 0; j < 420; j++)
                {

                    if (i < 350)
                    {
                        pixelVector.SetPixel(i, j, Color.FromArgb(255, 255, ((255 * i) / 350), ((255 * i) / 350)));
                    }
                    else
                    {
                        pixelVector.SetPixel(i, j, Color.FromArgb(255, 255, 255, (-255 * (i - 700) / 350)));
                    }


                }

            }


            /* for (int i = 350; i < 700; i++)
              {

                  for (int j = 0; j < 420; j++)
                  {

                      pixelVector.SetPixel(i, j, Color.FromArgb(255, 255, (255 * i / 700), (255 * i / 700)));

                  }

              }*/


            //// p1 componente r  (0.0)    (700.0)
            ///   p1 comónente g (0.0)  (700,255)
            ///   p1 componente b (0,255) (700,0)
            ///   
            ///   no interpolar la primera componente por los colores    
            ///   
            ///   
            ///   
            ///   
            ///   




            PBox.Image = pixelVector;

            PBox.BackColor = Color.White;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap pixelVector = new Bitmap(700, 420);
            Vector v = new Vector();
            v.Apagar(pixelVector);

            PBox.Image = pixelVector;

            PBox.BackColor = Color.White;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Vector V = new Vector();

            Bitmap pixelVector = new Bitmap(700, 420);

            // rgb azul 0.0.255     verde  0.255.0
            for (int i = 0; i < 700; i++)
            {

                for (int j = 0; j < 420; j++)
                {



                    pixelVector.SetPixel(i, j, Color.FromArgb(255, 255, (int)((255 * i) / 700), 0));



                }

            }




            PBox.Image = pixelVector;

            PBox.BackColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Bitmap pixelVector = new Bitmap(700, 420);
            Vector3D v3d = new Vector3D();
            v3d.color0 = Color.Black;
            double t, h;

            t = -5;
            do
            {
                h = -4;
                do
                {
                    v3d.X0 = t;
                    v3d.Y0 = h;
                    v3d.Z0 = (0.17 * (Math.Pow(t, 2) - Math.Pow(h, 2)) - 3);
                    v3d.encender(pixelVector);

                    h = h + 0.1;


                } while (h <= 4);

                t = t + 0.1;

            } while (t <= 5);




            PBox.Image = pixelVector;

            PBox.BackColor = Color.White;

        }

        private void button8_Click(object sender, EventArgs e)
        {


            Vector v = new Vector();
            Bitmap pixel = new Bitmap(720, 420);
            PBox.BackColor = Color.White;
            double td = -3;

            do
            {
                v.X0 = td;
                v.Y0 = ((-1) * (Math.Pow(td, 2)) + 5 * td + 24) / 6.2;
                v.color0 = Color.Red;
                v.encender(pixel);
                PBox.Image = pixel;

                td += 0.01;

            } while (td <= 8);




            Circunferencia C = new Circunferencia();
            // Bitmap pixel = new Bitmap(720, 420);
            double t = -3;
            C.Rd = 0.5;

            do
            {
                C.color0 = Color.Blue;
                C.X0 = t;
                C.Y0 = ((-1) * (Math.Pow(t, 2)) + 5 * t + 24) / 6.2;

                C.encender(pixel);
                PBox.Image = pixel;
                PBox.Refresh();
                Thread.Sleep(20);
                C.Apagar(pixel);
                PBox.Image = pixel;
                t += 0.1;

            } while (t <= 8);



            PBox.BackColor = Color.White;



        }

        private void button9_Click(object sender, EventArgs e)
        {


            Circunferencia C = new Circunferencia();
            Bitmap pixel = new Bitmap(720, 420);
            double t = -5;
            C.Rd = 0.5;

            do
            {
                C.X0 = t;
                C.Y0 = ((-0.15) - (Math.Pow(t, 2)) - 7 * t - 10);
                C.color0 = Color.Blue;
                C.encender(pixel);
                PBox.Image = pixel;
                PBox.Refresh();
                Thread.Sleep(20);
                C.Apagar(pixel);
                PBox.Image = pixel;
                t += 0.1;

            } while (t <= 2);



            PBox.BackColor = Color.White;




        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap pixelVector = new Bitmap(700, 420);
            Circunferencia c = new Circunferencia();
            c.color0 = Color.Yellow;

            c.X0 = 0;
            c.Y0 = 0;
            c.Rd = 5;
            c.encender(pixelVector);

            //Vector vec = new Vector();
            Segmento seg = new Segmento();




            double t = 0;
            double dt = 0.01;
            do
            {
                seg.color0 = Color.Red;
                seg.X0 = 0;
                seg.Y0 = 0;
                seg.xf = 0 + 3 * Math.Cos(t); ;
                seg.yf = 0 + 3 * Math.Sin(t); ;
                seg.encender(pixelVector);
                PBox.Image = pixelVector;
                PBox.Refresh();
                //Thread.Sleep(20);
                seg.Apagar(pixelVector);
                PBox.Image = pixelVector;
                t = t - dt;

            } while (t >= -2 * (Math.PI));

            PBox.Image = pixelVector;
            PBox.BackColor = Color.White;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap pixelVector = new Bitmap(700, 420);

            Vector vec = new Vector();
            double t = -2.8;

            do
            {
                vec.color0 = Color.Red;
                vec.X0 = t;
                vec.Y0 = 1 / (t + 3);
                vec.encender(pixelVector);

                vec.color0 = Color.Blue;

                vec.Y0 = (1.0 / 3.0) - (t / 9) + ((Math.Pow(t, 2) / 27));
                vec.encender(pixelVector);
                t = t + 0.001;

            } while (t <= 10);

            PBox.Image = pixelVector;

            PBox.BackColor = Color.White;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bitmap pixel = new Bitmap(700, 420);

            Onda onda = new Onda();

            onda.grafOnda3d(pixel);
            PBox.Image = pixel;


        }

        private void button13_Click(object sender, EventArgs e)
        {
            Bitmap pixel = new Bitmap(700, 420);

            Onda onda = new Onda();
            onda.GrafOnda(pixel);
            //onda.Interferencia(pixel);
            PBox.Image = pixel;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bitmap pixel = new Bitmap(700, 420);

            double tp = 0;
            double dtp = 0.066;
            Onda onda = new Onda();

            do
            {

                onda.t = tp;
                onda.GrafOnda(pixel);
                PBox.Image = pixel;
                PBox.Refresh();
                Thread.Sleep(10);
                pixel = new Bitmap(700, 420);
                PBox.Image = pixel;
                tp = tp + dtp;

            } while (tp < 6);

        }

        private void button15_Click(object sender, EventArgs e)
        {

            Bitmap pixel = new Bitmap(700, 420);

            double tp = 0;
            double dtp = 0.045;
            Onda onda = new Onda();

            do
            {

                onda.t = tp;
                onda.Interferencia(pixel);
                PBox.Image = pixel;
                PBox.Refresh();
                pixel = new Bitmap(700, 420);
                PBox.Image = pixel;
                tp = tp + dtp;

            } while (tp < 2);

        }

        private void button16_Click(object sender, EventArgs e)
        {




            Bitmap pixel = new Bitmap(700, 420);

            double tp = 0;
            double dtp = 0.0145;
            Onda onda = new Onda();
            Vector3D vec3d = new Vector3D();

            do
            {
                // onda.grafOnda3d();
                onda.t = tp;
                onda.color0 = Color.Black;
                onda.interferenciaOnda3d(pixel);

                PBox.Image = pixel;
                //PBox.Refresh();
                //Thread.Sleep(3);
                pixel = new Bitmap(700, 420);
                PBox.Image = pixel;
                tp = tp + dtp;

            } while (tp < 6);

        }

        private void button17_Click(object sender, EventArgs e)
        {

            Bitmap pixel = new Bitmap(700, 420);

            double tp = 0;
            double dtp = 0.0145;
            Onda onda = new Onda();
            Vector3D vec3d = new Vector3D();

            do
            {
                onda.t = tp;
                onda.color0 = Color.Black;
                onda.grafOnda3d(pixel);
                PBox.Image = pixel;
                PBox.Refresh();
                Thread.Sleep(3);
                pixel = new Bitmap(700, 420);
                PBox.Image = pixel;
                tp = tp + dtp;

            } while (tp < 6);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0;



            Bitmap pixel = new Bitmap(700, 420);

            o.v = 9.3;
            o.w = 2.25;
            o.t = t;
            //o.principioHuygens(pixel);
            //PBox.Image = pixel;

            //****ONDA 3D****
            do
            {
                o.v = 5.3;
                o.w = 2.25;
                o.t = t;
                o.principioHuygens(pixel);
                PBox.Image = pixel;
                Refresh();

                pixel = new Bitmap(700, 420);
                //Thread.Sleep(5);
                t = t + 0.1;
            } while (t <= 4);


        }

        private void button19_Click(object sender, EventArgs e)
        {


            double yo = -3;
            double yf = 3;
            double xo = -7;
            double xf = -2;
            double t = 0;
            double dt = 0.01;

            Circunferencia c = new Circunferencia();

            c.Rd = 0.6;
            PBox.BackColor = Color.White;

            do
            {
                c.color0 = Color.Green;
                c.X0 = (xo * (1 - t)) + (xf * t);
                c.Y0 = (yo * (1 - t)) + (yf * t);
                c.encender(pixel);
                PBox.Image = pixel;
                PBox.Refresh();
                c.Apagar(pixel);
                t = t + dt;

            } while (t <= 1);

            double x = -2;

            do
            {
                c.color0 = Color.Green;
                c.X0 = x;
                c.Y0 = (((-Math.Pow(x, 2) + 2 * x + 8) / 4.5) + 3);
                c.encender(pixel);
                PBox.Image = pixel;
                PBox.Refresh();
                c.Apagar(pixel);
                x = x + 0.05;

            } while (x <= 4);



        }

        private void button20_Click(object sender, EventArgs e)
        {

            //Bitmap pixel = new Bitmap(700, 420);
            Circunferencia c = new Circunferencia();

            c.color0 = Color.Red;

            c.Rd = 0.4;
            c.X0 = -7;
            c.Y0 = -3;
            c.encender(pixel);
            c.color0 = Color.Red;
            c.X0 = -2;
            c.Y0 = 3;
            c.encender(pixel);
            c.color0 = Color.Red;
            c.X0 = 1;
            c.Y0 = 5;
            c.encender(pixel);
            c.color0 = Color.Red;
            c.X0 = 4;
            c.Y0 = 3;
            c.encender(pixel);
            PBox.Image = pixel;
            PBox.BackColor = Color.White;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Bitmap pixelvector = new Bitmap(700, 420);

            CuerdaV cuerda = new CuerdaV();
            cuerda.color0 = Color.Red;
            cuerda.GraficarC(pixel);

            PBox.Image = pixel;
            PBox.BackColor = Color.White;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 700; i++)
            {

                for (int j = 0; j < 420; j++)
                {



                    //  pixel.SetPixel(i, j, Color.FromArgb(51*(i-700)/-700+ 255 * i/700, 255 * (i - 700) / -700 + 21 * i/700, 255 * (i - 700) / -700 + 153 * i/700));

                    //pixel.SetPixel(i, j, Color.FromArgb( 0, 255 , 255 * (i - 700) / -700));     //(-255 * (i - 700) / 350)

                    //  pixel.SetPixel(i, j, Color.FromArgb((int)255 * i / 700, (int)255 * i / 700, (int)255*i/700));

                    // pixel.SetPixel(i, j, Color.FromArgb(255, 255 * i / 700, 0));

                    // pixel.SetPixel(i, j, Color.FromArgb(255 * i*i-(1050*i)+(350*700)/(350*700)+255 * i*i-(700*i)/(-350*700) , 0 , 255 ));
                }



                //255 * (i - 350) / -350 * (i - 700) / -700 + 255 * i / 350 * (i - 700) / -350


            }
            PBox.Image = pixel;
            PBox.BackColor = Color.White;


        }

        private void button23_Click(object sender, EventArgs e)
        {



            double t = 0;
            double dt = 0.01;

            Circunferencia c = new Circunferencia();




            c.color0 = Color.Red;

            c.Rd = 0.4;
            c.X0 = -6;
            c.Y0 = 3;
            c.encender(pixel);
            c.color0 = Color.Red;
            c.X0 = -1;
            c.Y0 = -3;
            c.encender(pixel);
            c.color0 = Color.Red;
            c.X0 = 5;
            c.Y0 = 2;
            c.encender(pixel);

            PBox.Image = pixel;
            PBox.BackColor = Color.White;


            c.Rd = 0.6;

            Vector vec = new Vector();







            double x = -6;

            do
            {
                vec.color0 = Color.Red;
                vec.X0 = x;
                vec.Y0 = 3 * (Math.Pow(x, 2) - 4 * x - 5) / 55 - 3 * (Math.Pow(x, 2) + x - 30) / -30 + 2 * (Math.Pow(x, 2) + 7 * x + 6) / 66;
                vec.encender(pixel);
                c.color0 = Color.Green;
                c.X0 = x;
                c.Y0 = 3 * (Math.Pow(x, 2) - 4 * x - 5) / 55 - 3 * (Math.Pow(x, 2) + x - 30) / -30 + 2 * (Math.Pow(x, 2) + 7 * x + 6) / 66;
                c.encender(pixel);
                PBox.Image = pixel;
                PBox.Refresh();
                c.Apagar(pixel);
                x = x + 0.05;

            } while (x <= 5);




        }

        private void button24_Click(object sender, EventArgs e)
        {

            CuerdaV cv = new CuerdaV();

            double t = 0;


            do
            {
                cv.color0 = Color.Green;
                cv.GraficarC(pixel);
                PBox.Image = pixel;
                Refresh();
                //pixel = null;
                pixel = new Bitmap(700, 420);
                //Plano();
                Thread.Sleep(30);
                cv.t = t;
                t += 0.50;

                //Ejes

            } while (t <= 2 * Math.PI);

        }

        private void button25_Click(object sender, EventArgs e)
        {



            double x = -1;
            //double y = 1;
            // double t = 0;
            // double dt = 0.005;

            //  Vector vec = new Vector(0,0,Color.Red);

            //segmento


            Segmento seg = new Segmento();
            seg.color0 = Color.Green;

            seg.X0 = -5;
            seg.Y0 = 4;
            seg.xf = 7;
            seg.yf = 1;
            seg.encender(pixel);

            seg.X0 = 2;
            seg.Y0 = -2;
            seg.xf = 4;
            seg.yf = 3;
            seg.encender(pixel);

            seg.X0 = 3;
            seg.Y0 = 3;
            seg.xf = 4;
            seg.yf = 5;
            seg.encender(pixel);

            PBox.Image = pixel;
            PBox.BackColor = Color.White;

            //animacion

            //do
            //{

            //    if (x <= 1.88)
            //    {
            //        vec.color0 = Color.Red;
            //        vec.X0 = x;
            //        vec.Y0 = (x - 1.88) / -2.88 + 5.98 * (x + 1) / 2.88;
            //        vec.encender(pixel);
            //        PBox.Image = pixel;
            //        PBox.Refresh();
            //        //vec.Apagar(pixel);
            //        x = x + dt;

            //    }
            //    else
            //    {
            //        vec.color0 = Color.Blue;
            //        vec.X0 = x;
            //        vec.Y0 = 5.98*(x - 9) / (1.88-9) + -5.98 * (x - 1.88) / (9-1.88);
            //        vec.encender(pixel);
            //        PBox.Image = pixel;
            //        PBox.Refresh();
            //        //vec.Apagar(pixel);
            //        x = x + dt;
            //    }





            //} while (x <= 9);




        }

        private void button26_Click(object sender, EventArgs e)
        {
            Bitmap pixel = new Bitmap(700, 420);

            Onda onda = new Onda();
            onda.Onda2(pixel);
            //onda.Interferencia(pixel);
            PBox.Image = pixel;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Bitmap pixel = new Bitmap(700, 420);

            Onda onda = new Onda();
            onda.Interferencia2Ondas(pixel);
            //onda.Interferencia(pixel);
            PBox.Image = pixel;

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Bitmap pixel = new Bitmap(700, 420);

            Onda onda = new Onda();

            onda.Interferencia(pixel);
            PBox.Image = pixel;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Bitmap pixel = new Bitmap(600, 500);

            Onda onda = new Onda();

            onda.Interferencia3D2(pixel);
            PBox.Image = pixel;

        }

        private void button30_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0;
            do
            {
                o.v = 9.3;
                o.w = 2.25;
                o.t = t;
                o.Interferencia3D(pixel);
                PBox.Image = pixel;
                Refresh();
                pixel = null;
                pixel = new Bitmap(650, 500);
                Thread.Sleep(5);
                t = t + 0.01;
            } while (t <= 4);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Onda o = new Onda();
            double t = 0;
            do
            {
                o.v = 9.3;
                o.w = 2.25;
                o.t = t;
                o.Interferencia3D2(pixel);
                PBox.Image = pixel;
                Refresh();
                pixel = null;
                pixel = new Bitmap(650, 500);
                Thread.Sleep(100);
                t = t + 0.01;
            } while (t <= 4);
        }

        private void PBox_Click(object sender, EventArgs e)
        {

        }
    }
}

