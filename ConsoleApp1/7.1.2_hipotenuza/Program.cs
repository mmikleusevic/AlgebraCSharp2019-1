using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._2_hipotenuza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite duljinu hipotenuze");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite duljinu jedne katete");
            double b = double.Parse(Console.ReadLine());
            kateta(c, b);

            Console.ReadKey();
        }
        static void kateta(double c, double b)
        {
            Console.WriteLine("Duljina druge katete je {0}", Math.Sqrt(c*c-b*b));
        }
    }
}
