using System;

namespace Interface_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[4];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 5, Navn = "Anders" };
            hunde[3] = new Hund() { Alder = 5, Navn = "Hanne" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn + "-" + item.Alder) ;
                //Console.WriteLine(item.Alder);
            }


            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    // class Hund : IComparable
    class Hund : IComparable<Hund>
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        //public int CompareTo(object obj)
        //{
        //    Hund h = obj as Hund;
        //    if (h.Alder > this.Alder)
        //        return -1;
        //    if (h.Alder < this.Alder)
        //        return 1;
        //    return 0;
        //}

        public int CompareTo(Hund other)
        {

            return string.Compare(this.Navn, other.Navn);

            //if (h.Navn > this.Navn)
            //    return -1;
            //if (h.Navn < this.Navn)
            //    return 1;
            //return 0;

        }
    }
}
