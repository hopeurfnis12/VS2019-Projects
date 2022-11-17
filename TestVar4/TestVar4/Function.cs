using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVar4
{
	internal class Function
	{
		public double GetF(double x, double a, double b)
		{
			if (a <= 5) throw new Exception("ERROR: a <= 5");
			else if (a == 6) throw new Exception("ERROR: a == 6");
			else if (b == 5) throw new Exception("ERROR: b == 5");
			else return (Math.Log(10, Math.Sqrt(a - 5))) / (Math.Pow(b, 3) - 125) * (Math.Pow(x, 5) + 20 * x + 67);
		}
	}
}
