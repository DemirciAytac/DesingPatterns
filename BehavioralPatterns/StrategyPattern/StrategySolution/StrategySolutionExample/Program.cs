using System;

namespace StrategySolutionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingContext context = new SortingContext();
            double[] list = { 5, 2, 98, 45, 78, 88, 82 };
            context.SortDouble(list);
            for (int i = 0; i < list.Length -1; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
    }
}
