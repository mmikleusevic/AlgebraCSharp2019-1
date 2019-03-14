using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace primjer_osoba
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik uc1 = new Ucenik("Maja","Majić");
            Ucenik uc2 = new Ucenik("Ana","Majić");
            Ucenik uc3 = new Ucenik("Maja","Zmajić");
            List<Osoba> osobe = new List<Osoba>();
            List<Osoba> samoMaje = new List<Osoba>();
            osobe.Add(uc1);
            osobe.Add(uc2);
            osobe.Add(uc3);

            string trazenoIme = "Maja";
            int brojacMaja = 0;
            foreach (var item in osobe)
            {
                if(item.Ime == trazenoIme)
                {
                    brojacMaja++;
                    Console.WriteLine(item.Ime);
                }  
            }
            Console.WriteLine(trazenoIme + " se pojavljuje " + brojacMaja + " puta");

            // from <alias> in <collection>
            try
            {
                    samoMaje = (
                    from os 
                    in osobe
                    where os.Ime == trazenoIme
                    // select os).SingleOrDefault();
                    select os).Take(2).ToList();

                // Console.WriteLine("Našao sam osobu " + trazenaOsoba.Ime + " " + trazenaOsoba.prezime);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("Greška: " + ioe.Message);
            }
            finally
            {
                foreach (var item in samoMaje)
                {
                    Console.WriteLine("Moje ime je "+item.Ime+" "+item.prezime);
                }
                
            }
            Console.ReadKey();
        }
    }
}
