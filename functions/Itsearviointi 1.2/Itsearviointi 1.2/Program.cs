using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itsearviointi_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita lause");
            int q = 0;
            string r = Console.ReadLine();
            foreach (char e in r)
                if (char.IsLetterOrDigit(e))
                {
                    q++;
                }
            int w = 1;
            do
            {
                Console.WriteLine(w + ". " + r);
                w++;
            }
            while (w <= q);
            Console.ReadKey();
        } 
    }
}
