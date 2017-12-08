using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukko_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 20];
			Console.WriteLine("[X, Y] = Arvo");
            Random q = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 20; a++)
                {
                    int e = q.Next(0, 99);
                    if (e < 10)
                    {
                        array[i, a] = e;
                        Console.WriteLine($"[{i}, {a}] = 0{e}");
                    }
                    else
                    {
                        array[i, a] = e;
                        Console.WriteLine($"[{i}, {a}] = {e}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

        
    

