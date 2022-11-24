using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVar4
{
	internal class ListAccur : IComparer
	{
		private const double accur = 0.0001;
		public int Compare(object x, object y)
		{
			double x1 = (double)x;
			double y1 = (double)y;

			if (Math.Abs(x1 - y1) <= accur)	
				return 0;

			return x1 > y1 ? 1 : -1;
		}
	}
}
