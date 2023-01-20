namespace TestVar4
{
	[TestClass]
	public class UnitTests4
	{
		ListAccur comp = new ListAccur();

		[TestMethod]
		public void CorrectTestMethod1()
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "TestirovanieVar4.exe";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.Start();

			p.StandardInput.WriteLine("2"); // nфффф
			p.StandardInput.WriteLine("1"); // x1
			p.StandardInput.WriteLine("2"); // x2
			p.StandardInput.WriteLine("7"); // a
			p.StandardInput.WriteLine("8"); // b

			string name = "test.txt";
			p.StandardInput.WriteLine(name);

			p.WaitForExit();
			p.Close();

			List<double> cor = new List<double>() { 1.5107, 2.3863 };
			List<double> cur = new List<double>();
			string path = @"" + name;
			FileStream fs = new FileStream(path, FileMode.Open);
			using (StreamReader sr = new StreamReader(fs))
			{
				string line;
				while ((line = sr.ReadLine()) != null) cur.Add(Convert.ToDouble(line));
			}
			CollectionAssert.AreEqual(cor, cur, comp);
			File.Delete(path);
			Assert.IsFalse(File.Exists(path));
		}

		[TestMethod]
		public void CorrectTestMethod2()
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "TestirovanieVar4.exe";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;

			p.Start();
			p.StandardInput.WriteLine("2"); // n
			p.StandardInput.WriteLine("1"); // x1
			p.StandardInput.WriteLine("2"); // x2
			p.StandardInput.WriteLine("7"); // a
			p.StandardInput.WriteLine("8"); // b

			string name = "C:\\Users\\ayhal\\Documents\\test.txt";
			p.StandardInput.WriteLine(name);

			p.WaitForExit();
			p.Close();

			List<double> cor = new List<double>() { 1.5107, 2.3863 };
			List<double> cur = new List<double>();
			string path = @"" + name;
			FileStream fs = new FileStream(path, FileMode.Open);
			using (StreamReader sr = new StreamReader(fs))
			{
				string line;
				while ((line = sr.ReadLine()) != null) cur.Add(Convert.ToDouble(line));
			}
			CollectionAssert.AreEqual(cor, cur, comp);
			File.Delete(path);
			Assert.IsFalse(File.Exists(path));
		}

		[TestMethod]
		public void WrongTestMethod1()
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "TestirovanieVar4.exe";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardError = true;
			p.Start();
			p.StandardInput.WriteLine("-1"); // n
			p.StandardInput.WriteLine("1"); // x1
			p.StandardInput.WriteLine("2"); // x2
			p.StandardInput.WriteLine("7"); // a
			p.StandardInput.WriteLine("8"); // b

			string name = "test.txt";
			p.StandardInput.WriteLine(name);
			p.WaitForExit();

			string s = p.StandardError.ReadToEnd();

			Assert.AreEqual(true, s.Contains("ERROR: n < 1"));

			p.Close();
		}

		[TestMethod]
		public void WrongTestMethod11()
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "TestirovanieVar4.exe";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardError = true;
			p.Start();
			p.StandardInput.WriteLine("2"); // n
			p.StandardInput.WriteLine("1"); // x1
			p.StandardInput.WriteLine("2"); // x2
			p.StandardInput.WriteLine("3"); // a
			p.StandardInput.WriteLine("8"); // b

			string name = "test.txt";
			p.StandardInput.WriteLine(name);

			p.WaitForExit();

			string s = p.StandardError.ReadToEnd();

			Assert.AreEqual(true, s.Contains("ERROR: a <= 5"));

			p.Close();
		}

		[TestMethod]
		public void WrongTestMethod12()
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "TestirovanieVar4.exe";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardError = true;
			p.Start();
			p.StandardInput.WriteLine("2"); // n
			p.StandardInput.WriteLine("1"); // x1
			p.StandardInput.WriteLine("2"); // x2
			p.StandardInput.WriteLine("6"); // a
			p.StandardInput.WriteLine("8"); // b

			string name = "test.txt";
			p.StandardInput.WriteLine(name);

			p.WaitForExit();

			string s = p.StandardError.ReadToEnd();

			Assert.AreEqual(true, s.Contains("ERROR: a == 6"));

			p.Close();
		}

		[TestMethod]
		public void WrongTestMethod13()
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "TestirovanieVar4.exe";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardError = true;
			p.Start();
			p.StandardInput.WriteLine("2"); // n
			p.StandardInput.WriteLine("1"); // x1
			p.StandardInput.WriteLine("2"); // x2
			p.StandardInput.WriteLine("7"); // a
			p.StandardInput.WriteLine("5"); // b

			string name = "test.txt";
			p.StandardInput.WriteLine(name);

			p.WaitForExit();

			string s = p.StandardError.ReadToEnd();

			Assert.AreEqual(true, s.Contains("ERROR: b == 5"));

			p.Close();
		}

		[TestMethod]
		public void WrongTestMethod2()
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "TestirovanieVar4.exe";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardError = true;
			p.Start();
			p.StandardInput.WriteLine("1"); // n
			p.StandardInput.WriteLine("5"); // x1
			p.StandardInput.WriteLine("2"); // x2
			p.StandardInput.WriteLine("7"); // a
			p.StandardInput.WriteLine("8"); // b

			string name = "test.txt";
			p.StandardInput.WriteLine(name);

			p.WaitForExit();

			string s = p.StandardError.ReadToEnd();

			Assert.AreEqual(true, s.Contains("ERROR: x2 < x1"));

			p.Close();
		}

		[TestMethod]
		public void WrongTestMethod3()
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "TestirovanieVar4.exe";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardError = true;
			p.Start();
			p.StandardInput.WriteLine("10"); // n
			p.StandardInput.WriteLine("1"); // x1
			p.StandardInput.WriteLine("10"); // x2
			p.StandardInput.WriteLine("7"); // a
			p.StandardInput.WriteLine("8"); // b

			string name = "\\or\\o.txt";
			p.StandardInput.WriteLine(name);

			p.WaitForExit();

			string s = p.StandardError.ReadToEnd();

			Assert.AreEqual(true, s.Contains("File/path not exists"));

			p.Close();
		}

		[TestMethod]
		public void WrongTestMethod4()
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "TestirovanieVar4.exe";
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardError = true;
			p.Start();
			p.StandardInput.WriteLine("1"); // n
			p.StandardInput.WriteLine("1"); // x1
			p.StandardInput.WriteLine("10"); // x2
			p.StandardInput.WriteLine("7"); // a
			p.StandardInput.WriteLine("8"); // b

			string name = "PRN.txt";
			p.StandardInput.WriteLine(name);

			p.WaitForExit();

			string s = p.StandardError.ReadToEnd();

			Assert.AreEqual(true, s.Contains("File/path not exists"));

			p.Close();
		}
	}
}