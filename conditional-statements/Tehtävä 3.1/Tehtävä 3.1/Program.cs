using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa N! kertoman arvon");
            Console.WriteLine("Syötä numero");
            String userinput1;
            userinput1 = Console.ReadLine();
            int a;
            int.TryParse(userinput1, out a);
            int i = 1;
            int f = 1;

            if (a < 0)
                Console.WriteLine("Määrittelemätön");
            else
                do
                {
                    i=i+1;
                    f=i*f;
                }
                while (i < a);

            Console.WriteLine("Tehtävän 1 vastaus");
            Console.WriteLine(f);

            Console.ReadKey();

            

        }
    }
}
