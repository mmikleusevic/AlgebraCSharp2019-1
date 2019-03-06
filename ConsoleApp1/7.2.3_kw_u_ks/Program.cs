using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3_kw_u_ks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite snagu u kw");
            double kw = double.Parse(Console.ReadLine());
            Console.WriteLine("Snaga u ks iznosi {0} ", ks(kw));
            Console.ReadKey();
        }
        static double ks(double kw)
        {
            return kw * 1.3586;
        }
    }
}
