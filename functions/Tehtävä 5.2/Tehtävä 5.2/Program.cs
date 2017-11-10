using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kaksi lukua");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c = string.Compare(a, b);
            if (c == 1)
                Console.WriteLine("{0} on pienempi kuin {1}", b, a);
            else
                Console.WriteLine("{0} on pienempi kuin {1}", a, b);
            Console.ReadKey();
        }
    }
}
