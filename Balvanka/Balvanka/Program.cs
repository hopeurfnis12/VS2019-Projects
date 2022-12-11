using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balvanka
{
	class Program
	{
		private static void Main()
		{
			string fileName1 = "note1.txt";
			string fileName2 = "note2.txt";
			string path = @"../../../"; // путь назад к самому проекту
			FileStream fs1 = new FileStream(path + fileName1, FileMode.OpenOrCreate); // создать или открыть сущ. файл
			FileStream fs2 = new FileStream(path + fileName2, FileMode.OpenOrCreate);
			using (StreamReader reader = new StreamReader(fs1))
			{
				using (StreamWriter writer = new StreamWriter(fs2))
				{
					string line = null;
					while ((line = reader.ReadLine()) != null) // читает из файла fs1, строку
					{
						if (line == "") // если строка пустая
						{
							writer.WriteLine();
							continue;
						}
						string[] subs = line.Split(' '); // разделяю строку на подстроки
						for (int i = 0; i < subs.Length; i++)
						{
							if (subs[i][0] == 'и' || subs[i][0] == 'И')
							{
								writer.Write(subs[i] + ' '); // вписываю в fs2 подстроку которая содержит 'и' && 'И'
							}
						}
						writer.WriteLine();
					}

				}
			}
			Console.WriteLine("Нажмите любую кнопку, чтобы удалить файл №2");
			Console.ReadKey(); // ждем когда пользователь нажмет кнопку
		}
	}
}