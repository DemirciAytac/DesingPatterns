using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySolutionExample
{
    public class BubbleSort : ISorter
    {
        public void Sort(double[] list)
        {
            Console.WriteLine("Using Bubble Sort");
            double temp;
            int counter, index;
            int length = list.Length;
            for (counter = 0; counter < length - 1; counter++)
            {
                for (index = 0; index < length - 1 - counter; index++)
                {
                    if (list[index] > list[index + 1])
                    {
                        temp = list[index];
                        list[index] = list[index + 1];
                        list[index + 1] = temp;
                    }
                }
            }
        }
    }
}
