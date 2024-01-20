using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPractica1
{
    internal class Vector3D : Vector
    {
        public double Z0;
        double ax, ay;

        

        public override void encender(Bitmap pixelVector)
        {
            //int Sx, Sy;

            Vector v = new Vector(0,0,color0);

            v.Axonometria(X0, Y0, Z0, out ax,out  ay);
            //v.Pantalla(ax, ay, out Sx, out Sy);

            v.X0 = ax;
            v.Y0 = ay;
            v.encender(pixelVector);
           
        }


    }
}
