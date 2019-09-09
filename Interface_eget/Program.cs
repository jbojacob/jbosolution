
using System;

namespace Interface_eget
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Hund();
            array[3] = new Ubåd();
            foreach (var item in array)
            {
                item.Gem();
                item.Skriv();
            }

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

    interface IDbFunktioner
    {
        void Gem();
        void Skriv();
    }

    class Hund : IDbFunktioner
    {

        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund (her kunne der uploades til en database - smart)...");
            Console.WriteLine("");
        }
        public void Skriv()
        {
            Console.WriteLine("Her skrives der omkring hunden fx i logfil...");
            Console.WriteLine("");
        }

    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
            Console.WriteLine("");
        }
        public void Skriv()
        {
            Console.WriteLine("Her skrives der omkring ubåden fx i logfil...");
            Console.WriteLine("");
        }
    }

}