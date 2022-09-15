using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLaba9
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\Users\ayhal\Desktop\СРС\3.2\Программирование в .NET\";
			string file = "TestExcel.xlsx";
			//File.Delete(path + file);

			try
			{
				using (Excel.ExcelTools tools = new Excel.ExcelTools())
				{
					if(tools.Open(filePath: Path.Combine(path, file)))
					{	
						tools.Set(column: "C", row: 1, data: "Почта");

						tools.Set(column: "B", row: 3, data: "Номер");
						tools.Set(column: "B", row: 4, data: 1290);
						tools.Set(column: "B", row: 5, data: 764);
						tools.Set(column: "B", row: 6, data: 6526);

						tools.Set(column: "C", row: 3, data: "Наименование");
						tools.Set(column: "C", row: 4, data: "посылка");
						tools.Set(column: "C", row: 5, data: "бандероль");
						tools.Set(column: "C", row: 6, data: "письмо");

						tools.Set(column: "D", row: 3, data: "Дата отправки");
						tools.Set(column: "D", row: 4, data: DateTime.Parse("12.10.2015"));
						tools.Set(column: "D", row: 5, data: DateTime.Parse("04.11.2012"));
						tools.Set(column: "D", row: 6, data: DateTime.Parse("05.10.2012"));

						tools.Save();
					}
					tools.Clear();
				}
			}
			catch(Exception ex) { Console.WriteLine(ex.Message); }
			Process.Start(path + file);
		}
	}
}
