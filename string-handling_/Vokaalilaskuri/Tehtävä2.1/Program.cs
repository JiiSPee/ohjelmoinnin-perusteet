using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
			Console.WriteLine("Kirjoita jotain ja ohjelma laskee vokaalit");
            data = Console.ReadLine();
            string data2;
            //data2 = data.ToLower();
            //char[] char1 = { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm',' ' };
            //data2 = data2.Replace(char1.ToString(),String.Empty);
            //Console.WriteLine($"Sanassa {data2} on {data2.Length} vokaalia");
            Console.WriteLine($"Sanassa {data} on {RemoveKonsonants(data)} vokaalia");
            Console.ReadKey();  



        }

        static int RemoveKonsonants(string xxx)
        {
            xxx = xxx.ToLower();
            char[] char1 = { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', ' ' };
            for(int i=0;i<char1.Length;i++)
                xxx = xxx.Replace(char1[i].ToString(), String.Empty);
            return xxx.Length;
        }
    }
}
