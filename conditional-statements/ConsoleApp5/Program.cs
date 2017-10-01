using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minkä ikäinen olet?");
            string userinput1;
            userinput1 = Console.ReadLine();

            int ikä;
            int.TryParse(userinput1, out ikä);

            Console.WriteLine("Oletko Mtk:n jäsen? k/e (k=kyllä, e=ei)");
            string userinput2;
            userinput2 = Console.ReadLine();

            char mtk;
            char.TryParse(userinput2, out mtk);

            Console.WriteLine("Oletko opiskelija? k/e");
            string userinput3;
            userinput3 = Console.ReadLine();

            char opiskelija;
            char.TryParse(userinput3, out opiskelija);

            Console.WriteLine("Oletko varusmies? k/e");
            string userinput4;
            userinput4 = Console.ReadLine();

            char varusmies;
            char.TryParse(userinput4, out varusmies);

            if (ikä < 7)
                Console.WriteLine("0e");
            else if (mtk == 'k' && opiskelija == 'k')
                Console.WriteLine("Alennus-%  -60%  Hinta  6,40e");
            else if (ikä > 7 && ikä < 15)
                Console.WriteLine("Alennus-%  -50%  Hinta  8.00e");
            else if (ikä > 65)
                Console.WriteLine("Alennus-%  -50%  Hinta  8.00e");
            else if (varusmies == 'k')
                Console.WriteLine("Alennus-%  -50%  Hinta  8.00e");
            else if (opiskelija == 'k')
                Console.WriteLine("Alennus-%  -45%  Hinta  8.80e");
            else if (mtk == 'k')
                Console.WriteLine("Alennus-%  -15%  Hinta  13,60e");
            else
                Console.WriteLine("16e");
            Console.ReadKey();

        }
    }
}
