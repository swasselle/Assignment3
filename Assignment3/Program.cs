using System;

namespace Assignment3
{
    class Program
    {
        static void HelloFromDeb()
        {
            Console.WriteLine("Hello from Deb!");
        }

        static void HelloFromAlex()
        {
            Console.WriteLine("Hello from Alex!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HelloFromAlex();
            HelloFromDeb();
        }
    }
}
