using System;
using System.Collections.Generic;
using System.Text;

namespace Konto_fællesopgave
{
    class Konto
    {

        public List<Transaktion> transaktioner;

        public Konto()
        {
            transaktioner = new List<Transaktion>();

        }

        public void TilføjTransaktion(Transaktion t)
        {
            transaktioner.Add(t);
        }


        public decimal Saldo()
        {
            decimal sum = 0;
            foreach (var item in transaktioner)
            {
                sum = sum + item.beløb;
            }
            return sum;
        }
    }
}
