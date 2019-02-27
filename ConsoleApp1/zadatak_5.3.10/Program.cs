using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbrojdjeljenja = 0;
            Console.WriteLine("Unesite broj");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i > 0; i--)
            {
                if(a % i == 0 && a != i)
                {
                    Console.Write("{0} ", i);
                    zbrojdjeljenja += i;
                }
            }
            if(a == zbrojdjeljenja)
            {
                Console.WriteLine("\nUneseni broj je savršen");
            }
            Console.ReadKey();
        }
    }
}
