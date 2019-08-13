using System;

namespace Strenge
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);

            Console.WriteLine();

            string navnjbo = "jacob";
            string navnjbo2 = navnjbo.ToUpper();
            Console.WriteLine(char.ToUpper(navnjbo[0]));
            Console.WriteLine(navnjbo2);

            Console.WriteLine(Convert.ToInt32(KortKulør.Spar));

                
                {

        }

            string strFirstLetter = navnjbo.Substring(0, 1).ToUpper();
            string strFullWord = strFirstLetter + navnjbo.Substring(1);
            Console.WriteLine(strFullWord);

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);
            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);
            string samletNavn2 = $"{fornavn} {efternavn}";

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
