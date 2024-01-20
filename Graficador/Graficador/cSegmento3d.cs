using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    class cSegmento3d:cVector3D
    {
		public double Xf, Yf, Zf;
		public override void Encender(Bitmap Lienzo)
		{

			cVector3D v = new cVector3D();
			double t = 0, dt = 0.001;
			do
			{
				v.x0 = (x0 * (1 - t)) + (Xf * t);
				v.y0 = (y0 * (1 - t)) + (Yf * t);
				v.z0 = (z0 * (1 - t)) + (Zf * t);
				v.color0 = Color.Green;
				v.Encender(Lienzo);
				t = t + dt;
			}
			while (t <= 1);
		}
	}
}
