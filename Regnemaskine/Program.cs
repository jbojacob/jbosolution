using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler_regnemaskine
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();

            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            double t1 = System.Convert.ToDouble(tal1);
            double t2 = System.Convert.ToDouble(tal2);

            double resultat = t1 + t2;
            Console.WriteLine("Resultatet er");
            Console.WriteLine(resultat.ToString("N1"));


            Console.WriteLine();
            Console.WriteLine("Hvor jeg dog bare kan det her:(");



            //if (system.diagnostics.debugger.isattached)
            //{
            //    console.write("press any key to continue . . . ");
            //    console.readkey();
            //}


        }
    }
}