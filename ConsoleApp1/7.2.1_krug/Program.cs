using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite opseg kruga");
            double o = double.Parse(Console.ReadLine());
            Console.WriteLine("Radius kruga je {0}, njegova površina je {1} ",radius(o),povrsina(o));
            Console.ReadKey();
        }
        static double radius(double o)
        {
            double r;
            r = o / 2 / 3.14;
            return r;
        }
        static double povrsina(double o)
        {
            double r = radius(o);
            double p;
            p = r * r * 3.14;
            return p;
        }
    }
}
