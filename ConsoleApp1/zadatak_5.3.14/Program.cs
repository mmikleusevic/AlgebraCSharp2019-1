using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program ispisuje sve neparne brojeve od 1 do 10");
            for (int i = 1; i <= 10; i=i+2)
            {
                    Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}
