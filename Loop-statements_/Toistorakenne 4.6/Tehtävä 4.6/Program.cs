using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statements_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi ja tulostaa 1000 nopanheittoa");
            Random r = new Random();
            int w = 0;
            int k = 0;
            for (int i = 1; i <= 1000; i++)
            {
                w = r.Next(1, 7);

                Console.Write(i);
                Console.Write(". ");
                Console.WriteLine(w);
                if (w == 6)
                {
                    k++;
                }
            }
            Console.WriteLine("Kuutonen heitettiin {0} kertaa", k);
            Console.ReadKey();
        }
    }
}
