using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._8_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj od kojega zelite faktorijele");
            List<int> faktorijele = new List<int>();
            int a = int.Parse(Console.ReadLine());
            foreach (int i in broj(a))
            {
                Console.Write("{0} ", i);
            }
            
            Console.ReadKey();
        }
        static List<int> broj(int a)
        {
            List<int> faktori = new List<int>();
            int brojac = 1;
            int faktor = 1;
            while (brojac <= a+1)
            {
                faktori.Add(faktor);
                faktor = faktor * brojac;  
                brojac++;
            }
            return faktori;
        }
    }
}
