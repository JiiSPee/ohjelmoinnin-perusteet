using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana tai lausa ja ohjelma laskee L kirjaimien määrän");
            string userinput1;
            userinput1 = Console.ReadLine();
            userinput1 = userinput1.ToUpper();
            int laske = 0;
            foreach (char q in userinput1)
            {
                if (q == 'L') laske++;
            }
            Console.WriteLine($"Syötteessä on {laske} L kirjainta");
            Console.ReadKey();

        
            


            Console.ReadKey();

        }
    }
}
