using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itsearviointi_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä lukuja. Syöttäessä luvun -1 ohjelma laskee syöttämäsi luvut yhteen");
            int q = 0;
            while (true)
            {
                string w = Console.ReadLine();
                int i = Convert.ToInt32(w);
                if (i == -1)
                {
                    Console.WriteLine("Lukujen summa on {0}", q);
                    break;
                }
                else
                    q += i;
            }
            Console.ReadKey();

        }
    }
}
