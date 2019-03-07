using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_objekt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Što je to nastavnik?");
            Console.WriteLine(Nastavnik.Opis());
            Console.WriteLine("Koji je koeficijent nastavnika?");
            Console.WriteLine(Nastavnik.Koeficijent());

            Nastavnik na1 = new Nastavnik();
            // ne mozemo postaviti READ ONLY property
            // na1.Ime = "Claudije";

            Console.WriteLine("Njegovo ime je " + na1.Ime);

            // OIB možemo postaviti 
            na1.Oib = 123345;

            // Ne dozvoljava čitanje oiba.
            // Console.WriteLine("Njegov oib je " + na1.Oib);

            // Ispiši dio oiba
            Console.WriteLine("Njegov OIB je " + na1.PartialOib + "*********");

            // instanciraj novi objekt klase Ucenik
            Ucenik uc1 = new Ucenik();
            


            //inicijalizacija objekta
            Console.WriteLine("Unesi ime učenika");
            uc1.Ime = Console.ReadLine();

            Console.WriteLine("Unesi prezime učenika");
            uc1.prezime = Console.ReadLine();

            Console.WriteLine("Unesi ocjenu iz matematike");
            uc1.ocjenaIzMatematike = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi ocjenu iz engleskog");
            uc1.ocjenaIzEngleskog = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi ocjenu iz biologije");
            uc1.ocjenaIzBiologije = int.Parse(Console.ReadLine());

            Console.WriteLine("Prosjek je: " + uc1.Prosjek());

            //instanciraj novi objekt klase Ucenik
            Ucenik uc2 = new Ucenik("Perica");
            Console.WriteLine("Ime učenika je " + uc1.Ime + " i " + uc2.Ime);

            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2 };
            ucenici.Add(uc1);
            ucenici.Add(uc2);

            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
