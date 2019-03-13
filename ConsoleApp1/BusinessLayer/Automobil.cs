namespace BusinessLayer
{
    public class Automobil
    {
        public string markaAutomobila = "";
        public double ks = 0;
        public double osnovnaCijena = 0;

        public double IznosPoreza()
        {
            double porez = 0;
            if(ks < 50)
            {
                porez = 0.05;
            }
            else if(ks > 50 && ks < 150)
            {
                porez = 0.1;
            }
            else
            {
                porez = 0.15;
            }
            return osnovnaCijena * porez;
        }
        public double UkupnaCijena()
        {
            return osnovnaCijena + IznosPoreza();
        }
    }
}