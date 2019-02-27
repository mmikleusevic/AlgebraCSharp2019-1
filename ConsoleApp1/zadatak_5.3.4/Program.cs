using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli pozitivan broj");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int fact = 1;
                for (int i = a; i > 0; i--)
                {
                    fact *= i;
                }
                Console.WriteLine(fact);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
