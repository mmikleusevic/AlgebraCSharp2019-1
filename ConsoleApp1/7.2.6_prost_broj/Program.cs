using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._6_prost_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj");
            int a = int.Parse(Console.ReadLine());
            foreach (int i in broj(a))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
        static List<int> broj(int broj)
        {
            List<int> faktori = new List<int>();
            int i = 2;
            while(i <= broj)
            {
                if(broj % i == 0)
                {
                    faktori.Add(i);
                    broj = broj / i;
                }
                else
                {
                    i++;
                }
            }
            return faktori;
        }
    }
}
