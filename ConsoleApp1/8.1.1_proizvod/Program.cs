using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1_proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod p1 = new Proizvod();

            Console.WriteLine("Unesi Naziv proizvoda");
            p1.naziv = Console.ReadLine();

            Console.WriteLine("Unesi cijenu proizvoda");
            p1.cijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesi maržu proizvoda");
            p1.marza = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesi porez na proizvod");
            p1.porez = double.Parse(Console.ReadLine());

            Console.WriteLine("MPC za proizvod {0} je {1}. ", p1.naziv, p1.Mpc());
            Console.ReadKey();

        }
    }
}
