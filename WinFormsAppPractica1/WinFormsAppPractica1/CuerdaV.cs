using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPractica1
{
    internal class CuerdaV : Vector
    {

        double l = 15;
        double c = 0.3;
        public double t = 0;
        
      //  double ve = 1;


        //double g = 1; // representa la velocidad 
        public void GraficarC(Bitmap pixelvector)
        {
            Vector vec = new Vector(0, 0, color0);
            double x;
            x = -5;
            do
            {
                vec.X0 = x;

                vec.Y0 = Fourier(x);
                vec.encender(pixelvector);
                x = x + 0.05;
            } while (x <= l);

            //bk = (2.0 / Math.PI + k + c) * (l / 6.0) * (g(0) * Math.Sin((k * Math.PI * 0) / l))
            //    + 4 * g(l / 2.0) * Math.Sin((k * Math.PI * (l / 2.0)) / l)
            //    + g(l) * Math.Sin(k * Math.PI);


            //ak = (2.0 / l) * (f(0) * Math.Sin((k * Math.PI * 0)) / l)
            //    + 4 * f(l / 2.0) * Math.Sin((k * Math.PI / 2.0))
            //    + f(l) * Math.Sin(k * Math.PI);

            //sun = sun + (ak * Math.Cos((k * Math.PI * c * t) / l)//6.6
            //    + bk * Math.Sin((k * Math.PI * c * t) / l))//0.001
            //    * Math.Sin((k * Math.PI * x) / l);//0



        }

        public double Fourier(double x )
        {


            double sol;
            double bk, ak, sun;
            int k;
            k = 1;
            sun = 0;

            do
            {
                ak = (2.0 / l) * (l / 6.0);
                ak = ak * (0 + 4 * f(l / 2.0) * Math.Sin(k * Math.PI / 2.0) + 0);

                bk = (2.0 / (k * Math.PI * c)) * (l / 6.0);
                bk = bk * (0 + 4 * g(l / 2.0) * Math.Sin((k * Math.PI) / 2.0) + 0);

                sun = sun + (ak * Math.Cos((k * Math.PI * c * t) / l) + bk * Math.Sin((k * Math.PI * c * t) / l)) * Math.Sin((k * Math.PI * x) / l);
                sun = sun / 1.5;

                k++;
            } while (k<=10);
            sol =sun;

            return sol;
        }
            
        public double f(double x) 
        {
            //return -x / 3.5 * (x - l);
            return x / 5;
        }

        public double g(double x)
        {
            //return -x / 3.5 * (x - l);
            //return 1;
            return x / 5;
        }

    }
}
