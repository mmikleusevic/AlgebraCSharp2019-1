using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._1_zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi dva broja, program ispisuje njihov zbroj");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            zbroj(a, b);
            Console.ReadKey();
        }
        static void zbroj(int c, int d)
        {
            Console.WriteLine("Zbroj je {0}", c + d);
        }
    }
}
