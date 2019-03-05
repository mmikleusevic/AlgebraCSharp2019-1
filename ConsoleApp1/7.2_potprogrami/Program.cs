using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_potprogrami
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            HelloWorld();
            HelloWorld();
            Console.WriteLine(HelloWorld("Ola"));

            Kraj();
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        static string HelloWorld(string poz)
        {
            return poz + ", i tebi oj putniče";
        }
        static void Kraj()
        {
            Console.WriteLine("Pritisnite neku tipku za kraj...");
            Console.ReadKey();
        }
    }
}
