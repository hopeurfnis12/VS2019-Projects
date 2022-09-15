using System;
using System.Linq;

namespace NETLaba8_1
{
	class Program
	{
		static void Main(string[] args)
		{
			var exam_marks = new[]
			{
				new {Id = 34, Student_id = 32, Subject_id = 10, Mark = 4, Exam_date = "23.01.2000" },
				new {Id = 43, Student_id = 6, Subject_id = 22, Mark = 4, Exam_date = "18.01.2000" },
				new {Id = 75, Student_id = 55, Subject_id =   10, Mark = 5, Exam_date = "05.01.2000" },
				new {Id = 145, Student_id = 12, Subject_id = 10, Mark = 5, Exam_date = "12.01.2000" },
				new {Id = 238, Student_id = 12, Subject_id =   22, Mark = 3, Exam_date = "17.06.1999" },
				new {Id = 639, Student_id = 55, Subject_id =  22, Mark = 3, Exam_date = "22.06.1999" }
			};

			var student = new[]
			{
				new {Id = 1, Surname = "Иванов", Name = "Иван", Stipend = 150, Kurs = 1, City = "Орел", Birthday = "12.03.1982", Univ_id = 1},
				new {Id = 3, Surname = "Петров", Name = "Петр", Stipend = 200, Kurs = 3, City = "Курстк", Birthday = "01.12.1980", Univ_id = 1 },
				new {Id = 6, Surname = "Сидоров", Name = "Вадим", Stipend = 150, Kurs = 4, City = "Москва", Birthday = "07.06.1979", Univ_id = 2 },
				new {Id = 10, Surname = "Иванов", Name = "Иван", Stipend = 0, Kurs = 4, City = "Якутск", Birthday = "12.12.2000", Univ_id = 3 },
				new {Id = 12, Surname = "Зайцев", Name = "Ольга", Stipend = 10000, Kurs = 2, City = "Липецк", Birthday = "01.05.1981", Univ_id = 1 },
				new {Id = 32, Surname = "Кузнецов", Name = "Борис", Stipend = 10000, Kurs = 2, City = "Брянск", Birthday = "21.01.1900", Univ_id = 1 },
				new {Id = 55, Surname = "Белкин", Name = "Игорь", Stipend = 250, Kurs = 5, City = "Воронеж", Birthday = "07.01.1980", Univ_id = 1 }
			};

			var subject = new[]
			{
				new {Id = 3, Name = "Русский язык", Hour = 112, Semestr = 1 },
				new {Id = 4, Name = "Английский", Hour = 80, Semestr = 2 },
				new {Id = 5, Name = "Литература", Hour = 90, Semestr = 1 },
				new {Id = 10, Name = "Математика", Hour = 120, Semestr = 1 },
				new {Id = 22, Name = "Информатика", Hour = 108, Semestr = 2 }
			};

			var lectures = new[]
			{
				new {Id = 24, Surname = "Колесников", Name = "Борис", City = "Воронеж", Subject_id = 10 },
				new {Id = 46, Surname = "Никонов", Name = "Иван", City = "Воронеж", Subject_id = 10 },
				new {Id = 74, Surname = "Лагунин", Name = "Павел", City = "Москва", Subject_id =  10 },
				new {Id = 108, Surname = "Струков", Name = "Николай", City = "Москва", Subject_id =  22 },
				new {Id = 276, Surname = "Николаев", Name = "Виктор", City = "Воронеж", Subject_id = 22 },
				new {Id = 328, Surname = "Сорокин", Name = "Павел", City = "Орел", Subject_id = 10 }
			};

			var univ = new[]
			{
				new {Id = 1, Name = "СВФУ", Rating = 4.3, City = "Якутск" },
				new {Id = 2, Name = "МГУ", Rating = 4.7, City = "Москва" },
				new {Id = 3, Name = "СПбГУ", Rating = 4.5, City = "Санкт-Петербург" },
				new {Id = 4, Name = "НГУ", Rating = 3.9, City = "Новосибирск" },
				new {Id = 5, Name = "ТПУ", Rating = 4.2, City = "Томск" }
			};


			Console.WriteLine("\n1.Вывести сведения о студентах, фамилии, либо имена которых начинаются на «И».");
			var query1 =
				from s in student
				where s.Name.StartsWith("И") || s.Surname.StartsWith("И")
				select s;

			foreach (var s in query1)
			{
				Console.WriteLine("Id = " + s.Id + ", Name: " + s.Surname + " " +s.Name +
					", Stipend = " + s.Stipend + ", Kurs = " + s.Kurs + ", City: " +
					s.City + ", Birthday: " + s.Birthday);
			}


			Console.WriteLine("\n2.Вывести данные об оценках студентов второго курса, отсортированные по фамилии.");
			var query2 =
				from em in exam_marks
				from s in student
				where s.Id == em.Student_id && s.Kurs == 2
				orderby s.Surname
				select "Name: " + s.Surname + " " + s.Name + ", Kurs = " +
				s.Kurs + ", Mark = " + em.Mark;

			foreach (var s in query2)
			{
				Console.WriteLine(s);
			}


			Console.WriteLine("\n3. Вывести фамилии преподавателей и названия предметов которые они ведут.");
			var query3 =
				from l in lectures
				from s in subject
				where l.Subject_id == s.Id
				orderby l.Surname
				select "Surname: " + l.Surname + ", Subject: " + s.Name;

			foreach (var s in query3)
			{
				Console.WriteLine(s);
			}


			Console.WriteLine("\n4. Вывести фамилии и имена студентов, обучающихся на курсе не ниже 3 и получающих наибольшую стипендию.");
			var query4 =
				from s in student
				where s.Kurs >= 3
				group s by s.Kurs into sk
				let maxstip = sk.Max(x => x.Stipend)
				select new
				{
					Kurs = sk.Key,
					Stipend = maxstip,
					Info = from a in sk select a	
				};
			foreach (var sk in query4)
			{
				foreach (var s in sk.Info)
				{
					if (sk.Stipend == s.Stipend) Console.Write("Name: " + s.Surname + " " + s.Name);
				}
				Console.WriteLine(", Kurs = " + sk.Kurs + ", Stipend = " + sk.Stipend);
			}


			Console.WriteLine("\n5.Рассчитать среднюю оценку студентов, полученную на экзамене по информатике.");
			var query5 =
				from em in exam_marks
				where em.Subject_id == 22
				group em by em.Subject_id into g
				let avgmark = g.Average(x => x.Mark)
				select new
				{
					Subject_id = g.Key,
					Average_mark = avgmark
				};
			foreach (var s in query5)
			{
				Console.WriteLine("Average mark: " + string.Format("{0:N1}", s.Average_mark));
			}

			Console.ReadKey();
		}
	}
}
