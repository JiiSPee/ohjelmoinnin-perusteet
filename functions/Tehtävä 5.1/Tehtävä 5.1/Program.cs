using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_5._1

    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Syötä numero");
                string w;
                w = Console.ReadLine();
                int q = Convert.ToInt32(w);
                if (q > 0)
                    Console.WriteLine(new String('*', q));
                else
                    Console.WriteLine("luku {0} ei ole sallittu", q);
                Console.ReadKey();
            }
        }
    }