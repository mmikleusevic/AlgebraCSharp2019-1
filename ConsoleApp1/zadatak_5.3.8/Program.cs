using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojac = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                {
                    brojac++;
                }
            }
            Console.WriteLine(" Postoji {0} brojeva djeljivih sa 7 i nedjeljivih sa 3 ", brojac);
            Console.ReadKey();
        }
    }
}
