using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
	public class Student
	{
		public virtual void Stipend(float proc)
		{...}
	}

	public class Student2 : Student
	{
		public override void Stipend(float proc)
		{...}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Student stud = new Student();
			stud.Stipend(8.5f);
			Student2 stud2 = new Student2();
			stud2.Stipend(2.4f);
			Console.ReadKey();
		}
	}
}
