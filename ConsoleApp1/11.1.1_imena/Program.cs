using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11._1._1_imena
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> imena = new List<string>();
            while (true)
            {
                Console.WriteLine("Unesite imena, za završetak unesite kraj");
                string ime = Console.ReadLine();
                if (ime == "kraj")
                {
                    break;
                }
                else
                {
                    imena.Add(ime);
                }               
            }
            List<string> imenaSaSlovomA = (from im in imena
                                           where im.ToLower().Contains("a")
                                           select im).ToList();
            Console.WriteLine();
            Console.Write("Imena koja sadrže slovo \"a\" su: ");

            foreach (string ime in imenaSaSlovomA)
            {
                Console.Write(ime + ", ");
            }
            Console.ReadKey();
        }

    }
}
