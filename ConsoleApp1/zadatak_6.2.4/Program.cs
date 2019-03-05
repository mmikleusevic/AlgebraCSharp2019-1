using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_6._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> broj = new List<int>();
            Console.WriteLine("Unesi prirodan broj");
            int br = int.Parse(Console.ReadLine());

            while (br > 0)
            {
                broj.Add(br % 10);
                br = br / 10;
            }
            Console.WriteLine("Ispis znamenki naopako");
            for (int i = 0; i < broj.Count; i++)
            {
                Console.Write(" " + broj[i]);
            }
            Console.ReadKey();
        }
    }
}
