using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statements_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monta kertaa kolikkoa heitetään?");

            int q = Convert.ToInt32(Console.ReadLine());

            Random w = new Random();
            int a = 0;
            int u = 0;
            int k = 0;



            for (int i = 0; i < q; i++)
            {
                k = w.Next(0, 2);
                if (k == 1)
                {
                    u++;
                }
                else
                {
                    a++;
                }
            }
            Console.WriteLine("Rahaa heitettiin {0} kertaa", q);
            Console.WriteLine("Kruuna heitettiin {0} kertaa", u); Console.WriteLine("Klaava heitettiin {0} kertaa", a);

            Console.ReadKey();
          
        }

    }
}
