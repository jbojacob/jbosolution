using System;
using System.Collections.Generic;
using System.Text;

namespace Konto_fællesopgave
{
    class Transaktion
    {

        // felter
        public DateTime dato;
        public string tekst;
        public decimal beløb;


        public Transaktion(DateTime dato, string tekst, decimal beløb)
        {
            this.beløb = beløb;
        }
    }
}
