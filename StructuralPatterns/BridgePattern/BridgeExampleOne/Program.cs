using System;

namespace BridgeExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern \n");
            Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
            Console.WriteLine(new Abstraction(new ImplementationB()).Operation());

            Console.ReadKey(); Console.WriteLine("Hello World!");
        }
    }
}
