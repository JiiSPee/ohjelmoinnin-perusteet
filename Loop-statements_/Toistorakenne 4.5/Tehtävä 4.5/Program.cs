using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_statements_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vakioveikkaus rivi");
            Random q = new Random();
            int w = 0;
            for (int i = 1; i <= 13; i++)
            {
                w = q.Next(0, 10);
                if (w <= 4)
                {
                    Console.Write(i);
                    Console.WriteLine(". 1");

                }
                else if (w <= 6 && w > 4)
                {
                    Console.Write(i);
                    Console.WriteLine(". X");
                }
                else
                {
                    Console.Write(i);
                    Console.WriteLine(". 2");
                }
            }

            Console.ReadKey();
        }
    }
}
