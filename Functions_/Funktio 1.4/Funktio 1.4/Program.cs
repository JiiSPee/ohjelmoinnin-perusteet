using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Functions_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä 10 positiivista lukua");

            xx();

            Console.ReadLine();
        }

        static void xx()
        {
            string input = "";
            int maxNumber = 0;
            int maxNumberIndex = 0;
            string output = "";
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. ");
                input = Console.ReadLine();
                int n = Convert.ToInt32(input);
                if (n > maxNumber)
                {
                    maxNumber = n;
                    maxNumberIndex = i;
                }
                if (n <= 0)
                {
                    Console.WriteLine("Luku ei kelpaa, syötä uusi");
                    i--;
                }
                else
                {
                    output += $"{n} ";
                }

            }
            Console.WriteLine($"Syötit suraavat luvut:\n{output}\n");
            Console.WriteLine($"Suurin {maxNumber} oli {maxNumberIndex}. luku");
        }

    }
}
