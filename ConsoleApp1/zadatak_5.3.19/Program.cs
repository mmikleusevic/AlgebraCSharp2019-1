using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int a = 1;
            int brojac=0;
            Console.WriteLine("Unesite brojeve, prikazat ce im se suma, kada zelite prestanak unosa unesite 0");
            while (a != 0)
            {
                
                int c = int.Parse(Console.ReadLine());
                a = c;
                suma = suma + a;
                brojac++;
            }
            brojac--;
            Console.WriteLine("Zbroj unešenih brojeva je {0}, unešeno ih je {1}", suma, brojac);
            Console.ReadKey();
        }
    }
}
