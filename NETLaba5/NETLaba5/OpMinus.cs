using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLaba5
{
	class OpMinus
	{
		private int x;
		public OpMinus(int _x)
		{
			x = _x;
		}

		public static OpMinus operator -(OpMinus opm1, OpMinus opm2)
		{
			OpMinus opMinus = new OpMinus(opm1.x * opm2.x);
			Console.Write(opm1.x + " - " + opm2.x + " = ");
			return opMinus;
		}
		public override string ToString()
		{
			return Convert.ToString(x);
		}

		static void Main()
		{
			OpMinus om1 = new OpMinus(30);
			OpMinus om2 = new OpMinus(5);
			OpMinus om3 = new OpMinus(6);
			OpMinus om4 = new OpMinus(2);
			OpMinus otv = om1 - om2 - om3 - om4;
			Console.WriteLine(otv.ToString());
			Console.ReadKey();
		}
	}
}
