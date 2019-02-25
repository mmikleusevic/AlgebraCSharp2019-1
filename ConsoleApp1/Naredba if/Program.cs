using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naredba_if
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite prirodan broj: ");
                int a = int.Parse(Console.ReadLine());

                if (a > 10)
                {
                    Console.WriteLine("Uneseni broj je veći od 10.");
                }
                else
                {
                    Console.WriteLine("Uneseni broj NIJE veći od 10.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Opis greške:" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
