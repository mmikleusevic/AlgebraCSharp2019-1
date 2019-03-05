using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._5_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaProsti = new List<int>(); 
            int faktor = 2;
            Console.WriteLine("Unesi neki prirodan broj");
            int broj = int.Parse(Console.ReadLine());

            while(faktor <= broj)
            {
                if(broj % faktor == 0)
                {
                    listaProsti.Add(faktor);
                    broj = broj / faktor;
                }
                else
                {
                    faktor++;
                }
            }
            Console.WriteLine("Faktori vašeg broja");
            foreach (int i in listaProsti)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
