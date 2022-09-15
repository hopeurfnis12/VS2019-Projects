using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETKR1
{
	class Airport
	{
		int n = 0;
		List<Reis> reis = new List<Reis>();

		static void Main()
		{
			Airport a = new Airport();
			Console.Write("1. Добавить рейс \n2. Задержать рейс \n3. Количесвто улетевших/задержанных рейсов \n\n");
			string metod = Convert.ToString(Console.ReadLine());
			string cmd = "";
			Console.WriteLine();

			switch (metod)
			{
				case "1":
					a.Addreis();
					break;

				case "2":
					a.Stopreis();
					break;
				
				case "3":
					a.Count();
					break;

				default:
					Console.WriteLine("Нет такого метода!");
					Main();
					break;
			}

			Console.ReadKey();
		}

		public void Addreis()
		{
			Console.Write("Введите номер рейса которого хотите добавить: ");
			string r = Console.ReadLine();
			bool t = true;

			var result = from s in reis
						 where s.Name == "Bill"
						 select s;

			foreach (var student in result)
				Console.WriteLine(student.Id + ", " + student.Name);

			if (t)
			{
				
			}
		}
		public void Stopreis()
		{

		}

		public void Count()
		{

		}
	}
}
