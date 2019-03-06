using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._4_celzij_u_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite stupnjeve u fahrenheitima");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Temperatura u stupnjevima celzija iznosi {0} ", celziji(f));
            Console.ReadKey();
        }
        static double celziji(double f)
        {
            return (f * 5 / 9) - 17.7777;
        }
    }
}
