using System;

namespace Egenskaber_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


      class Person
        {
            private int alder;

            public int Alder
            {
                get { return Alder; }
                set { Alder = value; }
            }
            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }


        }
    }
}
