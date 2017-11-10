using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itsearviointi_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita lause. Ohjelma toistaa sen viisi kertaa");
            string q = Console.ReadLine();
            int w = 0;
            do
            {
                Console.WriteLine(w + ". " + q);
                w++;
            }
            while (w <= 4);

            Console.ReadKey();

        }
    }
}
