using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5._3._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena = 0;
            try
            {
                while ( ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Unesite ocjenu od 1 do 5");
                    ocjena = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Unešena ocjena je {0} ", ocjena);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Nije unešen broj " + ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
