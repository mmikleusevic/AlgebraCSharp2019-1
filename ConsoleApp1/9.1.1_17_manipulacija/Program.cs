using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._1_17_manipulacija
{
    class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas je suncan dan, zato vam dobar dan";
            string rijec = "dan";
            char slovo = 'n';
            int brojac = 0;
            for (int i = 0; i < recenica.Length; i++)
            {
                if(recenica[i] == slovo)
                {
                    brojac++;
                }
            }
            Console.WriteLine("\n9.1.1. Znak u rijeci");
            Console.WriteLine("Znak {0} se u rijeci '{1}' pojavljuje {2} puta\n ",slovo,recenica,brojac);
            brojac = 0;
            string[] nizrijeci = recenica.Split(' ',',','!');
            // recenica = recenica.ToLower();
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                if(nizrijeci[i] == rijec)
                {
                    brojac++;
                }
                Console.WriteLine(nizrijeci[i]);
            }


            Console.WriteLine("\n9.1.2. Rijec u recenici");
            Console.WriteLine("Rijec {0} se u recenici '{1}' pojavljuje {2} puta\n ", rijec, recenica, brojac);


            nizrijeci = recenica.Split(' ');
            brojac = 0;
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                Console.WriteLine(nizrijeci[i]);
                brojac++;
            }

            Console.WriteLine("\n9.1.3. Rijec u novi red");
            Console.WriteLine("Nalazi se {0} rijeci u recenici {1}\n ", brojac, recenica);

            Console.ReadKey();
        }
    }
}
