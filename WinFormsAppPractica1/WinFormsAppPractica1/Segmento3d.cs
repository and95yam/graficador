using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPractica1
{
    internal class Segmento3d: Vector3D
    {

		public double Xf, Yf, Zf;
		public override void encender(Bitmap Lienzo)
		{

			Vector3D v = new Vector3D();
			double t = 0, dt = 0.001;
			do
			{
				v.X0 = (X0 * (1 - t)) + (Xf * t);
				v.Y0 = (Y0 * (1 - t)) + (Yf * t);
				v.Z0 = (Z0 * (1 - t)) + (Zf * t);
				v.color0 = Color.Green;
				v.encender(Lienzo);
				t = t + dt;
			}
			while (t <= 1);
		}

	}
}
