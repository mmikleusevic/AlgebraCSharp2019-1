using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2._1_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2019, 2, 28);
            DateTime datum2 = new DateTime(2019, 3, 28);
            TimeSpan interval1 = datum2 - datum1;

            Console.WriteLine("Interval između {0} i {1} je {2} ",datum1,datum2,interval1.Ticks);
            Console.WriteLine("U satima..." + interval1.TotalHours);
            Console.WriteLine("U minutama..." + interval1.TotalMinutes);
            Console.WriteLine("U danima..." + interval1.TotalDays);
            Console.WriteLine("U sekundama..." + interval1.TotalSeconds);
            Console.ReadKey();
        }
    }
}
