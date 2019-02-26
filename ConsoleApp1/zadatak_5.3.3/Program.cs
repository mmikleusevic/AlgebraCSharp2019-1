using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suma prvih sto
            int suma = 0;
            for (int i = 0; i < 100; i++)
            {
                suma = suma + i;
            }
            Console.Write("Zbroj prvih sto brojeva je {0}", suma);
            Console.ReadLine();
        }
    }
}
