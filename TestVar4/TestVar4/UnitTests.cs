using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;

namespace TestVar4
{
	[TestClass]
	public class UnitTests
	{
		Function f = new Function();


		/// CORRECT ///

		[TestMethod]
		public void CorrectTestMethod1()
		{
			Assert.AreEqual(-201994783.4, f.GetF(5, 5.999, 5.001), 0.1);
		}

		[TestMethod]
		public void CorrectTestMethod2()
		{
			Assert.AreEqual(-4846.891463, f.GetF(0.001, 6.0001, -7.999), 0.000001);
		}


		[TestMethod]
		public void CorrectTestMethod3()
		{
			Assert.AreEqual(-2.92805037, f.GetF(4, 23, -8.001), 0.00000001);
		}

		[TestMethod]
		public void CorrectTestMethod4()
		{
			Assert.AreEqual(-0.536, f.GetF(0, 105, 0));
		}
		/// ///

		/// WRONG ///

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod1()
		{
			f.GetF(3, 5, 4);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod2()
		{
			f.GetF(5, 6, 4);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void WrongTestMethod3()
		{
			f.GetF(3, 6.01, 5);
		}
	}
}