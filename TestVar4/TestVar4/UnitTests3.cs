using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVar4
{
	[TestClass]
	public class UnitTests3
	{
		Function f = new Function();
		ListAccur comp = new ListAccur();

		[TestMethod]
		public void CorrectTestMethod1()
		{
			string name = "nss.txt";
			string path = @"" + name;

			List<double> cor = new List<double>() { 1.5107, 2.3863 };
			List<double> cur = new List<double>();

			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
			Assert.IsTrue(File.Exists(path));

			using (StreamReader sr = new StreamReader(path))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					cur.Add(Convert.ToDouble(line));
				}
			}
			CollectionAssert.AreEqual(cor, cur, comp);
			File.Delete(path);
			Assert.IsFalse(File.Exists(path));
		}

		[TestMethod]
		public void CorrectTestMethod2()
		{
			string name = "C:\\Users\\ayhal\\Documents\\oro.txt";
			string path = @"" + name;

			List<double> cor = new List<double>() { 1.5107, 2.3863 };
			List<double> cur = new List<double>();

			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
			Assert.IsTrue(File.Exists(path));

			using (StreamReader sr = new StreamReader(path))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					cur.Add(Convert.ToDouble(line));
				}
			}
			CollectionAssert.AreEqual(cor, cur, comp);
			File.Delete(path);
			Assert.IsFalse(File.Exists(path));
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod1()
		{
			string name = "D:\\oro.txt";
			string path = @"" + name;
			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod2()
		{
			string name = "or?3wo.txt";
			string path = @"" + name;
			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod3()
		{
			string name = "ow*o.txt";
			string path = @"" + name;
			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod4()
		{
			string name = "or/o.txt";
			string path = @"" + name;
			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod5()
		{
			string name = "\\or\\o.txt";
			string path = @"" + name;
			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod6()
		{
			string name = "o<r>o.txt";
			string path = @"" + name;
			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod7()
		{
			string name = "oroasd|ds.txt";
			string path = @"" + name;
			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod8()
		{
			string name = "odsf:o.txt";
			string path = @"" + name;
			f.WriteToFile(name, f.GetArray(2, 1, 2, 7, 8));
		}
	}
}