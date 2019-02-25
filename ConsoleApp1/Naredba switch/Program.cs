using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naredba_switch
{
    class Program
    {
        static double SafeDivision(double x, double y)
        {
            if(y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string operacija = "";
            try
            {
                Console.Write("Unesite 1. broj: ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Unesite 2. broj: ");
                b = float.Parse(Console.ReadLine());
                Console.Write("Unesite računsku operaciju (+,-,*,/): ");
                operacija = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                switch (operacija)
                {
                    case "+":
                        Console.WriteLine("Zbroj: {0}", a + b);
                        break;
                    case "-":
                        Console.WriteLine("Razlika: {0}", a - b);
                        break;
                    case "*":
                        Console.WriteLine("Umnožak: {0}", a * b);
                        break;
                    case "/":
                        try
                        {
                            Console.WriteLine("Kvocijent: {0}", SafeDivision(a, b));
                        }
                        catch (DivideByZeroException ex2)
                        {
                            Console.WriteLine(ex2.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Nepoznata računska operacija!");
                        break;
                }
                Console.WriteLine("Pritisnite neku tipku za kraj...");
                Console.ReadKey();
            }
        }

        private static int SafeDivision(float v)
        {
            throw new NotImplementedException();
        }
    }
}
