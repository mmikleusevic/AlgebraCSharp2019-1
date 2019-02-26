using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int a = int.Parse(Console.ReadLine());

            if(a >= 100 && a<= 200)
            {
                Console.WriteLine("Broj jest u intervalu [100, 200].");
            }
            else
            {
                Console.WriteLine("Broj NIJE u intervalu [100, 200]!");
            }
            Console.ReadKey();
        }
    }
}
