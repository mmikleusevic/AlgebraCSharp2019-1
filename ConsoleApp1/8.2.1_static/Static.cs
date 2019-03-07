using System;
using System.Collections.Generic;

namespace _8._2._1_static
{
    internal class Static
    {
        // PRIVATE konstruktor onemogućava instanciranje
        private Static() { }

        #region STATIC metode

        public static double Zbroj(double broj1, double broj2)
        {
            return broj1 + broj2;
        }

        public static double Kub(double broj)
        {
            return broj * broj * broj;
        }

        public static double UdaljenostTocaka(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public static double CelzijFahrenheit(double stupnjevi)
        {
            return ((double)9 / 5) * stupnjevi + 32;
        }

        #endregion
    }
}