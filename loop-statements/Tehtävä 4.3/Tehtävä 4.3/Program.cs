using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statements_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua välillä 1-50");
            Console.WriteLine("Paina mitätahansa aloittaaksesi");
            int i = 0;
            Random r = new Random();
            do
            {
                i = i + 1;
                Console.Write(r.Next(50));
                Console.Write(", ");
                Console.Write(r.Next(50));
                Console.Write(", ");
                Console.Write(r.Next(50));
                Console.Write(", ");
                Console.Write(r.Next(50));
                Console.Write(", ");
                Console.Write(r.Next(50));
                Console.WriteLine();
            }
            while (i < 4);
            Console.ReadKey();
        }
    }
}
