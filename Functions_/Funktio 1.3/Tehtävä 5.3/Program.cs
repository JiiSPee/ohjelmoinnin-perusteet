using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vali = true;
            while (vali)
            {
                Console.WriteLine("Syötä numero välillä 0-10");
                string input = Console.ReadLine();
                int q;
                if (int.TryParse(input, out q) && q >= 0 && q <= 10)
                {
                    Console.WriteLine("Numero OK!");
                    vali = false;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Syöte ei kelpaa.");
                }
            }
        }
    }
}
