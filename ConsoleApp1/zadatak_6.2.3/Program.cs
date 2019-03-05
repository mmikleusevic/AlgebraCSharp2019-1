using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_6._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaBrojeva = new List<int>();
            int br = 1;

            Console.WriteLine("Unosi brojeve sve dok ne uneseš 0");
            while (br != 0)
            {
                br = int.Parse(Console.ReadLine());
                listaBrojeva.Add(br);
            }
            listaBrojeva.Sort();

            Console.WriteLine("Brojevi poredani po veličini");
            foreach (int broj in listaBrojeva)
            {
                Console.Write(" "+broj);
            }
            Console.ReadKey();
        }
    }
}
