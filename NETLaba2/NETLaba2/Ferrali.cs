using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLaba2
{
	class Ferrali : Car
	{
		private const int MaxSpeed = 400;
		public void SpeedUp()
		{
            if (carstatus == "on")
            {
                if (speed < MaxSpeed)
                {
                    speed += 100;
                    Console.WriteLine("Speed = " + speed);
                }
                else Console.WriteLine("Max speed = " + speed);
            }
            else Console.WriteLine("Car not started!");
        }


        public void SpeedDown()
        {
            if (carstatus == "on")
            {
                if (speed != 0)
                {
                    speed -= 100;
                }
                Console.WriteLine("Speed = " + speed);
            }
            else Console.WriteLine("Car not started!");
        }
    }
}
