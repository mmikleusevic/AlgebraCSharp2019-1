using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._9_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite uspjeh");
            string usp = Console.ReadLine();

            Console.WriteLine("Prosjek je {0} ", uspjeh(usp));
            Console.ReadKey();
        }
        static string uspjeh(string usp)
        {
            if(usp == "nedovoljan")
            {
                Console.WriteLine("manji od 1.5 ");
            }
            else if (usp == "dovoljan")
            {
                Console.WriteLine("veći od 1.5, manji od 2.5 ");
            }
            else if (usp == "dobar")
            {
                Console.WriteLine("veći od 2.5, manji od 3.5 ");
            }
            else if (usp == "vrlo dobar")
            {
                Console.WriteLine("veći od 3.5, manji od 4.5 ");
            }
            else
            {
                Console.WriteLine("veći od 4.4");
            }
            return usp;
        }
    }
}
