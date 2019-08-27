using System;

namespace jbotester_egenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Person P = new Person();
            P.Fornavn = "Jaocb";
            Console.WriteLine(P.Fornavn);
        }
    }
}class Person
{

    public string Fornavne { get; set; }

    public string Fornavn { get; set; }

}
