using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graficador
{
    internal class cCuerda:cVector
    {

        double l = 6;
        double c = 1;
        public double t = 0.7;

        //  double ve = 1;


        //double g = 1; // representa la velocidad 
        public void GraficarC(Bitmap pixelvector)
        {
            cVector vec = new cVector(0, 0, color0);
            double x;
            x = 0;
            do
            {
                vec.x0 = -2*x;

                vec.y0 = Fourier(x);
                vec.Encender(pixelvector);
                x = x + 0.0010;
            } while (x <= 4);

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

        public double Fourier(double x)
        {
            int k;
            double bk, ak, sum;

            double sol;

            k = 0;
            sum = 0;



            do
            {
                k++;

               /* ak = 0.11 * 4 * f(2) * Math.Sin(k * Math.PI / 0.5) + f(4) * Math.Sin(k * Math.PI);
                ak = ak * 0.5;

                bk=0.11*(4*g(2)*Math.Sin(k * Math.PI / 0.5)+g(4) * Math.Sin(k * Math.PI));
                bk = bk * (2 / (k * Math.PI));

                sum = sum + (ak * Math.Cos((k * Math.PI * t) / 4) + bk * Math.Sin((k * Math.PI * t) / 4)) * Math.Sin(k * Math.PI * (x / 4));*/

                ak = (2.0 / l) * (l / 6.0);
                ak = ak * (0 + 4 * f(l / 2.0) * Math.Sin(k * Math.PI / 2.0) + 0);

                bk = (2.0 / (k * Math.PI * c)) * (l / 6.0);
                bk = bk * (0 + 4 * g(l / 2.0) * Math.Sin((k * Math.PI) / 2.0) + 0);

                sum = sum + (ak * Math.Cos((k * Math.PI * c * t) / l) + bk * Math.Sin((k * Math.PI * c * t) / l)) * Math.Sin((k * Math.PI * x) / l);
                sum = sum / 1.5;

                 /*bk = (2.0 / Math.PI + k + c) * (l / 6.0) * (g(0) * Math.Sin((k * Math.PI * 0) / l))
                     + 4 * g(l / 2.0) * Math.Sin((k * Math.PI * (l / 2.0)) / l)
                     + g(l) * Math.Sin(k * Math.PI);


                 ak = (2.0 / l) * (f(0) * Math.Sin((k * Math.PI * 0)) / l)
                     + 4 * f(l / 2.0) * Math.Sin((k * Math.PI / 2.0))
                     + f(l) * Math.Sin(k * Math.PI);

                 sum = sum + (ak * Math.Cos((k * Math.PI * c * t) / l)//6.6
                     + bk * Math.Sin((k * Math.PI * c * t) / l))//0.001
                     * Math.Sin((k * Math.PI * x) / l);//0*/



            } while (k <= 15);
            sol = sum;

            return sol;
        }

        public double f(double x)
        {
            //return -x / 3.5 * (x - l);
            //return x / 5;
           return 2*x;
        }

        public double g(double x)
        {
           // return -x / 3.5 * (x - l);
           return 7;
          //  return x / 5;
        }

    }

}

