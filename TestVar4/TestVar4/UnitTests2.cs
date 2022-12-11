using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVar4
{
	[TestClass]
	public class UnitTests2
	{
		Function f = new Function();
		ListAccur comp = new ListAccur();

		[TestMethod]
		public void CorrectTestMethod1()
		{
			List<double> cor = new List<double>() { 1.5107, 2.3863 };
			CollectionAssert.AreEqual(cor, f.GetArray(2, 1, 2, 7, 8), comp);
		}

		[TestMethod]
		public void CorrectTestMethod2()
		{
			List<double> cor = new List<double>() { 0.0252, 0.03118, 0.0382, 0.0465, };
			CollectionAssert.AreEqual(cor, f.GetArray(4, 23, 26, 1435, 545), comp);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod1()
		{
			f.GetArray(-1, 2, 2, 7, 8);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod2()
		{
			f.GetArray(1, 1.0002, 1.0001, 7, 8);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod3()
		{
			f.GetArray(11, 1.0001, 1.001, 6, 8);
		}
	}
}
