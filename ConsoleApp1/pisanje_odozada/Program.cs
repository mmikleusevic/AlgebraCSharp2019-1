using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisanje_odozada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite neku recenicu");
            string recenica = Console.ReadLine();
            for (int i = recenica.Length - 1; i >= 0; i--)
            {
                Console.Write(recenica[i]);
            }
            Console.ReadKey();
        }
    }
}
