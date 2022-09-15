using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLaba2
{

	

	class Car
	{
		public double speed;
		public string carstatus = "off";

		static void Main()
		{
			Toyota toyota = new Toyota();
			Ferrali ferrali = new Ferrali();
			Bugatti bugatti = new Bugatti();
			Radio radio = new Radio();

			Console.Write("Choose car: \n 1. Toyota \n 2. Ferrali \n 3. Bugatti \n\nYour car: ");
			string carname = Convert.ToString(Console.ReadLine());
			string cmd = "";
			Console.WriteLine();

			switch (carname.ToLower())
			{
				case "1": case "toyota":
					toyota.Status("Toyota");
					Console.Write("\nRadio: ");
					radio.Status();
					Console.WriteLine("\nAvailable commands: \n Start \n SpeedUp / SpeedDown \n Stop \n Status \n RadioOn / RadioOff \n Break \n\n");
					while (true)
					{
						Console.Write("Command: ");
						cmd = Convert.ToString(Console.ReadLine()).ToLower();
						if (cmd == "break")
						{
							Console.WriteLine("Application breaked");
							break;
						}
						switch (cmd)
						{
							case "start":
								toyota.Start();
								break;

							case "speedup": case "speed up":
								toyota.SpeedUp();
								break;

							case "speeddown" : case "speed down":
								toyota.SpeedDown();
								break;

							case "stop":
								toyota.Stop();
								break;

							case "status":
								toyota.Status("Toyota");
								Console.Write("\nRadio: ");
								radio.Status();
								break;

							case "radioon": case "radio on":
								radio.On();
								break;

							case "radiooff": case "radio off":
								radio.Off();
								break;

							default:
								Console.WriteLine("Write correct command!");
								break;
						}
						Console.WriteLine();
					}
					break;


				case "2": case "ferrali":
					ferrali.Status("Ferrali");
					Console.Write("\nRadio: ");
					radio.Status();
					Console.WriteLine("\nAvailable commands: \n Start \n SpeedUp / SpeedDown \n Stop \n Status \n RadioOn / RadioOff \n Break \n\n");
					while (true)
					{
						Console.Write("Command: ");
						cmd = Convert.ToString(Console.ReadLine()).ToLower();
						if (cmd == "break")
						{
							Console.WriteLine("Application breaked");
							break;
						}
						switch (cmd)
						{
							case "start":
								ferrali.Start();
								break;

							case "speedup": case "speed up":
								ferrali.SpeedUp();
								break;

							case "speeddown": case "speed down":
								ferrali.SpeedDown();
								break;

							case "stop":
								ferrali.Stop();
								break;

							case "status":
								ferrali.Status("Ferrali");
								Console.Write("\nRadio: ");
								radio.Status();
								break;

							case "radioon": case "radio on":
								radio.On();
								break;

							case "radiooff": case "radio off":
								radio.Off();
								break;

							default:
								Console.WriteLine("Write correct command!");
								break;
						}
						Console.WriteLine();
					}
					break;


				case "3": case "bugatti":
					bugatti.Status("Bugatti");
					Console.Write("\nRadio: ");
					radio.Status();
					Console.WriteLine("\nAvailable commands: \n Start \n SpeedUp / SpeedDown \n Stop \n Status \n RadioOn / RadioOff \n Break \n\n");
					while (true)
					{
						Console.Write("Command: ");
						cmd = Convert.ToString(Console.ReadLine()).ToLower();
						if (cmd == "break")
						{
							Console.WriteLine("Application breaked");
							break;
						}
						switch (cmd)
						{
							case "start":
								bugatti.Start();
								break;

							case "speedup": case "speed up":
								bugatti.SpeedUp();
								break;

							case "speeddown": case "speed down":
								bugatti.SpeedDown();
								break;

							case "stop":
								bugatti.Stop();
								break;

							case "status":
								bugatti.Status("Bugatti");
								Console.Write("\nRadio: ");
								radio.Status();
								break;

							case "radioon": case "radio on":
								radio.On();
								break;

							case "radiooff": case "radio off":
								radio.Off();
								break;

							default:
								Console.WriteLine("Write correct command!");
								break;
						}
						Console.WriteLine();
					}
					break;


				default:
					Console.WriteLine("There is no such machine!");
					Main();
					break;
			}
			Console.ReadKey();
		}

		public void Start()
		{
			if (carstatus == "off")
			{
				carstatus = "on";
				Console.WriteLine("Car status: on");
			}
			else Console.WriteLine("Car already on!");
		}


		public void Stop()
		{
			if (carstatus == "on")
			{
				if (speed == 0)
				{
					carstatus = "off";
					Console.WriteLine("Car status: off");
				}
				else Console.WriteLine("Car cant stop!");
			}
			else Console.WriteLine("Car already stop!");
		}


		public void Status(string name)
		{
			Console.Write("Your car: " + name +"\nCar status: " + carstatus + "\nSpeed: " + speed);
		}

	}
}
