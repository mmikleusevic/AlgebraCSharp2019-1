using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj: ");
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());

                if (a % 4 == 0 && !(a < 100))
                {
                    Console.WriteLine("Broj je dobar.");
                }
                else
                {
                    Console.WriteLine("Broj NIJE dobar!");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Provjeri da li je unešen broj? " + e.ToString());
            }
            Console.ReadKey();
        }
    }
}
