using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._7_prost_broj_ponovno
{
    class Program
    {
        static void Main(string[] args)
        {
            string odgovor = "D";
            while ((odgovor != "N" && odgovor == "D") || (odgovor !="n" && odgovor == "d"))
            {
                Console.WriteLine("Unesite prirodan broj");
                int a = int.Parse(Console.ReadLine());
                foreach (int i in broj(a))
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Želite li ponovno (D/N)?");
                odgovor = Console.ReadLine();
            }
            
        }
        static List<int> broj(int broj)
        {
            List<int> faktori = new List<int>();
            int i = 2;
            while (i <= broj)
            {
                if (broj % i == 0)
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
