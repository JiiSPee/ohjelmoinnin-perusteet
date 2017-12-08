using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen lukujen summan");
            Console.WriteLine("Syötä numero N");
            String userinput1;
            userinput1 = Console.ReadLine();
            int a;
            int.TryParse(userinput1, out a);
            int i = 0;
            int f = 0;
            int k = 1;
            int p = 0;
            int h = -1;

            if (a == 0)
                Console.WriteLine("Vastaus in 0");
            else if (a > 0)
            {
                do
                {
                    f = i + f;
                    i = i + 2;


                }
                while (i <= a);

                do
                {
                    p = k + p;
                    k = k + 2;

                }
                while (k <= a);

                Console.WriteLine("Tehtävän 3 vastaus");
                Console.WriteLine("Parillisten summa");
                Console.WriteLine(f);

                Console.WriteLine("Parittomien summa");
                Console.WriteLine(p);
            }

            else
            {
                do
                {
                    f = i + f;
                    i = i - 2;


                }
                while (i >= a);

                do
                {
                    p = h + p;
                    h = h - 2;

                }
                while (h >= a);

                Console.WriteLine("Tehtävän 3 vastaus");
                Console.WriteLine("Parillisten summa");
                Console.WriteLine(f);

                Console.WriteLine("Parittomien summa");
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
