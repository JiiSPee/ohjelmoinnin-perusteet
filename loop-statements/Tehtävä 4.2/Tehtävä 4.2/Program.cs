using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statements_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa Kertotaulun luvuille 1-9");
            Console.WriteLine("Paina mitä tahansa aloittaaksesi");
            Console.ReadKey();
            int q = 0;
            do
            {
                int i = 0;
                int f = 1;
                q = q + 1;
                do
                {
                    i = i + 1;
                    f = i * q;

                    Console.Write(q);
                    Console.Write(" x ");
                    Console.Write(i);
                    Console.Write(" = ");
                    Console.WriteLine(f);
                }
                while (i < 9);
            }

            while (q < 9);
            Console.ReadKey();

        }
    }
}