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
				throw new Exception("ERROR: a <= 5");
			}
			else if (a == 6)
			{
				throw new Exception("ERROR: a == 6");
			}
			else if (b == 5)
			{
				throw new Exception("ERROR: b == 5");
			}
			else return (Math.Log(10, Math.Sqrt(a - 5))) / (Math.Pow(b, 3) - 125) * (Math.Pow(x, 5) + 20 * x + 67);
		}

		public static List<double> GetArray(int n, double x1, double x2, double a, double b)
		{
			List<double> garr = new List<double>();
			if (x2 < x1)
			{
				throw new Exception("ERROR: x2 < x1");
			}
			else if (n < 1)
			{
				throw new Exception("ERROR: n < 1");
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
			if (val.Count() == 0 || val == null) throw new Exception("list error");
			else
			{
				//string path_project = @"..\..\..\" + name;
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

		public static void Main(String[] args)
		{
			Console.Write("n: ");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.Write("x1: ");
			double x1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("x2: ");
			double x2 = Convert.ToDouble(Console.ReadLine());

			Console.Write("a: ");
			double a = Convert.ToDouble(Console.ReadLine());

			Console.Write("b: ");
			double b = Convert.ToDouble(Console.ReadLine());

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
			WriteToFile(name, otv);
		}
	}
}