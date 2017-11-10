using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statements_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa lukujen 1-10 neliöjuuret");
            Console.WriteLine("Aloita painamalla mitätahansa näppäintä");
            Console.ReadKey();

            int i = 0;
            int f = 1;

            do
            {
                i = i + 1;
                f = i;
                Console.Write(i);
                Console.Write(" = ");
                Console.WriteLine(Math.Sqrt(f));
            }

            while (i < 10);

            Console.ReadKey();

        }
    }
}
