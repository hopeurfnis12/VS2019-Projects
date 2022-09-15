using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLaba3
{
	class Program
	{
        public static void Main()
        {
            Random rnd = new Random();
            int n = rnd.Next(0, 10);
            string[][] str = new string[n][];
            char[] alph = new char[62];
            int j = 0;
            for (char i = 'A'; i < 'Z'; i++)
            {
                alph[j] = i;
                j++;
            }
            for (char i = 'a'; i < 'z'; i++)
            {
                alph[j] = i;
                j++;
            }
            for (char i = '0'; i < '9'; i++)
            {
                alph[j] = i;
                j++;
            }

            using (StreamWriter fOut = new StreamWriter("C:/Users/ayhal/Desktop/laba3.txt"))
            {
                for (int i = 0; i < n; i++)
                {
                    //sum = 0;
                    str[i] = new string[rnd.Next(0, 50)];
                    for (int c = 0; c < str[i].Length; c++)
                    {
                        str[i][c] = Convert.ToString(alph[rnd.Next(0, 62)]);
                        fOut.Write(str[i][c]);
                    }
                    //fOut.Write(" S = " + sum);
                    fOut.WriteLine();
                }
            }


            try
            {
                StreamReader fIn = new StreamReader("C:/Users/ayhal/Desktop/laba3.txt");
                while (fIn.Peek() != -1)
                {
                    int sum = 0;
                    string s = fIn.ReadLine(); // прочитать строку
                    Console.Write(s);
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == 'S') sum++;
                    }
                    Console.WriteLine(" - \'S\' = " + sum);
                   
                }
                fIn.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
		}
	}
}
