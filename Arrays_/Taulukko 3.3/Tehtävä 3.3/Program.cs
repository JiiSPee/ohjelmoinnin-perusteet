using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrt_1 = new int[10];
            int[] arrt_2 = new int[10];
            int[] arrt_3 = new int[10];
            Random x = new Random();
            for (int i = 0; i < 10; i++)
            {
                int q = x.Next(0, 50);
                arrt_1[i] = q;
            }
            for (int i = 0; i < 10; i++)
            {
                int q = x.Next(0, 20);
                arrt_2[i] = q;
            }
            for (int i = 0; i < 10; i++)
            {
                if (arrt_1[i] > arrt_2[i])
                {
                    arrt_3[i] = arrt_1[i];
                }
                else
                {
                    arrt_3[i] = arrt_2[i];
                }
            }
            Console.Write("Arrt_1: ");
            foreach (int i in arrt_1) Console.Write($"{i} ");
            Console.WriteLine();
            Console.Write("Arrt_2: ");
            foreach (int i in arrt_2) Console.Write(i + " ");
            Console.WriteLine();
            Console.Write("Arrt_3: ");
            foreach (int i in arrt_3) Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
