using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float suma = 0;
            float prosjek = 0;
            Console.WriteLine("Unesite 5 prirodnih brojeva");
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    a = int.Parse(Console.ReadLine());
                    if (a < 0)
                    {
                        throw new Exception("Negativan broj");
                    }
                    suma = suma + a;
                }
                prosjek = suma / 5;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unešeni broj nije prirodan " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("Suma svih brojeva je {0}, njihov prosjek je {1}", suma, prosjek);
            }
            Console.ReadKey();
        }      
    }
}
