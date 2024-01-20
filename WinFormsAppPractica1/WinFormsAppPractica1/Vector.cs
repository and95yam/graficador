using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPractica1
{
    internal class Vector
    {
        //procesos  pantalla
        //vreal 
        //encender
        //apagar

        // elementos x0,y0 : real,  es para la posicion del vector 

        /// color0  variable que sirve para el colo del vector 
        /// 

        // proceso encender        SX,SY: intenger;
        // se llama a pantalla(x0,y0, sx,sy);
        //encender pixel (sx,sy, color0)

        //coordenadas de la ventana del pc
        public  double sx1 = 0;
        public  double sx2 = 700;
        public  double sy1 = 0;
        public  double sy2 = 420;

        //Coordenadas de la ventana real

        public double x1 = -20;
        public double x2 = 20;
        public double y1 = -10.98;
        public double y2 = 10.98;
        //color 
        public Color color0 ;


        //puntos x0 y y0 ;

        public double X0 ;
        public double Y0 ;
        

        public Vector() {}

        public Vector(double x0, double y0, Color color0)
        {
            this.X0 = x0;
            this.Y0 = y0;
            this.color0 = color0;
        }




        public virtual void encender(Bitmap pixelVector)
        {

           
            int Sx, Sy;
            Pantalla(X0, Y0, out Sx, out Sy);

            if (Sx >= 0 && Sx < 700 && Sy >= 0 && Sy < 420)
            {
                pixelVector.SetPixel(Sx, Sy, color0);

            }
            

        }

        public virtual void Apagar(Bitmap pixelVector)
        {
            Pantalla(X0, Y0, out int sx, out int sy);

            if (sx >= 0 && sx < 700 && sy >= 0 && sy < 420)
            {
                color0 = Color.White;
                encender(pixelVector);

            }


        }

        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = Convert.ToInt32(((x - x1) / (x1 - x2) * (sx1 - sx2)) + sx1);
            sy = Convert.ToInt32(((y - y2) / (y2 - y1) * (sy1 - sy2)) + sy1);

        }

        public void VReal(int sx, int sy, out double x, out double y)
        {
            x = (((sx - sx1) / (sx1 - sx2)) * (x1 - x2)) + x1;
            y = (((sy - sy1) / (sy1 - sy2)) * (y2 - y1)) + y2;

        }


        public void Axonometria (double x,double y, double z, out double ax, out double ay)
        {
            ax = y - (x / 2) * Math.Cos(Math.PI / 4);
            ay = z - (x / 2) * Math.Sin(Math.PI / 4);
        }

    }

}
