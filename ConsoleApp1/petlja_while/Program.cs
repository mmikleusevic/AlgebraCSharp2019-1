﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlja_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime = "";
            while (ime != "kraj")
            {
                Console.ReadLine();

                if(ime != "kraj")
                {
                    Console.WriteLine("Dobar dan,{0}!", ime);
                }
            }
        }
    }
}
