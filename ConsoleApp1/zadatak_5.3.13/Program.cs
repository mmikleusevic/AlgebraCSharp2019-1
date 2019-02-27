using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int min=int.MaxValue;
            int max=int.MinValue;
            int broj;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Unesite broj");
                broj = int.Parse(Console.ReadLine());
                if(broj < min)
                {
                    min = broj;
                }
                if(broj > max)
                {
                    max = broj;
                }
            }
            Console.WriteLine("Minimalni broj je {0}, maximalni broj je {1}", min, max);
            Console.ReadKey();
        }
    }
}
