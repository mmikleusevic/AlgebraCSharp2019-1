using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1_primjer
{
    public enum RadniDani
    {
        Ponedjeljak=1,
        Utorak,
        Srijeda,
        Cetvrtak,
        Petak
    }
    public enum Ocjene
    {
        Nedovoljan = 1,
        Dovoljan,
        Dobar,
        Vrlodobar,
        Odlican
    }
    public enum Katovi
    {
        Prizemlje,
        Prvi,
        Drugi,
        Treci,
        Cetvrti
    }

    class Program
    {
        static void Main(string[] args)
        {
            Firma algebra = new Firma("Algebra d.o.o.");
            algebra.Kat = Katovi.Treci;
            Console.WriteLine("Ispiši firmu");

        
        }
    }
    public class Firma
    {
        private Katovi kat;
        private string naziv;
        private string v;
        public override string ToString()
        {
            string kojiKat = "";
            switch ((int)kat)
            {
                case 0:
                    kojiKat = "nultom";
                    break;
                case 1:
                    kojiKat = "prvom";
                    break;
                case 2:
                    kojiKat = "drugom";
                    break;
                case 3:
                    kojiKat = "trecem";
                    break;
                case 4:
                    kojiKat = "cetvrtom";
                    break;
                default: kojiKat = "nepoznatom";
                    break;

            }
            return "Naše ime je "+this.naziv+" i nalazimo se na " +kojiKat+" katu";
        }
        public Firma(string v)
        {
            this.Naziv = v;
        }

        public Katovi Kat { get => kat; set => kat = value; }
        public string Naziv { get => naziv; set => naziv = value; }
    }
}
