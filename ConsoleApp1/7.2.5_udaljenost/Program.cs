using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._5_udaljenost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite udaljenost izmedu dvije tocke");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite jednu točku, prvo x1, zatim x2");
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("(y2-y1) na kvadrat je = {0}", y(d, x2, x1));
            Console.WriteLine("Unesite jedan y");
            double yn = double.Parse(Console.ReadLine());
            Console.WriteLine("Drugi y je {0}",Math.Sqrt(y(d,x2,x1)-yn));
            Console.ReadKey();
        }
        static double y(double d, double x2, double x1)
        {
            return (d * d) - ((x2 * x2)-(x1 * x1));
        }
    }
}
