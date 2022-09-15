using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLaba5_2
{
    class Planet
    {
        int rad;
        string name;
        private Planet[] stArray;

        public Planet(int ch)
        { 
            stArray = new Planet[ch];
        }

        public Planet(int _rad, string _name)
        {
            rad = _rad; name = _name;
        }
        public Planet this[int pos]
        {
            get
            {
                return (stArray[pos]);
            }
            set
            {
                stArray[pos] = value;
            }
        }
        private static void Main()
        {
            Planet st = new Planet(9);
            st[0] = new Planet(696340, "Sun");
            st[1] = new Planet(2439, "Mercury");
            st[2] = new Planet(6051, "Venus");
            st[3] = new Planet(6371, "Earth");
            st[4] = new Planet(3389, "Mars");
            st[5] = new Planet(69911, "Jupiter");
            st[6] = new Planet(58232, "Saturn");
            st[7] = new Planet(25362, "Uranus");
            st[8] = new Planet(24622, "Neptune");

            Console.WriteLine("Earth radius = " + st[3].rad + " km");
            Console.WriteLine();

            Console.WriteLine("Planets with a larger radius than the earth:");
            for (int i = 0; i < 9; i++)
            {
                if(st[3].rad < st[i].rad && i != 3)
                    Console.WriteLine(" " + st[i].name + " = " + st[i].rad + " km");
            }
            Console.WriteLine();

            Console.WriteLine("Planets with a smaller radius than the earth:");
            for (int i = 0; i < 9; i++)
            {
                if (st[3].rad > st[i].rad && i != 3)
                    Console.WriteLine(" " + st[i].name + " = " + st[i].rad + " km");
            }
            Console.ReadKey();
        }
    }
}
