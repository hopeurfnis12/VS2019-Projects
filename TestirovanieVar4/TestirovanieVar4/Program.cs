using System;
using System.Collections.Generic;

namespace TestirovanieVar4
{
	internal class Program
	{
		public static double GetF(double x, double a, double b)
		{
			if (a <= 5)
			{
				Console.WriteLine("ERROR: a <= 5, x = " + x);
				return 0;
			}
			else if (a == 6)
			{
				Console.WriteLine("ERROR: a == 6, x = " + x);
				return 0;
			}
			else if (b == 5)
			{
				Console.WriteLine("ERROR: b == 5, x = " + x);
				return 0;
			}
			else return (Math.Log(10, Math.Sqrt(a - 5))) / (Math.Pow(b, 3) - 125) * (Math.Pow(x, 5) + 20 * x + 67);
		}

		public static List<double> GetArray(int n, double x1, double x2, double a, double b)
		{
			List<double> garr = new List<double>();
			if (x2 < x1)
			{
				Console.WriteLine("ERROR: x2 < x1");
				return garr;
			}
			else if (n < 1)
			{
				Console.WriteLine("ERROR: n < 1");
				return garr;
			}
			else
			{
				double h = ((double)x2 - (double)x1) / (n - 1);
				double x = (double)x1;
				for (int i = 0; i < n; i++)
				{
					garr.Add(GetF(x, a, b));
					x += h;
				}
				return garr;
			}
		}

		static void WriteToFile(string name, List<double> val)
		{
			string path = @"" + name;
			FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
			using (StreamWriter op = new StreamWriter(fs))
			{
				for (int i = 0; i < val.Count; i++) op.WriteLine(i + " = " + val[i]);
			}
		}

		public static void Main(String[] args)
		{
			int n = 2;
			double x1 = 1;
			double x2 = 2;
			double a = 7;
			double b = 8;
			Console.WriteLine("n = " + n
				+ ", x1 = " + x1 + ", x2 = " + x2
				+  ", a = " + a + ", b = " + b);

			List<double> otv = GetArray(n, x1, x2, a, b);
			
			double h = (x2 - x1) / (n - 1);
			double x = x1;
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("x = " + x + ", f(x,a,b) = " + otv[i]);
				x += h;
			}

			string name = "";
			while (name == "")
			{
				Console.Write("\nFile name = ");
				name = Console.ReadLine().ToString();
				if (name == "") Console.WriteLine("EMPTY NAME!!!");
			}
			WriteToFile(name + ".txt", otv);
		}
	}
}