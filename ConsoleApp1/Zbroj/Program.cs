using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaracija varijabli
            int x, y;

            // Definicija varijabli x i y
            x = 5;
            y = x + 3;

            //Ispis u konzolu
            Console.WriteLine("Broj x je:" + x);
            Console.WriteLine("Broj y je:" + y);
            Console.WriteLine("Njihov zbroj je:" + (x+y));

            //Ne zatvaraj dok se ne stisne key
            Console.ReadKey();
        }
    }
}
