using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taulukko_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[9];
            Random q = new Random();
            for (int i = 0; i < 9; i++)
            {
                double r = q.Next(1, 40);
                if (array.Contains(r))
                {
                    i = i - 1;
                }
                else
                {
                    array[i] = r;
                }
            }
            int e = q.Next(1, 40);
            Console.WriteLine("Loton oikearivi on:");
            Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}");
            Console.WriteLine($"Lisänumerot: {array[7]} ja {array[8]}");
            Console.WriteLine($"Tuplausnumero: {e}");
            Console.ReadLine();
        }
    }
}
