using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2_jednakokracan_trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite površinu jednakokračnog trokuta");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite duljinu jedne katete jednakokračnog trokuta");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Duljina druge katete je {0}", kateta(p, a));

            Console.ReadKey();
        }
        static double kateta(double p, double a)
        {
            return (p * 2) / a;
        }
    }
}
