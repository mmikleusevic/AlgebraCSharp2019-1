using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto = new Automobil();

            Console.WriteLine("Unesite Marku automobila");
            auto.markaAutomobila = Console.ReadLine();

            Console.WriteLine("Unesite KS automobila");
            auto.ks = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite osnovnu cijenu automobila");
            auto.osnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Automobil marke {0}, ima {1} KS, porez na njega iznosi {2}, te ukupna cijena mu je {3}", auto.markaAutomobila, auto.ks, auto.IznosPoreza(),auto.UkupnaCijena());
            Console.ReadKey();
        }
    }
}
