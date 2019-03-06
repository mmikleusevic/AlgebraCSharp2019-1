using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._11_parni_neparni
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>();
            Console.WriteLine("Unosi brojeve sve dok ne uneseš 0");
            int broj = 1;
            while( broj != 0)
            {
                broj = int.Parse(Console.ReadLine());
                brojevi.Add(broj);
            }
            Console.WriteLine("Parni su: \n");
            foreach (int i in parni(brojevi))
            {
                Console.Write(" "+i);
            }
            Console.WriteLine("\nNeparni su: \n");
            foreach (int i in neparni(brojevi))
            {
                Console.Write(" "+i);
            }
            Console.ReadKey();
        }
        static List<int> parni(List<int> brojevi)
        {
            List<int> par = new List<int>();
            foreach (int i in brojevi)
            {
                if(i % 2 == 0)
                {
                    par.Add(i); 
                } 
            }
            return par;
        }
        static List<int> neparni(List<int> brojevi)
        {
            List<int> nepar = new List<int>();
            foreach (int i in brojevi)
            {
                if (i % 2 != 0)
                {
                    nepar.Add(i);
                }
            }
            return nepar;
        }
    }
}
