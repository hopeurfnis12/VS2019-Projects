using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
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

		public List<double> GetArray(int n, double x1, double x2, double a, double b)
		{
			if (x2 < x1) throw new Exception("ERROR: x2 < x1");
			else if (n < 1) throw new Exception("ERROR: n < 1");
			else
			{
				double h = ((double)x2 - (double)x1) / (n - 1);
				double x = (double)x1;
				List<double> garr = new List<double>();
				for (int i = 0; i < n; i++)
				{
					garr.Add(GetF(x, a, b));
					x += h;
				}
				return garr;
			}
		}

		public void WriteToFile(string name, List<double> val)
		{
			string path_project = @"..\..\..\" + name;
			string path = @"" + name;
			FileStream fs;
			try
			{
				fs = new FileStream(path, FileMode.OpenOrCreate);
				using (StreamWriter op = new StreamWriter(fs))
				{
					for (int i = 0; i < val.Count; i++) op.WriteLine(val[i]);
				}
			}
			catch (IOException)
			{
				throw new Exception("File/path not exists");
			}

		}
	}
}
