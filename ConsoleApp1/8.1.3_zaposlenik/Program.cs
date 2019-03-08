using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3_zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prvi način
            // Instanciranje novog objekta Z1 klase Zaposlenik
            // Zaposlenik Z1 = new Zaposlenik("Pero","Perić","1234567890123");
            // Zaposlenik Z2 = new Zaposlenik("Marko", "Marić");

            // List <Zaposlenik> listaZaposlenika  = new List<Zaposlenik>();
            // listaZaposlenika.Add(Z1);
            // listaZaposlenika.Add(Z2);

            // Drugi način
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>()
            {
                new Zaposlenik("Pero", "Perić", "1234567890123"),
                new Zaposlenik("Marko", "Marić")
            };


            listaZaposlenika.ForEach(Zaposlenik => UnesiBodove(Zaposlenik));
            listaZaposlenika.ForEach(Zaposlenik => UnesiVrijednost(Zaposlenik));
            listaZaposlenika.ForEach(Zaposlenik => IspisiZaposlenike(Zaposlenik));

            // Unesi pravilno broj bodova

            // Ispis
            Console.WriteLine("Zaposlenik: " + Z1.Ime + " " + Z1.Prezime);
            Console.WriteLine("Neto: " + Z1.NetoIzracunPlace());
            Console.WriteLine("Porez: " + Z1.Porez);
            Console.WriteLine("Bruto: " + Z1.BrutoIzracunPlace());

            Console.ReadKey();
        }

        private static void IspisiZaposlenike(Zaposlenik zaposlenik)
        {
            
        }

        private static void UnesiVrijednost(Zaposlenik zaposlenik)
        {
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite vrijednost boda: ");

                try
                {
                    zaposlenik.VrijednostBoda = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
            }
        }

        private static void UnesiBodove(Zaposlenik zaposlenik)
        {
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite broj bodova: ");

                try
                {
                    zaposlenik.BrojBodova = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška: " + ex.Message);
                }
            }
        }
    }
}
