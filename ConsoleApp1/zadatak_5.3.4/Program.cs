using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli pozitivan broj");
            try
            {
                int a = int.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    throw new NegativeNumberException("Negativni broj");
                }
                if (a >= 20)
                {
                    throw new VeciOdDvajstException("Broj veći od 20");
                }
                int fact = 1;
                for (int i = a; i > 0; i--)
                {
                    fact *= i;
                }
                Console.WriteLine(fact);
            }
            catch (NegativeNumberException Nex)
            {
                Console.WriteLine("Dozvoljeni brojevi su u intervalu [1,19].", Nex.ToString());
            }
            catch (VeciOdDvajstException Vex)
            {
                Console.WriteLine("Broj je prevelik, veći je od dimenzije int", Vex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {

        }
        public NegativeNumberException(string message)
            : base(message)
        {
            Console.WriteLine("Dodatno custom pojašnjenje klase NegativeNumberException");
        }
        public NegativeNumberException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
    public class VeciOdDvajstException : Exception
    {
        public VeciOdDvajstException()
        {

        }
        public VeciOdDvajstException(string message)
            : base(message)
        {

        }
        public VeciOdDvajstException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
