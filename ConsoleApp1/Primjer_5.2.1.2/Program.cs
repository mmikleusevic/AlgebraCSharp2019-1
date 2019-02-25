using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer_5._2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Uneseni broj je pozitivan");
            }
            else if(a < 0)
            {
                Console.WriteLine("Uneseni broj je negativan");
            }
            else
            {
                Console.WriteLine("Uneseni broj je jednak 0");
            }
            Console.ReadKey();
        }
    }
}
