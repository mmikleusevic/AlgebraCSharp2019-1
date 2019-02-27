using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int potencija = 1;
            while (potencija < 1000)
            {
                potencija *= 2;
                if (potencija > 999)
                {
                    potencija = potencija / 2;
                    break;
                }
            }
            Console.WriteLine("Potencija od 2 najbliža 999 je {0}", potencija);
            Console.ReadKey();
        }
    }
}
