using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita sana tai lause ja ohjelma laskee merkkien määrän.");
            string userinput1;
            userinput1 = Console.ReadLine();

            Console.WriteLine($"Syötteessä on {userinput1.Length} merkkiä");
            Console.ReadKey();
        }
    }
}
