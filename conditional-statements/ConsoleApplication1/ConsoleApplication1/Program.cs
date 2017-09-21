using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            Console.WriteLine("syötä luku: ");
            String userinput;
            userinput = Console.ReadLine();

            int evaluatedNumber;
            int.TryParse(userinput, out evaluatedNumber);
            if(evaluatedNumber < 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
            }
            else if(evaluatedNumber > 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
            }
            else
            {
                Console.WriteLine($"Numero {evaluatedNumber} on nolla");
            }


            Console.WriteLine($"Syötit arvon {userinput}");
            Console.ReadKey();



        }
    }
}
