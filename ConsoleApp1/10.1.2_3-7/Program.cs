using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10._1._2_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Create);
            FileStream fs2 = new FileStream("3or7SaZarezima.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1);
            StreamWriter sw2 = new StreamWriter(fs2);

            for (int i = 0; i <= 100; i++)
            {
                if((i % 3 == 0) || (i % 7 == 0))
                {
                    sw1.WriteLine(i);
                    sw2.Write("{0},", i);
                }
            }
            sw1.Flush();
            sw1.Close();
            fs1.Close();
            sw2.Flush();
            sw2.Close();
            fs2.Close();

            Console.WriteLine("Ispis sadržaja");

            fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs1);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            sr.Close();
            fs1.Close();

            fs1 = new FileStream("3or7SaZarezima.txt", FileMode.Open);
            sr = new StreamReader(fs1);
            s = sr.ReadToEnd();
            Console.WriteLine(s);
            sr.Close();
            fs1.Close();

            Console.ReadKey();
        }
    }
}
