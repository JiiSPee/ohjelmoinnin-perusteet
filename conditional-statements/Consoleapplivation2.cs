using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laittaa numerot nousevaan järjestykseen");
            Console.WriteLine("syötä ensimmäinen luku ");
            String userinput1;
            userinput1 = Console.ReadLine();

            int a;
            int.TryParse(userinput1, out a);

            Console.WriteLine("syötä toinen luku ");
            String userinput2;
            userinput2 = Console.ReadLine();

            int b;
            int.TryParse(userinput2, out b);

            Console.WriteLine("syötä kolmas luku ");
            String userinput3;
            userinput3 = Console.ReadLine();

            int c;
            int.TryParse(userinput3, out c);

            if(a < b && b < c)
            {
                Console.WriteLine($"{a}, {b}, {c}");
            }
            else if (a > b && b > c)
            {
                Console.WriteLine($"{c}, {b}, {a}");
            }
            else if (a < c && c < b)
            {
                Console.WriteLine($"{a}, {c}, {b}");
            }
            else if (b < a && a < c)
            {
                Console.WriteLine($"{b}, {a}, {c}");
            }
            else if (b < c && c < a)
            {
                Console.WriteLine($"{b}, {c}, {a}");
            }
            else if (c < a && a < b)
            {
                Console.WriteLine($"{c}, {a}, {b}");
            }
            Console.ReadKey();
        }
    }
}
