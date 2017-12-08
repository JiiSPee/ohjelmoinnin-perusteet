using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana tai lause ja ohjelma tarkistaa onko se palintromi");
            string userinput1= Console.ReadLine();
            string userinput2= userinput1.ToUpper();
            userinput2 = userinput2.Replace(" ", String.Empty);

            int i = 0;
            int j = userinput2.Length - 1;

            while (i < j)
            {
                if (userinput2[i] != userinput2[j])
                {
                    Console.WriteLine($"Syöte '{userinput1}' ei ole palintromi");
                    break;
                }

                i++;
                j--;
                if (j <= i) 
                {
                    Console.WriteLine($"Syöte '{userinput1}' on palintromi");
                }
            }
            
            Console.ReadKey();

        }
    }
}
