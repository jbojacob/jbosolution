using System;

namespace O5_for_if
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int xx = 1; xx < 11; xx++)
            {
                for (int yy = 1; yy < 11; yy++)
                {
                    string tal = (xx * yy).ToString();
                    if ((xx * yy) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                

                    }
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Her kommer Jacobs test");
                Console.WriteLine();

                for (int i = 1; i < 20; i++)


                    Console.Write(i);
                {
                }
            }

            //// Hold console åben ved debug
            //if (System.Diagnostics.Debugger.IsAttached)
            //{
            //    Console.Write("Press any key to continue . . . ");
            //    Console.ReadKey();
            //}
    }
}


}