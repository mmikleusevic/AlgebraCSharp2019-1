using System;

namespace _8._1._2_objekt
{
    internal class Ucenik
    {
        public DateTime datumNastanka;
        private string ime = "";
        public string prezime = "";
        public int ocjenaIzMatematike = 0;
        public int ocjenaIzEngleskog = 0;
        public int ocjenaIzBiologije = 0;

        public string Ime
        {
            get => ime;
            set => ime = value;
        }

        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;
        }

        public Ucenik(string v)
        {
            this.Ime = v;
        }
        public Ucenik(string v,string prez)
        {
            this.Ime = v;
            this.prezime = prez;
        }

        public double Prosjek()
        {
            double prosjek = 0;
            prosjek = (double)(ocjenaIzMatematike + ocjenaIzEngleskog + ocjenaIzBiologije) / 3;
            return prosjek;
        }
        public override string ToString()
        {
            return "Moje ime je " + this.Ime + " a moj prosjek je: " + this.Prosjek();
        }
    }
}