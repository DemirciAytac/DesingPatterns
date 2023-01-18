using System;

namespace StrategyProblemExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double[] list = { 5, 1, 8, 0, 45 };
            Sorter algorithm = new Sorter();
            algorithm.Sort(list);
            Console.WriteLine(list);
        }
    }
}
