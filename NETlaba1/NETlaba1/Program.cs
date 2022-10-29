using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETlaba1
{
	class Program
	{
		static void Main()
		{
			Task9();
			Console.ReadKey();
		}


		static void Task1()
		{
			Console.WriteLine("1. Составить программу решения линейного уравнения ax + b = 0, где a не равно 0.");
			Console.WriteLine("ax + b = 0");
			double a;
			double b;
			Console.Write("a = ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("b = ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("x = " + (-b/a));
		}


		static void Task2()
		{
			Console.WriteLine("\n2. Определить максимальное из двух различных вещественных чисел.");
			double a;
			double b;
			Console.Write("x = ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("y = ");
			b = Convert.ToDouble(Console.ReadLine());
			if (a >= b) Console.WriteLine("max = " + a);
			else Console.WriteLine("max = " + b);
		}

		
		static void Task3()
		{
			Console.WriteLine("\n3. Для натурального числа k напечатать фразу: «Мы нашли k грибов в лесу», согласовав окончание слова «гриб» с числом k.");
			int k, kf;
			Console.Write("Введите k: ");
			k = Convert.ToInt32(Console.ReadLine());
			if (k % 100 >= 10 && k % 100 <= 19)
			{
				Console.WriteLine("Мы нашли " + k + " грибов в лесу");
			}
			else
			{
				kf = k % 10;
				Console.Write("Мы нашли " + k + " гриб");
				if (kf != 1)
				{
					if (4 >= kf && kf >= 2) Console.Write("а ");
					else Console.Write("ов ");
				}
				else Console.Write(" ");
				Console.WriteLine("в лесу");
			}
		}
		/*
		1 - комментариЙ(так же и для цифр: 121, 31 - окончание определяется по последней цифре числа)
		2 - комментариЯ
		3 - комментариЯ
		4 - комментариЯ
		5 - комментариЕВ
		6 - комментариЕВ
		7 - комментариЕВ
		8 - комментариЕВ
		9 - комментариЕВ
		0 - комментариЕВ
		*/


		static void Task4()
		{
			Console.WriteLine("\n4. Даны площади круга и квадрата. Определить:\n 1) уместится ли квадрат в круге?\n 2) уместится ли круг в квадрате?");

			double ssq, sci, r, x, disq, dici;
			Console.Write("Введите площадь квадрата: ");
			ssq = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите площадь круга: ");
			sci = Convert.ToDouble(Console.ReadLine());
			
			x = Math.Sqrt(ssq);
			disq = Math.Sqrt(2 * x * x);
			r = Math.Sqrt(sci / Math.PI);
			dici = 2 * Math.Sqrt(sci / Math.PI);

			if (disq <= dici) Console.WriteLine("1) Да, квадрат поместиться в круге");
			else Console.WriteLine("1) Нет, квадрат НЕ поместиться в круге");
			
			if (x >= r) Console.WriteLine("2) Да, круг поместиться в квадрате");
			else Console.WriteLine("2) Нет, круг НЕ поместиться в квадрате");
		}


		static void Task5()
		{
			Console.WriteLine("\n5. Даны две скорости: одна в километрах в час, другая – в метрах в секунду. Какая из скоростей больше?");

			double kmh, ms;
			Console.Write("км/ч = ");
			kmh = Convert.ToDouble(Console.ReadLine());
			Console.Write("м/с = ");
			ms = Convert.ToDouble(Console.ReadLine());
			if (kmh == ms * 3.6) Console.WriteLine("Скорости одинаковы");
			if (kmh > ms * 3.6) Console.WriteLine("Скорость " + kmh + " км/ч больше");
			if (kmh < ms * 3.6) Console.WriteLine("Скорость " + ms + " м/с больше");
		}


		static void Task6()
		{
			Console.WriteLine("\n6. Известны год и номер месяца рождения человека, а также год и номер месяца сегодняшнего дня. Определить возраст человека (число полных лет). В случае совпадения номеров месяцев считать, что прошел полный год. ");

			int by, bm,
				ty = Convert.ToInt32(DateTime.Today.Year.ToString()), tm = Convert.ToInt32(DateTime.Today.Month.ToString()),
				age = 0;
			Console.WriteLine("Сегодняшняя дата: " + ty + " год и " + tm + " месяц");
			Console.Write("Год рождения: ");
			by = Convert.ToInt32(Console.ReadLine());
			if (by > ty) Console.WriteLine("Год не может быть больше сегодняшнего года");
			else
			{
				Console.Write("Месяц рождения: ");
				bm = Convert.ToInt32(Console.ReadLine());
				if (bm > 12 || bm < 1) Console.WriteLine("Нет такого месяца");
				else
				{
					if (bm > tm && by == ty) Console.WriteLine("Месяц не может быть больше сегодняшнего месяца");
					else
					{
						if (by == ty)
						{
							age += tm - bm;
							if (tm > bm) Console.WriteLine("Полных месяцов: " + age);
							else Console.WriteLine("Родился в этот месяц");
						}
						else
						{
							age += ty - by;
							if (tm - bm < 0) age--;
							Console.WriteLine("Полных лет: " + age);
						}
					}
				}
			}
		}


		static void Task7()
		{
			Console.WriteLine("\n7. Дана фамилия человека. Вывести приветствие. В случае, когда фамилия оканчивается на «ов» - «Здравствуйте господин Иванов!», на «ова» - «Здравствуйте госпожа Иванова!» В остальных случаях вывести: «Здравствуйте господин(госпожа) …».");

			string sn, subsn = "";
			int l;
			Console.Write("Введите вашу фамилию: ");
			sn = Console.ReadLine();
			l = sn.Length - 1;
			if (sn[l] == 'а')
			{
				for (int i = l; i >= 0 && i > l - 3; i--)
				{
					subsn += sn[i];
				}
				if (subsn == "аво") Console.WriteLine("Здравствуйте госпожа Иванова!");
				else Console.WriteLine("Здравствуйте госпожа " + sn);
			}
			else
			{
				for (int i = l; i >= 0 && i > l - 2; i--)
				{
					subsn += sn[i];
				}
				if (subsn == "во") Console.WriteLine("Здравствуйте господин Иванов!");
				else Console.WriteLine("Здравствуйте господин " + sn);
			}
		}


		static void Task8()
		{
			Console.WriteLine("\n 8. Даны дни недели. Вывести в зависимости от выбора, какие занятия на этот день запланированы. ");
			Console.Write("Введите номер дня недели: ");
			switch (Console.ReadLine())
			{
				case "1":
					Console.WriteLine("Понедельник: убираться дома");
					break;
				case "2":
					Console.WriteLine("Вторник: делать СРС");
					break;
				case "3":
					Console.WriteLine("Среда: отдохнуть");
					break;
				case "4":
					Console.WriteLine("Четверг: сходить в библиотеку");
					break;
				case "5":
					Console.WriteLine("Пятница: делать СРС");
					break;
				case "6":
					Console.WriteLine("Суббота: делать СРС");
					break;
				case "7":
					Console.WriteLine("Воскресенье: Отдохнуть и составить план на следующую неделю");
					break;
				default:
					Console.WriteLine("Нет такого дня в неделе");
					break;
			}
		}
		static void Task9()
		{
			double x = 5, a = 5.999, b = 5.001;
			Console.WriteLine(((Math.Log(10, Math.Sqrt(a - 5))) / (Math.Pow(b, 3) - 125)) * (Math.Pow(x, 5) + 20 * x + 67));	
			Console.WriteLine(Math.Log(10, Math.Sqrt(a - 5)));
			Console.WriteLine(Math.Pow(b, 3) - 125);
			Console.WriteLine(Math.Pow(x, 5) + 20 * x + 67);
		}
	}
}
