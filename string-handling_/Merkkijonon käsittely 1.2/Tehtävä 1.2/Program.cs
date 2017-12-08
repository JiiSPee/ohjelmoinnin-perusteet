using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kirjoita sana tai lause ja ohjelma muuttaa e kirjaimet @ merkiksi");
            string userinput1;
            userinput1 = Console.ReadLine();
            userinput1 = userinput1.ToUpper();
            userinput1 = userinput1.Replace("E", "@");
            Console.WriteLine($"{userinput1}");
            Console.ReadKey();


        }
    }
}
