using _8._1._2_automobil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik uc1 = new Ucenik(); // Osoba() i Ucenik()
            Ucenik uc2 = new Ucenik("Anica"); // Osoba()
            Ucenik uc3 = new Ucenik("Perica", "Perić"); // Osoba()

            uc3.PrijaviIspit(new Ispit("Engleski"));

            // generic list
            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2, uc3 };

            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }

            // collection base lista(kao ArrayList)
            Studenti studenti = new Studenti();
            studenti.Add(uc1);
            studenti.Add(uc2);
            studenti.Add("Lara", "Crofft");

            Console.WriteLine("\nIspis klase studenti koja nasljeduje CollectionBase\n");
            foreach (var item in studenti)
            {
                Console.WriteLine(" ----> "+item.ToString()+"\n");
            }

            // Dodaj vozače
            Vozac vo1 = new Vozac("Luka", "Krilić"); // Osoba()
            vo1.Kategorija_a = true;
            vo1.Kategorija_c = true;

            Vozac vo2 = new Vozac("Niko", "Bulić"); // Osoba()
            vo2.Kategorija_b = true;
            vo2.Kategorija_d = true;

            List<Vozac> vozac = new List<Vozac> { vo1, vo2 };

            foreach (var item in vozac)
            {
                Console.WriteLine(item);
            }

            var a1 = new Automobil();
            a1.markaAutomobila = "Ford";


            var a2 = new Automobil();
            a2.markaAutomobila = "Mazda";

            vo1.Automobili.Add(a1);
            vo1.Automobili.Add(a2);

            Pilot pi1 = new Pilot("Ford", "Roks"); // Osoba()
            pi1.Kategorija_b = true;
            pi1.Kategorija_d = true;
            pi1.Kategorija_x = true;

            List<Pilot> piloti = new List<Pilot> { pi1 };

            foreach (var item in piloti)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
