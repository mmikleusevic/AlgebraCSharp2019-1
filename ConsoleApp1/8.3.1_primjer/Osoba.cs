using _8._1._2_Prirucnuik;
using System;

namespace _8._3._1_primjer
{
    public abstract class Osoba
    {
        public DateTime datumNastanka;
        private string ime = "";
        public string prezime = "";

        public string Ime
        {
            get => ime;
            set => ime = ToUpper.FirstCharToUpper(value);
        }

        public Osoba()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("Pozvana metoda Osoba::Osoba()");
        }

        public Osoba(string v1, string v2)
        {
            this.ime = v1;
            this.prezime = v2;
        }
    }
}