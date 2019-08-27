﻿using System;

namespace Arvning_Simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Efternavn = "x", Fornavn = "y" };

            Elev e = new Elev() { Efternavn = "t", Fornavn = "g", KlasseLokale = "A" };

            Instruktør i = new Instruktør() { Efternavn = "2", Fornavn = "s", NøgleId = 1 };

            Console.WriteLine(p.FuldtNavn());

            Console.WriteLine(e.FuldtNavn());

            Console.WriteLine(i.FuldtNavn());

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }

        }

    }



    public class Person

    {

        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public string FuldtNavn()

        {

            return $"{Fornavn} {Efternavn}";

        }



    }



    public class Elev : Person

    {

        public string KlasseLokale { get; set; }

    }



    public class Instruktør : Person

    {

        public int NøgleId { get; set; }
    }
    }

