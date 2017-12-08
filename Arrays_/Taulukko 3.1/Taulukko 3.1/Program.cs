using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukko_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("[X] = Arvo");
            Random x = new Random();
            for (int i = 0; i < 10; i++)
            {
                int q = x.Next(0, 20);
                array[i] = q;
                if (q < 10)
                {
                    Console.WriteLine($"[{i}] = 0{array[i]}");
                }
                else
                {
                    Console.WriteLine($"[{i}] = {array[i]}");
                }
            }
            Console.ReadLine();
        }
    }
}
