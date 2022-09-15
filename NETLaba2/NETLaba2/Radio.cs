using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLaba2
{
	class Radio
	{

		public string radiostatus = "off";
		public void On()
		{
			if (radiostatus == "off")
			{
				radiostatus = "on";
				Console.WriteLine("Radio: on");
			}
			else
			{
				Console.WriteLine("Radio already on!");
			}
		}

		public void Off()
		{
			if (radiostatus == "on")
			{
				radiostatus = "off";
				Console.WriteLine("Radio: off");
			}
			else
			{
				Console.WriteLine("Radio already off!");
			}
		}

		public void Status()
		{
			Console.WriteLine(radiostatus);
		}
	}
}
