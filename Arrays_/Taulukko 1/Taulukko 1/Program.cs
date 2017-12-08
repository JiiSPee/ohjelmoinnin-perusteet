using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukko_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random q = new Random();
            double n = 0;
            for (int i = 0; i < 100; i++)
            {
                int r = q.Next(0, 51);
                array[i] = r;
                Console.WriteLine($"{i+1}. {array[i]}");
                n = n + r;
            }
            double m = n / 100;
            Console.WriteLine($"Summa on {n} ja keskiarvo on {m}");
            Console.ReadLine();
            }
        }
    
}
