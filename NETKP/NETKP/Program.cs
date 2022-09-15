using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETKP
{
	class Program
	{
		private static void Main()
		{
			Console.Write(
				"// Работа со строками\n" +
				"1. Введите в консоли предложение, состоящее только из слов и предлогов.\n" +
				"Замените в этом предложении каждое второе вхождение слова/предлога, записав его в обратном порядке.\n" +
				"Пример:\n" +
				"Корабли лавировали лавировали но не вылавировали\n" +
				"Корабли илаворивал лавировали он не илаворивалыв\n\n" +
				"// Массивы, класс Random\n" +
				"2. Создайте квадратную матрицу целых чисел. Выведите ее на экран.\n" +
				"Найдите максимальные числа в каждой строке матрицы.\n" +
				"Выведите на экран полученный результат, например: 20, 33, 75.\n\n" +
				"3. Создайте не выровненную матрицу, состоящую из множества\n" +
				"английских букв от ‘a’ до ‘k’, полученных в произвольном порядке.\n" +
				"Выведите ее в экран.Создайте на основе исходной новую матрицу,\n" +
				"заменив в первой символы ‘a’ на ‘е’. Транспонируйте получившуюся матрицу.\n" +
				"Выведите результат на экран.\n\n");
			for (; ; )
			{
				Console.WriteLine("Чтобы выйти, напишите 0");
				Console.Write("Выберите номер задания: ");
				string t = Console.ReadLine();
				if (t == "0") break;
				Console.WriteLine();
				switch (t)
				{
					case "1":
						Console.WriteLine("Task1");
						Task1();
						Console.Write("\nНапишите любой символ чтобы продолжить: ");
						Console.ReadKey();
						Console.WriteLine("\n");
						break;

					case "2":
						Console.WriteLine("Task2");
						Task2();
						Console.Write("\nНапишите любой символ чтобы продолжить: ");
						Console.ReadKey();
						Console.WriteLine("\n");
						break;

					case "3":
						Console.WriteLine("Task3");
						Task3();
						Console.Write("\nНапишите любой символ чтобы продолжить: ");
						Console.ReadKey();
						Console.WriteLine("\n");
						break;

					default:
						Console.WriteLine("Нет такого задания\n");
						break;
				}
			}
		}


		//////////////////////////// 1 ////////////////////////////
		/*
		 //Работа со строками
		 1. Введите в консоли предложение, состоящее только из слов и предлогов.
			Замените в этом предложении каждое второе вхождение слова/предлога, записав его в обратном порядке.
			Пример:
			Корабли лавировали лавировали но не вылавировали
			Корабли илаворивал лавировали он не илаворивалыв
		*/
		static void Task1()
		{
			string Reverse(string rs)
			{
				string re = "";
				for (int i = rs.Length - 1; i >= 0; i--)
				{
					re += rs[i];
				}
				return re;
			}


			//string s = "Корабли,   лавировали. лавировали   но не  вылавировали";
			string s = Console.ReadLine();
			string[] ss = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			string ans = "";
			for(int i = 0; i < ss.Length; i++)
			{
				//Console.WriteLine(ss[i]);
				if(i%2 != 0)
				{
					ans += Reverse(ss[i]) + " ";
				} else
				{
					ans += ss[i] + " ";
				}
			}
			Console.WriteLine(ans);
		}


		//////////////////////////// 2 ////////////////////////////
		/*
		 //Массивы, класс Random
		 2. Создайте квадратную матрицу целых чисел. Выведите ее на экран.
			Найдите максимальные числа в каждой строке матрицы.
			Выведите на экран полученный результат, например: 20, 33, 75.
		*/
		static void Task2()
		{
			Console.Write("Введите размер квадратной матрицы: ");
			int n = Convert.ToInt16(Console.ReadLine());
			int[,] M = new int[n, n];
			int[] max = new int[n];
			Random random = new Random();
			int r;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					r = random.Next(0, 100);
					M[i, j] = r;
					if (j == 0)
					{
						max[i] = M[i, j];
					} else { if(max[i] < r) max[i] = r; }
				}
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(M[i, j] + "\t");
				}
				Console.WriteLine();
			}

			Console.Write("\nМаксимальные числа в каждой строке: ");
			foreach (var i in max)
			{
				if (i != max[max.Length - 1]) Console.Write(i.ToString() + ", ");
				else Console.WriteLine(i.ToString() + ".");
			}
		}


		//////////////////////////// 3 ////////////////////////////
		/*
		 3. Создайте не выровненную матрицу, состоящую из множества
			английских букв от ‘a’ до ‘k’, полученных в произвольном порядке.
			Выведите ее в экран. Создайте на основе исходной новую матрицу,
			заменив в первой символы ‘a’ на ‘е’. Транспонируйте получившуюся матрицу.
			Выведите результат на экран.
		*/
		static void Task3()
		{
			Random random = new Random();
			int n = random.Next(1, 20);
			int m, max = 0;
			char[][] A = new char[n][];
			char r;
			for (int i = 0; i < n; i++)
			{
				m = random.Next(1, 20);
				A[i] = new char[m];
				if (m > max) max = m;
				for (int j = 0; j < m; j++)
				{
					r = (char)random.Next('a', 'k');
					A[i][j] = r;
				}
			}

			Console.WriteLine("\nСгенерированная матрица:\n");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < A[i].Length; j++)
				{
					Console.Write(A[i][j] + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("\nНовая транспонированная матрица:\n");
			char[,] B = new char[max, n];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < A[i].Length; j++)
				{
					if (A[i][j] == 'a') B[j, i] = 'e';
					else B[j, i] = A[i][j];
				}
			}

			for (int i = 0; i < max; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(B[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
