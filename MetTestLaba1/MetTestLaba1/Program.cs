using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MetTestLaba1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите n = ");
			int N = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите х1 = ");
			double X1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите х2 = ");
			double X2 = Convert.ToDouble(Console.ReadLine());

			if(X2 < X1) Console.WriteLine("Ошибка: x2 < x1");
			else
			{
				Console.Write("Введите a = ");
				double A = Convert.ToDouble(Console.ReadLine());
			
				Console.Write("Введите c = ");
				double C = Convert.ToDouble(Console.ReadLine());

				if ( (A < 4 && Math.Abs(C) > 3) || (A > 4 && Math.Abs(C) < 3) || (Math.Abs(C) == 3))
					Console.WriteLine("Ошибка: a/b");
				else
				{
					Console.WriteLine(N + " " + X1 + " " + X2 + " " + A + " " + C);
				}
			}
			/*
				1. Введено не число/пустая строка
				2. Введено А, которое меньше 4 и С которое больше 3 и меньше -3.
				3. Введено А, которое больше 4 и С которое меньше 3 и больше -3.
				4. С которое равно 3 или -3
			 */
			Console.ReadKey();
		}


		double GetF(double x, double a, double c)
		{
			return Math.Sqrt((a - 4)/(Math.Pow(c, 4) - 81)) * Math.Tan(x);
		}


		/*
		List GetArray(int n, double x1, double x2, double a, double b)
		{
			for(i = (x1:x2), n)
				getf(i, a, c)
		}


		void WiteToFile(string name, List values)
		{

		}
		*/
	}
}
